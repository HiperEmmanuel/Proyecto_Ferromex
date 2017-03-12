using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;

namespace Proyecto_Ferromex.ModuloMecanico
{
    class Mecanico_Reg
    {

        //REGISTRAR MECANICO
        public static int InvocarSP(Mecanico pMecanico)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    int retorno = 0;
                    // setear parametros del command
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = BDConexion.ObtenerConexion();
                    cmd.CommandText = "RegMecanico";

                    //asignar paramentros
                    cmd.Parameters.AddWithValue("_nombre", pMecanico.nombre);
                    cmd.Parameters.AddWithValue("_app", pMecanico.app);
                    cmd.Parameters.AddWithValue("_apm", pMecanico.apm);
                    cmd.Parameters.AddWithValue("_ciudad", pMecanico.ciudad);
                    cmd.Parameters.AddWithValue("_calle", pMecanico.calle);
                    cmd.Parameters.AddWithValue("_numero", pMecanico.numero);
                    cmd.Parameters.AddWithValue("_colonia", pMecanico.colonia);
                    cmd.Parameters.AddWithValue("_cp", pMecanico.cp);
                    cmd.Parameters.AddWithValue("_curp", pMecanico.curp);
                    cmd.Parameters.AddWithValue("_rfc", pMecanico.rfc);
                    cmd.Parameters.AddWithValue("_fechaN", pMecanico.fecha);
                    cmd.Parameters.AddWithValue("_tel", pMecanico.telefono);
                    //abrir la conexion
                    BDConexion.ObtenerConexion();

                    //ejecutar el query
                    retorno = cmd.ExecuteNonQuery();
                    return retorno;
                }
                catch (Exception ex)
                {
                    throw ex;

                }
                finally
                {
                    BDConexion.CerrarConexion();
                } // end try
            } // end using

        } // end GuardarHuella






        public static List<Mecanico> Buscar(Mecanico pMecanico)
        {
            List<Mecanico> _lista = new List<Mecanico>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * FROM mecanicos where nombre ='{0}' or app='{1}' or apm='{2}'", pMecanico.nombre, pMecanico.app, pMecanico.apm), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Mecanico p2Mecanico = new Mecanico();
                p2Mecanico.id = _reader.GetInt32(0);
                p2Mecanico.nombre = _reader.GetString(1);
                p2Mecanico.app = _reader.GetString(2);
                p2Mecanico.apm = _reader.GetString(3);
                p2Mecanico.ciudad = _reader.GetString(4);
                p2Mecanico.calle = _reader.GetString(5);
                p2Mecanico.numero = _reader.GetInt32(6);
                p2Mecanico.colonia = _reader.GetString(7);
                p2Mecanico.cp = _reader.GetInt32(8);
                p2Mecanico.curp = _reader.GetString(9);
                p2Mecanico.rfc = _reader.GetString(10);
                p2Mecanico.fecha = _reader.GetString(11);
                p2Mecanico.telefono = _reader.GetString(12);



                //p2Mecanico.Direccion = _reader.GetString(4);


                _lista.Add(p2Mecanico);
            }

            return _lista;
        }


        public static Mecanico ObtenerMecanico(int pId)
        {
            Mecanico pMecanico = new Mecanico();
            MySqlConnection conexion = BDConexion.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM mecanicos   where id_mecanico={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pMecanico.id = _reader.GetInt32(0);
                pMecanico.nombre = _reader.GetString(1);
                pMecanico.app = _reader.GetString(2);
                pMecanico.apm = _reader.GetString(3);
                pMecanico.ciudad = _reader.GetString(4);
                pMecanico.calle = _reader.GetString(5);
                pMecanico.numero = _reader.GetInt32(6);
                pMecanico.colonia = _reader.GetString(7);
                pMecanico.cp = _reader.GetInt32(8);
                pMecanico.curp = _reader.GetString(9);
                pMecanico.rfc = _reader.GetString(10);
                pMecanico.fecha = _reader.GetString(11);
                pMecanico.telefono = _reader.GetString(12);

            }

            conexion.Close();
            return pMecanico;

        }

        public static int Actualizar(Mecanico pMecanico)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    int retorno = 0;
                    // setear parametros del command
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = BDConexion.ObtenerConexion();
                    cmd.CommandText = "ActualizarMec";

                    //asignar paramentros
                    cmd.Parameters.AddWithValue("_id", pMecanico.id);
                    cmd.Parameters.AddWithValue("_nombre", pMecanico.nombre);
                    cmd.Parameters.AddWithValue("_app", pMecanico.app);
                    cmd.Parameters.AddWithValue("_apm", pMecanico.apm);
                    cmd.Parameters.AddWithValue("_ciudad", pMecanico.ciudad);
                    cmd.Parameters.AddWithValue("_calle", pMecanico.calle);
                    cmd.Parameters.AddWithValue("_numero", pMecanico.numero);
                    cmd.Parameters.AddWithValue("_colonia", pMecanico.colonia);
                    cmd.Parameters.AddWithValue("_cp", pMecanico.cp);
                    cmd.Parameters.AddWithValue("_curp", pMecanico.curp);
                    cmd.Parameters.AddWithValue("_rfc", pMecanico.rfc);
                    cmd.Parameters.AddWithValue("_fechaN", pMecanico.fecha);
                    cmd.Parameters.AddWithValue("_tel", pMecanico.telefono);
                    //abrir la conexion
                    BDConexion.ObtenerConexion();

                    //ejecutar el query
                    retorno = cmd.ExecuteNonQuery();
                    return retorno;
                }
                catch (Exception ex)
                {
                    throw ex;

                }
                finally
                {
                    BDConexion.CerrarConexion();
                } // end try
            } // end using

        } // end GuardarHuella


        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From mecanicos where id_mecanico={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}