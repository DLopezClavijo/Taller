using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNegocioyADatos.Entidades
{
    public class Usuario
    {

        //Atributos
        int id;
        string nombre;
        string login;
        string password;
        byte tipo;
        string tlfContacto;
        //Constructor


        public Usuario(int id, string nombre, string login, string password, byte tipo, string tlfContacto)
        {
            this.id = id;
            this.nombre = nombre;
            this.login = login;
            this.password = password;
            this.tipo = tipo;
            this.tlfContacto = tlfContacto;
        }

        public Usuario()
        {

        }

        public Usuario(DataSet1.usuariosRow regUsuario)
        {
            this.id = regUsuario.idUsuario;
            this.nombre = regUsuario.nombre;
            this.login = regUsuario.login;
            this.password = regUsuario.password;
            this.tipo = (byte)regUsuario.tipo;
            this.tlfContacto = regUsuario.tlfContacto;

        }

        #region//Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public byte Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string TlfContacto
        {
            get { return tlfContacto; }
            set { tlfContacto = value; }
        }
        #endregion
    }
}
