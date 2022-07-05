using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    [Table("Svods")]
    class Svod
    {
        public int id { get; set; }
        private string date;
        private string startDate { get; set; }
        private string endDate { get; set; }
        private int kollDays { get; set; }
        private string temperaturnK { get; set; }
        private int obNaSvazi { get; set; }
        private int obSNeystoikoi { get; set; }
        private string planoviyNaVse { get; set; }
        private string planoviyZaOtvalivchihsa { get; set; }
        private string neystoika { get; set; }
        private string viruchka { get; set; }
        private string factPlan { get; set; }
        private string dinamicFactPlan { get; set; }
        private string planoviyIspolnitelu { get; set; }
        private string facticheskiyIspolnitelu { get; set; }
        private string speedOtDinamiki { get; set; }
        private string planYplataIspITOG { get; set; }
        private string factYplataIspITOG { get; set; }
        private string neystoikaITOG { get; set; }
        private string viruchkaItog { get; set; }
        private int prognozITOG { get; set; }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public int KollDays
        {
            get { return kollDays; }
            set { kollDays = value; }
        }

        public string TemperaturnK
        {
            get { return temperaturnK; }
            set { temperaturnK = value; }
        }

        public int ObNaSvazi
        {
            get { return obNaSvazi; }
            set { obNaSvazi = value; }
        }

        public int ObSNeystoikoi
        {
            get { return obSNeystoikoi; }
            set { obSNeystoikoi = value; }
        }

        public string PlanoviyNaVse
        {
            get { return planoviyNaVse; }
            set { planoviyNaVse = value; }
        }

        public string PlanoviyZaOtvalivchihsa
        {
            get { return planoviyZaOtvalivchihsa; }
            set { planoviyZaOtvalivchihsa = value; }
        }

        public string Neystoika
        {
            get { return neystoika; }
            set { neystoika = value; }
        }

        public string Viruchka
        {
            get { return viruchka; }
            set { viruchka = value; }
        }

        public string FactPlan
        {
            get { return factPlan; }
            set { factPlan = value; }
        }

        public string DinamicFactPlan
        {
            get { return dinamicFactPlan; }
            set { dinamicFactPlan = value; }
        }

        public string PlanoviyIspolnitelu
        {
            get { return planoviyIspolnitelu; }
            set { planoviyIspolnitelu = value; }
        }

        public string FacticheskiyIspolnitelu
        {
            get { return facticheskiyIspolnitelu; }
            set { facticheskiyIspolnitelu = value; }
        }

        public string SpeedOtDinamiki
        {
            get { return speedOtDinamiki; }
            set { speedOtDinamiki = value; }
        }

        public string PlanYplataIspITOG
        {
            get { return planYplataIspITOG; }
            set { planYplataIspITOG = value; }
        }

        public string FactYplataIspITOG
        {
            get { return factYplataIspITOG; }
            set { factYplataIspITOG = value; }
        }

        public string NeystoikaITOG
        {
            get { return neystoikaITOG; }
            set { neystoikaITOG = value; }
        }

        public string ViruchkaItog
        {
            get { return viruchkaItog; }
            set { viruchkaItog = value; }
        }

        

        public Svod() { }
    }
}
