using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioWindowsForms2
{
    public partial class Form_Lista : Form
    {
        public Form_Lista(string conteudoArquivo)
        {
            InitializeComponent();
            textBoxLista.Text = conteudoArquivo; // Recebe o conteúdo do arquivo como parâmetro
        }

        private void Form_Lista_Load(object sender, EventArgs e)
        {

        }
    }
}
