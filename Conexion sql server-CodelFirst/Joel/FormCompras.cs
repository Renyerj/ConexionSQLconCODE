using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;
using CNegocio;

namespace Joel
{
    public partial class FormCompras : Form
    {
        private PersonRule _personRule;
        private ClsCompraEntity _ClsCompra;
        public FormCompras()
        {
            InitializeComponent();
            this._personRule = new PersonRule();
            this._ClsCompra = new ClsCompraEntity();
        }

        Boolean FormLoad = false;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdescripcion_OnValueChanged(object sender, EventArgs e)
        {
            _ClsCompra.Descripcion = txtdescripcion.Text;
            
        }

        private void txtCantidad_OnValueChanged(object sender, EventArgs e)
        {
            _ClsCompra.Cantidad = Convert.ToInt32(txtCantidad.Text); ;

        }

        private void txtPrecio_OnValueChanged(object sender, EventArgs e)
        {
            _ClsCompra.Precio = Convert.ToInt32(txtPrecio.Text); ;
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.FormLoad)
            {
                this._ClsCompra.ClienteId = Guid.Parse(cbCliente.SelectedValue.ToString());
            }
        }

        private Guid CompraId = Guid.Empty;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _personRule.GuardarCompras(this._ClsCompra);
                MessageBox.Show("La compra se a guardado correctamente putos");
                txtdescripcion.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Text = "";
                cbCliente.Text = "";

                txtdescripcion.Focus();

                this.List();
            }
            catch (Exception o)
            {
                this.List();
                o.ToString();
               // MessageBox.Show("Error maricas");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Seguro desea actualizar los datos ", "", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                this._ClsCompra.CompraId = this.CompraId;
                //Accedemos a una consulta mediante e personrule
                _personRule.ActualizarCompras(this._ClsCompra);
                MessageBox.Show("Actualizado Correctamente");
                txtdescripcion.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Text = "";
                cbCliente.Text = "";

                txtdescripcion.Focus();
                //Realizamos un listado de todps los datos
                this.List();
                btnGuardar.Enabled = false;

            }
            else
            {
                if (R == DialogResult.No)
                {
                    MessageBox.Show("Ah canselado el proceso exitosamente");
                    txtdescripcion.Text = "";
                    txtPrecio.Text = "";
                    txtCantidad.Text = "";
                    cbCliente.Text = "";

                    this.List();
                    txtdescripcion.Focus();
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtdescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            cbCliente.Text = "";

            this.List();
            txtdescripcion.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult R = MessageBox.Show("Seguro desea Eliminar los datos ", "", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                this._ClsCompra.CompraId = this.CompraId;
                _personRule.EliminarCompras(this._ClsCompra);
                MessageBox.Show("Eliminado Correctamente");
                txtdescripcion.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Text = "";
                cbCliente.Text = "";

                txtdescripcion.Focus();
                btnGuardar.Enabled = true;
                this.List();
            }
            else
            {
                if (R == DialogResult.No)
                {
                    MessageBox.Show("Ah canselado el proceso exitosamente");
                    txtdescripcion.Text = "";
                    txtPrecio.Text = "";
                    txtCantidad.Text = "";
                    cbCliente.Text = "";

                    txtdescripcion.Focus();
                    this.List();
                }
            }

        }

        public void LlenarDatos()
        {//Espeficicamos en el orden que se rellenara el datagrid
            this.CompraId = Guid.Parse(dtgLlenardatos.CurrentRow.Cells[0].Value.ToString());
            txtdescripcion.Text = dtgLlenardatos.CurrentRow.Cells[1].Value.ToString();
            txtCantidad.Text = dtgLlenardatos.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dtgLlenardatos.CurrentRow.Cells[3].Value.ToString();
            cbCliente.Text = dtgLlenardatos.CurrentRow.Cells[4].Value.ToString();

            this.List();
        }

        private void dtgLlenardatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.LlenarDatos();
            btnGuardar.Enabled = false;
        }

        private void List()
        {
            try
            {
                //Llenamos el datagrid cpn una consulta
                dtgLlenardatos.DataSource = (from c in _personRule.ListarCompras(txtdescripcion.Text) select new { c.CompraId, c.Descripcion, c.Cantidad, c.Precio, c.ClienteId }).ToList();
                dtgLlenardatos.Columns[0].Visible = false;

                cbCliente.DataSource = (from c in _personRule.ListarClientes("") select new { Id = c.ClienteId, Nombres = c.Nombres}).ToList();
                cbCliente.ValueMember = "Id";
                cbCliente.DisplayMember = "Nombres";

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            this.List();
            this.FormLoad = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
