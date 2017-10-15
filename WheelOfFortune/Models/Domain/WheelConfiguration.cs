﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WheelOfFortune.Models.Domain
{
    public class WheelConfiguration
    {
        public WheelConfiguration()
        {
            Spins = new List<Spin>();
        }

        public int Id { get; set; }

        [Required]
        public double Propability { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public bool Win { get; set; }

        [Required]
        public string ResultText { get; set; }

        [Required]
        public double Score { get; set; }

        [Required]
        public ICollection<Spin> Spins { get; set; }


    }
}