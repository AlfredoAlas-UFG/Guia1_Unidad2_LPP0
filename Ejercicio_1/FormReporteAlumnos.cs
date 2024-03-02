using Ejercicio_1.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class FormReporteAlumnos : Form
    {
        public FormReporteAlumnos()
        {
            InitializeComponent();

            LlenarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            // Limpiar las columnas existentes
            listarAlumnosGrid.Columns.Clear();

            // Agregar columnas para las propiedades de Alumno
            listarAlumnosGrid.Columns.Add("carnet", "Carnet");
            listarAlumnosGrid.Columns.Add("nombre", "Nombre");
            listarAlumnosGrid.Columns.Add("apellido", "Apellido");
            listarAlumnosGrid.Columns.Add("materia", "Materia");
            // Agregar columnas para cada calificación
            listarAlumnosGrid.Columns.Add("calificacion1", "Calificación 1");
            listarAlumnosGrid.Columns.Add("calificacion2", "Calificación 2");
            listarAlumnosGrid.Columns.Add("calificacion3", "Calificación 3");
            listarAlumnosGrid.Columns.Add("promedio", "Promedio");

            // Impedir a los usuarios agregar nuevas filas
            listarAlumnosGrid.AllowUserToAddRows = false;

            // Impedir a los usuarios editar las celdas
            listarAlumnosGrid.ReadOnly = true;

            // Otras configuraciones para evitar la edición:
            // Impedir a los usuarios eliminar filas
            listarAlumnosGrid.AllowUserToDeleteRows = false;

            // Impedir a los usuarios ordenar las columnas
            listarAlumnosGrid.AllowUserToOrderColumns = false;

            // Impedir el ajuste de tamaño de las columnas y filas por parte del usuario
            listarAlumnosGrid.AllowUserToResizeColumns = false;
            listarAlumnosGrid.AllowUserToResizeRows = false;
        }

        private void LlenarDataGridView()
        {
            // Asegúrate de que el DataGridView esté configurado
            ConfigurarDataGridView();

            // Obtener los alumnos
            Alumno[] alumnos = AppContext.ObtenerAlumnos();

            // Limpiar filas existentes
            listarAlumnosGrid.Rows.Clear();

            // Llenar el DataGridView con los datos de los alumnos
            foreach (Alumno alumno in alumnos)
                listarAlumnosGrid.Rows.Add(alumno.carnet, alumno.nombre, alumno.apellido, alumno.asignatura,
                    alumno.calificacionesArray[0], alumno.calificacionesArray[1], alumno.calificacionesArray[2], alumno.calificacionesArray.Average());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
