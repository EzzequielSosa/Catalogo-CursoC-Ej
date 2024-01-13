using Conexion_DB;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticulosTecnologia
{
    public partial class AltaArticulo : Form
    {
        private Articulos articulo = null;

        public AltaArticulo()
        {
            InitializeComponent();
        }

        public AltaArticulo(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
            
        }

        public void cargarImagenAlta(string imagen)
        {
            try
            {
                pictureBox1.Load(imagen);
            }
            catch (Exception )
            {
                pictureBox1.Load("https://wpdirecto.com/wp-content/uploads/2017/08/alt-de-una-imagen.png");

            }
        }

        private void AltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            comboBoxCategoria.DataSource = categoriaNegocio.listar();
            comboMarca.DataSource = marcaNegocio.listar();

           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_conectar conexion = new DB_conectar();
          
            
            try
            {



                if (articulo == null)
                {
                    articulo = new Articulos();
                }


                articulo.Codigo = textBoxCodigo.Text;
                articulo.Nombre = textBoxNombre.Text;
                articulo.Imagenurl = textBoxImagenUrl.Text;
                articulo.Descripcion = textBoxDescripcion.Text;
                articulo.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                articulo.Marca = (Marca)comboMarca.SelectedItem;

                articulo.Precio = decimal.Parse(textBoxPrecio.Text);
               // articulo.Descri = (Categoria)comboBoxCategoria.SelectedItem;
               // articulo.Marca = (Marca)comboMarca.SelectedItem;
              


                if (articulo.Id != 0)
                {
                    conexion.modificar(articulo);
                    MessageBox.Show("Modificado Correctamente");
                }
                else
                {
                    conexion.agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente");
                    Close();
                }

               
                Close();
 
             }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagenAlta(textBoxImagenUrl.Text);
        }
    }
}
