using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LogicadeNegocio.EntidadesNegocio
{
    public class Pais
    {
        public string _nombre { get; set; }
        public int _codigo { get; set; }
        public int _pbi { get; set; }
        public int _poblacion { get; set; }
        public string _imagen { get; set; }
        public Region _region { get; set; }

        
        public override bool Equals(object obj)
        {
            bool noExiste = false;
            if (obj != null && obj is Pais)
            {
                noExiste = this._codigo == ((Pais)obj)._codigo;
            }

            return noExiste;
        }

        public bool Equals([AllowNull] Pais other)
        {
            return this._codigo == other._codigo;
        }
    }
}
