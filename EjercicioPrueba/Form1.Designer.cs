namespace Ejerciciodelidiota
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.lblServiciosSeleccionados = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNumeroServicios = new System.Windows.Forms.Button();
            this.lstServiciosSeleccionados = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnServicioMenorDemanda = new System.Windows.Forms.Button();
            this.btnMontoPromedioLavado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(27, 36);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(109, 16);
            this.lblTipoVehiculo.TabIndex = 0;
            this.lblTipoVehiculo.Text = "Tipo de Vehiculo";
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Location = new System.Drawing.Point(30, 109);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(106, 16);
            this.lblTipoServicio.TabIndex = 1;
            this.lblTipoServicio.Text = "Tipo de Servicio";
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbTipoVehiculo.Items.AddRange(new object[] {
            "Auto",
            "Camioneta"});
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(142, 33);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoVehiculo.TabIndex = 2;
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Items.AddRange(new object[] {
            "Lavado",
            "Encerado",
            "Silicona"});
            this.cmbTipoServicio.Location = new System.Drawing.Point(142, 106);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoServicio.TabIndex = 3;
            // 
            // lblServiciosSeleccionados
            // 
            this.lblServiciosSeleccionados.AutoSize = true;
            this.lblServiciosSeleccionados.Location = new System.Drawing.Point(326, 33);
            this.lblServiciosSeleccionados.Name = "lblServiciosSeleccionados";
            this.lblServiciosSeleccionados.Size = new System.Drawing.Size(155, 16);
            this.lblServiciosSeleccionados.TabIndex = 4;
            this.lblServiciosSeleccionados.Text = "Servicios seleccionados";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 165);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar Servicio";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnNumeroServicios
            // 
            this.btnNumeroServicios.Location = new System.Drawing.Point(30, 237);
            this.btnNumeroServicios.Name = "btnNumeroServicios";
            this.btnNumeroServicios.Size = new System.Drawing.Size(215, 30);
            this.btnNumeroServicios.TabIndex = 7;
            this.btnNumeroServicios.Text = "Calcular numero de servicios";
            this.btnNumeroServicios.UseVisualStyleBackColor = true;
            this.btnNumeroServicios.Click += new System.EventHandler(this.btnNumeroServicios_Click);
            // 
            // lstServiciosSeleccionados
            // 
            this.lstServiciosSeleccionados.FormattingEnabled = true;
            this.lstServiciosSeleccionados.ItemHeight = 16;
            this.lstServiciosSeleccionados.Location = new System.Drawing.Point(329, 52);
            this.lstServiciosSeleccionados.Name = "lstServiciosSeleccionados";
            this.lstServiciosSeleccionados.Size = new System.Drawing.Size(440, 132);
            this.lstServiciosSeleccionados.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(353, 398);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 30);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnServicioMenorDemanda
            // 
            this.btnServicioMenorDemanda.Location = new System.Drawing.Point(287, 237);
            this.btnServicioMenorDemanda.Name = "btnServicioMenorDemanda";
            this.btnServicioMenorDemanda.Size = new System.Drawing.Size(215, 30);
            this.btnServicioMenorDemanda.TabIndex = 12;
            this.btnServicioMenorDemanda.Text = "Servicio con menos demanda";
            this.btnServicioMenorDemanda.UseVisualStyleBackColor = true;
            this.btnServicioMenorDemanda.Click += new System.EventHandler(this.btnServicioMenorDemanda_Click);
            // 
            // btnMontoPromedioLavado
            // 
            this.btnMontoPromedioLavado.Location = new System.Drawing.Point(541, 229);
            this.btnMontoPromedioLavado.Name = "btnMontoPromedioLavado";
            this.btnMontoPromedioLavado.Size = new System.Drawing.Size(215, 46);
            this.btnMontoPromedioLavado.TabIndex = 13;
            this.btnMontoPromedioLavado.Text = "Monto promedio por servicio de lavado";
            this.btnMontoPromedioLavado.UseVisualStyleBackColor = true;
            this.btnMontoPromedioLavado.Click += new System.EventHandler(this.btnMontoPromedioLavado_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Estoy aqui";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMontoPromedioLavado);
            this.Controls.Add(this.btnServicioMenorDemanda);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lstServiciosSeleccionados);
            this.Controls.Add(this.btnNumeroServicios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblServiciosSeleccionados);
            this.Controls.Add(this.cmbTipoServicio);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.lblTipoServicio);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.Label lblServiciosSeleccionados;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnNumeroServicios;
        private System.Windows.Forms.ListBox lstServiciosSeleccionados;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnServicioMenorDemanda;
        private System.Windows.Forms.Button btnMontoPromedioLavado;
        private System.Windows.Forms.Button button1;
    }
}

