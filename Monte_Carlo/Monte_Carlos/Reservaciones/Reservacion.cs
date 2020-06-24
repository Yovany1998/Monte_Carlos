using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlos.Reservaciones
{
    class Reservacion
    {
        private Conexion conexion;
        private string idReservacion;
        private string idCliente;
        private string idMesa;
        private DateTime dateFecha;
        private int hora;
        private MySqlException error;

        public Reservacion()
        {
            idReservacion = "";
            idCliente = "";
            idMesa = "";
            dateFecha = DateTime.Today;
            conexion = new Conexion();
        }

        public Reservacion(string i, string n, string c , DateTime f,int h)
        {

            idReservacion = i;
            idCliente = n;
            idMesa = c;
            dateFecha = f;
            hora = h;
            conexion = new Conexion();
        }

        public Boolean Guardar()
        {
            if (conexion.IUD(string.Format("INSERT INTO cliente (idReservacion,idCliente,idMesa,fecha,hora) VALUES ('{0}','{1}','{2}','{3}','{4}');", idReservacion, idCliente, idMesa, dateFecha,hora)))
            {
                return true;
            }
            else
            {
                error = conexion.Error;
                return false;
            }
        }

        public string Idreservacion
        {
            get
            {
                return idReservacion;
            }
            set
            {
                idReservacion = value;
            }
        }

        public string Idcliente
        {
            get
            {
                return idCliente;
            }
            set
            {
                idCliente = value;
            }
        }

        public string IdMesa
        {
            get
            {
                return idMesa;
            }
            set
            {
                idMesa = value;
            }
        }

        public DateTime DateFecha
        {
            get
            {
                return dateFecha;
            }
            set
            {
                dateFecha = value;
            }
        }

        public int Hora
        {
            get
            {
                return hora;
            }
            set
            {
                hora = value;
            }
        }

        public MySqlException Error
        {
            get { return error; }
        }



    }

}
