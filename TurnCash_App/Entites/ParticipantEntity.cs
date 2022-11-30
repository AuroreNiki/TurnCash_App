using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnCash_App.Entites
{
    internal class ParticipantEntity
    {
        public int id_participant;
        public string nom_participant;
        public string email;
        public string phone;

        public ParticipantEntity(int id_participant, string nom_participant, string email, string phone)
        {
            this.id_participant = id_participant;
            this.nom_participant = nom_participant;
            this.email = email;
            this.phone = phone;
        }
    }
}
