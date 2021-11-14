using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2Libro.Datos;
using TP2Libro.Entidades;

namespace TP2Libro.Windows
{
    public partial class FrmListaLibros : Form
    {
        public FrmListaLibros()
        {
            InitializeComponent();
        }

        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private RepositorioDeLibros repositorio;
        private List<Libro> lista;
        private int cantidadDeRegistros;
        private void FrmListaLibros_Load(object sender, EventArgs e)
        {
            CargarDatosComboEditorial();
            CargarDatosComboTema();
            repositorio = new RepositorioDeLibros();
            cantidadDeRegistros = repositorio.GetCantidad();
            if (cantidadDeRegistros>0)
            {
                lista = repositorio.GetLista();
                MostrarDatosEnGrilla();
                ActualizarCantidadDeRegistros(repositorio.GetCantidad());
            }
        }

        private void CargarDatosComboTema()
        {
            var lista = Enum.GetValues(typeof(TemaDisponible)).Cast<TemaDisponible>().ToList();
            foreach (var libro in lista)
            {
                FiltroTemaToolStripComboBox.Items.Add(libro);
            }
        }

        private void CargarDatosComboEditorial()
        {
            var lista = Enum.GetValues(typeof(EditorialDisponible)).Cast<EditorialDisponible>().ToList();
            foreach (var libro in lista)
            {
                FiltroEditorialToolStripComboBox.Items.Add(libro);
            }
        }

        private void ActualizarCantidadDeRegistros(int cantidad)
        {
            ContadorRegistroLabel.Text = cantidad.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var libro in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, libro);
                AgregarFila(r);
                ActualizarCantidadDeRegistros(cantidadDeRegistros);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Libro libro)
        {
            r.Cells[colNombreLibro.Index].Value = libro.NombreLibro;
            r.Cells[colEditorial.Index].Value = libro.EditorialDisponible;
            r.Cells[colTema.Index].Value = libro.TemaDisponible;
            r.Cells[colCantidadDePaginas.Index].Value = libro.NumPaginas;
            r.Cells[colISBN.Index].Value = libro.ISBN;
            r.Cells[colAutor.Index].Value = libro.Autor;

            r.Tag = libro;
        }
        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FrmLibroEdit frm = new FrmLibroEdit() { Text = "Cargar nuevo Libro" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
            Libro libro = frm.GetLibro();
            if (repositorio.Existe(libro))
            {
                MessageBox.Show("Libro repetido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            repositorio.Agregar(libro);
            var r = ConstruirFila();
            SetearFila(r, libro);
            AgregarFila(r);
            MessageBox.Show("Libro Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarCantidadDeRegistros();
        }
        private void ActualizarCantidadDeRegistros()
        {
            ContadorRegistroLabel.Text = repositorio.GetCantidad().ToString();
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {


            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            Libro libro = (Libro)r.Tag;

            DialogResult dr = MessageBox.Show("¿Desea borrar el Libro seleccionado?", "Confirmar Baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                bool borrado = repositorio.Borrar(libro);
                borrado = true;
                if (borrado)
                {
                    DatosDataGridView.Rows.Remove(r);
                    ActualizarCantidadDeRegistros();
                    MessageBox.Show("Libro Borrado!!!", "Mennsaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo dar de baja el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }

        private void ActualizarToolStripButton_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetLista();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros(repositorio.GetCantidad());
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            Libro libro = (Libro)r.Tag;
            Libro copiaLibro = (Libro)libro.Clone();
            FrmLibroEdit frm = new FrmLibroEdit() { Text = "Edite el Libro" };
            frm.SetLibro(libro);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
            copiaLibro = frm.GetLibro();
            if (repositorio.Existe(copiaLibro))
            {
                MessageBox.Show("El libro ya esta guardado!!");
                return;
            }
            else
            {
                repositorio.Editar(libro, copiaLibro);
                SetearFila(r, copiaLibro);
                MessageBox.Show("Registro modificado!!");
            }

        }

        private void AscendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.OrdenAscendentePorPaginas();
            MostrarDatosEnGrilla();
        }

        private void DescendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.OrdenDescendentePorPaginas();
            MostrarDatosEnGrilla();
        }

        private void FiltroEditorialToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltroEditorialToolStripComboBox.SelectedIndex >=-1)
            {
                var index = FiltroEditorialToolStripComboBox.SelectedIndex;
                Func<Libro, bool> predicado = p => p.EditorialDisponible == (EditorialDisponible)index;
                lista = RepositorioDeLibros.GetInstancia().GetListaFiltrada(predicado);
                MostrarDatosEnGrilla();
                ActualizarCantidadDeRegistros(repositorio.GetCantidad(predicado));
            }
        }

        private void FiltroTemaToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltroTemaToolStripComboBox.SelectedIndex >= -1)
            {
                var index = FiltroTemaToolStripComboBox.SelectedIndex;
                Func<Libro, bool> predicado = p => p.TemaDisponible == (TemaDisponible)index;
                lista = RepositorioDeLibros.GetInstancia().GetListaFiltrada(predicado);
                MostrarDatosEnGrilla();
                ActualizarCantidadDeRegistros(repositorio.GetCantidad(predicado));
            }
        }
    }
}
