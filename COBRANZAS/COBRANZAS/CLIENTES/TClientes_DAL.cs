
using COBRANZAS.AdminDB;
using COBRANZAS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COBRANZAS.CLIENTES
{
    public class TClientes_DAL
    {
        // Para acceder a los parametros de la conexion
        TParamSql objParamSql = new TParamSql();
        // Para manejar un cliente a traves del modelo
        TModelClientes cliente = new TModelClientes();
        // Para manejar Lista de clientes
        List<TModelClientes> lstClientes = new List<TModelClientes>();    

        public TClientes_DAL() { 
        
        }

        // Consulta la informacion de 1 cliente
        public TModelClientes consultar(int Id) {
            DataTable dtClientes = new DataTable();
            TModelClientes Xcliente = new TModelClientes();
            using (SqlConnection con = new SqlConnection(objParamSql.getStringCon())) {
                try
                {
                    con.Open();
                    SqlCommand sql = new SqlCommand($" SELECT * FROM CLIENTES WHERE ID = {Id}", con);
                   
                    dtClientes.Load(sql.ExecuteReader());
                    if (dtClientes.Rows.Count > 0)
                    {
                        foreach (DataRow Fila in dtClientes.Rows)
                        {
                            Xcliente.Id = Convert.ToInt32(Fila["ID"].ToString());
                            Xcliente.Nombre = Fila["NOMBRE"].ToString();
                            Xcliente.Identidad = Fila["IDENTIDAD"].ToString();
                            Xcliente.Direccion = Fila["DIRECCION"].ToString();
                            Xcliente.Telefono = Fila["TELEFONO"].ToString();
                            Xcliente.Correo = Fila["CORREO"].ToString();
                            Xcliente.Municipio = Fila["MUNICIPIO"].ToString();
                            Xcliente.UsuarioCreacion = Fila["USUARIO_CREACION"].ToString();
                            Xcliente.UsuarioMofica = Fila["USUARIO_MODIFICACION"].ToString();
                            DateTime Fecha_Creacion = new DateTime(); ;
                            Xcliente.FechaCreacion = (DateTime.TryParse(Fila["FECHA_CREACION"].ToString(), out Fecha_Creacion) ? Fecha_Creacion : Fecha_Creacion);
                            Xcliente.FechaCreacion.ToString();
                            DateTime FechaNac = new DateTime();
                            Xcliente.FechaNacimiento = (DateTime.TryParse(Fila["FECHA_NACIMIENTO"].ToString(), out FechaNac) ? FechaNac : FechaNac);
                        }
                    }
                    con.Close();
                }
                catch( Exception Err )
                {
                    MessageBox.Show($"La operacion no se pudo completar \n {Err.Message}" );
                }
            }
            return Xcliente;
        }

        // Devulve la lista clientes
        public List<TModelClientes> getClientes() {
            List<TModelClientes> Clientes = new List<TModelClientes>();
            using (SqlConnection con = new SqlConnection(objParamSql.getStringCon()))
            {
                try
                {
                    con.Open();
                    SqlCommand query = new SqlCommand("SP_LISTAR_CLIENTES", con);
                    DataTable dtDatos = new DataTable();
                    dtDatos.Load(query.ExecuteReader());
                    if (dtDatos.Rows.Count > 0) {
                        foreach (DataRow Fila in dtDatos.Rows)
                        {
                            Clientes.Add(new TModelClientes
                            {
                                Id = (int)Fila["ID"],
                                Identidad = Fila["IDENTIDAD"].ToString(),
                                Nombre = Fila["NOMBRE"].ToString(),
                                Telefono = Fila["TELEFONO"].ToString(),
                                Correo = Fila["CORREO"].ToString(),
                                Municipio = Fila["MUNICIPIO"].ToString(),
                                FechaNacimiento = (DateTime)Fila["FECHA_NACIMIENTO"],
                                Direccion = Fila["DIRECCION"].ToString(),
                                UsuarioCreacion = Fila["USUARIO_CREACION"].ToString(),
                                Activo =  ( Fila["ACTIVO"].ToString()=="True" ? true : false)
                            });    
                        }
                    }
                }
                catch(Exception e) {
                    MessageBox.Show($"La operacion no se pudo completar comunique con el equipo de soporte sistemas \n {e.Message} ");          
                }
            }
            return Clientes;
        }
      
        // Guarda un nuevo registro de 1 cliente
        public bool guardar(TModelClientes prmCliente, String prmUsuario) {
            bool ValResul = false;
            using ( SqlConnection con = new SqlConnection(objParamSql.getStringCon())) {
                try
                {
                    con.Open();
                    SqlCommand sql = new SqlCommand("SP_INSERTAR_CLIENTES", con);
                    sql.CommandType = CommandType.StoredProcedure;
                    sql.Parameters.AddWithValue("@prmIdentidad", prmCliente.Identidad);
                    sql.Parameters.AddWithValue("@prmNombre", prmCliente.Nombre);
                    sql.Parameters.AddWithValue("@prmDireccion", prmCliente.Direccion);
                    sql.Parameters.AddWithValue("@prmTelefono", prmCliente.Telefono);
                    sql.Parameters.AddWithValue("@prmCorreo", prmCliente.Correo);
                    sql.Parameters.AddWithValue("@prmMunicipio", prmCliente.Municipio);
                    sql.Parameters.AddWithValue("@prmFechaNacimiento", prmCliente.FechaNacimiento);
                    sql.Parameters.AddWithValue("@prmUsuario", prmUsuario);
                    sql.Parameters.AddWithValue("@Result", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    sql.ExecuteNonQuery();
                    int Num =  (int)sql.Parameters["@Result"].Value;
                    if (Num == 1)
                        ValResul = true;
                }
                catch(Exception Err) {
                    MessageBox.Show($"La operacion no se pudo completar \n {Err.Message}");
                }
            }
            return ValResul;
        }

        // Modifica los datos de un clientes
        public bool modificar(TModelClientes prmCliente, String prmUsuario)
        {
            bool ValResul = false;
            using (SqlConnection con = new SqlConnection(objParamSql.getStringCon()))
            {
                try
                {
                    con.Open();
                    SqlCommand sql = new SqlCommand("SP_ACTUALIZAR_CLIENTES", con);
                    sql.CommandType = CommandType.StoredProcedure;
                    sql.Parameters.AddWithValue("@prmId", prmCliente.Id);
                    sql.Parameters.AddWithValue("@prmIdentidad", prmCliente.Identidad);
                    sql.Parameters.AddWithValue("@prmNombre", prmCliente.Nombre);
                    sql.Parameters.AddWithValue("@prmDireccion", prmCliente.Direccion);
                    sql.Parameters.AddWithValue("@prmTelefono", prmCliente.Telefono);
                    sql.Parameters.AddWithValue("@prmCorreo", prmCliente.Correo);
                    sql.Parameters.AddWithValue("@prmMunicipio", prmCliente.Municipio);
                    sql.Parameters.AddWithValue("@prmFechaNacimiento", prmCliente.FechaNacimiento);
                    sql.Parameters.AddWithValue("@prmUsuario", prmUsuario);
                    sql.Parameters.AddWithValue("@Result", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    sql.ExecuteNonQuery();
                    int Num = (int)sql.Parameters["@Result"].Value;
                    if (Num == 1)
                        ValResul = true;
                }
                catch (Exception Err)
                {
                    MessageBox.Show($"La operacion no se pudo completar \n {Err.Message}");
                }
            }
            return ValResul;
            return false;
        }

        // Marca como anulado un registro de cliente
        public bool anular(int IdCliente )
        {
            bool ValResul = false;
            using (SqlConnection con = new SqlConnection(objParamSql.getStringCon()))
            {
                try
                {
                    con.Open();
                    SqlCommand sql = new SqlCommand("SP_ANULAR_CLIENTES", con);
                    sql.CommandType = CommandType.StoredProcedure;
                    sql.Parameters.AddWithValue("@prmId", IdCliente);
                    sql.Parameters.AddWithValue("@Result", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    sql.ExecuteNonQuery();
                    int Num = (int)sql.Parameters["@Result"].Value;
                    if (Num == 1)
                        ValResul = true;
                }
                catch (Exception Err)
                {
                    MessageBox.Show($"La operacion no se pudo completar \n {Err.Message}");
                }
            }
            return ValResul;
        }

    }
}
