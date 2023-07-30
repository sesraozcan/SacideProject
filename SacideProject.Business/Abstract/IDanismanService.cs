using SacideProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacideProject.Business.Abstract
{
    public interface IDanismanService
    {
        Danisman GetById(int id);
        List<Danisman> GetAll();
        List<Danisman> GetListAll();
        void Create(Danisman entity);
        void Update(Danisman entity);
        void Delete(Danisman entity);
    }
}
