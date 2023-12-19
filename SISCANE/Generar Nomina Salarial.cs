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
using ManSysDbBuilder.Data;
using QuickTools.QData; 

namespace ManSys
{
    public partial class GenerarNomina : Form
    {
        public GenerarNomina()
        {
            InitializeComponent();
        }

 

        private void GenerarNomina_Load(object sender, EventArgs e)
        {
            this.CargarDatos(); 
        }
        public void CargarDatos()
        {
            this.LLenarGridNomina();
            this.ActualizarPagoPorHoraNormales();
            this.ActualizarPagoPorHoraExtra();
            this.ActualizarSalarioNeto();
            this.ActualizarDiasTrabajados();
            this.ActualizarDescuentos();
            this.ActualizarMontoTotal();
            this.CargarEmpleados();
            this.CargarDeducciones();
            this.CargarImpuestos();
            this.CargarBonificaiones();
            this.CargarNominas();

			this.InicioDeNomina.Value = DateTime.Today;
            this.CierreDeNomina.Value = DateTime.Today;
         }
        private void ActualizarMontoTotal()
        {   
            //double neto, descuento, total;
            //neto = double.Parse(SueldoNeto.Text);
            //descuento = double.Parse(Descuentos.Text);
            //total =  neto - descuento;
            //PagoTotal.Text = total.ToString();
        }
        private void ActualizarDescuentos()
        {
            //double ars, afp, descuento, pago;  
            //ars = double.Parse(DescuentoArs.Text);
            //afp = double.Parse(DescuentoAfp.Text);
            //pago = double.Parse(SueldoNeto.Text);
            //descuento = (((ars+afp) / 100) * pago);
            //Descuentos.Text = $"{descuento}"; 
        }
        private bool ValidarDatos()
        {
            //if (!Get.IsNumber(txthorasn.Text))
            //{
            //    return false;
            //}
            //if (!Get.IsNumber(txthorase.Text))
            //{
            //    return false;
            //}
            //if (!Get.IsNumber(PrecioHoraNormal.Text))
            //{
            //    return false;
            //}
            //if (!Get.IsNumber(PrecioHoraExtra.Text))
            //{
            //    return false;
            //}
            return true; 
        }
        private void ActualizarDiasTrabajados()
        {
            if (!ValidarDatos())
            {
                MessageBox.Show("Ahi Datos incorrectos en los formularios numericos");
                return; 
            }
            
            //string dia = $"{DateTime.Parse(InicioDeNomina.Text).ToString("dd")} {DateTime.Parse(CierreDeNomina.Text).ToString("dd")}";

   //         this.DiasTrabajadosBox.Text = (int.Parse((CierreDeNomina.Value-InicioDeNomina.Value).Days.ToString())+1).ToString();
            this.PeridoDeNomina.Text = InicioDeNomina.Value.ToString("dd/MM/yyyy")+"-"+CierreDeNomina.Value.ToString("dd/MM/yyyy"); 
			////for(int d = inicio; d < final; d++)
			//{
			//    dias++; 
			//}
			//SueldoNeto.Text = $"{dias * int.Parse(SueldoNeto.Text)}"; 
			//MessageBox.Show($"{dias}"); 
			// 5 6 7 8 9
			// 1 2 3 4 5

		}
		private void ActualizarSalarioNeto()
        {
            if (!ValidarDatos())
            {
                MessageBox.Show("Ahi Datos incorrectos en los formularios numericos");
                return;
            }
            //horas trabajadas * pago de hora + horas extras * horas trabajadas extra
            //int pago = (int.Parse(txthorasn.Text) * int.Parse(PrecioHoraNormal.Text)) + (int.Parse(txthorase.Text) * int.Parse(PrecioHoraExtra.Text));
            //SueldoNeto.Text = $"{pago}"; 
        }
        private void LLenarGridNomina()
        {
            //Codigo para llenar grid de empleados
            /*

            DataTable dtempleados = new DataTable();

            SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = dataConnection;

            SqlDataAdapter daempleados = new SqlDataAdapter("GetDB_Mantenimiento_de_Nomina", dataConnection);

            daempleados.SelectCommand.CommandType = CommandType.StoredProcedure;


            ListadodeNominaRegistrada.DataSource = dtempleados;
            */
        }

 

        private void bntlimpiar_Click(object sender, EventArgs e)
        {
            Console.Clear();
			Limpiar();
		}
        private void Limpiar()
        {
            //txtcodigo.Clear();
            //txtnombre.Clear();
            //txtapellido.Clear();
            //txtdni.Clear();
            //txtsalariobase.Clear();
            //txtdepartamento.ResetText();
            //txtpuesto.ResetText();
            //txtturno.Clear();
            //txttipodecobro.ResetText();
            //txtfechadepagoinicio.ResetText();
            //txtfechadepagocierre.ResetText();
            //txthorasn.Clear();
            //txtpreciohn.ResetText();
            //txthorase.Clear();
            //txtpreciohe.ResetText();
            //txtmontohn.ResetText();
            //txtmontohe.ResetText();
            //txtmontoapagar.ResetText();
            //txttotalasig.ResetText();
            //txtdescuentoars.ResetText();
            //txtdescuentoafp.ResetText();
            //txtsueldoneto.ResetText();
           

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadodeNominaRegistrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            txtcodigo.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Codigo"].Value.ToString();
            txtnombre.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Nombre"].Value.ToString();
            txtapellido.Text = ListadodeNominaRegistrada.CurrentRow.Cells["Apellido"].Value.ToString();
            txtdni.Text = ListadodeNominaRegistrada.CurrentRow.Cells["CEDULA"].Value.ToString();
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
            */
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
            //btnNuevo.Enabled = false;
            //btnRegistrar.Enabled = true;
            //btnModificar.Enabled = true;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = true;
            //bntbuscar.Enabled = true;
            //Limpiar();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //btnNuevo.Enabled = true;
            //btnRegistrar.Enabled = false;
            //btnModificar.Enabled = false;
            //btnCancelar.Enabled = true;
            //btnEliminar.Enabled = true;
            //bntbuscar.Enabled = true;
            //Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show($"Esta seguro que quiere Eliminar el Periodo de Nomina: {PeridoDeNomina.Text}","Alerta",MessageBoxButtons.YesNo)  != DialogResult.Yes) return;
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"DELETE FROM dbo.Nomina WHERE Periodo = '{PeridoDeNomina.Text}'", con);
                    cmd.ExecuteNonQuery();
                    this.CargarNominas();
                }
            }catch(Exception ex)
            {
                ShowError($"Hubo un error al tratar de elminar El periodo de Nomina {PeridoDeNomina.Text}", ex); 
            }
            /*
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
            */
        }

        private void bntbuscar_Click_1(object sender, EventArgs e)
        {
            /*
            
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
            */


            
        }

        internal DataTable _Empleados { get; set; }  
        private DataTable _Deducciones { get; set; }
        private DataTable _Impuestos { get; set; } 
        private DataTable _Bonificaciones { get; set; }
        public List<Key> BonosPersonales { get; set; } = new List<Key>();
		public List<Key> DescuentosPersonales{ get; set; } = new List<Key>();


		private void CargarBonificaiones()
        {
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
					_Bonificaciones  = new DataTable();
					SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Bonificaciones ", con);
					adapter.Fill(_Bonificaciones);

				}
			}
			catch (Exception ex) { ShowError("Hubo un error al tratar de cargar las Bonificaciones", ex); }
		}
        private void CargarImpuestos()
        {
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
                    _Impuestos   = new DataTable();
					SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Impuestos ", con);
					adapter.Fill(_Impuestos);

				}
			}
			catch (Exception ex) { ShowError("Hubo un error al tratar de cargar los Impuestos", ex); }
		}
        private void CargarDeducciones()
        {
			try
			{
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
                    _Deducciones = new DataTable();
 					SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Deducciones ", con);
					adapter.Fill(_Deducciones);

				}
			}
			catch (Exception ex) { ShowError("Hubo un error al tratar de cargar las Deducciones", ex); }
		}
        private void CargarEmpleados()
        {
			//mantenimientoDeducciones
			try
			{
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    con.Open();
                    _Empleados = new DataTable(); 
                     SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Empleados ", con);
                    adapter.Fill(_Empleados);

                }
            }catch(Exception ex){ ShowError("Hubo un error al tratar de cargar los Empleados", ex); }
		}


		public void ShowError(string message, Exception ex) => MessageBox.Show($"{message}\n{ex}", "Algo Salio mal!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public float ConseguirSueldoNetoPorDia(int empleadoId)
        {
            try {
				string empleado = empleadoId.ToString();

				foreach (DataRow row in this._Empleados.Rows)
                {
                    if(row["Id"].ToString() == empleado)
                    {
                        float hora = (float.Parse(row["Salario_Base"].ToString())/30/8);
						//Divide el sueldo que cobra mensual por los dias y horas que trabaja 
						if (row["Turno"].ToString() == "Rotativo" || row["Turno"].ToString() == "Nocturno")
                        {
						    return	hora+(float.Parse(HorasNocturnasPorcentage.Text) * hora / 100);
						}
                        return hora;   
                    }
                }
                    return 0; 
            }catch(Exception ex){
                    this.ShowError("Hubo un error al Tratar de Conseguir el sueldo del Empleado",ex);
                    return 0; 
            }
        }

        public float ToPorcent(string empleado,string porcentage)
        {
            float porcent, sueldo;
            sueldo = this.ConseguirSueldoNetoPorDia(int.Parse(empleado))*8*30;//Sueldo Mensual del Empleado
            porcent = float.Parse(porcentage.Replace("%", "")) * sueldo / 100; 
			return porcent; 
        }
        public float ConseguirTotalDeDescuento(int empleadoId)
        {
        
            float total = 0;
            string empleado, cantidad;
            empleado = empleadoId.ToString();
            this.DescuentosPersonales = new List<Key>(); 

            foreach(DataRow row in this._Deducciones.Rows)
            {
                cantidad = row["Cantidad"].ToString();
                
                if (cantidad.Contains("%"))
                {
                    cantidad = this.ToPorcent(empleado, cantidad).ToString();
                }

                if(row["Applicacion"].ToString() == empleado)
                {
                     
					total += float.Parse(cantidad);
                    this.DescuentosPersonales.Add(new Key()
                    {
                        Name = row["Nombre"].ToString(),
                        Value = cantidad
                    });  ; 
                    
				}
				if (row["Applicacion"].ToString() != empleado && row["Applicacion"].ToString() == "A Todos")
				{
					total += float.Parse(cantidad);
					this.DescuentosPersonales.Add(new Key()
					{
						Name = row["Nombre"].ToString(),
						Value = cantidad
					}); ;
				}
			}
			return total; 
        }
        private class Jornada
        {
            public int EmpleadoId{ get; set; }
            public string Empleado { get; set; }
            public string Fecha { get; set; }   
            public string Entrada { get; set; }
            public string Salida { get; set; }
            public float HorasTrabajadas { get; set; }
            public float HorasExtras { get; set; }
			public override string ToString()
			{
                return $"EmpleadoId: [{EmpleadoId}]\n Empleado: [{Empleado}]\n Fecha: [{Fecha}]\n Entrada: [{Entrada}]\n Salida: [{Salida}]\n Horas: [{HorasTrabajadas}]\n Horas Extras: [{HorasExtras}]\n";
			}

		}
		
		 List<Jornada> Jornadas { get; set; }
        private void ActualizaHoras(int empleado,float horas,string ultimaFecha,float horasExtras)
        {
            Get.Red($"Actualizando Horas: Empleado [{empleado}] Horas [{horas}] Fecha [{ultimaFecha}]");
           for(int i = 0; i<this.Jornadas.Count; i++)
           {
                if(this.Jornadas[i].EmpleadoId == empleado)
                {
                    this.Jornadas[i].HorasTrabajadas += horas;
                    this.Jornadas[i].Fecha = ultimaFecha;
                    this.Jornadas[i].HorasExtras += horasExtras; 
				}
           }
        }
		private bool InRange(DateTime dateToCheck, DateTime startDate, DateTime endDate) => dateToCheck >= startDate && dateToCheck <= endDate;
		
		private bool ExisteEmpleadoEnJornada(int empleado)
        {
            foreach(Jornada jornada in Jornadas) 
            {
                if(jornada.EmpleadoId == empleado)
                {
                    return true; 
                }
            }
            return false; 
        }
        public float ConseguirTotalDeBonificaciones(int empleadoId,string fecha)
        {
            float total = 0;
             try{
                this.BonosPersonales = new List<Key>(); 
                    foreach(DataRow row in this._Bonificaciones.Rows)
                    {
                        if(row["EmpleadoId"].ToString() == empleadoId.ToString() && fecha == row["Fecha_de_Applicacion"].ToString())
                        {
                            total += float.Parse(row["Monto"].ToString());
                        this.BonosPersonales.Add(new Key()
                        {
                            Name = row["Tipo_de_Bonificacion"].ToString(),
                            Value = row["Monto"].ToString()
                        });
                        }
                    }

                return total;
             }catch(Exception ex)
             {
                ShowError($"Hubo un errror al tratar de conseguir las bonfificaciones personales de El EmpleadoId {empleadoId}", ex);
                return total;
             }
        }
        private void RegistrarNominaAuto()
        {

            //MessageBox.Show(ConseguirSueldoNeto(1000.ToString()).ToString());
            this.Jornadas = new List<Jornada>(); 
			DataTable table = new DataTable();
            DataTable filtro = new DataTable();
			filtro.Columns.Add("EmpleadoId", typeof(int));
			filtro.Columns.Add("Empleado", typeof(string));
			filtro.Columns.Add("Fecha", typeof(string));
			filtro.Columns.Add("Entrada", typeof(string));
			filtro.Columns.Add("Salida", typeof(string));
			filtro.Columns.Add("HorasTrabajadas", typeof(float));


			using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Gestion_de_Jornada ", con);
                adapter.Fill(table);

                foreach(DataRow row in  table.Rows) 
                {
                         if (this.InRange(DateTime.ParseExact(row["Fecha"].ToString(), "dd/MM/yyyy", null), this.InicioDeNomina.Value, this.CierreDeNomina.Value))
						
                    {
                        DataRow r = filtro.NewRow();

                        r["EmpleadoId"] = row["EmpleadoId"];
                        r["Empleado"] = row["Empleado"];
                        r["Fecha"] = row["Fecha"];
                        r["Entrada"] = row["Entrada"];
                        r["Salida"] = row["Salida"];
                        r["HorasTrabajadas"] = row["HorasTrabajadas"];
                        filtro.Rows.Add(r);
                    }
				}


				foreach (DataRow row in filtro.Rows)
                {
					if (this.ExisteEmpleadoEnJornada(int.Parse(row["EmpleadoId"].ToString())))
					{

						this.ActualizaHoras(int.Parse(row["EmpleadoId"].ToString()), float.Parse(row["HorasTrabajadas"].ToString()), row["Fecha"].ToString(), float.Parse(row["HorasTrabajadas"].ToString())-8<=0 ? 0 : float.Parse(row["HorasTrabajadas"].ToString())-8);

					}

					if (!this.ExisteEmpleadoEnJornada(int.Parse(row["EmpleadoId"].ToString())))
                   {
                        Get.Blue($"Agregando: {row["EmpleadoId"]}");
                        this.Jornadas.Add(new Jornada()
                        {
                            EmpleadoId = int.Parse(row["EmpleadoId"].ToString()),
                            Empleado = row["Empleado"].ToString(),
                            Fecha = row["Fecha"].ToString(),
                            Entrada = row["Entrada"].ToString(),
                            Salida = row["Salida"].ToString(),
                            HorasTrabajadas = float.Parse(row["HorasTrabajadas"].ToString()),
                            HorasExtras = float.Parse(row["HorasTrabajadas"].ToString())-8<=0 ? 0 : float.Parse(row["HorasTrabajadas"].ToString())-8

						}) ;
                   }
				
                    //Get.Ok();
				}
                this.Jornadas.ForEach(item => Get.Yellow(item.ToString()));
               // return;
            }
            using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
            {
                con.Open();
                float descuento, sueldo, total, sueldoHora, horas, horaExtra, totalExtras, bonos;
                sueldo = 0;
                total = 0;
                sueldoHora = 0; 
                
				foreach (Jornada row in this.Jornadas)
				{
                    descuento = this.ConseguirTotalDeDescuento(row.EmpleadoId);

                    bonos = this.ConseguirTotalDeBonificaciones(row.EmpleadoId, this.CierreDeNomina.Value.ToString("dd/MM/yyyy"));

                    sueldoHora = this.ConseguirSueldoNetoPorDia(row.EmpleadoId);
                    
                    horas = row.HorasExtras == 0 ? row.HorasTrabajadas : row.HorasTrabajadas - row.HorasExtras;
                    
                    horaExtra = row.HorasExtras/*horas-8<=0 ? 0 : horas-8*/ ;
                    //pagale las horas extras al 15% si las horas extras no son igual a cero
                    totalExtras =  horaExtra!=0?((sueldoHora * float.Parse(this.HorasExtrasPorcentage.Text) / 100)+sueldoHora)*horaExtra:0;/*horaExtra==0 ? 0 : horaExtra*sueldoHora+(sueldoHora*15/100);*/

                    sueldo = (horas * sueldoHora)+totalExtras+bonos;
                    total =  sueldo - descuento  ;

					SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Nomina(Periodo,EmpleadoId,Salario_Base,Horas_Trabajadas,Horas_Extras,Ingreso,Descuento,Total_Ingreso) values(@Periodo,@EmpleadoId,@Salario_Base,@Horas_Trabajadas,@Horas_Extras,@Ingreso,@Descuento,@Total_Ingreso)", con);

					cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar));
                    cmd.Parameters["@Periodo"].Value = this.PeridoDeNomina.Text;
                   
					cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
                    cmd.Parameters["@EmpleadoId"].Value = row.EmpleadoId;

					cmd.Parameters.Add(new SqlParameter("@Salario_Base", SqlDbType.Float));
                    cmd.Parameters["@Salario_Base"].Value = sueldoHora; 

					cmd.Parameters.Add(new SqlParameter("@Horas_Trabajadas", SqlDbType.Float));
                    cmd.Parameters["@Horas_Trabajadas"].Value = row.HorasTrabajadas; 

					cmd.Parameters.Add(new SqlParameter("@Horas_Extras", SqlDbType.Float));
                    cmd.Parameters["@Horas_Extras"].Value = horaExtra; 

					cmd.Parameters.Add(new SqlParameter("@Ingreso", SqlDbType.Float));
                    cmd.Parameters["@Ingreso"].Value = sueldo;

					cmd.Parameters.Add(new SqlParameter("@Descuento", SqlDbType.Float));
					cmd.Parameters["@Descuento"].Value = descuento;

					cmd.Parameters.Add(new SqlParameter("@Total_Ingreso", SqlDbType.Float));
                    cmd.Parameters["@Total_Ingreso"].Value =total-this.ConseguirTotalDeImpuestos(total);

					cmd.ExecuteNonQuery();
					Get.Pink($"{this.PeridoDeNomina.Text}\n{row.EmpleadoId}\n{sueldoHora}\n{row.HorasTrabajadas}\n{horaExtra}\n{sueldo}\n{descuento}\n{total}\n\n");

				}


			}
            this.CargarNominas();

		}
        
        private bool ExistePeriodo(string periodo)
        {
			try
			{

				using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
				{
					dataConnection.Open();
					DataTable table = new DataTable();
					SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM dbo.Nomina WHERE Periodo = '{periodo}'", dataConnection);
					adapter.Fill(table);
					if(table.Rows.Count > 0)
                    {
                        return true; 
                    }
				}
			}
			catch (Exception ex)
			{
				ShowError($"Hubo un error al Verificar este periodo {periodo}", ex);
			}

			return false; 
		}


        public float ConseguirTotalDeImpuestos(float sueldoTotal)
        {
            try{
				float value = 0;
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Impuestos", con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                  
                    foreach(DataRow row in table.Rows)
                    {
                        value += float.Parse(row["Porcentage"].ToString())*sueldoTotal/100;
                    }
                }
                return value; 
            }catch(Exception ex)
            {
                this.ShowError("Hubo un error al tratar de conseguir El total de impuestos", ex);
                return 0; 
            }
        }



		private void btnRegistrar_Click(object sender, EventArgs e)
        {
         
             
            if(this.RegistroAutomatico.Checked)
            {
                if(this.ExistePeriodo(this.PeridoDeNomina.Text)){
                    MessageBox.Show("El Periodo de Nomina dado ya ha sido Registrado");
                    return;
                }
                this.RegistrarNominaAuto(); 
                return;
            }
            /*
            SqlConnection cn = new SqlConnection(Connection.ConnectionString);
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
            */

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

                if(!this.RegistroAutomatico.Checked && this.ExistePeriodo(this.PeridoDeNomina.Text))
                {   
                    
                    return;
                }
                if(this.ExistePeriodo(this.PeridoDeNomina.Text))
                {
				//MessageBox.Show(ConseguirSueldoNeto(1000.ToString()).ToString());
				this.Jornadas = new List<Jornada>();
				DataTable table = new DataTable();
				DataTable filtro = new DataTable();
				filtro.Columns.Add("EmpleadoId", typeof(int));
				filtro.Columns.Add("Empleado", typeof(string));
				filtro.Columns.Add("Fecha", typeof(string));
				filtro.Columns.Add("Entrada", typeof(string));
				filtro.Columns.Add("Salida", typeof(string));
				filtro.Columns.Add("HorasTrabajadas", typeof(float));


				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();

					SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Gestion_de_Jornada ", con);
					adapter.Fill(table);

					foreach (DataRow row in table.Rows)
					{
						if (this.InRange(DateTime.ParseExact(row["Fecha"].ToString(), "dd/MM/yyyy", null), this.InicioDeNomina.Value, this.CierreDeNomina.Value))

						{
							DataRow r = filtro.NewRow();

							r["EmpleadoId"] = row["EmpleadoId"];
							r["Empleado"] = row["Empleado"];
							r["Fecha"] = row["Fecha"];
							r["Entrada"] = row["Entrada"];
							r["Salida"] = row["Salida"];
							r["HorasTrabajadas"] = row["HorasTrabajadas"];
							filtro.Rows.Add(r);
						}
					}


					foreach (DataRow row in filtro.Rows)
					{
						if (this.ExisteEmpleadoEnJornada(int.Parse(row["EmpleadoId"].ToString())))
						{

							this.ActualizaHoras(int.Parse(row["EmpleadoId"].ToString()), float.Parse(row["HorasTrabajadas"].ToString()), row["Fecha"].ToString(), float.Parse(row["HorasTrabajadas"].ToString())-8<=0 ? 0 : float.Parse(row["HorasTrabajadas"].ToString())-8);

						}

						if (!this.ExisteEmpleadoEnJornada(int.Parse(row["EmpleadoId"].ToString())))
						{
							Get.Blue($"Agregando: {row["EmpleadoId"]}");
							this.Jornadas.Add(new Jornada()
							{
								EmpleadoId = int.Parse(row["EmpleadoId"].ToString()),
								Empleado = row["Empleado"].ToString(),
								Fecha = row["Fecha"].ToString(),
								Entrada = row["Entrada"].ToString(),
								Salida = row["Salida"].ToString(),
								HorasTrabajadas = float.Parse(row["HorasTrabajadas"].ToString()),
								HorasExtras = float.Parse(row["HorasTrabajadas"].ToString())-8<=0 ? 0 : float.Parse(row["HorasTrabajadas"].ToString())-8

							});
						}

						//Get.Ok();
					}
					this.Jornadas.ForEach(item => Get.Yellow(item.ToString()));
					// return;
				}
				using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
				{
					con.Open();
                    float descuento, sueldo, total, sueldoHora, horas, horaExtra, totalExtras, bonos;
				

					sueldo = 0;
					total = 0;
					sueldoHora = 0;

					foreach (Jornada row in this.Jornadas)
					{
						bonos = ConseguirTotalDeBonificaciones(row.EmpleadoId, this.CierreDeNomina.Value.ToString("dd/MM/yyyy"));


						descuento = this.ConseguirTotalDeDescuento(row.EmpleadoId);

						sueldoHora = this.ConseguirSueldoNetoPorDia(row.EmpleadoId);

						horas = row.HorasExtras == 0 ? row.HorasTrabajadas : row.HorasTrabajadas - row.HorasExtras;

						horaExtra = row.HorasExtras/*horas-8<=0 ? 0 : horas-8*/ ;
						//pagale las horas extras al 15% si las horas extras no son igual a cero
						totalExtras =  horaExtra!=0 ? ((sueldoHora * float.Parse(this.HorasExtrasPorcentage.Text) / 100)+sueldoHora)*horaExtra : 0;/*horaExtra==0 ? 0 : horaExtra*sueldoHora+(sueldoHora*15/100);*/

                        sueldo = (horas * sueldoHora)+totalExtras+bonos;
						total =  sueldo - descuento;
						SqlCommand cmd = new SqlCommand("UPDATE dbo.Nomina SET Periodo = @Periodo,EmpleadoId = @EmpleadoId,Salario_Base = @Salario_Base,Horas_Trabajadas = @Horas_Trabajadas,Horas_Extras = @Horas_Extras,Ingreso = @Ingreso,Descuento = @Descuento,Total_Ingreso = @Total_Ingreso WHERE EmpleadoId = @EmpleadoId", con);

						cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar));
						cmd.Parameters["@Periodo"].Value = this.PeridoDeNomina.Text;


						cmd.Parameters.Add(new SqlParameter("@EmpleadoId", SqlDbType.Int));
						cmd.Parameters["@EmpleadoId"].Value = row.EmpleadoId;

						cmd.Parameters.Add(new SqlParameter("@Salario_Base", SqlDbType.Float));
						cmd.Parameters["@Salario_Base"].Value = sueldoHora;

						cmd.Parameters.Add(new SqlParameter("@Horas_Trabajadas", SqlDbType.Float));
						cmd.Parameters["@Horas_Trabajadas"].Value = row.HorasTrabajadas;

						cmd.Parameters.Add(new SqlParameter("@Horas_Extras", SqlDbType.Float));
						cmd.Parameters["@Horas_Extras"].Value = horaExtra;

						cmd.Parameters.Add(new SqlParameter("@Ingreso", SqlDbType.Float));
						cmd.Parameters["@Ingreso"].Value = sueldo;

						cmd.Parameters.Add(new SqlParameter("@Descuento", SqlDbType.Float));
						cmd.Parameters["@Descuento"].Value = descuento;

						cmd.Parameters.Add(new SqlParameter("@Total_Ingreso", SqlDbType.Float));
						cmd.Parameters["@Total_Ingreso"].Value =total-this.ConseguirTotalDeImpuestos(total);

						cmd.ExecuteNonQuery();
						Get.Pink($"{this.PeridoDeNomina.Text}\n{row.EmpleadoId}\n{sueldoHora}\n{row.HorasTrabajadas}\n{horaExtra}\n{sueldo}\n{descuento}\n{total}\n\n");
                        
					}


				}
				this.CargarNominas();
				Get.Yellow("Actualizado");
                return;
			}else{
                MessageBox.Show($"Periodo de Nomina no Registrado {this.PeridoDeNomina.Text}");
            }
            /*
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
            */
        }
  

     

        private void GenerarNomina_MouseDown(object sender, MouseEventArgs e)
        {
 
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void ActualizarPagoPorHoraNormales()
        {
            //switch (this.PrecioHoraNormalesOpcion.Text)
            //{
            //    case "Agente":
            //        this.PrecioHoraNormal.Text = "210";
            //        break;
            //    case "Supervisor":
            //        this.PrecioHoraNormal.Text = "315";

            //        break;
            //    case "Calidad":
            //        this.PrecioHoraNormal.Text = "335";
            //        break;
            //    case "Manager":
            //        this.PrecioHoraNormal.Text = "415";
            //        break;
            //}
        }
        private void ActualizarPagoPorHoraExtra()
        {
            //switch (this.PrecioHorasExtraOpcion.Text)
            //{
            //    case "Agente":
            //        this.PrecioHoraExtra.Text = "285";
            //        break;
            //    case "Supervisor":
            //        this.PrecioHoraExtra.Text = "425";

            //        break;
            //    case "Calidad":
            //        this.PrecioHoraExtra.Text = "452";
            //        break;
            //    case "Manager":
            //        this.PrecioHoraExtra.Text = "560";
            //        break;
            //}
        }
        private void PrecioHoraNormalesOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CargarDatos();          
        }

        private void PrecioHorasExtraOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void InicioDeNomina_ValueChanged(object sender, EventArgs e)
        {
			//this.CargarDatos();
			this.ActualizarDiasTrabajados();

		}

		private void CierreDeNomina_ValueChanged(object sender, EventArgs e)
        {
            //this.CargarDatos();
            this.ActualizarDiasTrabajados();
        }

        private void txthorasn_TextChanged(object sender, EventArgs e)
        {
            this.CargarDatos();
        }
      
        private void CargarNominas()
        {
			try
			{

				using (SqlConnection dataConnection = new SqlConnection(Connection.ConnectionString))
				{
					dataConnection.Open();
					DataTable table = new DataTable();
					DataTable filtro = new DataTable();
					filtro.Columns.Add("Periodo", typeof(string));
					//filtro.Columns.Add("Fecha", typeof(string));

					SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Nomina", dataConnection);
 					adapter.Fill(table);
                    List<string>  lista = new List<string>();
                    foreach(DataRow row in table.Rows)
                    {
                        if(!lista.Contains(row["Periodo"].ToString()))
                        {
                            lista.Add(Name = row["Periodo"].ToString());
                        }
                    }
                    lista.ForEach((item) => {
                        DataRow row = filtro.NewRow();
                        row["Periodo"] = item;
                        filtro.Rows.Add(row); 
                    });

					ListadodeNominaRegistrada.DataSource = filtro;


				}
			}
			catch (Exception ex)
			{
				ShowError("Hubo un error al Cargar las Nominas", ex);
			}
		}
		private void btnRefrescar_Click_1(object sender, EventArgs e)
		{
            this.CargarNominas();
		}

		private void RegistroAutomatico_CheckedChanged(object sender, EventArgs e)
		{
           if(!this.RegistroAutomatico.Checked)
           {
                this.RegistroAutomatico.Checked = true; 
           }
		}
	}
}
