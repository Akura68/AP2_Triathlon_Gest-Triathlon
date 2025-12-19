using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Triathlon
    {
        private int id;
        private string nom;
        private string lieu;
        private DateTime date_;
        private int code;

        public Triathlon(int id, string nom, string lieu, DateTime date_, int code)
        {
            this.id = id;
            this.nom = nom;
            this.lieu = lieu;
            this.date_ = date_;
            this.code = code;
        }

        public int getId() { return id; }
        public string getNom() { return nom; }
        public string getLieu() { return lieu; }
        public DateTime getDate() { return date_; }
        public int getCode() { return code; }

    }
}
