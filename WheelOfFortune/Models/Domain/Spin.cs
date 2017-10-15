using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WheelOfFortune.Models.Domain;

namespace WheelOfFortune.Models
{
    public class Spin
    {
        public Spin()
        {
            WheelConfigurations = new List<WheelConfiguration>();
        }

        public int Id { get; set; }

        // User Bet Value
        [Required]
        public double BetValue { get; set; }

        // the result of the spin
        [Required]
        public double ScoreValue { get; set; }

        // The winning amount
        [Required]
        public double ResultValue { get; set; }

        [Required]
        public DateTime ExecutionDate { get; set; }

        [Required]
        public ICollection<WheelConfiguration> WheelConfigurations  { get; set; }

        public ApplicationUser User { get; set; }
      
    }
}