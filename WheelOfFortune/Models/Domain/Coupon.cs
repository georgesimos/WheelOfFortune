﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WheelOfFortune.Models.Domain
{
    public class Coupon
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        public int Value { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public DateTime DateExpired { get; set; }


        [Required]
        public bool Active { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

    }
}