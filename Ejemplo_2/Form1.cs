using Ejemplo_2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Ejemplo_2
{
    public partial class Form1 : Form
    {
        private List<Producto> Productos = new List<Producto>();
        private int editaIndice = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void actualizaTabla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Productos; 
        }
        private void reset()
        {
            tbxNombre.Clear();
            tbxDescripcion.Clear();
            tbxMarca.Clear();
            tbxPrecio.Clear();
            tbxStock.Clear();
            tbxImagenPath.Clear();
            tbxImagenPath.Enabled = true;
        }

        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;

            
            string imagenPath = dgvProductos.CurrentRow.Cells["ImagenPath"].Value.ToString();

            if (!string.IsNullOrEmpty(imagenPath) && File.Exists(imagenPath))
            {
                Form formImagen = new Form
                {
                    Width = 600,
                    Height = 400,
                    FormBorderStyle = FormBorderStyle.FixedDialog
                };

                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(imagenPath),
                    Dock = DockStyle.Fill
                };

                formImagen.Controls.Add(pictureBox);
                formImagen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Imagen no disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            float.TryParse(tbxPrecio.Text, out float precio);
            int.TryParse(tbxStock.Text, out int stock);

            Producto product = new Producto();
            product.nombre = tbxNombre.Text;
            product.descripcion = tbxDescripcion.Text;
            product.marca = tbxMarca.Text;
            product.precio = precio;
            product.stock = stock;
            product.imagen = tbxImagenPath.Text;

            if (editaIndice > -1)
            {
                Productos[editaIndice] = product;
                editaIndice = -1;
            }
            else
            {
                Productos.Add(product); 
            }

            actualizaTabla();
            reset();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (editaIndice > -1)
            {
                string imagenPath = dgvProductos.Rows[editaIndice].Cells["ImagenPath"].Value?.ToString();


                if (!string.IsNullOrEmpty(imagenPath) && File.Exists(imagenPath))
                {
                    try
                    {

                        File.Delete(imagenPath);
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show($"No se pudo eliminar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Productos.RemoveAt(editaIndice);
                editaIndice = -1;

                reset();
                actualizaTabla(); 
            }
            else
            {
                MessageBox.Show("Da click en elemento para seleccionar y borrar", "Selecciona un Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Title = "Selecciona la imagen del producto";
                openFileDialog.Filter = "Archivos para imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string archivoSeleccionado = openFileDialog.FileName;

                    string carpetaDestino = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Ejercicio_2", "ImagenesProductos");

                    Directory.CreateDirectory(carpetaDestino);

                    string nombreArchivoDestino = Guid.NewGuid().ToString() + Path.GetExtension(archivoSeleccionado);

                    string rutaCompletaDestino = Path.Combine(carpetaDestino, nombreArchivoDestino);

                    try
                    {
                        File.Copy(archivoSeleccionado, rutaCompletaDestino);

                        tbxImagenPath.Text = rutaCompletaDestino;
                        tbxImagenPath.Enabled = !File.Exists(rutaCompletaDestino);

                        MessageBox.Show("Imagen guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al subir la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvProductos_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvProductos.SelectedRows[0];
            int posicion = dgvProductos.Rows.IndexOf(selected);
            editaIndice = posicion;
            Producto product = Productos[posicion];
            tbxNombre.Text = product.nombre;
            tbxDescripcion.Text = product.descripcion;
            tbxMarca.Text = product.marca;
            tbxImagenPath.Text = product.imagen;
            tbxPrecio.Text = Convert.ToString(product.precio);
            tbxStock.Text = Convert.ToString(product.stock);
        }
    }
}
