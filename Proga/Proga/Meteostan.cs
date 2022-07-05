using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    [Table("Meteostans")]
    class Meteostan
    {
        [Key]
        public int id { get; set; }
        private string date;
        private string be, no, co, gotnia, sred;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Be
        {
            get { return be; }
            set { be = value; }
        }
        public string NO
        {
            get { return no; }
            set { no = value; }
        }
        public string CO
        {
            get { return co; }
            set { co = value; }
        }

        public string Gotnia
        {
            get { return gotnia; }
            set { gotnia = value; }
        }

        public string Sred
        {
            get { return sred; }
            set { sred = value; }
        }


        public Meteostan() { }
        public Meteostan(string date, string be, string no, string co, string gotnia, string sred )
        {
            this.date = date;
            this.be = be;
            this.no = no;
            this.co = co;
            this.gotnia = gotnia;
            this.sred = sred;
        }

    }
}
