using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickTools.QCore;
using System.Data.SqlClient; 
//using Common.Cache;
using QuickTools; 
//using DataAccess; 

namespace ManSys
{
    public partial class MenuPrincipal : Form
    {
        //private object MenuPrincipalpal;

        public MenuPrincipal()
        {
            Get.Green("InitializeComponent From MenuPrincipalpal");
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
         //   ConnectionString con = new ConnectionString(); 

       //    Get.Yellow( con.Connection());


          /*
                using (SqlConnection connection = new SqlConnection(con.Connection()))
                {
                    connection.Open();
                    Get.Write("Messages", 10);
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.chatapp order by ID", connection);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    foreach (DataRow row in data.Rows)
                    {
                        Get.Yellow("[" + row["ID"] + "]" + "[" + row["created"] + "]" + " " + "[" + row["uname"] + "]" + " " + "[" + row["msg"] + "]");
                    }
                }
 
            */










            // NO SERA UTILIZADO EN ESTA VERSION 
            // lblposicion.Text = UserLoginCache.Puesto_Ocupado;
            // lblnombrecompleto.Text = UserLoginCache.Nombre + ", " + UserLoginCache.Apellido;
            // lbldepartamento.Text = UserLoginCache.Departamento;

        }

        private void mantenimientoDeNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new GenerarNomina();
            formulario.Show();
        }

        private void mantenimientoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new MantenimientoDeEmpleados();
            formulario.Show();
        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultaDeEmpleados();
            formulario.Show();
        }

        private void consultaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new ReporteDeNomina();
            formulario.Show();
        }

        private void reporteDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new ReporteDeEmpleados();
            formulario.Show();
        }

        private void reporteDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new ReporteDeUsuarios();
            formulario.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Estas Seguro que Quieres Cerrar el Systema?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            this.Close();
        }

        private void consultaDeVolanteDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPrincipal();
            formulario.Show();
        }

        private void gestionDeEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Gestión_de_Empresa();
            formulario.Show();
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Empleado();
            formulario.Show();
        }

        private void generarVolantedePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generar_Volante_de_Pago volante = new Generar_Volante_de_Pago();
            volante.Show();

		}

        private void consultaDeNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultadeNominaSalarial();
            formulario.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gENERARNOMINAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new GenerarNomina();
            formulario.Show();
        }

        private void mATENIMIENTODEDEPARTAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new mantenimientoDept();
            formulario.Show();
        }

        private void mANTENIMIENTODEPOSICIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new mantenimientoPosc();
            formulario.Show();
        }

        private void mANTENIMIENTODEIMPUESTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new mantenimientoImp();
            formulario.Show();
        }

        private void mANTENIMIENTODEDEDUCCIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
			mantenimientoDeducciones formulario = new mantenimientoDeducciones();
            formulario.Show();
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNCIDENCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Incidencias();
            formulario.Show();
        }

        private void bONIFICACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Bonificaciones();
            formulario.Show();
        }

        private void cONSULTADEDEPARTAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultadeDepartamentos();
            formulario.Show();
        }

        private void cONSULTADEPOSICIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Consulta_de_Posiciones();
            formulario.Show();
        }

        private void cONSULTADEIMPUESTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Consulta_de_Impuestos();
            formulario.Show();
        }

        private void cONSULTADEDEDUCCIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Consulta_de_Deducciones();
            formulario.Show();
        }

        private void cONSULTADEINCIDENCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Consulta_de_Incidencias();
            formulario.Show();
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var app = new ProveedorDeAplicacion();
            app.Show(); 
        }

        private void reporteDeUsuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var reporte = new ReporteDeUsuarios();
            reporte.Show();
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

		private void jORNADAToolStripMenuItem_Click(object sender, EventArgs e)
		{
            new Mantenimiento_de_Horario().Show();
		}

		private void jORNADAESToolStripMenuItem_Click(object sender, EventArgs e)
		{
            new Generar_JornadaLaboral().Show();
		}
	}
}
