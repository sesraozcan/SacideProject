using SacideProject.Entity;
using System.Collections.Generic;

namespace SacideProject.WebUI.Models
{
    public class DanismanModel
    {
        public int DanismanID { get; set; }
        public string DanismanAd { get; set; }
        public string DanismanSoyad { get; set; }
        public List<Terapi> SelectedTerapi { get; set; }
    }
}
