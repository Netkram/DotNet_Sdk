using System;
using System.Collections.Generic;

namespace concrete.Models
{
    public partial class TestSummary
    {
        public string projectnumber { get; set; }
        public string labnumber { get; set; }
        public Nullable<int> setnumber { get; set; }
        public Nullable<System.DateTime> datecast { get; set; }
        public Nullable<double> strength { get; set; }
        public Nullable<System.DateTime> datetested { get; set; }
        public Nullable<double> spec28dayst { get; set; }
        public int ID { get; set; }
    }
}
