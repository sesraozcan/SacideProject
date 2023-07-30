using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacideProject.Entity
{
    public class Danisman
    {
        public int DanismanID { get; set; }
        public string DanismanAd { get; set; }
        public string DanismanSoyad { get; set; }
        public int TerapiID { get; set; }
        public Terapi Terapi { get; set; }
    }
}
