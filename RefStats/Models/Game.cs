using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RefStats.Models
{
    public class Game
    {


        public int Id { get; set; }

        public DateTime GameDate { get; set; }
        public DayOfWeek GameDay { get; set; }
        public ListOfSeries Series { get; set; }
        public ListOfGameTime GameTime { get; set; }

        public string Arena { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public ListOfFees Fee1 { get; set; }
        public ListOfFees Fee2 { get; set; }


        public enum ListOfSeries
        {
            [Display(Name = "Välj Serie")]
            Ingen,
            U11,
            U12,
            U13,
            U14,
            U15,
            U16,
            J18,
            J20,
            REC,
            DREC,
            VETERAN,
            [Display(Name = "Flickor A")]
            FlickorA,
        }
        public enum ListOfGameTime
        {
            [Display(Name = "Välj speltid")]
            Ingen,
            [Display(Name = "2X15min")]
            Match_2x15,
            [Display(Name = "2X20min")]
            Match_2X20,
            [Display(Name = "3X20min")]
            Match_3X20,
            [Display(Name = "10min")]
            Match_10,
        }
        public enum ListOfFees
        {
            [Display(Name = "Välj ersättning")]
            Ingen,
            [Display(Name = "43kr")]
            U11_1x10,
            [Display(Name = "130kr")]
            U11_2x15,
            [Display(Name = "210kr")]
            U11_2x151D,
            [Display(Name = "185kr")]
            U12_2x20,
            [Display(Name = "330kr")]
            DREC_2x20,
            [Display(Name = "495kr")]
            DREC1Ref_2x20,
            [Display(Name = "55kr")]
            PZU14_10,
            [Display(Name = "435kr")]
            FA_2x20,
            [Display(Name = "450kr")]
            REC,
            [Display(Name = "675kr")]
            REC1D,

        }
        public enum DayOfWeek
        {
            [Display(Name = "Välj veckodag")]
            Ingen,
            Mån,
            Tis,
            Ons,
            Tor,
            Fre,
            Lör,
            Sön,
        }

    }
}
