namespace Capa_Vista
{
    partial class frmMDI
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
            this.mspMDI = new System.Windows.Forms.MenuStrip();
            this.tsmiInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNominaProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBuscarDatosGeneralesDeNominaProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeduccionesPercepccionesProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeducciónPercepciónEmpleadoProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiControlDeHorasDíasProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNominaReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.mspMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspMDI
            // 
            this.mspMDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(74)))), ((int)(((byte)(181)))));
            this.mspMDI.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mspMDI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInicio,
            this.tsmiMantenimientos,
            this.tsmiProcesos,
            this.tsmiHerramientas,
            this.tsmiReportes,
            this.tsmiAyuda});
            this.mspMDI.Location = new System.Drawing.Point(0, 0);
            this.mspMDI.Name = "mspMDI";
            this.mspMDI.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mspMDI.Size = new System.Drawing.Size(975, 25);
            this.mspMDI.TabIndex = 0;
            // 
            // tsmiInicio
            // 
            this.tsmiInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCerrarSesion});
            this.tsmiInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiInicio.Name = "tsmiInicio";
            this.tsmiInicio.Size = new System.Drawing.Size(63, 21);
            this.tsmiInicio.Text = "Inicio";
            this.tsmiInicio.ToolTipText = "Opciones de Sesión";
            // 
            // tsmiCerrarSesion
            // 
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Size = new System.Drawing.Size(187, 26);
            this.tsmiCerrarSesion.Text = "Cerrar Sesión";
            this.tsmiCerrarSesion.Click += new System.EventHandler(this.tsmiCerrarSesion_Click);
            // 
            // tsmiMantenimientos
            // 
            this.tsmiMantenimientos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiMantenimientos.Name = "tsmiMantenimientos";
            this.tsmiMantenimientos.Size = new System.Drawing.Size(137, 21);
            this.tsmiMantenimientos.Text = "Mantenimientos";
            this.tsmiMantenimientos.ToolTipText = "Mantenimientos del Módulo";
            // 
            // tsmiProcesos
            // 
            this.tsmiProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNominaProceso});
            this.tsmiProcesos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiProcesos.Name = "tsmiProcesos";
            this.tsmiProcesos.Size = new System.Drawing.Size(86, 21);
            this.tsmiProcesos.Text = "Procesos";
            // 
            // tsmiNominaProceso
            // 
            this.tsmiNominaProceso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBuscarDatosGeneralesDeNominaProceso,
            this.tsmiDeduccionesPercepccionesProceso,
            this.tsmiDeducciónPercepciónEmpleadoProceso,
            this.tsmiControlDeHorasDíasProceso});
            this.tsmiNominaProceso.Name = "tsmiNominaProceso";
            this.tsmiNominaProceso.Size = new System.Drawing.Size(145, 26);
            this.tsmiNominaProceso.Text = "Nómina";
            // 
            // tsmiBuscarDatosGeneralesDeNominaProceso
            // 
            this.tsmiBuscarDatosGeneralesDeNominaProceso.Name = "tsmiBuscarDatosGeneralesDeNominaProceso";
            this.tsmiBuscarDatosGeneralesDeNominaProceso.Size = new System.Drawing.Size(340, 26);
            this.tsmiBuscarDatosGeneralesDeNominaProceso.Text = "Buscar Datos Generales de Nómina";
            this.tsmiBuscarDatosGeneralesDeNominaProceso.Click += new System.EventHandler(this.tsmiBuscarDatosGeneralesDeNominaProceso_Click);
            // 
            // tsmiDeduccionesPercepccionesProceso
            // 
            this.tsmiDeduccionesPercepccionesProceso.Name = "tsmiDeduccionesPercepccionesProceso";
            this.tsmiDeduccionesPercepccionesProceso.Size = new System.Drawing.Size(340, 26);
            this.tsmiDeduccionesPercepccionesProceso.Text = "Deducciones / Percepcciones";
            this.tsmiDeduccionesPercepccionesProceso.Click += new System.EventHandler(this.tsmiDeduccionesPercepccionesProceso_Click);
            // 
            // tsmiDeducciónPercepciónEmpleadoProceso
            // 
            this.tsmiDeducciónPercepciónEmpleadoProceso.Name = "tsmiDeducciónPercepciónEmpleadoProceso";
            this.tsmiDeducciónPercepciónEmpleadoProceso.Size = new System.Drawing.Size(340, 26);
            this.tsmiDeducciónPercepciónEmpleadoProceso.Text = "Deducción / Percepción Empleado";
            this.tsmiDeducciónPercepciónEmpleadoProceso.Click += new System.EventHandler(this.tsmiDeducciónPercepciónEmpleadoProceso_Click);
            // 
            // tsmiControlDeHorasDíasProceso
            // 
            this.tsmiControlDeHorasDíasProceso.Name = "tsmiControlDeHorasDíasProceso";
            this.tsmiControlDeHorasDíasProceso.Size = new System.Drawing.Size(340, 26);
            this.tsmiControlDeHorasDíasProceso.Text = "Control de Horas / Días";
            this.tsmiControlDeHorasDíasProceso.Click += new System.EventHandler(this.tsmiControlDeHorasDíasProceso_Click);
            // 
            // tsmiHerramientas
            // 
            this.tsmiHerramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarEmpleadosToolStripMenuItem});
            this.tsmiHerramientas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiHerramientas.Name = "tsmiHerramientas";
            this.tsmiHerramientas.Size = new System.Drawing.Size(118, 21);
            this.tsmiHerramientas.Text = "Herramientas";
            // 
            // mostrarEmpleadosToolStripMenuItem
            // 
            this.mostrarEmpleadosToolStripMenuItem.Name = "mostrarEmpleadosToolStripMenuItem";
            this.mostrarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.mostrarEmpleadosToolStripMenuItem.Text = "Mostrar Empleados";
            this.mostrarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.mostrarEmpleadosToolStripMenuItem_Click);
            // 
            // tsmiReportes
            // 
            this.tsmiReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNominaReporte});
            this.tsmiReportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiReportes.Name = "tsmiReportes";
            this.tsmiReportes.Size = new System.Drawing.Size(85, 21);
            this.tsmiReportes.Text = "Reportes";
            // 
            // tsmiNominaReporte
            // 
            this.tsmiNominaReporte.Name = "tsmiNominaReporte";
            this.tsmiNominaReporte.Size = new System.Drawing.Size(145, 26);
            this.tsmiNominaReporte.Text = "Nómina";
            this.tsmiNominaReporte.Click += new System.EventHandler(this.tsmiNominaReporte_Click);
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(66, 21);
            this.tsmiAyuda.Text = "Ayuda";
            this.tsmiAyuda.Click += new System.EventHandler(this.tsmiAyuda_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(0, 507);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(975, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(31)))), ((int)(((byte)(70)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 25);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(975, 504);
            this.pnlContenedor.TabIndex = 1;
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 529);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.mspMDI);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspMDI;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "301 - Módulo de Recursos Humanos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.mspMDI.ResumeLayout(false);
            this.mspMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMDI;
        private System.Windows.Forms.ToolStripMenuItem tsmiInicio;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiProcesos;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportes;
        private System.Windows.Forms.ToolStripMenuItem tsmiHerramientas;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
        private System.Windows.Forms.ToolStripMenuItem tsmiNominaProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiNominaReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeduccionesPercepccionesProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuscarDatosGeneralesDeNominaProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeducciónPercepciónEmpleadoProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiControlDeHorasDíasProceso;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.ToolStripMenuItem mostrarEmpleadosToolStripMenuItem;
    }
}