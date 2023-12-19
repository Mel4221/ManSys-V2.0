using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;

namespace ManSys
{
    public partial class Gestión_de_Empresa : Form
    {
        // Realizo la Conexión a la Base de Datos
 
        public Gestión_de_Empresa()
        {
            InitializeComponent();
        }

    
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntlimpiar_Click(object sender, EventArgs e)
        {

            //btnNuevo.Enabled = true;
            //btnRegistrar.Enabled = false;
            //btnModificar.Enabled = false;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = true;
            //btnBuscar.Enabled = true;
            //txtbusqueda.Enabled = true;
            Limpiar();
        }
        private void Limpiar()
        {
            txtrnc.Clear();
            txtnombre.Clear();
            txtsector.Clear();
            txtdireccion.Clear();
            txtpais.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Cargo el estado para el botón Nuevo y los demás elementos.
            //btnNuevo.Enabled = false;
            //btnRegistrar.Enabled = true;
            //btnModificar.Enabled = true;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = true;
            //btnBuscar.Enabled = true;
            //txtbusqueda.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //btnNuevo.Enabled = true;
            //btnRegistrar.Enabled = false;
            //btnModificar.Enabled = false;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = true;
            //btnBuscar.Enabled = true;
            //txtbusqueda.Enabled = true;
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!QuickTools.QCore.Get.IsNumber(txtrnc.Text)) { MessageBox.Show("EL RNC NO ES VALIDO SOLO PERMITE NUMEROS"); return; }
         

            try
            {
 
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"DELETE FROM dbo.Gestion_de_Empresas WHERE RNC = {txtrnc.Text}", con);
                    cmd.ExecuteNonQuery();
                    this.Limpiar();
                    this.LLenarGridEmpresas();
                }
				 
			}
            catch (Exception ex)
            {
                new MantenimientoDeEmpleados().ShowError("Hubo un error al tratar de Eliminar a la Empresa", ex);
            }
         

            //btnNuevo.Enabled = true;
            //btnRegistrar.Enabled = false;
            //btnModificar.Enabled = false;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = false;
            //btnBuscar.Enabled = true;
            //txtbusqueda.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Connection.ConnectionString);
            SqlCommand cm = new SqlCommand("UPDATE dbo.Gestion_de_Empresas SET Nombre=@Nombre,RNC=@RNC,Sector_de_Empresa = @Sector_Empresarial,Direccion = @Dirección,Pais = @Pais WHERE RNC = @RNC ", cn);
           
           

            cm.Parameters.Add(new SqlParameter("@RNC", SqlDbType.Int));
            cm.Parameters["@RNC"].Value = txtrnc.Text;

            cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cm.Parameters["@Nombre"].Value = txtnombre.Text;

            cm.Parameters.Add(new SqlParameter("@Sector_Empresarial", SqlDbType.VarChar));
            cm.Parameters["@Sector_Empresarial"].Value = txtsector.Text;

            cm.Parameters.Add(new SqlParameter("@Dirección", SqlDbType.VarChar));
            cm.Parameters["@Dirección"].Value = txtdireccion.Text;

            cm.Parameters.Add(new SqlParameter("@Pais", SqlDbType.VarChar));
            cm.Parameters["@Pais"].Value = txtpais.Text;

            cn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Guardado Satisfactoriamente");
            this.LLenarGridEmpresas();

            //btnNuevo.Enabled = true;
            //btnRegistrar.Enabled = false;
            //btnModificar.Enabled = false;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = true;
            //btnBuscar.Enabled = true;
            //txtbusqueda.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Connection.ConnectionString);
            SqlCommand cm = new SqlCommand("INSERT INTO dbo.Gestion_de_Empresas(Nombre,RNC,Sector_de_Empresa,Direccion,Pais) values(@Nombre,@RNC,@Sector_Empresarial,@Dirección,@Pais)", cn);
           

            cm.Parameters.Add(new SqlParameter("@RNC", SqlDbType.Int));
            cm.Parameters["@RNC"].Value = txtrnc.Text;

            cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cm.Parameters["@Nombre"].Value = txtnombre.Text;

            cm.Parameters.Add(new SqlParameter("@Sector_Empresarial", SqlDbType.VarChar));
            cm.Parameters["@Sector_Empresarial"].Value = txtsector.Text;

            cm.Parameters.Add(new SqlParameter("@Dirección", SqlDbType.VarChar));
            cm.Parameters["@Dirección"].Value = txtdireccion.Text;

            cm.Parameters.Add(new SqlParameter("@Pais", SqlDbType.VarChar));
            cm.Parameters["@Pais"].Value = txtpais.Text;

            cn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Guardado Satisfactoriamente");


            //btnNuevo.Enabled = true;
            //btnRegistrar.Enabled = false;
            //btnModificar.Enabled = false;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = true;
            //btnBuscar.Enabled = true;
            //txtbusqueda.Enabled = true;
            this.LLenarGridEmpresas();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LLenarGridEmpresas();
        }

        private void LLenarGridEmpresas()
        {
            //Codigo para llenar grid de empleados


            DataTable dtempleados = new DataTable();

            SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString);
            SqlCommand cm = new SqlCommand();
            cm.Connection = dataConnection;

            SqlDataAdapter daempleados = new SqlDataAdapter("SELECT * FROM dbo.Gestion_de_Empresas", dataConnection);


            daempleados.Fill(dtempleados);


			ListadodeEmpresas.DataSource = dtempleados;
        }

        private void ListadodeEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtrnc.Text = ListadodeEmpresas.CurrentRow.Cells["RNC"].Value.ToString();
            //txtnombre.Text = ListadodeEmpresas.CurrentRow.Cells["Nombre"].Value.ToString();
            //txtsector.Text = ListadodeEmpresas.CurrentRow.Cells["Sector_Empresarial"].Value.ToString();
            //txtdireccion.Text = ListadodeEmpresas.CurrentRow.Cells["Dirección"].Value.ToString();
            //txtpais.Text = ListadodeEmpresas.CurrentRow.Cells["Pais"].Value.ToString();
            ////btnNuevo.Enabled = true;
            //btnRegistrar.Enabled = true;
            //btnModificar.Enabled = true;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = true;
        }

        private void Gestión_de_Empresa_Load(object sender, EventArgs e)
        {
            LLenarGridEmpresas();
            //btnNuevo.Enabled = true;
            //btnRegistrar.Enabled = false;
            //btnModificar.Enabled = false;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = true;
            //btnBuscar.Enabled = true;
            //txtbusqueda.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        //    string sql = "SELECT * FROM Gestión_de_Empresas WHERE RNC=" + txtbusqueda.Text;

        //    SqlConnection con = new SqlConnection(Connection);
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.CommandType = CommandType.Text;
        //    SqlDataReader reader;
        //    con.Open();
        //    try
        //    {
        //        reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            //btnNuevo.Enabled = false;
        //            //btnRegistrar.Enabled = true;
        //            //btnModificar.Enabled = true;
        //            //btnCancelar.Enabled = true;
        //            //btnEliminar.Enabled = true;
        //            //btnBuscar.Enabled = true;
        //            //txtbusqueda.Enabled = true;
        //            //txtnombre.Focus();
        //            //txtrnc.Text = reader[0].ToString();
        //            //txtnombre.Text = reader[1].ToString();
        //            //txtsector.Text = reader[2].ToString();
        //            //txtdireccion.Text = reader[3].ToString();
        //            //txtpais.Text = reader[4].ToString();


        //        }
        //        else
        //            MessageBox.Show("Ningun Registro Encontrado con el Dato de Busqueda Ingresado !");

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }

           
        }

        private void Gestión_de_Empresa_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void txtcontraseña_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {

        }

		private void gblistadovisitas_Enter(object sender, EventArgs e)
		{

		}
        private void BuscarEmpresa()
        {
            try{
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    con.Open();
                    string query = QuickTools.QCore.Get.IsNumber(this.txtbusqueda.Text)==true? $"SELECT * FROM dbo.Gestion_de_Empresas WHERE RNC = {this.txtbusqueda.Text}" : $"SELECT * FROM dbo.Gestion_de_Empresas WHERE Nombre = '{this.txtbusqueda.Text}'";

					SqlDataAdapter adapter = new SqlDataAdapter(query,con);
                    DataTable table = new DataTable();
                    adapter.Fill(table); 
                    foreach(DataRow row in table.Rows)
                    {
                        this.txtrnc.Text = row["RNC"].ToString();
                        this.txtnombre.Text = row["Nombre"].ToString();
                        this.txtsector.Text = row["Sector_de_Empresa"].ToString();
                        this.txtdireccion.Text = row["Direccion"].ToString();
                        this.txtpais.Text = row["Pais"].ToString();
					}
                }
                
            }catch(Exception ex)
            {
                new MantenimientoDeEmpleados().ShowError("Hubo un errror al Buscar la empresa", ex); 
            }
        }
		private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.BuscarEmpresa();
				e.SuppressKeyPress = true;
				return;
			}
		}

		private void btnBuscar_Click_1(object sender, EventArgs e)
		{
            this.BuscarEmpresa();
		}
	}
}
