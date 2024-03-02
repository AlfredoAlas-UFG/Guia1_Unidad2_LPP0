using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace G2_Ejemplo_1
{
    partial class ContactosForm : Form
    {
        private List<Persona> Personas = new List<Persona>();
        private int edit_indice = -1;

        public ContactosForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona per = new Persona();
            per.nombre = tbxNombre.Text;
            per.apellido = tbxApellido.Text;
            per.telefono = tbxTelefono.Text;
            per.correo = tbxCorreo.Text;
            
            if (edit_indice > -1)
            {
                Personas[edit_indice] = per;
                edit_indice = -1;
            }
            else
            {
                Personas.Add(per);
            }

            actualizarDatos();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1)
            {
                Personas.RemoveAt(edit_indice);
                edit_indice = -1;
                limpiar();
                actualizarDatos();
            }
            else
            {
                MessageBox.Show("Por favor dar doble click sobre contacto");
            }
        }

        private void actualizarDatos()
        {
            TablaContacto.DataSource = null;
            TablaContacto.DataSource = Personas; 
        }

        private void limpiar()
        {
            tbxNombre.Clear();
            tbxApellido.Clear();
            tbxTelefono.Clear();
            tbxCorreo.Clear();
        }

        private void gridContacto_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = TablaContacto.SelectedRows[0];
            int pos = TablaContacto.Rows.IndexOf(seleccion);
            edit_indice = pos;
            Persona per = Personas[pos];
            tbxNombre.Text = per.nombre;
            tbxApellido.Text = per.apellido;
            tbxTelefono.Text = per.telefono;
            tbxCorreo.Text = per.correo;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FrmRecibe formulario = new FrmRecibe();
            formulario.PersonaRecibe = Personas;
            formulario.Show();
        }
    }
}
