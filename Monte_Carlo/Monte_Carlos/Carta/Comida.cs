using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlos.Carta
{
    class Comida
    {
        private Conexion conexion;
        private int idComida;
        private string nombre;
        private float precio;
        private string descripcion;
        private MySqlException error;

        public Comida()
        {
            idComida = 0;
            nombre = "";
            precio = 0;
            descripcion = "";

            conexion = new Conexion();
        }

        public Comida(string i, string n, string c, string z)
        {

            nombre = n;
            precio = 0;
            descripcion = z;
            conexion = new Conexion();
        }

        public Boolean Guardar()
        {
            if (conexion.IUD(string.Format("INSERT INTO comida (nombre,precio,descripcion) VALUES ('{0}','{1}', '{2}');", nombre, precio, descripcion)))
            {
                return true;
            }
            else
            {
                error = conexion.Error;
                return false;
            }
        }

      

        public string NombreComida
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public float Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }
        
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        public MySqlException Error
        {
            get { return error; }
        }




    }
}
