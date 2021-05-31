﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.netAtelier_MVC_12.Models
{
    public class Chauffeur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Date_recrutement { get; set; }
        public decimal Salaire { get; set; }
    }
}