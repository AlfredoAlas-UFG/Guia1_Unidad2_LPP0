using Ejercicio_1.Models;
using System;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class FormAgregarAlumnos : Form
    {
        public FormAgregarAlumnos()
        {
            InitializeComponent();

            ConfigDataGrid();
        }

        private void ConfigDataGrid()
        {
            calificacionesGrid.ColumnCount = 3;
            for (int i = 0; i < 3; i++)
            {
                calificacionesGrid.Columns[i].Name = $"Calificación {i + 1}";
            }
            calificacionesGrid.Rows.Add(0, 0, 0);
            calificacionesGrid.AllowUserToAddRows = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbCarnet.Text) ||
                    string.IsNullOrWhiteSpace(txbNombre.Text) ||
                    string.IsNullOrWhiteSpace(txbApellido.Text) ||
                    string.IsNullOrWhiteSpace(txbAsignatura.Text))
                {
                    MessageBox.Show("No pueden haber campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float[] calificaciones = new float[3];
                for (int i = 0; i < 3; i++)
                {
                    if (!float.TryParse(calificacionesGrid.Rows[0].Cells[i].Value.ToString(), out calificaciones[i]) || calificaciones[i] < 0 || calificaciones[i] > 10)
                    {
                        MessageBox.Show($"Calificación {i + 1} no es válida. Debe ser un número entre 0 y 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Alumno nuevoAlumno = new Alumno
                {
                    carnet = txbCarnet.Text,
                    nombre = txbNombre.Text,
                    apellido = txbApellido.Text,
                    asignatura = txbAsignatura.Text,
                    calificacionesArray = calificaciones
                };

                AppContext.AgregarAlumno(nuevoAlumno);

                MessageBox.Show("Alumno agregado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txbCarnet.Clear();
                txbNombre.Clear();
                txbApellido.Clear();
                txbAsignatura.Clear();
                calificacionesGrid.Rows[0].SetValues(0, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
