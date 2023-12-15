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
    public partial class ClienteForm : Form
    {
        MiniERPDBContexto _DbContext;
        public ClienteForm()
        {
            InitializeComponent();
            _DbContext = new MiniERPDBContexto();
            LoadInitialConfig();
            DesabilitarTexto();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            LoadGrid();

        }
        private void LoadGrid(string pesquisa = "")
        {
            using (var contexto = new MiniERPDBContexto())
            {
                var clientes = contexto.Clientes.Where(x => (x.Nome.StartsWith(pesquisa)
                                                            && !string.IsNullOrWhiteSpace(pesquisa))
                                                            || string.IsNullOrWhiteSpace(pesquisa)).ToList();
                dataGridView1.DataSource = clientes;
            }
        }

        private void textBoxNome1_TextChanged(object sender, EventArgs e)
        {
            textBoxNome1.Text = textBoxNome1.Text.ToUpper();
            textBoxNome1.SelectionStart = textBoxNome1.Text.Length;
        }

        private void textBoxCNPJ1_TextChanged(object sender, EventArgs e)
        {
            textBoxCNPJ1.SelectionStart = textBoxCNPJ1.Text.Length;
        }

        private void textBoxEmail1_TextChanged(object sender, EventArgs e)
        {
            textBoxEmail1.SelectionStart = textBoxEmail1.Text.Length;
        }

        private void textBoxTelefone1_TextChanged(object sender, EventArgs e)
        {
            textBoxTelefone1.SelectionStart = textBoxTelefone1.Text.Length;
        }


        private void btnAdicionarCliente1_Click(object sender, EventArgs e)
        {

            estaEditando = false;
            dataGridView1.Enabled = false;
            HabilitarTexto();
            SaveCancelAdd();
            _selectedClient = new Cliente();
            LimparCamposCliente1();
            BindTextBoxes(_selectedClient);
        }

        private void btnEditarCliente1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                estaEditando = true;
                // Habilita a edição da linha selecionada                
                dataGridView1.ReadOnly = false;

                SaveCancelEdit();
                HabilitarTexto();

                Cliente clienteSelecionado = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;
                BindTextBoxes(clienteSelecionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para editar.");
            }
        }

        private void btnExcluirCliente1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que quer excluir essa linha?", "Confirmação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    if (_selectedClient != null)
                    {
                        _DbContext.Clientes.Remove(_selectedClient); // Remove o cliente do contexto
                        _DbContext.SaveChanges(); // Salva as alterações no banco de dados

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
            LoadGrid();
            LoadInitialConfig();
            LimparCamposCliente1();
            DesabilitarTexto();
        }

        bool estaEditando = false;
        private void btnSalvarCliente1_Click(object sender, EventArgs e)
        {
            if (!estaEditando) // Adicionar cliente
            {
                var novoCliente = new Cliente
                {
                    Nome = textBoxNome1.Text,
                    Cnpj = textBoxCNPJ1.Text,
                    Email = textBoxEmail1.Text,
                    Telefone = textBoxTelefone1.Text,
                };

                _DbContext.Clientes.Add(novoCliente);
                _DbContext.SaveChanges();

                MessageBox.Show("Cliente adicionado com sucesso!");
            }
            else // Editar cliente
            {

                if (_selectedClient != null)
                {
                    var tmp = _DbContext.Clientes.Where(x => x.Id == _selectedClient.Id).FirstOrDefault();

                    // Atualizar cliente existente com os valores dos campos de texto
                    tmp.Nome = textBoxNome1.Text;
                    tmp.Cnpj = textBoxCNPJ1.Text;
                    tmp.Email = textBoxEmail1.Text;
                    tmp.Telefone = textBoxTelefone1.Text;

                    //_DbContext.Update(_selectedClient);
                    _DbContext.SaveChanges();
                    MessageBox.Show("Cliente atualizado com sucesso!");
                }
            }

            dataGridView1.Enabled = true;
            LoadInitialConfig();
            LoadGrid();
            DesabilitarTexto();
            LimparCamposCliente1();
            estaEditando = false;
        }

        private void btnCancelarCliente1_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            LoadInitialConfig();
            LimparCamposCliente1();
            DesabilitarTexto();
            estaEditando = false;
        }

        private void textBoxBuscarCliente1_TextChanged(object sender, EventArgs e)
        {
            //dataGridView1.EndEdit(); // End any ongoing edits

            //string textoBusca = textBoxBuscarCliente1.Text.ToUpper();

            //dataGridView1.CurrentCell = null; // Clear the current cell selection

            //foreach (DataGridViewRow row in dataGridView1.Rows)
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

        private void BindTextBoxes(Cliente cliente)
        {
            textBoxNome1.Text = cliente.Nome;
            textBoxCNPJ1.Text = cliente.Cnpj;
            textBoxEmail1.Text = cliente.Email;
            textBoxTelefone1.Text = cliente.Telefone;
        }

        private void LoadInitialConfig()
        {
            btnSalvarCliente1.Enabled = false;
            btnCancelarCliente1.Enabled = false;
            btnAdicionarCliente1.Enabled = true;
            btnEditarCliente1.Enabled = true;
            btnExcluirCliente1.Enabled = true;
            textBoxBuscarCliente1.Enabled = true;
        }

        private void SaveCancelAdd()
        {
            btnSalvarCliente1.Enabled = true;
            btnCancelarCliente1.Enabled = true;
            btnAdicionarCliente1.Enabled = false;
            btnEditarCliente1.Enabled = false;
            btnExcluirCliente1.Enabled = false;
            textBoxBuscarCliente1.Enabled = false;
        }

        private void SaveCancelEdit()
        {
            btnSalvarCliente1.Enabled = true;
            btnCancelarCliente1.Enabled = true;
            btnAdicionarCliente1.Enabled = false;
            btnEditarCliente1.Enabled = false;
            btnExcluirCliente1.Enabled = false;
            textBoxBuscarCliente1.Enabled = true;
        }
        private void DesabilitarTexto()
        {
            textBoxNome1.Enabled = false;
            textBoxCNPJ1.Enabled = false;
            textBoxEmail1.Enabled = false;
            textBoxTelefone1.Enabled = false;
        }

        private void HabilitarTexto()
        {
            textBoxNome1.Enabled = true;
            textBoxCNPJ1.Enabled = true;
            textBoxEmail1.Enabled = true;
            textBoxTelefone1.Enabled = true;
        }

        private void LimparCamposCliente1()
        {
            textBoxNome1.Clear();
            textBoxCNPJ1.Clear();
            textBoxEmail1.Clear();
            textBoxTelefone1.Clear();
            textBoxNome1.Focus();
        }

        Cliente _selectedClient;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _selectedClient = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;
                if (_selectedClient != null)
                {
                    BindTextBoxes(_selectedClient);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxBuscarCliente1_Leave(object sender, EventArgs e)
        {
           LoadGrid(textBoxBuscarCliente1.Text);
        }
    }
}
