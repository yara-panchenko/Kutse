﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Kutsee_Appp.Models
{
    public class Guest
    {
        [Required(ErrorMessage = "Sisesta nimi")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sisesta email")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Valesti sisestatud email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Sisesta telefoni number")]
        [RegularExpression(@"\+372.+", ErrorMessage = "Peal olema +372")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Sisesta oma valik")]

        public bool? WillAttend { get; set; }
    }
}