using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Proyecto_Kevin_Alonso_Gestion_OC_DND
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(InicioBienbenida));

            t.Start();
            Thread.Sleep(500);

            InitializeComponent();

            t.Abort();

            this.personajeTableAdapter.Fill(this.llamada_de_cthulhuDataSet.personaje);
            numeroPersonajes.Text = "Hay " + personajeTableAdapter.numPerson() + " personajes creados";
        }

        /// <summary>
        /// Inicializa el splashScreen.
        /// </summary>
        public void InicioBienbenida()
        {
            Application.Run(new splashScreen());
        }

        /// <summary>
        /// Inicia el formulario que permite buscar y filtrar.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void personajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonajesDeCadaJugador basesdatos = new PersonajesDeCadaJugador();
            basesdatos.MdiParent = this;
            basesdatos.Show();
        }

        /// <summary>
        /// Invoca el metodo que crea el formulario par alos nuevos personajes.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void crearPersonajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearPersonaje();
        }

        /// <summary>
        /// Invoca el metodo que crea el formulario par alos nuevos personajes.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tsmNuevoPersonaje_Click(object sender, EventArgs e)
        {
            crearPersonaje();
        }


        /// <summary>
        /// Crea el formulario de creacion de personaje
        /// </summary>
        private void crearPersonaje()
        {
            Cthulhu cthulhu = new Cthulhu();
            cthulhu.MdiParent = this;
            cthulhu.Show();
        }


        /// <summary>
        /// Crea el formulario que contiene el informe de la hoja de personajes
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void verPersonajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerPersonaje verAlPersoje = new VerPersonaje();
            verAlPersoje.MdiParent = this;
            verAlPersoje.Show();
        }

        private void listaDePersonajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarPersonajes listaP = new EditarPersonajes();
            listaP.MdiParent = this;
            listaP.Show();
        }

        private void cerrarVentanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cantidad = MdiChildren.Length;
            for ( int i = 0; i <= cantidad-1;)
            {
                MdiChildren[0].Close();
                i++;
            }
        }

        private void informesConGraficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 listaP = new Form2();
            listaP.MdiParent = this;
            listaP.Show();
        }

        private void verticalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordenarVertical();
        }

        private void horizontalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ordenarHorizontal();
        }

        /// <summary>
        /// Ordena los Mdi hijos en vertical
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordenarVertical();
        }

        /// <summary>
        /// Ordena los Mdi hijos en horizontal
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordenarHorizontal();
        }


        /// <summary>
        /// Es el metodo al que se llama para ordenar los layauts de forma horizontal.
        /// </summary>
        private void ordenarHorizontal()
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }


        /// <summary>
        /// Es el metodo al que se llama para ordenar los layauts de forma vertical.
        /// </summary>
        private void ordenarVertical()
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void añadirArmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            añadirArma añadirarma = new añadirArma();
            añadirarma.MdiParent = this;
            añadirarma.Show();
        }
    }

}








