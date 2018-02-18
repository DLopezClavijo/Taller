using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNegocioyADatos.Entidades
{
    public class Componentes
    {

        //Atributos
        int id;
        string descripcion;
        //Constructor


        public Componentes(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public  Componentes ()
        {
        }

        public Componentes(DataSet1.componentesRow regComponentes)
        {
            this.id = regComponentes.id;
            this.descripcion = regComponentes.descripcion;
        }


        #region//Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        #endregion
    }
}
