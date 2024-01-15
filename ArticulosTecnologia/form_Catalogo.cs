using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominio;
using Conexion_DB;


namespace ArticulosTecnologia
{
    public partial class form_Catalogo : Form
    {
        private List<Articulos> listaArticulos;
            
        public form_Catalogo()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            DB_conectar negocio = new DB_conectar();
            try
            {
                listaArticulos = negocio.Listar(); 
                dataGridViewListaArticulos.DataSource = listaArticulos;
                ocultarColumna();
                cargarImagen(listaArticulos[0].Imagenurl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void form_Catalogo_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a la APP!!");
            cargar();
       
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxCatalogo.Load(imagen);
            }
            catch (Exception)
            {
                pictureBoxCatalogo.Load("https://wpdirecto.com/wp-content/uploads/2017/08/alt-de-una-imagen.png");

            }
        }
        private void dataGridViewListaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewListaArticulos.CurrentRow != null)
                {
                    Articulos seleccionado = (Articulos)dataGridViewListaArticulos.CurrentRow.DataBoundItem;
                    cargarImagen(seleccionado.Imagenurl);
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }



        }


        private void dataGridViewListaArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonVerLista_Click(object sender, EventArgs e)
        {
            
            
                

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AltaArticulo ventana = new AltaArticulo();
            ventana.ShowDialog();
            cargar();

        }
        private void ocultarColumna()
        {
            dataGridViewListaArticulos.Columns["ImagenUrl"].Visible = false;
            dataGridViewListaArticulos.Columns["Id"].Visible = false;
            dataGridViewListaArticulos.Columns["IdMarca"].Visible=false;
            dataGridViewListaArticulos.Columns["IdCategoria"].Visible = false;

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dataGridViewListaArticulos.CurrentRow.DataBoundItem;

            AltaArticulo  modificar = new AltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();

        }

        private void buttonEliminarFisico_Click(object sender, EventArgs e)
        {
            DB_conectar conexion = new DB_conectar();
            Articulos seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dataGridViewListaArticulos.CurrentRow.DataBoundItem;
                    conexion.eliminar(seleccionado.Id);
                    MessageBox.Show("Eliminado Exitosamente");
                    cargar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void button1Filtro_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;
            string filtro = textBoxFiltro.Text;

            if (filtro.Length >=3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dataGridViewListaArticulos.DataSource = null;
            dataGridViewListaArticulos.DataSource = listaFiltrada;
            ocultarColumna();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    
    
}
