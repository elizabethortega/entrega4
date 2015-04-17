using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMayorEdad
{
    class persona
    {
        //atributos
        string nombre;
        int edad;

            //metodo constructor vacio
        public persona()
        {
        }

        //metodo constructor 
        public persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        //metodos get y set
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }




    }
}
