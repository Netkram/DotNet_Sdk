using System;
using System.Collections.Generic;

namespace concrete.Models
{
    public partial class CYL_LOAD_DIA
    {
        public string LABNUMBER { get; set; }
        public Nullable<System.DateTime> TESTDATE { get; set; }
        public string LOAD_KN { get; set; }
        public string LOAD_P { get; set; }
        public string DIAMETER { get; set; }
        public Nullable<decimal> STRENGTH { get; set; }
        public int ID { get; set; }
    }
}
