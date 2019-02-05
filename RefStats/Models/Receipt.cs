using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RefStats.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        public int Receipt_Id { get; set; }
        public int MatchNumber { get; set; }
        public DateTime MatchDate { get; set; }
        public string Match { get; set; }
                          
        [Display(Name = "HD")]
        public string MatchRef1 { get; set; }
        [Display(Name = "Arvode")]
        [DataType(DataType.Currency)]
        public float FeeRef1 { get; set; }
        [Display(Name = "Traktamente")]
        [DataType(DataType.Currency)]
        public float AllowanceRef1 { get; set; }
        [Display(Name = "Resekostnad")]
        [DataType(DataType.Currency)]
        public float TravelCostRef1 { get; set; }
        [Display(Name = "Att betala")]
        [DataType(DataType.Currency)]
        public float TotalRef1 { get => FeeRef1 + AllowanceRef1 + TravelCostRef1; }

        [Display(Name = "HD")]
        public string MatchRef2 { get; set; }
        [Display(Name = "Arvode")]
        [DataType(DataType.Currency)]
        public float FeeRef2 { get; set; }
        [Display(Name = "Traktamente")]
        [DataType(DataType.Currency)]
        public float AllowanceRef2 { get; set; }
        [Display(Name = "Resekostnad")]
        [DataType(DataType.Currency)]
        public float TravelCostRef2 { get; set; }
        [Display(Name = "Att betala")]
        [DataType(DataType.Currency)]
        public float TotalRef2 { get => FeeRef2 + AllowanceRef2 + TravelCostRef2; }

        [Display(Name = "LD")]
        public string MatchRef3 { get; set; }
        [Display(Name = "Arvode")]
        [DataType(DataType.Currency)]
        public float FeeRef3 { get; set; }
        [Display(Name = "Traktamente")]
        [DataType(DataType.Currency)]
        public float AllowanceRef3 { get; set; }
        [Display(Name = "Resekostnad")]
        [DataType(DataType.Currency)]
        public float TravelCostRef3 { get; set; }
        [Display(Name = "Att betala")]
        [DataType(DataType.Currency)]
        public float TotalRef3 { get => FeeRef3 + AllowanceRef3 + TravelCostRef3; }

        [Display(Name ="LD")]
        public string MatchRef4 { get; set; }
        [Display(Name = "Arvode")]
        [DataType(DataType.Currency)]
        public float FeeRef4 { get; set; }
        [Display(Name = "Traktamente")]
        [DataType(DataType.Currency)]
        public float AllowanceRef4 { get; set; }
        [Display(Name = "Resekostnad")]
        [DataType(DataType.Currency)]
        public float TravelCostRef4 { get; set; }
        [Display(Name = "Att betala")]
        [DataType(DataType.Currency)]
        public float TotalRef4 { get => FeeRef4 + AllowanceRef4 + TravelCostRef4; }

    }
}
