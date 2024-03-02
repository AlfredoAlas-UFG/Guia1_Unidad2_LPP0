using Ejercicio_1.Models;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class FormListarAlumnos : Form
    {
        public FormListarAlumnos()
        {
            InitializeComponent();

            LlenaDataGridView();
        }

        private void ConfiguraDataGridView()
        {
            listarAlumnosGrid.Columns.Clear();

            listarAlumnosGrid.Columns.Add("numero", "Numero");
            listarAlumnosGrid.Columns.Add("carnet", "Carnet");
            listarAlumnosGrid.Columns.Add("nombre", "Nombre");
            listarAlumnosGrid.Columns.Add("apellido", "Apellido");

            listarAlumnosGrid.AllowUserToAddRows = false;

            listarAlumnosGrid.ReadOnly = true;

            listarAlumnosGrid.AllowUserToDeleteRows = false;

            listarAlumnosGrid.AllowUserToOrderColumns = false;

            listarAlumnosGrid.AllowUserToResizeColumns = false;
            listarAlumnosGrid.AllowUserToResizeRows = false;
        }

        private void LlenaDataGridView()
        {
            ConfiguraDataGridView();

            Alumno[] alumnos = AppContext.ObtenerAlumnos();

            listarAlumnosGrid.Rows.Clear();

            foreach (var (alumno, index) in alumnos.Select((a, index) => ( a, index)))
                listarAlumnosGrid.Rows.Add(index+1, alumno.carnet, alumno.nombre, alumno.apellido, alumno.asignatura);
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
