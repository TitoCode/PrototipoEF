using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridad;

namespace Capa_Vista
{
    public partial class frmMDI : Form
    {
        string ayudas;
        public frmMDI()
        {
            InitializeComponent();
        }

        // FUNCIÓN PARA CONTENER UN FORM EN UN PANEL \\
        public void funcAbrirFormEnPanel(object Formhijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.None;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }


        private void tsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            // CERRAR SESIÓN \\
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
        }

        private void tsmiBuscarDatosGeneralesDeNominaProceso_Click(object sender, EventArgs e)
        {
            ayudas = "datNomi";
            // LLAMAR FUNCIÓN PARA MOSTRAR DATOS GENERALES DE NOMINA \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Nomina.frmNomina());
        }

        private void tsmiDeduccionesPercepccionesProceso_Click(object sender, EventArgs e)
        {
            ayudas = "mantDeduc";
            // LLAMAR FUNCIÓN PARA MOSTRAR MANTENIMIENTO DE DEDUCCIONES / PERCEPCCIONES \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Nomina.frmDeducPercep());
        }

        private void tsmiDeducciónPercepciónEmpleadoProceso_Click(object sender, EventArgs e)
        {
            ayudas = "ingDeduc";
            // LLAMAR FUNCIÓN PARA MOSTRAR INGRESO DE DEDUCCIONES / PERCEPCCIONES EN UN EMPLEADO \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Nomina.frmEmpleadoNomina());
        }

        private void tsmiControlDeHorasDíasProceso_Click(object sender, EventArgs e)
        {
            ayudas = "controlHoras";
            // LLAMAR FUNCIÓN PARA MOSTRAR CONTROL DE HORAS \\
            funcAbrirFormEnPanel(new Capa_Vista.Vista_Nomina.frmControlHorasDias());
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmMDI_KeyDown);
            frmLogin login = new frmLogin();
            login.ShowDialog();
            txtUsuario.Text = login.usuario();
        }

        private void tsmiAyuda_Click(object sender, EventArgs e)
        {
            //Se llaman a las ayudas del Modulo HRM
            Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm");
        }

        public void frmMDI_KeyDown(object sender, KeyEventArgs e)
        {
            funcAyudas(e);
        }

        private void funcAyudas(KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                switch (ayudas)
                {
                    case "ingresoCurso":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0003.htm");
                        break;
                    case "mantCursos":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0004.htm");
                        break;
                    case "ingresoCap":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0008.htm");
                        break;
                    case "mantCapa":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0010.htm");
                        break;
                    case "mantPuesto":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0012.htm");
                        break;
                    case "mantDept":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0013.htm");
                        break;
                    case "mantCompe":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0014.htm");
                        break;
                    case "mantFalt":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0015.htm");
                        break;
                    case "ingCompe":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0016.htm");
                        break;
                    case "datNomi":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0017.htm");
                        break;
                    case "mantDeduc":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0021.htm");
                        break;
                    case "ingDeduc":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0024.htm");
                        break;
                    case "controlHoras":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0027.htm");
                        break;
                    case "ingresoRec":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0029.htm");
                        break;
                    case "ingEntrev":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0032.htm");
                        break;
                    case "ingContra":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0034.htm");
                        break;
                    case "modEmp":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0036.htm");
                        break;
                    case "ascEmp":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0038.htm");
                        break;
                    case "despEmp":
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0040.htm");
                        break;

                    default:
                        Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0002.htm");
                        break;

                }
            }


        }
        private void tsmiEmpleadosReporte_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA REPORTE EMPLEADO \\
            funcAbrirFormEnPanel(new Vista_Reportes.frmReporteEmpleado());
        }

        private void tsmiCapacitacionReporte_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA REPORTE CAPACITACION \\
            funcAbrirFormEnPanel(new Vista_Reportes.frmReporteCapacitacion());
        }

        private void tsmiCompetenciasReporte_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA REPORTE COMPETENCIAS \\
            funcAbrirFormEnPanel(new Vista_Reportes.frmReporteCompeencias());

        }

        private void tsmiNominaReporte_Click(object sender, EventArgs e)
        {
            // LLAMAR FUNCIÓN PARA REPORTE NOMINA \\
            funcAbrirFormEnPanel(new Vista_Reportes.frmReporteNomina());
        }

        private void mostrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_Vista.Vista_Reclutamiento.frmMostrarEmpleado emp = new Vista_Reclutamiento.frmMostrarEmpleado();
            emp.ShowDialog();
        }
    }
}
