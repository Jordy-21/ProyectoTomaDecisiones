using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParaTomadeDecisiones.PRESENTACION
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void comunicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asdasdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entidadClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void consultaPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarUsuario form = new buscarUsuario();
            form.MdiParent = this;

            form.Show();
            
        }

        private void identificaciónDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*IdentificacionClientes Control = new IdentificacionClientes();
            panel2.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            panel2.Controls.Add(Control);
            */
        }
    }
}
