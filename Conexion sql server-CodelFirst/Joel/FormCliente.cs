using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregamos en la referencia nuestros dll generadados de nuestro modelo de datos y las consultas
using DataModel;
using CNegocio;

namespace Joel
{
    public partial class FormCliente : Form
    {
        //Definimos nombre para las clases
        private PersonRule _personRule;
        private ClsClienteEntity _ClsCliente;
        public FormCliente()
        {
            InitializeComponent();
            //definimos de que clase corresponde cada nombre
            this._personRule = new PersonRule();
            this._ClsCliente = new ClsClienteEntity();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Comando para salir
            this.Close();
        }

       
        private void txtNombres_OnValueChanged(object sender, EventArgs e)
        {
            //Agremos a la tabla cliente lo que el usuario ingrese en la caja de texto correspondiente a cliente
            _ClsCliente.Nombres = txtNombres.Text;

            this.List();
        }

        private void txtApellidos_OnValueChanged(object sender, EventArgs e)
        {
            _ClsCliente.Apellidos = txtApellidos.Text;

           
        }

        private void txtTelefono_OnValueChanged(object sender, EventArgs e)
        {
            _ClsCliente.Telefono = txtTelefono.Text;

           
        }

        private void txtDireccion_OnValueChanged(object sender, EventArgs e)
        {
            _ClsCliente.Direccion = txtDireccion.Text;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Pasamos a una consulta una coleccion  clscliente quien contendra todos los datos ingresados en las diferentes cajas de texto
                _personRule.GuardarClientes(this._ClsCliente);
                MessageBox.Show("Guardado");
                //Mandamos a limpiar las a¡cajas de texto
                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtTelefono.Text = "";
                txtDireccion.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private Guid ClienteId = Guid.Empty;

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Preguntamos si quiere eliminar
            DialogResult R = MessageBox.Show("Seguro desea actualizar los datos ", "", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                this._ClsCliente.ClienteId = this.ClienteId;
                //Accedemos a una consulta mediante e personrule
                _personRule.ActualizarClientes(this._ClsCliente);
                MessageBox.Show("Actualizado Correctamente");
                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtTelefono.Text = "";
                txtDireccion.Text = "";

                //Retorna el punterp a la cajade texto nombres
                txtNombres.Focus();

                //Realizamos un listado de todps los datos
                this.List();
                btnGuardar.Enabled = false;

            }
            else
            {
                if (R == DialogResult.No)
                {
                    MessageBox.Show("Ah canselado el proceso exitosamente");
                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    txtTelefono.Text = "";
                    txtDireccion.Text = "";

                    txtNombres.Focus();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";

            txtNombres.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Seguro desea Eliminar los datos ", "", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                this._ClsCliente.ClienteId = this.ClienteId;
                _personRule.EliminarClientes(this._ClsCliente);
                MessageBox.Show("Eliminado Correctamente");
                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtTelefono.Text = "";
                txtDireccion.Text = "";

                txtNombres.Focus();

                btnGuardar.Enabled = true;
            }
            else
            {
                if (R == DialogResult.No)
                {
                    MessageBox.Show("Ah canselado el proceso exitosamente");
                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    txtTelefono.Text = "";
                    txtDireccion.Text = "";

                    txtNombres.Focus();
                }
            }
        }
        //Creamos un delegado
        public void LlenarDatos()
        {//Espeficicamos en el orden que se rellenara el datagrid
            this.ClienteId = Guid.Parse(dtgLlenardatos.CurrentRow.Cells[0].Value.ToString());
            txtNombres.Text = dtgLlenardatos.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dtgLlenardatos.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = dtgLlenardatos.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dtgLlenardatos.CurrentRow.Cells[4].Value.ToString();
          
        }

        private void dtgLlenardatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mandamos a llamar el metodo
            this.LlenarDatos();
            btnGuardar.Enabled = false;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            this.List();
        }

        private void List()
        {
            try
            {
                //Llenamos el datagrid cpn una consulta
                dtgLlenardatos.DataSource = (from c in _personRule.ListarClientes(txtNombres.Text) select new { c.ClienteId, c.Nombres,c.Apellidos,c.Direccion, c.Telefono}).ToList();
                dtgLlenardatos.Columns[0].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
