using SacideProject.Data.Abstract;
using SacideProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacideProject.Data.Concrete
{
    public class TerapiRepository : GenericRepository<Terapi, SacideProjectContext>, ITerapiRepository
    {
        public List<Terapi> GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
