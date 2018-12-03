namespace Joel
{
    partial class FormCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimpiar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgLlenardatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrecio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtdescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLlenardatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageActive = null;
            this.btnSalir.Location = new System.Drawing.Point(1298, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(36, 34);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 2;
            this.btnSalir.TabStop = false;
            this.btnSalir.Zoom = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Location = new System.Drawing.Point(1148, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(126, 527);
            this.groupBox3.TabIndex = 143;
            this.groupBox3.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.ActiveBorderThickness = 1;
            this.btnActualizar.ActiveCornerRadius = 20;
            this.btnActualizar.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.btnActualizar.ActiveForecolor = System.Drawing.Color.Black;
            this.btnActualizar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.ButtonText = "Actualizar";
            this.btnActualizar.CausesValidation = false;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.IdleBorderThickness = 1;
            this.btnActualizar.IdleCornerRadius = 20;
            this.btnActualizar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnActualizar.IdleForecolor = System.Drawing.Color.Black;
            this.btnActualizar.IdleLineColor = System.Drawing.Color.Honeydew;
            this.btnActualizar.Location = new System.Drawing.Point(8, 150);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(102, 40);
            this.btnActualizar.TabIndex = 132;
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveBorderThickness = 1;
            this.btnGuardar.ActiveCornerRadius = 20;
            this.btnGuardar.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.btnGuardar.ActiveForecolor = System.Drawing.Color.Black;
            this.btnGuardar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.IdleBorderThickness = 1;
            this.btnGuardar.IdleCornerRadius = 20;
            this.btnGuardar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.IdleForecolor = System.Drawing.Color.Black;
            this.btnGuardar.IdleLineColor = System.Drawing.Color.Honeydew;
            this.btnGuardar.Location = new System.Drawing.Point(6, 11);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 40);
            this.btnGuardar.TabIndex = 128;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ActiveBorderThickness = 1;
            this.btnLimpiar.ActiveCornerRadius = 20;
            this.btnLimpiar.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.btnLimpiar.ActiveForecolor = System.Drawing.Color.Black;
            this.btnLimpiar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.ButtonText = "Limpiar Datos";
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.IdleBorderThickness = 1;
            this.btnLimpiar.IdleCornerRadius = 20;
            this.btnLimpiar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLimpiar.IdleForecolor = System.Drawing.Color.Black;
            this.btnLimpiar.IdleLineColor = System.Drawing.Color.Honeydew;
            this.btnLimpiar.Location = new System.Drawing.Point(8, 311);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 40);
            this.btnLimpiar.TabIndex = 130;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ActiveBorderThickness = 1;
            this.btnEliminar.ActiveCornerRadius = 20;
            this.btnEliminar.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.btnEliminar.ActiveForecolor = System.Drawing.Color.Black;
            this.btnEliminar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.IdleBorderThickness = 1;
            this.btnEliminar.IdleCornerRadius = 20;
            this.btnEliminar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEliminar.IdleForecolor = System.Drawing.Color.Black;
            this.btnEliminar.IdleLineColor = System.Drawing.Color.Honeydew;
            this.btnEliminar.Location = new System.Drawing.Point(8, 474);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 40);
            this.btnEliminar.TabIndex = 129;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dtgLlenardatos);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(88, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(992, 270);
            this.groupBox2.TabIndex = 144;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Compras";
            // 
            // dtgLlenardatos
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLlenardatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgLlenardatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgLlenardatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgLlenardatos.GridColor = System.Drawing.SystemColors.Control;
            this.dtgLlenardatos.Location = new System.Drawing.Point(13, 31);
            this.dtgLlenardatos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtgLlenardatos.Name = "dtgLlenardatos";
            this.dtgLlenardatos.RowHeadersWidth = 47;
            this.dtgLlenardatos.Size = new System.Drawing.Size(970, 226);
            this.dtgLlenardatos.TabIndex = 137;
            this.dtgLlenardatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLlenardatos_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(88, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(992, 248);
            this.groupBox1.TabIndex = 142;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Compras";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbCliente
            // 
            this.cbCliente.Font = new System.Drawing.Font("Californian FB", 12F);
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(85, 185);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(366, 27);
            this.cbCliente.TabIndex = 158;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 157;
            this.label1.Text = "Cliente";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Californian FB", 12F);
            this.txtCantidad.ForeColor = System.Drawing.Color.Black;
            this.txtCantidad.HintForeColor = System.Drawing.Color.Empty;
            this.txtCantidad.HintText = "";
            this.txtCantidad.isPassword = false;
            this.txtCantidad.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCantidad.LineIdleColor = System.Drawing.Color.Maroon;
            this.txtCantidad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCantidad.LineThickness = 3;
            this.txtCantidad.Location = new System.Drawing.Point(532, 58);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 33);
            this.txtCantidad.TabIndex = 153;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantidad.OnValueChanged += new System.EventHandler(this.txtCantidad_OnValueChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Font = new System.Drawing.Font("Californian FB", 12F);
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrecio.HintText = "";
            this.txtPrecio.isPassword = false;
            this.txtPrecio.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrecio.LineIdleColor = System.Drawing.Color.Maroon;
            this.txtPrecio.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrecio.LineThickness = 3;
            this.txtPrecio.Location = new System.Drawing.Point(14, 145);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(437, 33);
            this.txtPrecio.TabIndex = 152;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecio.OnValueChanged += new System.EventHandler(this.txtPrecio_OnValueChanged);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtdescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdescripcion.Font = new System.Drawing.Font("Californian FB", 12F);
            this.txtdescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtdescripcion.HintForeColor = System.Drawing.Color.Empty;
            this.txtdescripcion.HintText = "";
            this.txtdescripcion.isPassword = false;
            this.txtdescripcion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtdescripcion.LineIdleColor = System.Drawing.Color.Maroon;
            this.txtdescripcion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtdescripcion.LineThickness = 3;
            this.txtdescripcion.Location = new System.Drawing.Point(14, 58);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(437, 33);
            this.txtdescripcion.TabIndex = 151;
            this.txtdescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtdescripcion.OnValueChanged += new System.EventHandler(this.txtdescripcion_OnValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 22);
            this.label11.TabIndex = 148;
            this.label11.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 145;
            this.label3.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 22);
            this.label7.TabIndex = 144;
            this.label7.Text = "Descripcion";
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 583);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCompras";
            this.Load += new System.EventHandler(this.FormCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLlenardatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnSalir;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnActualizar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpiar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgLlenardatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecio;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCliente;
    }
}