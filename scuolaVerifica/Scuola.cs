using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scuolaVerifica
{
    internal class Scuola
    {
        string nome, indirizzo;
        int orarioApertura, orarioChiusura;

        public Scuola(string nome, string indirizzo, int orarioChiusura, int orarioApertura)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.orarioChiusura = orarioChiusura;
            this.orarioApertura = orarioApertura;
        }
        private string aggiuntaAlunno(string aggiuntaAlunno)
        {
            return nome+ aggiuntaAlunno;
        }
    }
}
