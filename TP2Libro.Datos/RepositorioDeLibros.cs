using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2Libro.Entidades;
using System.IO;

namespace TP2Libro.Datos
{
    public class RepositorioDeLibros
    {
        private List<Libro> listaLibros;

        private readonly string _archivo = Environment.CurrentDirectory + @"\Libros.txt";
        private readonly string _archivoBak = Environment.CurrentDirectory + @"\Libros.bak";

        public static RepositorioDeLibros instancia = null;

        public static RepositorioDeLibros GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new RepositorioDeLibros();
            }
            return instancia;
        }
        public RepositorioDeLibros()
        {
            listaLibros = new List<Libro>();
            listaLibros = LeerDatosDelArchivo();
        }

        

        private List<Libro> LeerDatosDelArchivo()
        {
            List<Libro> lista = new List<Libro>();
            if (File.Exists(_archivo))
            {
                StreamReader lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    Libro libro = ConstruirLibro(linea);
                    lista.Add(libro);
                }
                lector.Close();
            }

            return lista;
        }

        private Libro ConstruirLibro(string linea)
        {
            var campos = linea.Split('|');
            return new Libro()
            {
                NombreLibro = campos[0],
                EditorialDisponible = (EditorialDisponible)int.Parse(campos[1]),
                TemaDisponible = (TemaDisponible)int.Parse(campos[2]),
                NumPaginas = int.Parse(campos[3]),
                ISBN = campos[4],
                Autor=campos[5]
            };
        }

        public void Agregar(Libro libro)
        {
            listaLibros.Add(libro);
            AgregarEnArchivo(libro);
        }

        private void AgregarEnArchivo(Libro libro)
        {
            StreamWriter escritor = new StreamWriter(_archivo, true);
            string linea = ConstruirLinea(libro);
            escritor.WriteLine(linea);
            escritor.Close();
            
        }

        private string ConstruirLinea(Libro libro)
        {
            return $"{libro.NombreLibro}|{libro.EditorialDisponible.GetHashCode()}|{libro.TemaDisponible.GetHashCode()}|{libro.NumPaginas}|{libro.ISBN}|{libro.Autor}";
        }

        public void Editar(Libro libroBuscado, Libro copiaLibro)
        {
            EditarRegistroEnArchivo(libroBuscado, copiaLibro);
            int index = listaLibros.IndexOf(libroBuscado)+1;
            listaLibros.RemoveAt(index);
            listaLibros.Insert(index, copiaLibro);
        }

        private void EditarRegistroEnArchivo(Libro libroBuscado, Libro copiaLibro)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                var libroEnArchivo = ConstruirLibro(linea);
                if (libroEnArchivo.Equals(libroBuscado))
                {
                    linea = ConstruirLinea(copiaLibro);
                }
                escritor.WriteLine(linea);
            }
            escritor.Close();
            lector.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);
        }

        public bool Borrar(Libro libro)
        {
            BorrarDelArchivo(libro);
            return listaLibros.Remove(libro);

        }

        private void BorrarDelArchivo(Libro libro)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Libro libroEnArchivo = ConstruirLibro(linea);
                if (!libroEnArchivo.Equals(libro))
                {
                    escritor.WriteLine(linea);
                }
            }
            lector.Close();
            escritor.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);
        }

        public int GetCantidad()
        {
            return listaLibros.Count;
        }

        public List<Libro> GetLista()
        {
            return listaLibros;
        }

        
        public bool Existe(Libro libro)
        {
            return listaLibros.Contains(libro);
        }

        public List<Libro> OrdenAscendentePorPaginas()
        {
            return listaLibros.OrderBy(r => r.NumPaginas).ToList();
        }

        public List<Libro> OrdenDescendentePorPaginas()
        {
            return listaLibros.OrderByDescending(r => r.NumPaginas).ToList();
        }

        public List<Libro> GetListaFiltrada(Func<Libro, bool> predicado)
        {
            return listaLibros.Where(predicado).ToList();
        }

        public int GetCantidad(Func<Libro, bool> index)
        {
            return listaLibros.Count(index);
        }
    }
}
