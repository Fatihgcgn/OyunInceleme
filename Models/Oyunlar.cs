using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Oyunlar
    {
        public int Numara {get; set;}
        public string OyunAd { get; set; }
        public string OyunKategori { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
    
    
        public Oyunlar(int numara,string oyunAd,string oyunKategori,string image,string url)
        {
            this.Numara=numara;
            this.OyunAd=oyunAd;
            this.OyunKategori=oyunKategori;
            this.Image=image;
            this.Url=url;

        }
    
    
    
    
    }
    
}