using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YemekSepeti.Models
{
    public class Siparis
    {
        [Key]
        public int ID { get; set; }
        public string YemekAdi { get; set; }
        public string AraSicakAdi { get; set; }
        public string İcecekeler { get; set; }
        

    }
}