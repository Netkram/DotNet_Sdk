using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace concrete.Models
{
    public partial class carddata
    {
        [Display(Name = "Lab No")]
        public string labnumber { get; set; }
        [Display(Name = "Set No")]
        public int setnumber { get; set; }
        [Display(Name = "Date Cast")]
        public System.DateTime datecast { get; set; }
        public double spec28dayst { get; set; }
        [Display(Name = "Contractor")]
        public string contractor { get; set; }
        [Display(Name = "Proj No")]
        public string projectnumber { get; set; }
        [Display(Name = "Location On Structure")]
        public string locationonst { get; set; }
        [Display(Name = "Concrete Suplier")]
        public string concsupplier { get; set; }
        [Display(Name = "Time Mix Charged")]
        public string timemixercharged { get; set; }
        [Display(Name = "Type Of Mould")]
        public string typeofmould { get; set; }
        [Display(Name = "Temp Of Concrete")]
        public string tempofconc { get; set; }
        [Display(Name = "Specified Air")]
        public string specifiedair { get; set; }
        [Display(Name = "Water Added On Job")]
        public string wateraoj { get; set; }
        [Display(Name = "Truck No")]
        public string trucknumber { get; set; }
        [Display(Name = "Normal Size Of Aggregate(mm)")]
        public string nominalsizeofaggregate { get; set; }
        [Display(Name = "Type Of Admixture")]
        public string typeofadmixer { get; set; }
        [Display(Name = "Type Of Cement")]
        public string typeofcement { get; set; }
        [Display(Name = "OF")]
        public string of { get; set; }
        [Display(Name = "Time Cyl Cast")]
        public string timecylscast { get; set; }
        public string slump { get; set; }
        [Display(Name = "Air Temperature(Deg)")]
        public string airtemp { get; set; }
        public string air { get; set; }
        [Display(Name = "By What Authority")]
        public string byauth { get; set; }
        [Display(Name = "Load Number")]
        public string loadnumber { get; set; }
        public string drumctrevs { get; set; }
        [Display(Name = "Air Entraining Agent")]
        public string airentagent { get; set; }
        [Display(Name = "Initial 24HR curing Temp(deg,c) Max")]
        public string inicurtempmax { get; set; }
        [Display(Name = "Min")]
        public string inicurtempmin { get; set; }
        [Display(Name = "Project Code")]
        public string productcode { get; set; }
        public string labremarks { get; set; }
        [Display(Name = "Cylinders Cast By")]
        public string cylscastby { get; set; }
        public string costsheet { get; set; }
        [Display(Name = "Project")]
        public string project { get; set; }
        [Display(Name = "Size")]
        public Nullable<double> sizeofmould { get; set; } 
        [Display(Name = "Specified Slump")]
        public string specifiedslump { get; set; }
        [Display(Name = "Project Location")]
        public string prjlocation { get; set; }
        public int ID { get; set; }

        protected virtual void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<carddata>();
        }

    }
}
