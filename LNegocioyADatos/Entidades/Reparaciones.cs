using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNegocioyADatos.Entidades
{

   public class Reparaciones
    {

        //Atributos
        int id;
        int idClientes;
        int idComponente;
        DateTime fechaEntrada;
        DateTime fechaSalida;
        string observaciones;
        //Constructor


        public Reparaciones(int id, int idClientes, int idComponente, DateTime fechaEntrada, DateTime fechaSalida, string observaciones)
        {
            this.id = id;
            this.idClientes = idClientes;
            this.idComponente = idComponente;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
            this.observaciones = observaciones;
        }

        public Reparaciones()
        {
        }

        public Reparaciones(DataSet1.reparacionesRow regReparaciones)
        {
            this.id = regReparaciones.Id;
            this.idClientes = regReparaciones.idCliente;
            this.idComponente = regReparaciones.idComponente;
            this.fechaEntrada = regReparaciones.fechaEntrada;
            this.fechaSalida = regReparaciones.fechaSalida;
            this.observaciones = regReparaciones.observaciones;
        }

        #region//Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdClientes
        {
            get { return idClientes; }
            set { idClientes = value; }
        }
        public int IdComponente
        {
            get { return idComponente; }
            set { idComponente = value; }
        }
        public DateTime FechaEntrada
        {
            get { return fechaEntrada; }
            set { fechaEntrada = value; }
        }
        public DateTime FechaSalida
        {
            get { return fechaSalida; }
            set { fechaSalida = value; }
        }
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        #endregion
    }
}
