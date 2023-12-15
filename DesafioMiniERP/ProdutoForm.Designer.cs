namespace MiniERP
{
    partial class ProdutoForm
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
            textBoxBuscar3 = new TextBox();
            btnEditarProduto1 = new Button();
            btnCancelarProduto1 = new Button();
            btnExcluirProduto1 = new Button();
            btnSalvarProduto1 = new Button();
            btnAdicionarProduto1 = new Button();
            textBoxPreco = new TextBox();
            labelPreco = new Label();
            textBoxNome3 = new TextBox();
            labelNome3 = new Label();
            dataGridView3 = new DataGridView();
            lblFornecedor = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // textBoxBuscar3
            // 
            textBoxBuscar3.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic);
            textBoxBuscar3.Location = new Point(176, 81);
            textBoxBuscar3.Name = "textBoxBuscar3";
            textBoxBuscar3.Size = new Size(346, 23);
            textBoxBuscar3.TabIndex = 42;
            textBoxBuscar3.Text = "Buscar";
            textBoxBuscar3.TextAlign = HorizontalAlignment.Center;
            textBoxBuscar3.TextChanged += textBoxBuscar3_TextChanged;
            // 
            // btnEditarProduto1
            // 
            btnEditarProduto1.Location = new Point(719, 144);
            btnEditarProduto1.Name = "btnEditarProduto1";
            btnEditarProduto1.Size = new Size(100, 40);
            btnEditarProduto1.TabIndex = 41;
            btnEditarProduto1.Text = "Editar";
            btnEditarProduto1.UseVisualStyleBackColor = true;
            btnEditarProduto1.Click += btnEditarProduto1_Click;
            // 
            // btnCancelarProduto1
            // 
            btnCancelarProduto1.Location = new Point(705, 357);
            btnCancelarProduto1.Name = "btnCancelarProduto1";
            btnCancelarProduto1.Size = new Size(115, 23);
            btnCancelarProduto1.TabIndex = 40;
            btnCancelarProduto1.Text = "Cancelar";
            btnCancelarProduto1.UseVisualStyleBackColor = true;
            btnCancelarProduto1.Click += btnCancelarProduto1_Click;
            // 
            // btnExcluirProduto1
            // 
            btnExcluirProduto1.Location = new Point(719, 201);
            btnExcluirProduto1.Name = "btnExcluirProduto1";
            btnExcluirProduto1.Size = new Size(100, 40);
            btnExcluirProduto1.TabIndex = 39;
            btnExcluirProduto1.Text = "Excluir";
            btnExcluirProduto1.UseVisualStyleBackColor = true;
            btnExcluirProduto1.Click += btnExcluirProduto1_Click;
            // 
            // btnSalvarProduto1
            // 
            btnSalvarProduto1.Location = new Point(705, 313);
            btnSalvarProduto1.Name = "btnSalvarProduto1";
            btnSalvarProduto1.Size = new Size(114, 23);
            btnSalvarProduto1.TabIndex = 38;
            btnSalvarProduto1.Text = "Salvar";
            btnSalvarProduto1.UseVisualStyleBackColor = true;
            btnSalvarProduto1.Click += btnSalvarProduto1_Click;
            // 
            // btnAdicionarProduto1
            // 
            btnAdicionarProduto1.Location = new Point(719, 88);
            btnAdicionarProduto1.Name = "btnAdicionarProduto1";
            btnAdicionarProduto1.Size = new Size(100, 40);
            btnAdicionarProduto1.TabIndex = 37;
            btnAdicionarProduto1.Text = "Adicionar";
            btnAdicionarProduto1.UseVisualStyleBackColor = true;
            btnAdicionarProduto1.Click += btnAdicionarProduto1_Click;
            // 
            // textBoxPreco
            // 
            textBoxPreco.Font = new Font("Segoe UI", 9F);
            textBoxPreco.Location = new Point(457, 373);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(187, 23);
            textBoxPreco.TabIndex = 32;
            textBoxPreco.TextChanged += textBoxPreco_TextChanged;
            // 
            // labelPreco
            // 
            labelPreco.AutoSize = true;
            labelPreco.Font = new Font("Segoe UI", 9F);
            labelPreco.Location = new Point(457, 354);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(37, 15);
            labelPreco.TabIndex = 31;
            labelPreco.Text = "Preço";
            // 
            // textBoxNome3
            // 
            textBoxNome3.Font = new Font("Segoe UI", 9F);
            textBoxNome3.Location = new Point(48, 373);
            textBoxNome3.Name = "textBoxNome3";
            textBoxNome3.Size = new Size(319, 23);
            textBoxNome3.TabIndex = 30;
            textBoxNome3.TextChanged += textBoxNome3_TextChanged;
            // 
            // labelNome3
            // 
            labelNome3.AutoSize = true;
            labelNome3.Font = new Font("Segoe UI", 9F);
            labelNome3.Location = new Point(45, 354);
            labelNome3.Name = "labelNome3";
            labelNome3.Size = new Size(40, 15);
            labelNome3.TabIndex = 29;
            labelNome3.Text = "Nome";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(45, 121);
            dataGridView3.Margin = new Padding(2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(596, 206);
            dataGridView3.TabIndex = 28;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFornecedor.Location = new Point(322, 26);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(88, 37);
            lblFornecedor.TabIndex = 43;
            lblFornecedor.Text = "label1";
            // 
            // ProdutoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 452);
            Controls.Add(lblFornecedor);
            Controls.Add(textBoxBuscar3);
            Controls.Add(btnEditarProduto1);
            Controls.Add(btnCancelarProduto1);
            Controls.Add(btnExcluirProduto1);
            Controls.Add(btnSalvarProduto1);
            Controls.Add(btnAdicionarProduto1);
            Controls.Add(textBoxPreco);
            Controls.Add(labelPreco);
            Controls.Add(textBoxNome3);
            Controls.Add(labelNome3);
            Controls.Add(dataGridView3);
            Margin = new Padding(2);
            Name = "ProdutoForm";
            Text = "Produto";
            Load += ProdutoForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxBuscar3;
        private Button btnEditarProduto1;
        private Button btnCancelarProduto1;
        private Button btnExcluirProduto1;
        private Button btnSalvarProduto1;
        private Button btnAdicionarProduto1;
        private TextBox textBoxTelefone3;
        private Label labelTelefone3;
        private TextBox textBoxEmail3;
        private Label labelEmail3;
        private TextBox textBoxPreco;
        private Label labelPreco;
        private TextBox textBoxNome3;
        private Label labelNome3;
        private DataGridView dataGridView3;
        private Label lblFornecedor;
    }
}