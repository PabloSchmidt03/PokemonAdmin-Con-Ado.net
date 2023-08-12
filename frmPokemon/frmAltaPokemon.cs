using dom;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPokemon
{
    public partial class frmAltaPokemon : Form
    {
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Pokemon nuevo = new Pokemon();
                nuevo.Numero = int.Parse(txtNumero.Text);
                nuevo.Nombre = txbNombre.Text;
                nuevo.Descripcion = txbDescripcion.Text;
                nuevo.Elemento = (Tipo)cbxTipo.SelectedItem;
                nuevo.Debilidad = (Tipo)cbxDebilidad.SelectedItem;
                nuevo.UrlImagen = txbUrl.Text;


                //necesito mandarlo a la db
                PokemonNegocio nego = new PokemonNegocio();
                nego.Agregar(nuevo);



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio nego = new ElementoNegocio();
            try
            {
                cbxDebilidad.DataSource = nego.listar();
                cbxTipo.DataSource = nego.listar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txbUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txbUrl.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemonCarga.Load(imagen);
            }
            catch (Exception)
            {

                pbxPokemonCarga.Load("https://w7.pngwing.com/pngs/785/530/png-transparent-desktop-computer-icons-empty-banner-angle-rectangle-photography-thumbnail.png");
            }
        }
    }
}
