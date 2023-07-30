using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacideProject.Entity
{
    public class Terapi
    {
        public int TerapiID { get; set; }
        public string TerapiAd { get; set;}
        public string TerapiSayisi { get; set; }
        public List<Danisman> Danismanlar { get; set; }
    }
}
