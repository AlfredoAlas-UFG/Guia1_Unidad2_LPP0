using Ejercicio_1.Models;
using System;

namespace Ejercicio_1
{
    public static class AppContext
    {
        private static Alumno[] alumnos = new Alumno[0]; // Inicializa un arreglo vacío

        // Método para agregar un nuevo alumno
        public static void AgregarAlumno(Alumno nuevoAlumno)
        {
            // Redimensiona el arreglo para hacer espacio para el nuevo alumno
            Array.Resize(ref alumnos, alumnos.Length + 1);
            alumnos[alumnos.Length - 1] = nuevoAlumno; // Agrega el nuevo alumno en la última posición
        }

        // Método para obtener la lista de alumnos
        public static Alumno[] ObtenerAlumnos()
        {
            return alumnos;
        }
    }

}
