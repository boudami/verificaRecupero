using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scuolaVerifica
{
    internal class Alunno
    {
        string nome, cognome, cittaResidenza;
        int eta;

        public Alunno(string nome, string cognome, string cittaResidenza, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.cittaResidenza = cittaResidenza;
            this.eta = eta;
        }
        public string getNome() { return nome; }
        public string getCognome() { return cognome; }
        private object toString()
        {
            return getCognome;
        }
        private string categoria()
        {
            if (eta < 16)
            {
                return "biennio";
            }
            else return "triennio";
        }
    }
}
