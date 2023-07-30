using SacideProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacideProject.Data.Abstract
{
    public interface ITerapiRepository : IRepository<Terapi>
    {
        List<Terapi> GetListAll();
    }
}
