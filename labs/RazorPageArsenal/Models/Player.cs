using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPageArsenal.Models
{
    public class Player
    {
        public int ID { get; set; }
        [Display(Name="Player Name")]
        public string PlayerName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        
        public string Position { get; set; }

        [DisplayFormat(DataFormatString = "{0:#}")]
        [Display(Name = "Market Value (in £)")]
        public decimal MarketValue { get; set; }
    }
}
