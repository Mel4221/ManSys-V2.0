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
using QuickTools.QCore;
using System.Linq.Expressions;
using QuickTools.QIO;

namespace ManSys
{
 
    public partial class MantenimientoDeEmpleados : Form
    {
        // Realizo la Conexión a la Base de Datos
        string connectionString = Connection.ConnectionString;
        bool nuevo;

        public MantenimientoDeEmpleados()
        {
            InitializeComponent();
        }


        private bool TodoEstaCompleto()
        {
            if (txtNombre.Text == "" ||
                 txtApellido.Text == ""||
                 txtdireccion.Text == ""||
                 txttelefono.Text == ""||
                 txtfechadeingreso.Text == "" ||
                 txtdeparmento.Text == "" ||
                 txtdni.Text == ""||
                 txtsalariobase.Text == ""||
                 txttipodecobro.Text == ""||
                 txtturno.Text == ""
               )
            {
                return false; 
            }

        
  
            return true;
        }
        private bool ExisteRegistro()
        {
               using(SqlConnection cn = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand cm = new SqlCommand();

                cn.Open();
                cm.Connection = cn;
                cm.CommandText = "SP_Verificar";
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                cm.Parameters["@Nombre"].Value = txtNombre.Text;

                cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
                cm.Parameters["@Apellido"].Value = txtApellido.Text;

                cm.Parameters.Add(new SqlParameter("@CEDULA", SqlDbType.VarChar));
                cm.Parameters["@CEDULA"].Value = txtdni.Text;
                SqlDataReader reader = cm.ExecuteReader();


                if (reader.Read())
                {
                    return true;
                }
                return false;
            }
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                bool cumpleCondiciones = true;
            if (ExisteRegistro())
            {
                MessageBox.Show("El Usuario ya Existe");
                cumpleCondiciones = false;
                return;
            }

            if (TodoEstaCompleto() == false)
            {
                MessageBox.Show("Pofavor completar todos los campos");
                cumpleCondiciones = false;
                return; 
            }
            if (cumpleCondiciones)
            {


                SqlConnection cn = new SqlConnection(connectionString);
                SqlCommand cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandText = "SP_Insert_Mantenimiento_de_Empleados";
                cm.CommandType = CommandType.StoredProcedure;
                /*
                cm.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
                cm.Parameters["@Id"].Value = txtId.Text;
                */
                cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                cm.Parameters["@Nombre"].Value = txtNombre.Text;

                cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
                cm.Parameters["@Apellido"].Value = txtApellido.Text;

                cm.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
                cm.Parameters["@Direccion"].Value = txtdireccion.Text;

                cm.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
                cm.Parameters["@Telefono"].Value = txttelefono.Text;

                cm.Parameters.Add(new SqlParameter("@Fecha_de_Ingreso", SqlDbType.VarChar));
                cm.Parameters["@Fecha_de_Ingreso"].Value = DateTime.Parse(txtfechadeingreso.Text).ToString("dd/M/yyyy");
                
                cm.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
                
                cm.Parameters["@Puesto_Ocupado"].Value = txtpuestoocupado.Text;

                cm.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
                cm.Parameters["@Departamento"].Value = txtdeparmento.Text;

                cm.Parameters.Add(new SqlParameter("@CEDULA", SqlDbType.VarChar));
                cm.Parameters["@CEDULA"].Value = txtdni.Text;

                cm.Parameters.Add(new SqlParameter("@Salario_Base", SqlDbType.VarChar));
                cm.Parameters["@Salario_Base"].Value = txtsalariobase.Text;

                cm.Parameters.Add(new SqlParameter("@Tipo_de_Cobro", SqlDbType.VarChar));
                cm.Parameters["@Tipo_de_Cobro"].Value = txttipodecobro.Text;

                cm.Parameters.Add(new SqlParameter("@Turno", SqlDbType.VarChar));
                cm.Parameters["@Turno"].Value = txtturno.Text;

                cn.Open();
                cm.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado Satisfactoriamente");

                /*
                btnNuevo.Enabled = true;
                btnRegistrar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = true;
                btnEliminar.Enabled = true;
                btnBuscar.Enabled = true;
                txtbusqueda.Enabled = true;
                */
                cn.Close();
            }
        }catch(Exception ex)
            {
                ShowError("No se pudo hacer el registro porque: ", ex); 
            }


}
        public void ShowError(string message , Exception ex)
        {
            MessageBox.Show($"{message}\n{ex}", "Algo Salio mal!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void Limpiar()
        {
            txtId.ResetText();
            txtNombre.Clear();
            txtApellido.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtfechadeingreso.ResetText();
            txtpuestoocupado.ResetText();
            txtdeparmento.ResetText();
            txtdni.Clear();
            txtsalariobase.Clear();
            txttipodecobro.ResetText();
            //txtturno.Clear();
        }

        private void MantenimientoDeEmpleados_Load(object sender, EventArgs e)
        {
            LLenarGridEmpleados();
            // TODO: This line of code loads data into the 'empleadosDataSet.Empleados' table. You can move, or remove it, as needed.
            //this.empleadosTableAdapter.Fill(this.empleadosDataSet.Empleados);
            //
            // TODO: This line of code loads data into the 'manSysDBDataSet.GetDB_Mantenimiento_de_Empleados' table. You can move, or remove it, as needed.
            //this.getDB_Mantenimiento_de_EmpleadosTableAdapter.Fill(this.manSysDBDataSet.GetDB_Mantenimiento_de_Empleados);
            /*
           LLenarGridEmpleados();

           btnNuevo.Enabled = true;
           btnRegistrar.Enabled = false;
           btnModificar.Enabled = false;
           btnCancelar.Enabled = true;
           btnEliminar.Enabled = true;
           btnBuscar.Enabled = true;
           txtbusqueda.Enabled = true;
           */

        }

        private void LLenarGridEmpleados()
        {
            //Codigo para llenar grid de empleados


            DataTable dtempleados = new DataTable();

            SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString);

            SqlDataAdapter daempleados = new SqlDataAdapter("GetDB_Mantenimiento_de_Empleados", dataConnection);

            daempleados.SelectCommand.CommandType = CommandType.StoredProcedure;

            daempleados.Fill(dtempleados);
            ListadodeEmpleados.DataSource = dtempleados;
            //ListadodeEmpleados.Update();
            //ListadodeEmpleados.DataSource = daempleados;
            //ListadodeEmpleados.Refresh(); 
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Cargo el estado para el botón Nuevo y los demás elementos.
            btnNuevo.Enabled = false;
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
            nuevo = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Mantenimiento_de_Empleados WHERE Id=" + txtId.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro Eliminado Correctamente !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
        }


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtfechadeingreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM dbo.Empleados WHERE {CriterioDeBusqueda.Text} = {txtbusqueda.Text}";

            //try
            //{
            //if (reader.Read())
            //{
            /*
            btnNuevo.Enabled = false;
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
            txtNombre.Focus();
            */
            using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
            {
                connection.Open(); 
               using(SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    string text = null;
                    foreach (var item in reader)
                    {
                        text += $"{item.ToString()}\n"; 
                    }
                    Writer.Write("request.txt", text);

                    /*
                    txtId.Text = reader[0].ToString();
                    txtNombre.Text = reader[1].ToString();
                    txtApellido.Text = reader[2].ToString();
                    txtdireccion.Text = reader[3].ToString();
                    txttelefono.Text = reader[4].ToString();
                    txtfechadeingreso.Text = reader[5].ToString();
                    txtpuestoocupado.Text = reader[6].ToString();
                    txtdeparmento.Text = reader[7].ToString();
                    txtdni.Text = reader[8].ToString();
                    txtsalariobase.Text = reader[9].ToString();
                    txttipodecobro.Text = reader[10].ToString();
                    txtturno.Text = reader[11].ToString();
                    */
                    //nuevo = false;
                }
            }
                //}
                //else
                //    MessageBox.Show("Ningun Registro Encontrado con el Dato de Busqueda Ingresado !");

            //    }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.ToString());
            //}
          

            //txtbusqueda.Text = "";

            }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        
            /*
            SqlConnection cn = new SqlConnection(Connection.ConnectionString);
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;

            cm.CommandText = "SP_Update_Mantenimiento_de_Empleados";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cm.Parameters["@Nombre"].Value = txtNombre.Text;

            cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
            cm.Parameters["@Apellido"].Value = txtApellido.Text;

            cm.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
            cm.Parameters["@Direccion"].Value = txtdireccion.Text;

            cm.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
            cm.Parameters["@Telefono"].Value = txttelefono.Text;

            cm.Parameters.Add(new SqlParameter("@Fecha_de_Ingreso", SqlDbType.VarChar));
            cm.Parameters["@Fecha_de_Ingreso"].Value = txtfechadeingreso.Text;

            cm.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
            cm.Parameters["@Puesto_Ocupado"].Value = txtpuestoocupado.Text;

            cm.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
            cm.Parameters["@Departamento"].Value = txtdeparmento.Text;

            cm.Parameters.Add(new SqlParameter("@CEDULA", SqlDbType.VarChar));
            cm.Parameters["@CEDULA"].Value = txtdni.Text;

            cm.Parameters.Add(new SqlParameter("@Salario_Base", SqlDbType.VarChar));
            cm.Parameters["@Salario_Base"].Value = txtsalariobase.Text;

            cm.Parameters.Add(new SqlParameter("@Tipo_de_Cobro", SqlDbType.VarChar));
            cm.Parameters["@Tipo_de_Cobro"].Value = txttipodecobro.Text;

            cm.Parameters.Add(new SqlParameter("@Turno", SqlDbType.VarChar));
            cm.Parameters["@Turno"].Value = txtturno.Text;



            cn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Actualizado Satisfactoriamente");
            LLenarGridEmpleados();
            cn.Close();

            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;
            txtbusqueda.Enabled = true;
            */
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LLenarGridEmpleados();
        }

        private void bntlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void MantenimientoDeEmpleados_MouseDown(object sender, MouseEventArgs e)
        {

           
        }

        private void gblistadovisitas_Enter(object sender, EventArgs e)
        {

        }
        private void ListadodeEmpleados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ListadodeEmpleados.EndEdit();
                ListadodeEmpleados.Update();
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Actualizado Correctamente");
            }catch(Exception ex)
            {
                ShowError("No se pudo actualizar el registro por que: ", ex);
            }
        }
    }
    }

