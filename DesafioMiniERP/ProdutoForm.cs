using Microsoft.EntityFrameworkCore;
using MiniERP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class ProdutoForm : Form
    {
        private MiniERPDBContexto _DbContext2;
        public ProdutoForm()
        {
            InitializeComponent();
            _DbContext2 = new MiniERPDBContexto();
            LoadInitialConfig();
            DesabilitarTexto();
        }

        private void ProdutoForm_Load(object sender, EventArgs e)
        {
            LoadGrid2();
        }
        public void LoadGrid2()
        {
            if (FornecedorSelecionado != null)
            {
                lblFornecedor.Text = FornecedorSelecionado.Nome;
                var produtosFornecedor = _DbContext2.Produtos.Where(p => p.Fornecedor.Id == FornecedorSelecionado.Id).ToList();
                dataGridView3.DataSource = produtosFornecedor;
            }
        }
        public Fornecedor FornecedorSelecionado { get; set; }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                _selectedProduto = dataGridView3.SelectedRows[0].DataBoundItem as Produto;
                if (_selectedProduto != null)
                {
                    BindTextBoxes(_selectedProduto);
                    textBoxBuscar3.Text = _selectedProduto.Nome; 
                }
            }
        }

        private void textBoxBuscar3_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.EndEdit(); 

            string textoBusca = textBoxBuscar3.Text.ToUpper();

            dataGridView3.CurrentCell = null; 
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                bool encontrado = false;

                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToUpper().Contains(textoBusca))
                        {
                            encontrado = true;
                            break;
                        }
                    }

                    row.Visible = encontrado;
                }
            }
        }

        private void btnAdicionarProduto1_Click(object sender, EventArgs e)
        {
            estaEditando = false;
            dataGridView3.Enabled = false;
            HabilitarTexto();
            SaveCancelAdd();
            _selectedProduto = new Produto();
            LimparCamposProdutos();
            BindTextBoxes(_selectedProduto);
        }

        private void btnEditarProduto1_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                estaEditando = true;
                // Habilita a edição da linha selecionada                
                dataGridView3.ReadOnly = false;

                SaveCancelEdit();
                HabilitarTexto();

                Produto produtoSelecionado = (Produto)dataGridView3.SelectedRows[0].DataBoundItem;
                BindTextBoxes(produtoSelecionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para editar.");
            }
        }

        private void btnExcluirProduto1_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que quer excluir essa linha?", "Confirmação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Produto produtoParaExcluir = dataGridView3.SelectedRows[0].DataBoundItem as Produto;

                    if (produtoParaExcluir != null)
                    {
                        _DbContext2.Produtos.Remove(produtoParaExcluir); // Remove o cliente do contexto
                        _DbContext2.SaveChanges(); // Salva as alterações no banco de dados

                        MessageBox.Show("Linha excluída com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado para exclusão.");
                    }
                }

            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para excluir.");
            }
            LoadGrid2();
            LoadInitialConfig();
            LimparCamposProdutos();
            DesabilitarTexto();
        }

        bool estaEditando = false;
        private void btnSalvarProduto1_Click(object sender, EventArgs e)
        {
            if (!estaEditando) // Adicionar produto
            {
                var novoProduto = new Produto
                {
                    Nome = textBoxNome3.Text,
                    Preco = textBoxPreco.Text,
                    FornecedorId = FornecedorSelecionado.Id
                };

                _DbContext2.Produtos.Add(novoProduto);
                _DbContext2.SaveChanges();

                MessageBox.Show("Produto adicionado com sucesso!");
            }
            else // Editar produto
            {

                if (_selectedProduto != null)
                {
                    //var tmp = _DbContext2.Produtos.Include<Fornecedor>.Where(x => x.Id == _selectedProduto.Id).FirstOrDefault();
                    var tmp = _DbContext2.Produtos.Include(x => x.Fornecedor).Where(x => x.Id == _selectedProduto.Id).FirstOrDefault();

                    // Atualizar produto existente com os valores dos campos de texto
                    tmp.Nome = textBoxNome3.Text;
                    tmp.Preco = textBoxPreco.Text;
                    tmp.Fornecedor = FornecedorSelecionado;

                    _DbContext2.SaveChanges();
                    MessageBox.Show("Produto atualizado com sucesso!");
                }
            }

            dataGridView3.Enabled = true;
            LoadInitialConfig();
            LoadGrid2();
            DesabilitarTexto();
            LimparCamposProdutos();
            estaEditando = false;
        }

        private void btnCancelarProduto1_Click(object sender, EventArgs e)
        {
            dataGridView3.Enabled = true;
            LoadInitialConfig();
            LimparCamposProdutos();
            DesabilitarTexto();
            estaEditando = false;
        }

        private void textBoxNome3_TextChanged(object sender, EventArgs e)
        {
            textBoxNome3.Text = textBoxNome3.Text.ToUpper();
            textBoxNome3.SelectionStart = textBoxNome3.Text.Length;
        }

        private void textBoxPreco_TextChanged(object sender, EventArgs e)
        {
            textBoxPreco.SelectionStart = textBoxPreco.Text.Length;
        }

        private void BindTextBoxes(Produto produto)
        {
            textBoxNome3.Text = produto.Nome;
            textBoxPreco.Text = produto.Preco;
        }

        private void LoadInitialConfig()
        {
            btnSalvarProduto1.Enabled = false;
            btnCancelarProduto1.Enabled = false;
            btnAdicionarProduto1.Enabled = true;
            btnEditarProduto1.Enabled = true;
            btnExcluirProduto1.Enabled = true;

        }

        private void SaveCancelAdd()
        {
            btnSalvarProduto1.Enabled = true;
            btnCancelarProduto1.Enabled = true;
            btnAdicionarProduto1.Enabled = false;
            btnEditarProduto1.Enabled = false;
            btnExcluirProduto1.Enabled = false;

        }

        private void SaveCancelEdit()
        {
            btnSalvarProduto1.Enabled = true;
            btnCancelarProduto1.Enabled = true;
            btnAdicionarProduto1.Enabled = false;
            btnEditarProduto1.Enabled = false;
            btnExcluirProduto1.Enabled = false;

        }
        private void DesabilitarTexto()
        {
            textBoxNome3.Enabled = false;
            textBoxPreco.Enabled = false;
        }

        private void HabilitarTexto()
        {
            textBoxNome3.Enabled = true;
            textBoxPreco.Enabled = true;
        }
        private void LimparCamposProdutos()
        {
            textBoxNome3.Clear();
            textBoxPreco.Clear();
            textBoxNome3.Focus();
        }

        Produto _selectedProduto;
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                _selectedProduto = dataGridView3.SelectedRows[0].DataBoundItem as Produto;
                if (_selectedProduto != null)
                {
                    BindTextBoxes(_selectedProduto);
                }
            }

        }

        private void ProdutoForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
