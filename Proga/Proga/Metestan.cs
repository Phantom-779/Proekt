using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Metestan
    {
        private int id { get; set; }
        private string date;
        private float Be, NO, CO, Gotnia, sred;

        public Metestan() { }
        public Metestan(string date, float Be, float NO, float CO, float Gotnia, float sred )
        {
            this.date = date;
            this.Be = Be;
            this.NO = NO;
            this.CO = CO;
            this.Gotnia = Gotnia;
            this.sred = sred;
        }

    }
}
