using Firma.Forms;
using Firma.Forms.Clientes;
using Firma.Forms.Funcionarios;
using Mercado.Forms.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado.Forms
{
    public partial class Menu : MaterialSkin.Controls.MaterialForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cc = new CadastroCliente();
            cc.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastroDeFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFunc cf = new CadastroFunc();
            cf.ShowDialog();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCliente cc = new ConsultarCliente();
            cc.ShowDialog();
        }
    }
}
