using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace YemekSepeti.Models
{
    public class Context:DbContext
    {
        DbSet<Siparis> Anayemeks { get; set; }
        DbSet<Yemekler> Yemeklers { get; set; }
        DbSet<AraSicaklar> AraSicaklars { get; set; }
        DbSet<Icecekler> Iceceklers { get; set; }
        

    }
}