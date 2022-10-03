using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YemekSepeti.Models
{
    public class YemeklerViewModel
    {
        public int Id { get; set; }
        public string AnaYemekAdi { get; set; }
        public int Fiyati { get; set; }
    }
}