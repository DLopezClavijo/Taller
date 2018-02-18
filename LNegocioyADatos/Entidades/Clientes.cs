using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNegocioyADatos.Entidades
{
    public class Clientes
    {

        //Atributos
        int id;
        string nombre;
        string dni;
        string correo;
        string tlfContacto;
        //Constructor


        public Clientes(int id, string nombre, string dni, string correo, string tlfContacto)
        {
            this.id = id;
            this.nombre = nombre;
            this.dni = dni;
            this.correo = correo;
            this.tlfContacto = tlfContacto;
        }

        public Clientes()
        {

        }

        public Clientes(DataSet1.clientesRow regClientes)
        {
            this.id = regClientes.Id;
            this.nombre = regClientes.nombre;
            this.dni = regClientes.dni;
            this.correo = regClientes.correo;
            this.tlfContacto = regClientes.tlfContacto;
        }

        #region//Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descripcion
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string TlfContacto
        {
            get { return tlfContacto; }
            set { tlfContacto = value; }
        }
        #endregion
    }
}
