namespace MiniERP
{
    partial class ClienteForm
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
            clienteBindingSource = new BindingSource(components);
            miniERPDBContextoBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            textBoxTelefone1 = new TextBox();
            labelTelefone1 = new Label();
            textBoxEmail1 = new TextBox();
            labelEmail1 = new Label();
            textBoxCNPJ1 = new TextBox();
            labelCNPJ1 = new Label();
            textBoxNome1 = new TextBox();
            labelNome1 = new Label();
            btnEditarCliente1 = new Button();
            btnCancelarCliente1 = new Button();
            btnExcluirCliente1 = new Button();
            btnSalvarCliente1 = new Button();
            btnAdicionarCliente1 = new Button();
            textBoxBuscarCliente1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miniERPDBContextoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // miniERPDBContextoBindingSource
            // 
            miniERPDBContextoBindingSource.DataSource = typeof(MiniERPDBContexto);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 71);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(596, 182);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // textBoxTelefone1
            // 
            textBoxTelefone1.Font = new Font("Segoe UI", 9F);
            textBoxTelefone1.Location = new Point(457, 346);
            textBoxTelefone1.Name = "textBoxTelefone1";
            textBoxTelefone1.Size = new Size(195, 23);
            textBoxTelefone1.TabIndex = 21;
            textBoxTelefone1.TextChanged += textBoxTelefone1_TextChanged;
            // 
            // labelTelefone1
            // 
            labelTelefone1.AutoSize = true;
            labelTelefone1.Font = new Font("Segoe UI", 9F);
            labelTelefone1.Location = new Point(457, 328);
            labelTelefone1.Name = "labelTelefone1";
            labelTelefone1.Size = new Size(51, 15);
            labelTelefone1.TabIndex = 20;
            labelTelefone1.Text = "Telefone";
            // 
            // textBoxEmail1
            // 
            textBoxEmail1.Font = new Font("Segoe UI", 9F);
            textBoxEmail1.Location = new Point(56, 346);
            textBoxEmail1.Name = "textBoxEmail1";
            textBoxEmail1.Size = new Size(333, 23);
            textBoxEmail1.TabIndex = 19;
            textBoxEmail1.TextChanged += textBoxEmail1_TextChanged;
            // 
            // labelEmail1
            // 
            labelEmail1.AutoSize = true;
            labelEmail1.Font = new Font("Segoe UI", 9F);
            labelEmail1.Location = new Point(56, 328);
            labelEmail1.Name = "labelEmail1";
            labelEmail1.Size = new Size(36, 15);
            labelEmail1.TabIndex = 18;
            labelEmail1.Text = "Email";
            // 
            // textBoxCNPJ1
            // 
            textBoxCNPJ1.Font = new Font("Segoe UI", 9F);
            textBoxCNPJ1.Location = new Point(457, 288);
            textBoxCNPJ1.Name = "textBoxCNPJ1";
            textBoxCNPJ1.Size = new Size(195, 23);
            textBoxCNPJ1.TabIndex = 17;
            textBoxCNPJ1.TextChanged += textBoxCNPJ1_TextChanged;
            // 
            // labelCNPJ1
            // 
            labelCNPJ1.AutoSize = true;
            labelCNPJ1.Font = new Font("Segoe UI", 9F);
            labelCNPJ1.Location = new Point(459, 271);
            labelCNPJ1.Name = "labelCNPJ1";
            labelCNPJ1.Size = new Size(34, 15);
            labelCNPJ1.TabIndex = 16;
            labelCNPJ1.Text = "CNPJ";
            // 
            // textBoxNome1
            // 
            textBoxNome1.Font = new Font("Segoe UI", 9F);
            textBoxNome1.Location = new Point(56, 288);
            textBoxNome1.Name = "textBoxNome1";
            textBoxNome1.Size = new Size(333, 23);
            textBoxNome1.TabIndex = 15;
            textBoxNome1.TextChanged += textBoxNome1_TextChanged;
            // 
            // labelNome1
            // 
            labelNome1.AutoSize = true;
            labelNome1.Font = new Font("Segoe UI", 9F);
            labelNome1.Location = new Point(56, 269);
            labelNome1.Name = "labelNome1";
            labelNome1.Size = new Size(40, 15);
            labelNome1.TabIndex = 14;
            labelNome1.Text = "Nome";
            // 
            // btnEditarCliente1
            // 
            btnEditarCliente1.Location = new Point(730, 127);
            btnEditarCliente1.Name = "btnEditarCliente1";
            btnEditarCliente1.Size = new Size(100, 40);
            btnEditarCliente1.TabIndex = 26;
            btnEditarCliente1.Text = "Editar";
            btnEditarCliente1.UseVisualStyleBackColor = true;
            btnEditarCliente1.Click += btnEditarCliente1_Click;
            // 
            // btnCancelarCliente1
            // 
            btnCancelarCliente1.Location = new Point(716, 340);
            btnCancelarCliente1.Name = "btnCancelarCliente1";
            btnCancelarCliente1.Size = new Size(115, 23);
            btnCancelarCliente1.TabIndex = 25;
            btnCancelarCliente1.Text = "Cancelar";
            btnCancelarCliente1.UseVisualStyleBackColor = true;
            btnCancelarCliente1.Click += btnCancelarCliente1_Click;
            // 
            // btnExcluirCliente1
            // 
            btnExcluirCliente1.Location = new Point(730, 184);
            btnExcluirCliente1.Name = "btnExcluirCliente1";
            btnExcluirCliente1.Size = new Size(100, 40);
            btnExcluirCliente1.TabIndex = 24;
            btnExcluirCliente1.Text = "Excluir";
            btnExcluirCliente1.UseVisualStyleBackColor = true;
            btnExcluirCliente1.Click += btnExcluirCliente1_Click;
            // 
            // btnSalvarCliente1
            // 
            btnSalvarCliente1.Location = new Point(716, 296);
            btnSalvarCliente1.Name = "btnSalvarCliente1";
            btnSalvarCliente1.Size = new Size(114, 23);
            btnSalvarCliente1.TabIndex = 23;
            btnSalvarCliente1.Text = "Salvar";
            btnSalvarCliente1.UseVisualStyleBackColor = true;
            btnSalvarCliente1.Click += btnSalvarCliente1_Click;
            // 
            // btnAdicionarCliente1
            // 
            btnAdicionarCliente1.Location = new Point(730, 71);
            btnAdicionarCliente1.Name = "btnAdicionarCliente1";
            btnAdicionarCliente1.Size = new Size(100, 40);
            btnAdicionarCliente1.TabIndex = 22;
            btnAdicionarCliente1.Text = "Adicionar";
            btnAdicionarCliente1.UseVisualStyleBackColor = true;
            btnAdicionarCliente1.Click += btnAdicionarCliente1_Click;
            // 
            // textBoxBuscarCliente1
            // 
            textBoxBuscarCliente1.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic);
            textBoxBuscarCliente1.Location = new Point(188, 26);
            textBoxBuscarCliente1.Name = "textBoxBuscarCliente1";
            textBoxBuscarCliente1.Size = new Size(346, 23);
            textBoxBuscarCliente1.TabIndex = 27;
            textBoxBuscarCliente1.Text = "Buscar";
            textBoxBuscarCliente1.TextAlign = HorizontalAlignment.Center;
            textBoxBuscarCliente1.TextChanged += textBoxBuscarCliente1_TextChanged;
            textBoxBuscarCliente1.Leave += textBoxBuscarCliente1_Leave;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 423);
            Controls.Add(textBoxBuscarCliente1);
            Controls.Add(btnEditarCliente1);
            Controls.Add(btnCancelarCliente1);
            Controls.Add(btnExcluirCliente1);
            Controls.Add(btnSalvarCliente1);
            Controls.Add(btnAdicionarCliente1);
            Controls.Add(textBoxTelefone1);
            Controls.Add(labelTelefone1);
            Controls.Add(textBoxEmail1);
            Controls.Add(labelEmail1);
            Controls.Add(textBoxCNPJ1);
            Controls.Add(labelCNPJ1);
            Controls.Add(textBoxNome1);
            Controls.Add(labelNome1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "ClienteForm";
            Text = "Cliente";
            Load += ClienteForm_Load;
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)miniERPDBContextoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource clienteBindingSource;
        private BindingSource miniERPDBContextoBindingSource;
        private DataGridView dataGridView1;
        private TextBox textBoxTelefone1;
        private Label labelTelefone1;
        private TextBox textBoxEmail1;
        private Label labelEmail1;
        private TextBox textBoxCNPJ1;
        private Label labelCNPJ1;
        private TextBox textBoxNome1;
        private Label labelNome1;
        private Button btnEditarCliente1;
        private Button btnCancelarCliente1;
        private Button btnExcluirCliente1;
        private Button btnSalvarCliente1;
        private Button btnAdicionarCliente1;
        private TextBox textBoxBuscarCliente1;
    }
}