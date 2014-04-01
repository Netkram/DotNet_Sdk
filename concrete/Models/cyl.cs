using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace concrete.Models
{
    public partial class cyl
    {
        [Display(Name = "Lab No")]
        public string labnumber { get; set; }
        [Display(Name = "Set No")]
        public string setnumber { get; set; }
        [Display(Name = "Cyl No")]
        public string cylnumber { get; set; }
        [Display(Name = "Date Rec")]
        public Nullable<System.DateTime> datereclab { get; set; }
        [Display(Name = "Date Tst")]
        public Nullable<System.DateTime> datetested { get; set; }
        [Display(Name = "Cyl Wt")]
        public Nullable<double> cylwt { get; set; }
        [Display(Name = "Density")]
        public Nullable<int> cyldensity { get; set; }
        [Display(Name = "Strength")]
        public Nullable<double> strength { get; set; }
        [Display(Name = "Rems")]
        public string remarks { get; set; }
        public Nullable<int> number { get; set; }
        public int ID { get; set; }
    }
}
