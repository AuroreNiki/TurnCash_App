using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnCash_App.Entites
{
    internal class PretEntity
    {
        public int Id_pret { get; set; }
        public double montant;

        public PretEntity(int id_pret, double montant)
        {
            Id_pret = id_pret;
            this.montant = montant;
        }
    }
}
