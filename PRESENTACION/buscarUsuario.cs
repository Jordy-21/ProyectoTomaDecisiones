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
    public partial class buscarUsuario : Form
    {
        conexion cnn = new conexion();

        public buscarUsuario()
        {
            InitializeComponent();
        }

        private void buscarUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cnn.getClientes();
        }
    }
}
