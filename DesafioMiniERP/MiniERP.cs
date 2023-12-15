namespace MiniERP
{
    public partial class ERP : Form
    {

        public ERP()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm c = new ClienteForm();
            c.MdiParent = this;
            c.Show();
            c.Activate();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FornecedorForm f = new FornecedorForm();
            f.MdiParent = this;
            f.Show();
            f.Activate();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoForm p = new ProdutoForm();
            p.MdiParent = this;
            p.Show();
            p.Activate();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas v = new Vendas();
           v.MdiParent = this;
            v.Show();
            v.Activate();
        }
    }
}
