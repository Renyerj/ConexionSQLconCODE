using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joel
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //Hacemos una instancia de el formulario cliente
            FormCliente x = new FormCliente();
            x.MdiParent = this;
            x.BringToFront();
            x.Show();


            x.Left = 0;
            x.Top = 0;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FormCompras x = new FormCompras();
            x.MdiParent = this;
            x.BringToFront();
            x.Show();

            x.Left = 0;
            x.Top = 0;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
