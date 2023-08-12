using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dom;
using negocio;

namespace frmPokemon
{
    public partial class frmPokemon : Form
    {
        private List<Pokemon> listaPokemon;
        public frmPokemon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.listar();
            dgvPokemon.DataSource = listaPokemon;
            dgvPokemon.Columns["UrlImagen"].Visible= false;

        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon selected = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            try
            {
                pbxPokemon.Load(selected.UrlImagen);
            }
            catch (Exception)
            {

                pbxPokemon.Load("https://w7.pngwing.com/pngs/785/530/png-transparent-desktop-computer-icons-empty-banner-angle-rectangle-photography-thumbnail.png");
            }
            
        }

        private void btnIngresarPokemon_Click(object sender, EventArgs e)
        {
            frmAltaPokemon alta = new frmAltaPokemon();
            alta.ShowDialog();
        }
    }
}
