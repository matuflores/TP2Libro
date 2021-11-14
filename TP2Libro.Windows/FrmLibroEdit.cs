using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2Libro.Entidades;

namespace TP2Libro.Windows
{
    public partial class FrmLibroEdit : Form
    {
        public FrmLibroEdit()
        {
            InitializeComponent();
        }

        private Libro libro;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboEditorial(ref EditorialComboBox);
            CargarDatosComboTema(ref TemaComboBox);
            if(libro!=null)
            {
                NombreTextBox.Text = libro.NombreLibro.ToString();
                EditorialComboBox.SelectedItem = libro.EditorialDisponible;
                TemaComboBox.SelectedItem = libro.TemaDisponible;
                PaginasTextBox.Text = libro.NumPaginas.ToString();
                ISBNTextBox.Text = libro.ISBN.ToString();
                AutorTextBox.Text = libro.Autor.ToString();
            }
        }

        private void CargarDatosComboEditorial(ref ComboBox editorial)
        {
            editorial.DataSource = Enum.GetValues(typeof(EditorialDisponible));
        }

        private void CargarDatosComboTema(ref ComboBox tema)
        {
            tema.DataSource = Enum.GetValues(typeof(TemaDisponible));
        }

        internal Libro GetLibro()
        {
            return libro;
        }

        private void FrmLibroEdit_Load(object sender, EventArgs e)
        {

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            
            if (ValidarDatos())
            {
                if (libro==null)
                {
                    libro = new Libro();
                }
                libro = new Libro();
                libro.NombreLibro = NombreTextBox.Text;
                libro.EditorialDisponible = ((EditorialDisponible)EditorialComboBox.SelectedItem);
                libro.TemaDisponible = ((TemaDisponible)TemaComboBox.SelectedItem);
                libro.NumPaginas = int.Parse(PaginasTextBox.Text);
                libro.ISBN =ISBNTextBox.Text;
                libro.Autor = AutorTextBox.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            string numeros = "0123456789";
            for (int i = 0; i < ISBNTextBox.Text.Length; i++)
            {
                if (!(numeros.Contains(ISBNTextBox.Text[i].ToString())))
                {
                    valido = false;
                    errorProvider1.SetError(ISBNTextBox, "ISBN no valido");
                    ISBNTextBox.Focus();
                }
            }
            if (!int.TryParse(PaginasTextBox.Text, out int NumPaginas) || int.Parse(PaginasTextBox.Text)<=0)
            {
                valido = false;
                errorProvider1.SetError(PaginasTextBox, "Numero de Paginas incorrecto");
                PaginasTextBox.Focus();
                
            }
            
            if (ISBNTextBox.Text.Length<13)
            {
                valido = false;
                errorProvider1.SetError(ISBNTextBox, "El ISBN debe contener 13 numeros");
                ISBNTextBox.Focus();
            }
            
            return valido;
        }

        public void SetLibro(Libro libro)
        {
            this.libro = libro;
        }
    }
}
