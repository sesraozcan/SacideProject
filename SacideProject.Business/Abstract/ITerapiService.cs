using SacideProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacideProject.Business.Abstract
{
    public interface ITerapiService
    {
        Terapi GetById(int id);
        List<Terapi> GetAll();
        List<Terapi> GetListAll();
        void Create(Terapi entity);
        void Update(Terapi entity);
        void Delete(Terapi entity);
    }
}
