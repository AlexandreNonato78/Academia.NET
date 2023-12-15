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
    public partial class Vendas : Form
    {
        MiniERPDBContexto _DbContext;
        public Vendas()
        {
            InitializeComponent();
            _DbContext = new MiniERPDBContexto();
            LoadInitialConfig();
            DesabilitarTexto();
        }

        private void LoadComboCliente()
        {
            using (var contexto = new MiniERPDBContexto())
            {
                var clientes = contexto.Clientes.ToList();
                cboCliente.DisplayMember = "Nome";
                cboCliente.ValueMember = "Id";
                cboCliente.DataSource = clientes;
            }
        }
        private void LoadComboProduto()
        {
            using (var contexto = new MiniERPDBContexto())
            {
                var produtos = contexto.Produtos.ToList();
                cboProduto.DisplayMember = "Nome";
                cboProduto.ValueMember = "Id";
                cboProduto.DataSource = produtos;
            }
        }
        private void LoadGridVendas(int clienteId)
        {
            var vendas = (from v in _DbContext.Vendas.Include(x => x.Produto)
                          where v.ClienteId == clienteId
                          join c in _DbContext.Clientes on v.ClienteId equals c.Id
                          join p in _DbContext.Produtos on v.ProdutoId equals p.Id
                          select new VendaViewModel
                          {
                              VendaId = v.Id,
                              Data = v.Data,
                              Preco = decimal.Parse(v.Produto.Preco),
                              Quantidade = v.Quantidade,
                              NomeCliente = c.Nome,
                              NomeProduto = p.Nome
                          }).ToList();

            //dataGridVendas.AutoGenerateColumns = false;
            dataGridVendas.DataSource = vendas;

            //DataGridViewTextBoxColumn totalAPagarColumn = new DataGridViewTextBoxColumn();
            //totalAPagarColumn.HeaderText = "Total a Pagar";
            //dataGridVendas.Columns.Add(totalAPagarColumn);
        }
        private void cboCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedValue != null)
            {
                ClienteSelecionado = cboCliente.SelectedItem as Cliente;
                LoadGridVendas(ClienteSelecionado.Id);
            }
        }

        private void cboProduto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboProduto.SelectedValue != null)
            {
                ProdutoSelecionado = cboProduto.SelectedItem as Produto;
            }
        }

        Venda _selectedVenda;
        private void dataGridVendas_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridVendas.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridVendas.SelectedRows[0].DataBoundItem as VendaViewModel;
                if (selectedRow != null)
                {
                    _selectedVenda = _DbContext.Vendas.FirstOrDefault(v => v.Id == selectedRow.VendaId);
                    if (_selectedVenda != null)
                    {
                        BindTextBoxes(_selectedVenda);
                    }
                }
            }
            else
            {
                _selectedVenda = null; // Reseta _selectedVenda se nenhuma linha estiver selecionada
                LimparCamposVenda(); // Limpa os campos se nenhuma linha estiver selecionada
            }
        }

        private void btnAdicionarProduto1_Click(object sender, EventArgs e)
        {
            estaEditando = false;
            dataGridVendas.Enabled = false;
            HabilitarTexto();
            SaveCancelAdd();
            _selectedVenda = new Venda();
            LimparCamposVenda();
            BindTextBoxes(_selectedVenda);
        }

        private void btnExcluirProduto1_Click(object sender, EventArgs e)
        {
            if (dataGridVendas.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que quer excluir essa venda?", "Confirmação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (_selectedVenda != null)
                    {
                        _DbContext.Vendas.Remove(_selectedVenda);
                        _DbContext.SaveChanges(); // Salva as alterações no banco de dados

                        MessageBox.Show("Venda excluída com sucesso!");

                        LoadGridVendas(ClienteSelecionado.Id); // Atualiza a tabela após a exclusão
                        LimparCamposVenda();
                        DesabilitarTexto();
                    }
                    else
                    {
                        MessageBox.Show("Venda não encontrada para exclusão.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma venda para excluir.");
            }

        }

        public Cliente ClienteSelecionado { get; set; }
        public Produto ProdutoSelecionado { get; set; }

        bool estaEditando = false;
        private void btnSalvarProduto1_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedValue != null && cboProduto.SelectedValue != null)
            {
                ClienteSelecionado = cboCliente.SelectedItem as Cliente;
                ProdutoSelecionado = cboProduto.SelectedItem as Produto;

                if (!estaEditando) // Adicionar venda
                {
                    var novaVenda = new Venda
                    {
                        Data = textBoxData.Text,
                        Quantidade = int.Parse(textBoxQuantidade.Text),
                        ClienteId = ClienteSelecionado.Id,
                        ProdutoId = ProdutoSelecionado.Id
                    };

                    _DbContext.Add(novaVenda);
                    _DbContext.SaveChanges();

                    MessageBox.Show("Venda adicionada com sucesso!");

                    // Atualiza o grid de vendas após a adição da nova venda
                    LoadGridVendas(ClienteSelecionado.Id);
                }
                else // Editar venda
                {
                    var vendaExistente = _DbContext.Vendas.FirstOrDefault(v => v.Id == _selectedVenda.Id);

                    if (vendaExistente != null)
                    {
                        vendaExistente.Data = textBoxData.Text;
                        vendaExistente.Quantidade = int.Parse(textBoxQuantidade.Text); // Converta para o tipo de dado correto
                        vendaExistente.ClienteId = ClienteSelecionado.Id; // Atualize o cliente se necessário
                        vendaExistente.ProdutoId = ProdutoSelecionado.Id; // Atualize o produto se necessário

                        _DbContext.SaveChanges();
                        MessageBox.Show("Venda atualizada com sucesso!");
                        LoadGridVendas(ClienteSelecionado.Id); // Atualize a grid após a edição
                    }
                    else
                    {
                        MessageBox.Show("Venda não encontrada para edição.");
                    }
                    LoadInitialConfig();
                }
            }
        }

        private void btnCancelarProduto1_Click(object sender, EventArgs e)
        {
            dataGridVendas.Enabled = true;
            LimparCamposVenda();
            DesabilitarTexto();
            estaEditando = false;
            LoadInitialConfig();
        }

        private void BindTextBoxes(Venda venda)
        {
            cboProduto.SelectedValue = venda.ProdutoId;
            cboCliente.SelectedValue = venda.ClienteId;
            textBoxData.Text = venda.Data;
            textBoxQuantidade.Text = venda.Quantidade.ToString();
        }
        private void LoadInitialConfig()
        {
            textBoxData.Enabled = false;
            textBoxQuantidade.Enabled = false;
            btnCancelarVenda.Enabled = false;
            btnSalvarVenda.Enabled = false;
            btnAdicionarVenda.Enabled = true;
            btnExcluirVenda.Enabled = true;
        }

        private void SaveCancelAdd()
        {
            textBoxData.Enabled = true;
            textBoxQuantidade.Enabled = true;
            btnCancelarVenda.Enabled = true;
            btnSalvarVenda.Enabled = true;
            btnAdicionarVenda.Enabled = false;
            btnExcluirVenda.Enabled = false;
        }

        private void SaveCancelEdit()
        {
            textBoxData.Enabled = true;
            textBoxQuantidade.Enabled = true;
            btnCancelarVenda.Enabled = true;
            btnSalvarVenda.Enabled = true;
            btnAdicionarVenda.Enabled = false;
            btnExcluirVenda.Enabled = false;
        }
        private void DesabilitarTexto()
        {
            textBoxData.Enabled = false;
            textBoxQuantidade.Enabled = false;
        }

        private void HabilitarTexto()
        {
            textBoxData.Enabled = true;
            textBoxQuantidade.Enabled = true;
        }

        private void LimparCamposVenda()
        {
            textBoxData.Clear();
            textBoxQuantidade.Clear();
            textBoxData.Focus();
        }

        private void Vendas_Load_1(object sender, EventArgs e)
        {
            LoadComboCliente();
            LoadComboProduto();
        }
    }
}
