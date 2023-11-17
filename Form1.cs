using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioWindowsForms2
{
    public partial class Form1_Cadastro : Form
    {
        public Form1_Cadastro()
        {
            InitializeComponent();
        }

        List<Amigo> lista = new List<Amigo>();

        private void textBox1_nome_TextChanged(object sender, EventArgs e)
        {
            textBox1_nome.Text = textBox1_nome.Text.ToUpper();
            textBox1_nome.SelectionStart = textBox1_nome.Text.Length; // Coloca o cursor no final do texto
        }

        private void button1_adicionar_Click(object sender, EventArgs e)
        {
            if (textBox1_nome.Text.Equals(""))
            {
                MessageBox.Show("Alerta!", "Digite algo para cadastrar!");
                return;
            }

            String email;

            if (Amigo.amigoCadastrado(textBox1_nome.Text, lista))
            {
                MessageBox.Show("Alerta", "Este nome já existe no cadastro!");
            }
            else
            {
                String[] vetorNomes = textBox1_nome.Text.ToLower().Split(' ');

                if (vetorNomes.Length > 1)
                {
                    email = vetorNomes[vetorNomes.Length - 1] + "." + vetorNomes[0] + "@ufn.edu.br" + "; ";
                }
                else
                {
                    email = vetorNomes[0] + "@ufn.edu.br" + "; ";
                }

                lista.Add(new Amigo(textBox1_nome.Text, email));
                textBox3_lista.AppendText(textBox1_nome.Text + ", " + email);
                textBox1_nome.Clear();
                textBox1_nome.Focus();

                //gravar em arquivo texto
            }
        }

        private void textBox3_lista_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_adicionar_Click(object sender, EventArgs e)
        {
            textBox3_lista.Text = "";
            lista.Clear();

        }

        private void button4_csv_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "amigos.csv");

            try
            {
                using (StreamWriter escritor = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    foreach (var amigo in lista)
                    {
                        escritor.WriteLine($"{amigo.Nome};{amigo.Email}");
                    }
                }

                MessageBox.Show("Arquivo amigos.csv criado com sucesso no Desktop!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao criar o arquivo: {ex.Message}");
            }
        }

        private void button5_csv_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "amigos.csv");
            string amigoSecretoPath = Path.Combine(desktopPath, "amigo_secreto.csv");

            try
            {
                List<Amigo> amigos = new List<Amigo>();

                // Lê os amigos do arquivo CSV
                using (StreamReader leitor = new StreamReader(filePath))
                {
                    string linha;
                    while ((linha = leitor.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(';');
                        amigos.Add(new Amigo(dados[0], dados[1]));
                    }
                }

                // Embaralha a lista de amigos
                Random rng = new Random();
                List<Amigo> amigosEmbaralhados = amigos.OrderBy(a => rng.Next()).ToList();

                // Cria o arquivo de amigo secreto
                using (StreamWriter escritor = new StreamWriter(amigoSecretoPath, false, Encoding.UTF8))
                {
                    for (int i = 0; i < amigos.Count; i++)
                    {
                        int indiceAmigoSecreto = (i + 1) % amigos.Count; // Garante que não seja a mesma pessoa
                        escritor.WriteLine($"{i + 1}) {amigosEmbaralhados[i].Nome} tirou o(a) amigo(a) secreto(a) {amigosEmbaralhados[indiceAmigoSecreto].Nome}");
                    }
                }

                MessageBox.Show("Arquivo amigo_secreto.csv gerado com sucesso no Desktop!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar o arquivo: {ex.Message}");
            }

        }

        private void button1_Lista_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string amigoSecretoPath = Path.Combine(desktopPath, "amigo_secreto.csv");

            try
            {
                using (StreamReader leitor = new StreamReader(amigoSecretoPath))
                {
                    string conteudoArquivo = leitor.ReadToEnd(); // Lê o conteúdo do arquivo
                    Form_Lista formLista = new Form_Lista(conteudoArquivo); // Passa o conteúdo como parâmetro
                    formLista.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao abrir o arquivo: {ex.Message}");
            }
        }

        private void Form1_Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}





