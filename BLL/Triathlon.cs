using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Triathlon
    {
        private int idT;
        private string lieuT;
        private DateTime dateT;
        private string nomT;
        private int codeType;
        private string libelleType;

        public Triathlon(int idT, string lieuT, DateTime dateT, string nomT, int codeType, string libelleType)
        {
            this.idT = idT;
            this.lieuT = lieuT;
            this.dateT = dateT;
            this.nomT = nomT;
            this.codeType = codeType;
            this.libelleType = libelleType;
        }

        public int getIdT() { return idT; }
        public string getLieuT() { return lieuT; }
        public DateTime getDateT() { return dateT; }
        public string getNomT() { return nomT; }
        public int getCodeType() { return codeType; }
        public string getLibelleType() { return libelleType; }

    }
}
