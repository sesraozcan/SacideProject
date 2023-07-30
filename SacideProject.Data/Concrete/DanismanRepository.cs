using Microsoft.EntityFrameworkCore;
using SacideProject.Data.Abstract;
using SacideProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacideProject.Data.Concrete
{
    public class DanismanRepository : GenericRepository<Danisman, SacideProjectContext>, IDanismanRepository
    {
        public List<Danisman> GetListAll()
        {
            using (var context = new SacideProjectContext())
            {
                return context.Danismanlar.Include(y => y.Terapi).ToList();
            }
        }
    }
}
