namespace MiniERP
{
    partial class Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancelarVenda = new Button();
            btnExcluirVenda = new Button();
            btnSalvarVenda = new Button();
            btnAdicionarVenda = new Button();
            textBoxQuantidade = new TextBox();
            lblQuantidade = new Label();
            textBoxData = new TextBox();
            labelNome3 = new Label();
            dataGridVendas = new DataGridView();
            cboCliente = new ComboBox();
            lblCliente4 = new Label();
            cboProduto = new ComboBox();
            lblProduto = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridVendas).BeginInit();
            SuspendLayout();
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.Location = new Point(717, 398);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.Size = new Size(115, 23);
            btnCancelarVenda.TabIndex = 51;
            btnCancelarVenda.Text = "Cancelar";
            btnCancelarVenda.UseVisualStyleBackColor = true;
            btnCancelarVenda.Click += btnCancelarProduto1_Click;
            // 
            // btnExcluirVenda
            // 
            btnExcluirVenda.Location = new Point(731, 224);
            btnExcluirVenda.Name = "btnExcluirVenda";
            btnExcluirVenda.Size = new Size(100, 40);
            btnExcluirVenda.TabIndex = 50;
            btnExcluirVenda.Text = "Excluir";
            btnExcluirVenda.UseVisualStyleBackColor = true;
            btnExcluirVenda.Click += btnExcluirProduto1_Click;
            // 
            // btnSalvarVenda
            // 
            btnSalvarVenda.Location = new Point(717, 354);
            btnSalvarVenda.Name = "btnSalvarVenda";
            btnSalvarVenda.Size = new Size(114, 23);
            btnSalvarVenda.TabIndex = 49;
            btnSalvarVenda.Text = "Salvar";
            btnSalvarVenda.UseVisualStyleBackColor = true;
            btnSalvarVenda.Click += btnSalvarProduto1_Click;
            // 
            // btnAdicionarVenda
            // 
            btnAdicionarVenda.Location = new Point(731, 160);
            btnAdicionarVenda.Name = "btnAdicionarVenda";
            btnAdicionarVenda.Size = new Size(100, 40);
            btnAdicionarVenda.TabIndex = 48;
            btnAdicionarVenda.Text = "Adicionar";
            btnAdicionarVenda.UseVisualStyleBackColor = true;
            btnAdicionarVenda.Click += btnAdicionarProduto1_Click;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Font = new Font("Segoe UI", 9F);
            textBoxQuantidade.Location = new Point(470, 364);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(187, 23);
            textBoxQuantidade.TabIndex = 47;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 9F);
            lblQuantidade.Location = new Point(470, 344);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 46;
            lblQuantidade.Text = "Quantidade";
            // 
            // textBoxData
            // 
            textBoxData.Font = new Font("Segoe UI", 9F);
            textBoxData.Location = new Point(64, 427);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(361, 23);
            textBoxData.TabIndex = 45;
            // 
            // labelNome3
            // 
            labelNome3.AutoSize = true;
            labelNome3.Font = new Font("Segoe UI", 9F);
            labelNome3.Location = new Point(61, 408);
            labelNome3.Name = "labelNome3";
            labelNome3.Size = new Size(31, 15);
            labelNome3.TabIndex = 44;
            labelNome3.Text = "Data";
            // 
            // dataGridVendas
            // 
            dataGridVendas.AllowUserToAddRows = false;
            dataGridVendas.AllowUserToDeleteRows = false;
            dataGridVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVendas.Location = new Point(61, 104);
            dataGridVendas.Margin = new Padding(2);
            dataGridVendas.Name = "dataGridVendas";
            dataGridVendas.ReadOnly = true;
            dataGridVendas.RowHeadersWidth = 62;
            dataGridVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVendas.Size = new Size(596, 206);
            dataGridVendas.TabIndex = 43;
            dataGridVendas.SelectionChanged += dataGridVendas_SelectionChanged;
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(202, 45);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(361, 23);
            cboCliente.TabIndex = 53;
            cboCliente.DisplayMemberChanged += btnCancelarProduto1_Click;
            cboCliente.ValueMemberChanged += cboCliente_SelectedValueChanged;
            cboCliente.SelectedValueChanged += cboCliente_SelectedValueChanged;
            // 
            // lblCliente4
            // 
            lblCliente4.AutoSize = true;
            lblCliente4.Font = new Font("Segoe UI", 9F);
            lblCliente4.Location = new Point(145, 48);
            lblCliente4.Name = "lblCliente4";
            lblCliente4.Size = new Size(44, 15);
            lblCliente4.TabIndex = 54;
            lblCliente4.Text = "Cliente";
            // 
            // cboProduto
            // 
            cboProduto.FormattingEnabled = true;
            cboProduto.Location = new Point(64, 364);
            cboProduto.Name = "cboProduto";
            cboProduto.Size = new Size(361, 23);
            cboProduto.TabIndex = 55;
            cboProduto.DisplayMemberChanged += cboProduto_SelectedValueChanged;
            cboProduto.ValueMemberChanged += cboProduto_SelectedValueChanged;
            cboProduto.SelectedValueChanged += cboProduto_SelectedValueChanged;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 9F);
            lblProduto.Location = new Point(64, 343);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 56;
            lblProduto.Text = "Produto";
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 497);
            Controls.Add(lblProduto);
            Controls.Add(cboProduto);
            Controls.Add(lblCliente4);
            Controls.Add(cboCliente);
            Controls.Add(btnCancelarVenda);
            Controls.Add(btnExcluirVenda);
            Controls.Add(btnSalvarVenda);
            Controls.Add(btnAdicionarVenda);
            Controls.Add(textBoxQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(textBoxData);
            Controls.Add(labelNome3);
            Controls.Add(dataGridVendas);
            Name = "Vendas";
            Text = "Vendas";
            Load += Vendas_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelarVenda;
        private Button btnExcluirVenda;
        private Button btnSalvarVenda;
        private Button btnAdicionarVenda;
        private TextBox textBoxQuantidade;
        private Label lblQuantidade;
        private TextBox textBoxData;
        private Label labelNome3;
        private DataGridView dataGridVendas;
        private ComboBox cboCliente;
        private Label lblCliente4;
        private ComboBox cboProduto;
        private Label lblProduto;
    }
}