using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeros.Models
{
    public class SuperHero
    {
        [Key]
        public int Id { get; set; } 

        public string Name { get; set; }

        public string AlterEgo { get; set; }

        public string SuperPowerOne { get; set; }
        
        public string SuperPowerTwo { get; set; }
        
        public string CatchPhrase { get; set; }
    }
}