using LNegocioyADatos.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNegocioyADatos.Entidades;

namespace LNegocioyADatos
{
    public class LNyAD
    {
        static usuariosTableAdapter usuarioAdapter = new usuariosTableAdapter();
        static DataSet1.usuariosDataTable usuarioTable = new DataSet1.usuariosDataTable();

        #region Usuarios
        public static List<Usuario> listarUsuario()
        {
            List<Usuario> listaUsuario = new List<Usuario>();

            usuarioTable = usuarioAdapter.GetData();

            foreach (DataSet1.usuariosRow item in usuarioTable)
            {
                listaUsuario.Add(new Usuario(item));
            }

            return listaUsuario;
        }

        public static Usuario ObtenerUsuarioPorId(int id)
        {
            DataSet1.usuariosRow regUsuario = usuarioTable.FindByidUsuario(idUsuario);
            Usuario usu = new Usuario(regUsuario);
            return usu;
        }
        #endregion

    }
}
