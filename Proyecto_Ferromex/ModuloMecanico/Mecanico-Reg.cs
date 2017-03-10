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
    }
}
