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
    public partial class FornecedorForm : Form
    {
        MiniERPDBContexto _DbContext2;
        public FornecedorForm()
        {
            InitializeComponent();
            _DbContext2 = new MiniERPDBContexto();
            LoadInitialConfig();
            DesabilitarTexto();
        }

        private void FornecedorForm_Load(object sender, EventArgs e)
        {
            LoadGrid2();
        }
        private void LoadGrid2(string pesquisa = "")
        {
            using (var contexto2 = new MiniERPDBContexto())
            {
                var fornecedores = contexto2.Fornecedores.Where(x => (x.Nome.StartsWith(pesquisa)
                                                            && !string.IsNullOrWhiteSpace(pesquisa))
                                                            || string.IsNullOrWhiteSpace(pesquisa)).ToList();
                dataGridView2.DataSource = fornecedores;
            }
        }

        private void textBoxBuscarForn1_TextChanged(object sender, EventArgs e)
        {
            //dataGridView2.EndEdit(); // End any ongoing edits

            //string textoBusca = textBoxBuscarForn1.Text.ToUpper();

            //dataGridView2.CurrentCell = null; // Clear the current cell selection

            //foreach (DataGridViewRow row in dataGridView2.Rows)
            //{
            //    bool encontrado = false;

            //    if (!row.IsNewRow)
            //    {
            //        foreach (DataGridViewCell cell in row.Cells)
            //        {
            //            if (cell.Value != null && cell.Value.ToString().ToUpper().Contains(textoBusca))
            //            {
            //                encontrado = true;
            //                break;
            //            }
            //        }

            //        row.Visible = encontrado;
            //    }
            //}
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                _selectedFornecedor = dataGridView2.SelectedRows[0].DataBoundItem as Fornecedor;
                if (_selectedFornecedor != null)
                {
                    BindTextBoxes(_selectedFornecedor);
                    textBoxBuscarForn1.Text = _selectedFornecedor.Nome; // Ou outro campo que identifique o fornecedor
                }
            }
        }

        private void btnAdicionarForn1_Click(object sender, EventArgs e)
        {
            estaEditando = false;
            dataGridView2.Enabled = false;
            HabilitarTexto();
            SaveCancelAdd();
            _selectedFornecedor = new Fornecedor();
            LimparCamposFornecedor1();
            BindTextBoxes(_selectedFornecedor);
        }

        private void btnEditarForn1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                estaEditando = true;
                // Habilita a edição da linha selecionada                
                dataGridView2.ReadOnly = false;

                SaveCancelEdit();
                HabilitarTexto();

                Fornecedor fornecedorSelecionado = (Fornecedor)dataGridView2.SelectedRows[0].DataBoundItem;
                BindTextBoxes(fornecedorSelecionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para editar.");
            }
        }

        private void btnExcluirForn1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que quer excluir essa linha?", "Confirmação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    if (_selectedFornecedor != null)
                    {
                        _DbContext2.Fornecedores.Remove(_selectedFornecedor);
                        _DbContext2.SaveChanges();

                        MessageBox.Show("Linha excluída com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado para exclusão.");
                    }
                }

            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para excluir.");
            }
            LoadGrid2();
            LoadInitialConfig();
            LimparCamposFornecedor1();
            DesabilitarTexto();
        }


        private void btnProdutoForm_Click(object sender, EventArgs e)
        {
            // Verifica se algum fornecedor está selecionado
            if (_selectedFornecedor != null)
            {
                // Criar ou acessar a instância do ProdutoForm
                ProdutoForm produtoForm = new ProdutoForm();

                produtoForm.FornecedorSelecionado = _selectedFornecedor;

                produtoForm.LoadGrid2();
                // Exibir o ProdutoForm
                produtoForm.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um fornecedor antes associá-lo a um produto.");
            }
        }

        private void textBoxNome2_TextChanged(object sender, EventArgs e)
        {
            textBoxNome2.Text = textBoxNome2.Text.ToUpper();
            textBoxNome2.SelectionStart = textBoxNome2.Text.Length;
        }

        private void textBoxEmail2_TextChanged(object sender, EventArgs e)
        {
            textBoxEmail2.SelectionStart = textBoxEmail2.Text.Length;
        }

        private void textBoxCnpj2_TextChanged(object sender, EventArgs e)
        {
            textBoxCnpj2.SelectionStart = textBoxCnpj2.Text.Length;
        }


        private void textBoxTelefone2_TextChanged(object sender, EventArgs e)
        {
            textBoxTelefone2.SelectionStart = textBoxTelefone2.Text.Length;
        }

        bool estaEditando = false;
        private void btnSalvarForn1_Click(object sender, EventArgs e)
        {
            if (!estaEditando) // Adicionar cliente
            {
                var novoFornecedor = new Fornecedor
                {
                    Nome = textBoxNome2.Text,
                    Cnpj = textBoxCnpj2.Text,
                    Email = textBoxEmail2.Text,
                    Telefone = textBoxTelefone2.Text,
                };

                _DbContext2.Fornecedores.Add(novoFornecedor);
                _DbContext2.SaveChanges();

                MessageBox.Show("Fornecedor adicionado com sucesso!");
            }
            else // Editar cliente
            {

                if (_selectedFornecedor != null)
                {
                    var tmp2 = _DbContext2.Fornecedores.Where(x => x.Id == _selectedFornecedor.Id).FirstOrDefault();

                    // Atualizar cliente existente com os valores dos campos de texto
                    tmp2.Nome = textBoxNome2.Text;
                    tmp2.Cnpj = textBoxCnpj2.Text;
                    tmp2.Email = textBoxEmail2.Text;
                    tmp2.Telefone = textBoxTelefone2.Text;

                    //_DbContext.Update(_selectedClient);
                    _DbContext2.SaveChanges();
                    MessageBox.Show("Fornecedor atualizado com sucesso!");
                }
            }

            dataGridView2.Enabled = true;
            LoadInitialConfig();
            LoadGrid2();
            DesabilitarTexto();
            LimparCamposFornecedor1();
            estaEditando = false;
        }

        private void btnCancelarForn1_Click(object sender, EventArgs e)
        {
            dataGridView2.Enabled = true;
            LoadInitialConfig();
            LimparCamposFornecedor1();
            DesabilitarTexto();
            estaEditando = false;
        }

        private void BindTextBoxes(Fornecedor fornecedor)
        {
            textBoxNome2.Text = fornecedor.Nome;
            textBoxCnpj2.Text = fornecedor.Cnpj;
            textBoxEmail2.Text = fornecedor.Email;
            textBoxTelefone2.Text = fornecedor.Telefone;
        }

        private void LoadInitialConfig()
        {
            btnSalvarForn1.Enabled = false;
            btnCancelarForn1.Enabled = false;
            btnAdicionarForn1.Enabled = true;
            btnEditarForn1.Enabled = true;
            btnExcluirForn1.Enabled = true;
            textBoxBuscarForn1.Enabled = true;
            btnProdutoForm.Enabled = true;
        }

        private void SaveCancelAdd()
        {
            btnSalvarForn1.Enabled = true;
            btnCancelarForn1.Enabled = true;
            btnAdicionarForn1.Enabled = false;
            btnEditarForn1.Enabled = false;
            btnExcluirForn1.Enabled = false;
            textBoxBuscarForn1.Enabled = false;
            btnProdutoForm.Enabled = true;
        }

        private void SaveCancelEdit()
        {
            btnSalvarForn1.Enabled = true;
            btnCancelarForn1.Enabled = true;
            btnAdicionarForn1.Enabled = false;
            btnEditarForn1.Enabled = false;
            btnExcluirForn1.Enabled = false;
            textBoxBuscarForn1.Enabled = true;
            btnProdutoForm.Enabled = true;
        }
        private void DesabilitarTexto()
        {
            textBoxNome2.Enabled = false;
            textBoxCnpj2.Enabled = false;
            textBoxEmail2.Enabled = false;
            textBoxTelefone2.Enabled = false;
        }

        private void HabilitarTexto()
        {
            textBoxNome2.Enabled = true;
            textBoxCnpj2.Enabled = true;
            textBoxEmail2.Enabled = true;
            textBoxTelefone2.Enabled = true;
            textBoxNome2.Enabled = true;
        }
        private void LimparCamposFornecedor1()
        {
            textBoxNome2.Clear();
            textBoxCnpj2.Clear();
            textBoxEmail2.Clear();
            textBoxTelefone2.Clear();
            textBoxNome2.Focus();
        }

        Fornecedor _selectedFornecedor;
        private void dataGridView2_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                _selectedFornecedor = dataGridView2.SelectedRows[0].DataBoundItem as Fornecedor;
                if (_selectedFornecedor != null)
                {
                    BindTextBoxes(_selectedFornecedor);
                }
            }
        }

        private void textBoxBuscarForn1_Leave(object sender, EventArgs e)
        {
            LoadGrid2(textBoxBuscarForn1.Text);
        }
    }
}


