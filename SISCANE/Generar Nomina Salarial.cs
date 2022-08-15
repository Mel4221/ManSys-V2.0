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


namespace SISCANE
{
    public partial class Form2 : Form
    {
        string connectionString = @"Server=DESKTOP-802OK33;Database=SISCANE;Trusted_Connection=True;";
        public Form2()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
int wparam, int lparam);

        private void Form2_Load(object sender, EventArgs e)
        {
            LLenarGridNomina();
        }

        private void LLenarGridNomina()
        {
            //Codigo para llenar grid de empleados


            DataTable dtempleados = new DataTable();

            SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = dataConnection;

            SqlDataAdapter daempleados = new SqlDataAdapter("GetDB_Mantenimiento_de_Nomina", dataConnection);

            daempleados.SelectCommand.CommandType = CommandType.StoredProcedure;


            ListadodeNominaRegistrada.DataSource = dtempleados;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void bntbuscar_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bntlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtdni.Clear();
            txtsalariobase.Clear();
            txtdepartamento.ResetText();
            txtpuesto.ResetText();
            txtturno.Clear();
            txttipodecobro.ResetText();
            txtfechadepagoinicio.ResetText();
            txtfechadepagocierre.ResetText();
            txthorasn.Clear();
            txtpreciohn.ResetText();
            txthorase.Clear();
            txtpreciohe.ResetText();
            txtmontohn.ResetText();
            txtmontohe.ResetText();
            txtmontoapagar.ResetText();
            txttotalasig.ResetText();
            txtdescuentoars.ResetText();
            txtdescuentoafp.ResetText();
            txtsueldoneto.ResetText();
           

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadodeNominaRegistrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Codigo"].Value.ToString();
            txtnombre.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Nombre"].Value.ToString();
            txtapellido.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Apellido"].Value.ToString();
            txtdni.Text = ListadodeNominaRegistrada.CurrentRow.Cells["DNI"].Value.ToString();
            txtsalariobase.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Salario_Base"].Value.ToString();
            txtpuesto.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Puesto_Ocupado"].Value.ToString();
            txtdepartamento.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Departamento"].Value.ToString();
            txtturno.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Turno"].Value.ToString();
            txttipodecobro.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Tipo_de_Cobro"].Value.ToString();
            txtturno.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Turno"].Value.ToString();
            txthorasn.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Horas_Normales_Trabajadas"].Value.ToString();
            txtpreciohn.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Precio_Horas_Normales"].Value.ToString();
            txthorase.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Horas_Extra_Trabajadas"].Value.ToString();
            txtpreciohe.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Precio_Horas_Extra"].Value.ToString();
            txtmontohn.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Monto_Por_Horas_Normales"].Value.ToString();
            txtmontohe.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Monto_Por_Horas_Extra"].Value.ToString();
            txtmontoapagar.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Monto_Total_a_Pagar"].Value.ToString();
            txttotalasig.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Total_de_Asignaciones"].Value.ToString();
            txtdescuentoars.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Seguro_Médico_ARS"].Value.ToString();
            txtdescuentoafp.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Seguro_de_Pensión_AFP"].Value.ToString();
            txtsueldoneto.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Sueldo_Neto"].Value.ToString();

        }


        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LLenarGridNomina();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Cargo el estado para el botón Nuevo y los demás elementos.
            btnNuevo.Enabled = false;
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            bntbuscar.Enabled = true;
            Limpiar();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            bntbuscar.Enabled = true;
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
             string sql = "DELETE FROM Mantenimiento_de_Nomina WHERE Id=" + txtcodigo.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (1 > 0)
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
            bntbuscar.Enabled = true;
            Limpiar();
        }

        private void bntbuscar_Click_1(object sender, EventArgs e)
        {
            {
                string sql = "SELECT * FROM Mantenimiento_de_Nomina WHERE Id=" + txtcodigo.Text;

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader;
                con.Open();
                try
                {
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        btnNuevo.Enabled = false;
                        btnRegistrar.Enabled = true;
                        btnModificar.Enabled = true;
                        btnCancelar.Enabled = true;
                        btnEliminar.Enabled = true;
                        bntbuscar.Enabled = true;
                        txtnombre.Focus();
                        txtcodigo.Text = reader[0].ToString();
                        txtnombre.Text = reader[1].ToString();
                        txtapellido.Text = reader[2].ToString();
                        txtdni.Text = reader[3].ToString();
                        txtsalariobase.Text = reader[4].ToString();
                        txtpuesto.Text = reader[5].ToString();
                        txtdepartamento.Text = reader[6].ToString();
                        txtturno.Text = reader[7].ToString();
                        txttipodecobro.Text = reader[8].ToString();
                        txthorasn.Text = reader[10].ToString();
                        txtpreciohn.Text = reader[11].ToString();
                        txthorase.Text = reader[12].ToString();
                        txtpreciohe.Text = reader[11].ToString();
                        txtmontohn.Text = reader[13].ToString();
                        txtmontohe.Text = reader[14].ToString();
                        txtmontoapagar.Text = reader[15].ToString();
                        txttotalasig.Text = reader[16].ToString();
                        txtdescuentoars.Text = reader[17].ToString();
                        txtdescuentoafp.Text = reader[18].ToString();
                        txtsueldoneto.Text = reader[19].ToString();

                    }
                    else
                        MessageBox.Show("Ningun Registro Encontrado con el Dato de Busqueda Ingresado !");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }


            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "SP_Insert_Mantenimiento_de_Nomina";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            cm.Parameters["@Id"].Value = txtcodigo.Text;

            cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cm.Parameters["@Nombre"].Value = txtnombre.Text;

            cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
            cm.Parameters["@Apellido"].Value = txtapellido.Text;

            cm.Parameters.Add(new SqlParameter("@DNI", SqlDbType.VarChar));
            cm.Parameters["@DNI"].Value = txtdni.Text;

            cm.Parameters.Add(new SqlParameter("@Salario_Base", SqlDbType.VarChar));
            cm.Parameters["@Salario_Base"].Value = txtsalariobase.Text;

            cm.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
            cm.Parameters["@Puesto_Ocupado"].Value = txtpuesto.Text;

            cm.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
            cm.Parameters["@Departamento"].Value = txtdepartamento.Text;

            cm.Parameters.Add(new SqlParameter("@Turno", SqlDbType.VarChar));
            cm.Parameters["@Turno"].Value = txtturno.Text;

            cm.Parameters.Add(new SqlParameter("@Tipo_de_Cobro", SqlDbType.VarChar));
            cm.Parameters["@Tipo_de_Cobro"].Value = txttipodecobro.Text;

            cm.Parameters.Add(new SqlParameter("@Fecha_de_Pago", SqlDbType.VarChar));
            cm.Parameters["@Fecha_de_Pago"].Value = txttipodecobro.Text;

            cm.Parameters.Add(new SqlParameter("@Horas_Normales_Trabajadas", SqlDbType.Int));
            cm.Parameters["@Horas_Normales_Trabajadas"].Value = txthorasn.Text;

            cm.Parameters.Add(new SqlParameter("@Precio_Horas_Normales", SqlDbType.Money));
            cm.Parameters["@Precio_Horas_Normales"].Value = txtpreciohn.Text;

            cm.Parameters.Add(new SqlParameter("@Horas_Extra_Trabajadas", SqlDbType.Int));
            cm.Parameters["@Horas_Extra_Trabajadas"].Value = txthorase.Text;

            cm.Parameters.Add(new SqlParameter("@Precio_Horas_Extra", SqlDbType.Money));
            cm.Parameters["@Precio_Horas_Extra"].Value = txtpreciohe.Text;

            cm.Parameters.Add(new SqlParameter("@Monto_Por_Horas_Normales", SqlDbType.Money));
            cm.Parameters["@Monto_Por_Horas_Normales"].Value = txtmontohn.Text;

            cm.Parameters.Add(new SqlParameter("@Monto_Por_Horas_Extra", SqlDbType.Money));
            cm.Parameters["@Monto_Por_Horas_Extra"].Value = txtmontohe.Text;

            cm.Parameters.Add(new SqlParameter("@Monto_Total_a_Pagar", SqlDbType.Money));
            cm.Parameters["@Monto_Total_a_Pagar"].Value = txtmontoapagar.Text;

            cm.Parameters.Add(new SqlParameter("@Total_de_Asignaciones", SqlDbType.Money));
            cm.Parameters["@Total_de_Asignaciones"].Value = txttotalasig.Text;

            cm.Parameters.Add(new SqlParameter("@Seguro_Médico_ARS", SqlDbType.Money));
            cm.Parameters["@Seguro_Médico_ARS"].Value = txtdescuentoars.Text;

            cm.Parameters.Add(new SqlParameter("@Seguro_de_Pensión_AFP", SqlDbType.Money));
            cm.Parameters["@Seguro_de_Pensión_AFP"].Value = txtdescuentoafp.Text;

            cm.Parameters.Add(new SqlParameter("@Sueldo_Neto", SqlDbType.Money));
            cm.Parameters["@Sueldo_Neto"].Value = txtsueldoneto.Text;

            cn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Guardado Satisfactoriamente");


            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            bntbuscar.Enabled = true;
            Limpiar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "SP_Update_Mantenimiento_de_Nomina";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            cm.Parameters["@Id"].Value = txtcodigo.Text;

            cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cm.Parameters["@Nombre"].Value = txtnombre.Text;

            cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
            cm.Parameters["@Apellido"].Value = txtapellido.Text;

            cm.Parameters.Add(new SqlParameter("@DNI", SqlDbType.VarChar));
            cm.Parameters["@DNI"].Value = txtdni.Text;

            cm.Parameters.Add(new SqlParameter("@Salario_Base", SqlDbType.VarChar));
            cm.Parameters["@Salario_Base"].Value = txtsalariobase.Text;

            cm.Parameters.Add(new SqlParameter("@Puesto_Ocupado", SqlDbType.VarChar));
            cm.Parameters["@Puesto_Ocupado"].Value = txtpuesto.Text;

            cm.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
            cm.Parameters["@Departamento"].Value = txtdepartamento.Text;

            cm.Parameters.Add(new SqlParameter("@Turno", SqlDbType.VarChar));
            cm.Parameters["@Turno"].Value = txtturno.Text;

            cm.Parameters.Add(new SqlParameter("@Tipo_de_Cobro", SqlDbType.VarChar));
            cm.Parameters["@Tipo_de_Cobro"].Value = txttipodecobro.Text;

            cm.Parameters.Add(new SqlParameter("@Fecha_de_Pago", SqlDbType.VarChar));
            cm.Parameters["@Fecha_de_Pago"].Value = txttipodecobro.Text;

            cm.Parameters.Add(new SqlParameter("@Horas_Normales_Trabajadas", SqlDbType.Int));
            cm.Parameters["@Horas_Normales_Trabajadas"].Value = txthorasn.Text;

            cm.Parameters.Add(new SqlParameter("@Precio_Horas_Normales", SqlDbType.Money));
            cm.Parameters["@Precio_Horas_Normales"].Value = txtpreciohn.Text;

            cm.Parameters.Add(new SqlParameter("@Horas_Extra_Trabajadas", SqlDbType.Int));
            cm.Parameters["@Horas_Extra_Trabajadas"].Value = txthorase.Text;

            cm.Parameters.Add(new SqlParameter("@Precio_Horas_Extra", SqlDbType.Money));
            cm.Parameters["@Precio_Horas_Extra"].Value = txtpreciohe.Text;

            cm.Parameters.Add(new SqlParameter("@Monto_Por_Horas_Normales", SqlDbType.Money));
            cm.Parameters["@Monto_Por_Horas_Normales"].Value = txtmontohn.Text;

            cm.Parameters.Add(new SqlParameter("@Monto_Por_Horas_Extra", SqlDbType.Money));
            cm.Parameters["@Monto_Por_Horas_Extra"].Value = txtmontohe.Text;

            cm.Parameters.Add(new SqlParameter("@Monto_Total_a_Pagar", SqlDbType.Money));
            cm.Parameters["@Monto_Total_a_Pagar"].Value = txtmontoapagar.Text;

            cm.Parameters.Add(new SqlParameter("@Total_de_Asignaciones", SqlDbType.Money));
            cm.Parameters["@Total_de_Asignaciones"].Value = txttotalasig.Text;

            cm.Parameters.Add(new SqlParameter("@Seguro_Médico_ARS", SqlDbType.Money));
            cm.Parameters["@Seguro_Médico_ARS"].Value = txtdescuentoars.Text;

            cm.Parameters.Add(new SqlParameter("@Seguro_de_Pensión_AFP", SqlDbType.Money));
            cm.Parameters["@Seguro_de_Pensión_AFP"].Value = txtdescuentoafp.Text;

            cm.Parameters.Add(new SqlParameter("@Sueldo_Neto", SqlDbType.Money));
            cm.Parameters["@Sueldo_Neto"].Value = txtsueldoneto.Text;

            cn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Guardado Satisfactoriamente");


            btnNuevo.Enabled = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            bntbuscar.Enabled = true;
            Limpiar();

        }
        private void horasnormales()
            {
            txthorasn.Text.Trim();
            }
        private void preciohorasnormales()
        {
            txtpreciohn.Text.Trim();
        }

        private void txtmontohn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
