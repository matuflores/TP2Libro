using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2Libro.Entidades
{
    public class Libro:ICloneable
    {
        public string NombreLibro { get; set; }

        public EditorialDisponible EditorialDisponible { get; set; }

        public TemaDisponible TemaDisponible { get; set; }

        public int NumPaginas { get; set; }

        public string ISBN { get; set; }

        public string Autor { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override bool Equals(object obj)
        {
            if (obj==null || obj is Libro)
            {
                return false;
            }
            return this.ISBN == ((Libro)obj).ISBN;
        }
        public override int GetHashCode()
        {
            return ISBN.GetHashCode();
        }

        
    }
}
