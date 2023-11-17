namespace DesafioWindowsForms2
{
    partial class Form1_Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1_nome = new System.Windows.Forms.Label();
            this.textBox1_nome = new System.Windows.Forms.TextBox();
            this.button1_adicionar = new System.Windows.Forms.Button();
            this.textBox3_lista = new System.Windows.Forms.TextBox();
            this.button3_adicionar = new System.Windows.Forms.Button();
            this.button5_csv = new System.Windows.Forms.Button();
            this.button4_csv = new System.Windows.Forms.Button();
            this.button1_Lista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_nome
            // 
            this.label1_nome.AutoSize = true;
            this.label1_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_nome.Location = new System.Drawing.Point(56, 52);
            this.label1_nome.Name = "label1_nome";
            this.label1_nome.Size = new System.Drawing.Size(188, 16);
            this.label1_nome.TabIndex = 0;
            this.label1_nome.Text = "Digite o nome do(a) amigo(a): ";
            // 
            // textBox1_nome
            // 
            this.textBox1_nome.Location = new System.Drawing.Point(247, 52);
            this.textBox1_nome.Name = "textBox1_nome";
            this.textBox1_nome.Size = new System.Drawing.Size(178, 20);
            this.textBox1_nome.TabIndex = 2;
            this.textBox1_nome.TextChanged += new System.EventHandler(this.textBox1_nome_TextChanged);
            // 
            // button1_adicionar
            // 
            this.button1_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_adicionar.Location = new System.Drawing.Point(441, 46);
            this.button1_adicionar.Name = "button1_adicionar";
            this.button1_adicionar.Size = new System.Drawing.Size(85, 30);
            this.button1_adicionar.TabIndex = 4;
            this.button1_adicionar.Text = "adicionar";
            this.button1_adicionar.UseVisualStyleBackColor = true;
            this.button1_adicionar.Click += new System.EventHandler(this.button1_adicionar_Click);
            // 
            // textBox3_lista
            // 
            this.textBox3_lista.Location = new System.Drawing.Point(53, 95);
            this.textBox3_lista.Multiline = true;
            this.textBox3_lista.Name = "textBox3_lista";
            this.textBox3_lista.Size = new System.Drawing.Size(480, 210);
            this.textBox3_lista.TabIndex = 6;
            this.textBox3_lista.TextChanged += new System.EventHandler(this.textBox3_lista_TextChanged);
            // 
            // button3_adicionar
            // 
            this.button3_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_adicionar.Location = new System.Drawing.Point(348, 323);
            this.button3_adicionar.Name = "button3_adicionar";
            this.button3_adicionar.Size = new System.Drawing.Size(119, 44);
            this.button3_adicionar.TabIndex = 7;
            this.button3_adicionar.Text = "Limpar";
            this.button3_adicionar.UseVisualStyleBackColor = true;
            this.button3_adicionar.Click += new System.EventHandler(this.button3_adicionar_Click);
            // 
            // button5_csv
            // 
            this.button5_csv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5_csv.Location = new System.Drawing.Point(104, 383);
            this.button5_csv.Name = "button5_csv";
            this.button5_csv.Size = new System.Drawing.Size(189, 44);
            this.button5_csv.TabIndex = 9;
            this.button5_csv.Text = "Gerar CSV - amigo secreto";
            this.button5_csv.UseVisualStyleBackColor = true;
            this.button5_csv.Click += new System.EventHandler(this.button5_csv_Click);
            // 
            // button4_csv
            // 
            this.button4_csv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4_csv.Location = new System.Drawing.Point(104, 323);
            this.button4_csv.Name = "button4_csv";
            this.button4_csv.Size = new System.Drawing.Size(189, 44);
            this.button4_csv.TabIndex = 8;
            this.button4_csv.Text = "Gerar CSV - lista de amigos";
            this.button4_csv.UseVisualStyleBackColor = true;
            this.button4_csv.Click += new System.EventHandler(this.button4_csv_Click);
            // 
            // button1_Lista
            // 
            this.button1_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Lista.Location = new System.Drawing.Point(348, 383);
            this.button1_Lista.Name = "button1_Lista";
            this.button1_Lista.Size = new System.Drawing.Size(119, 44);
            this.button1_Lista.TabIndex = 10;
            this.button1_Lista.Text = "Lista";
            this.button1_Lista.UseVisualStyleBackColor = true;
            this.button1_Lista.Click += new System.EventHandler(this.button1_Lista_Click);
            // 
            // Form1_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 449);
            this.Controls.Add(this.button1_Lista);
            this.Controls.Add(this.button5_csv);
            this.Controls.Add(this.button4_csv);
            this.Controls.Add(this.button3_adicionar);
            this.Controls.Add(this.textBox3_lista);
            this.Controls.Add(this.button1_adicionar);
            this.Controls.Add(this.textBox1_nome);
            this.Controls.Add(this.label1_nome);
            this.Name = "Form1_Cadastro";
            this.Text = "Cadastro de Amigos";
            this.Load += new System.EventHandler(this.Form1_Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_nome;
        private System.Windows.Forms.TextBox textBox1_nome;
        private System.Windows.Forms.Button button1_adicionar;
        private System.Windows.Forms.TextBox textBox3_lista;
        private System.Windows.Forms.Button button3_adicionar;
        private System.Windows.Forms.Button button5_csv;
        private System.Windows.Forms.Button button4_csv;
        private System.Windows.Forms.Button button1_Lista;
    }
}

