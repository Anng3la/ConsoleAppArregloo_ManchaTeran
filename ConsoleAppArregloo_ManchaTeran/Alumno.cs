using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArregloo_ManchaTeran
{
    class Alumno
    {
        private string nombre;
        private string matricula;
        private string carrera;

        public string Nombre
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

        public string Matriula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public string Carrera
        {
            get
            {
                return carrera;
            }
            set
            {
                carrera = value;
            }
        }

        public Alumno()
        {
            nombre = "";
            matricula = "";
            carrera = "";
        }

        public Alumno(string nombre, string matricula, string carrera)
        {
            this.nombre = nombre;
            this.matricula = matricula;
            this.carrera = carrera;
        }

        public override string ToString()
        {
            return "  Nombre: " + nombre + "  Matricula: " + matricula + "  Carrera: " + carrera;
        }
    }
}
