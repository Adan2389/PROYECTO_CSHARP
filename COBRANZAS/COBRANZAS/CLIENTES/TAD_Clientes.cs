
using COBRANZAS.AdminDB;
using COBRANZAS.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COBRANZAS.CLIENTES
{
    public class TAD_Clientes
    {
        TParamSql objParamSql = new TParamSql();
        TModelClientes cliente = new TModelClientes();

        public TAD_Clientes() { 
        
        }

        // Consulta la informacion de 1 cliente
        public TModelClientes Consultar(int Id) {
            using (SqlConnection con = new SqlConnection(objParamSql.getStringCon())) {
                try
                {
                    con.Open();
                    SqlCommand sql = new SqlCommand($" SELECT * FROM CLIENTES WHERE ID = {Id}", con);
                    DataTable dtClientes = new DataTable();
                    dtClientes.Load(sql.ExecuteReader());
                    if (dtClientes.Rows.Count > 0)
                    {
                        foreach (DataRow Fila in dtClientes.Rows)
                        {
                            cliente.Id = Convert.ToInt32(Fila["ID"].ToString());
                            cliente.Nombre = Fila["NOMBRE"].ToString();
                            cliente.Identidad = Fila["IDENTIDAD"].ToString();
                            cliente.Direccion = Fila["DIRECCION"].ToString();
                            cliente.Telefono = Fila["TELEFONO"].ToString();
                            cliente.Correo = Fila["CORREO"].ToString();
                            cliente.Municipio = Fila["MUNICIPIO"].ToString();
                            cliente.UsuarioCreacion = Fila["USUARIO_CREACION"].ToString();
                            cliente.UsuarioMofica = Fila["USUARIO_MODIFICACION"].ToString();
                            DateTime Fecha_Creacion = new DateTime(); ;
                            cliente.FechaCreacion = (DateTime.TryParse(Fila["FECHA_CREACION"].ToString(), out Fecha_Creacion) ? Fecha_Creacion : Fecha_Creacion);
                            DateTime FechaNac = new DateTime();
                            cliente.FechaNacimiento = (DateTime.TryParse(Fila["FECHA_NACIMIENTO"].ToString(), out FechaNac) ? FechaNac : FechaNac);
                        }
                    }
                    con.Close();
                }
                catch( Exception Err )
                {
                    MessageBox.Show($"La operacion no se pudo completar \n {Err.Message}" );
                }
            }
            return cliente;
        }

        // Guarda un nuevo registro de 1 cliente
        public bool Guardar(TModelClientes prmCliente, String prmUsuario) {
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

        public bool Modificar(TModelClientes prmCliente, String prmUsuario)
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

        public bool Anular(int IdCliente )
        {

            return false;
        }

    }
}
