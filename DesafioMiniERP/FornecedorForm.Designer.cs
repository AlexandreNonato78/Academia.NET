namespace MiniERP
{
    partial class FornecedorForm
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
            components = new System.ComponentModel.Container();
            textBoxBuscarForn1 = new TextBox();
            btnEditarForn1 = new Button();
            btnCancelarForn1 = new Button();
            btnExcluirForn1 = new Button();
            btnSalvarForn1 = new Button();
            btnAdicionarForn1 = new Button();
            textBoxTelefone2 = new TextBox();
            labelTelefone2 = new Label();
            textBoxEmail2 = new TextBox();
            labelEmail2 = new Label();
            textBoxCnpj2 = new TextBox();
            labelCnpj2 = new Label();
            textBoxNome2 = new TextBox();
            labelNome2 = new Label();
            dataGridView2 = new DataGridView();
            btnProdutoForm = new Button();
            fornecedorBindingSource = new BindingSource(components);
            miniERPDBContextobindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fornecedorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miniERPDBContextobindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxBuscarForn1
            // 
            textBoxBuscarForn1.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic);
            textBoxBuscarForn1.Location = new Point(40, 37);
            textBoxBuscarForn1.Name = "textBoxBuscarForn1";
            textBoxBuscarForn1.Size = new Size(346, 23);
            textBoxBuscarForn1.TabIndex = 42;
            textBoxBuscarForn1.Text = "Buscar";
            textBoxBuscarForn1.TextAlign = HorizontalAlignment.Center;
            textBoxBuscarForn1.TextChanged += textBoxBuscarForn1_TextChanged;
            textBoxBuscarForn1.Leave += textBoxBuscarForn1_Leave;
            // 
            // btnEditarForn1
            // 
            btnEditarForn1.Location = new Point(693, 154);
            btnEditarForn1.Name = "btnEditarForn1";
            btnEditarForn1.Size = new Size(100, 40);
            btnEditarForn1.TabIndex = 41;
            btnEditarForn1.Text = "Editar";
            btnEditarForn1.UseVisualStyleBackColor = true;
            btnEditarForn1.Click += btnEditarForn1_Click;
            // 
            // btnCancelarForn1
            // 
            btnCancelarForn1.Location = new Point(688, 353);
            btnCancelarForn1.Name = "btnCancelarForn1";
            btnCancelarForn1.Size = new Size(115, 23);
            btnCancelarForn1.TabIndex = 40;
            btnCancelarForn1.Text = "Cancelar";
            btnCancelarForn1.UseVisualStyleBackColor = true;
            btnCancelarForn1.Click += btnCancelarForn1_Click;
            // 
            // btnExcluirForn1
            // 
            btnExcluirForn1.Location = new Point(693, 211);
            btnExcluirForn1.Name = "btnExcluirForn1";
            btnExcluirForn1.Size = new Size(100, 40);
            btnExcluirForn1.TabIndex = 39;
            btnExcluirForn1.Text = "Excluir";
            btnExcluirForn1.UseVisualStyleBackColor = true;
            btnExcluirForn1.Click += btnExcluirForn1_Click;
            // 
            // btnSalvarForn1
            // 
            btnSalvarForn1.Location = new Point(688, 309);
            btnSalvarForn1.Name = "btnSalvarForn1";
            btnSalvarForn1.Size = new Size(114, 23);
            btnSalvarForn1.TabIndex = 38;
            btnSalvarForn1.Text = "Salvar";
            btnSalvarForn1.UseVisualStyleBackColor = true;
            btnSalvarForn1.Click += btnSalvarForn1_Click;
            // 
            // btnAdicionarForn1
            // 
            btnAdicionarForn1.Location = new Point(693, 98);
            btnAdicionarForn1.Name = "btnAdicionarForn1";
            btnAdicionarForn1.Size = new Size(100, 40);
            btnAdicionarForn1.TabIndex = 37;
            btnAdicionarForn1.Text = "Adicionar";
            btnAdicionarForn1.UseVisualStyleBackColor = true;
            btnAdicionarForn1.Click += btnAdicionarForn1_Click;
            // 
            // textBoxTelefone2
            // 
            textBoxTelefone2.Font = new Font("Segoe UI", 9F);
            textBoxTelefone2.Location = new Point(429, 359);
            textBoxTelefone2.Name = "textBoxTelefone2";
            textBoxTelefone2.Size = new Size(195, 23);
            textBoxTelefone2.TabIndex = 36;
            textBoxTelefone2.TextChanged += textBoxTelefone2_TextChanged;
            // 
            // labelTelefone2
            // 
            labelTelefone2.AutoSize = true;
            labelTelefone2.Font = new Font("Segoe UI", 9F);
            labelTelefone2.Location = new Point(429, 341);
            labelTelefone2.Name = "labelTelefone2";
            labelTelefone2.Size = new Size(51, 15);
            labelTelefone2.TabIndex = 35;
            labelTelefone2.Text = "Telefone";
            // 
            // textBoxEmail2
            // 
            textBoxEmail2.Font = new Font("Segoe UI", 9F);
            textBoxEmail2.Location = new Point(28, 359);
            textBoxEmail2.Name = "textBoxEmail2";
            textBoxEmail2.Size = new Size(333, 23);
            textBoxEmail2.TabIndex = 34;
            textBoxEmail2.TextChanged += textBoxEmail2_TextChanged;
            // 
            // labelEmail2
            // 
            labelEmail2.AutoSize = true;
            labelEmail2.Font = new Font("Segoe UI", 9F);
            labelEmail2.Location = new Point(28, 341);
            labelEmail2.Name = "labelEmail2";
            labelEmail2.Size = new Size(36, 15);
            labelEmail2.TabIndex = 33;
            labelEmail2.Text = "Email";
            // 
            // textBoxCnpj2
            // 
            textBoxCnpj2.Font = new Font("Segoe UI", 9F);
            textBoxCnpj2.Location = new Point(429, 301);
            textBoxCnpj2.Name = "textBoxCnpj2";
            textBoxCnpj2.Size = new Size(195, 23);
            textBoxCnpj2.TabIndex = 32;
            textBoxCnpj2.TextChanged += textBoxCnpj2_TextChanged;
            // 
            // labelCnpj2
            // 
            labelCnpj2.AutoSize = true;
            labelCnpj2.Font = new Font("Segoe UI", 9F);
            labelCnpj2.Location = new Point(431, 284);
            labelCnpj2.Name = "labelCnpj2";
            labelCnpj2.Size = new Size(32, 15);
            labelCnpj2.TabIndex = 31;
            labelCnpj2.Text = "Cnpj";
            // 
            // textBoxNome2
            // 
            textBoxNome2.Font = new Font("Segoe UI", 9F);
            textBoxNome2.Location = new Point(28, 301);
            textBoxNome2.Name = "textBoxNome2";
            textBoxNome2.Size = new Size(333, 23);
            textBoxNome2.TabIndex = 30;
            textBoxNome2.TextChanged += textBoxNome2_TextChanged;
            // 
            // labelNome2
            // 
            labelNome2.AutoSize = true;
            labelNome2.Font = new Font("Segoe UI", 9F);
            labelNome2.Location = new Point(28, 282);
            labelNome2.Name = "labelNome2";
            labelNome2.Size = new Size(40, 15);
            labelNome2.TabIndex = 29;
            labelNome2.Text = "Nome";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(28, 84);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(596, 182);
            dataGridView2.TabIndex = 28;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged_1;
            // 
            // btnProdutoForm
            // 
            btnProdutoForm.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProdutoForm.Location = new Point(429, 27);
            btnProdutoForm.Name = "btnProdutoForm";
            btnProdutoForm.Size = new Size(195, 40);
            btnProdutoForm.TabIndex = 43;
            btnProdutoForm.Text = "Produto";
            btnProdutoForm.UseVisualStyleBackColor = true;
            btnProdutoForm.Click += btnProdutoForm_Click;
            // 
            // fornecedorBindingSource
            // 
            fornecedorBindingSource.DataSource = typeof(Models.Fornecedor);
            // 
            // miniERPDBContextobindingSource
            // 
            miniERPDBContextobindingSource.DataSource = typeof(MiniERPDBContexto);
            // 
            // FornecedorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 439);
            Controls.Add(btnProdutoForm);
            Controls.Add(textBoxBuscarForn1);
            Controls.Add(btnEditarForn1);
            Controls.Add(btnCancelarForn1);
            Controls.Add(btnExcluirForn1);
            Controls.Add(btnSalvarForn1);
            Controls.Add(btnAdicionarForn1);
            Controls.Add(textBoxTelefone2);
            Controls.Add(labelTelefone2);
            Controls.Add(textBoxEmail2);
            Controls.Add(labelEmail2);
            Controls.Add(textBoxCnpj2);
            Controls.Add(labelCnpj2);
            Controls.Add(textBoxNome2);
            Controls.Add(labelNome2);
            Controls.Add(dataGridView2);
            Margin = new Padding(2);
            Name = "FornecedorForm";
            Text = "Fornecedor";
            Load += FornecedorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fornecedorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)miniERPDBContextobindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxBuscarForn1;
        private Button btnEditarForn1;
        private Button btnCancelarForn1;
        private Button btnExcluirForn1;
        private Button btnSalvarForn1;
        private Button btnAdicionarForn1;
        private TextBox textBoxTelefone2;
        private Label labelTelefone2;
        private TextBox textBoxEmail2;
        private Label labelEmail2;
        private TextBox textBoxCnpj2;
        private Label labelCnpj2;
        private TextBox textBoxNome2;
        private Label labelNome2;
        private DataGridView dataGridView2;
        private Button btnProdutoForm;
        private BindingSource fornecedorBindingSource;
        private BindingSource miniERPDBContextobindingSource;
    }
}