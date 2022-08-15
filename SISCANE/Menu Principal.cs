using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace SISCANE
{
    public partial class Form1 : Form
    {
        //private object menuprincipal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
           // lblposicion.Text = UserLoginCache.Puesto_Ocupado;
           // lblnombrecompleto.Text = UserLoginCache.Nombre + ", " + UserLoginCache.Apellido;
           // lbldepartamento.Text = UserLoginCache.Departamento;
           
        }

        private void mantenimientoDeNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }

        private void mantenimientoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Form5();
            formulario.Show();
        }

        private void consultaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Form9();
            formulario.Show();
        }

        private void reporteDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Form7();
            formulario.Show();
        }

        private void reporteDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new R();
            formulario.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Estas Seguro que Quieres Cerrar Sesion?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            this.Close();
        }

        private void consultaDeVolanteDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Form10();
            formulario.Show();
        }

        private void gestionDeEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Gestión_de_Empresa();
            formulario.Show();
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Gestión_de_Usuarios();
            formulario.Show();
        }

        private void generarVolantedePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Form10();
            formulario.Show();
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
            Form formulario = new Form2();
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
            Form formulario = new mantenimientoDeducciones();
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

    
    }
}
