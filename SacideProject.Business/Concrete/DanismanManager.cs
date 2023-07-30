using SacideProject.Business.Abstract;
using SacideProject.Data.Abstract;
using SacideProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacideProject.Business.Concrete
{
    public class DanismanManager : IDanismanService
    {
        private IDanismanRepository _danismanRepository;

        public DanismanManager(IDanismanRepository danismanRepository)
        {
            _danismanRepository = danismanRepository;
        }
        public void Create(Danisman entity)
        {
            _danismanRepository.Create(entity);
        }

        public void Delete(Danisman entity)
        {
            _danismanRepository.Delete(entity);
        }

        public List<Danisman> GetAll()
        {
            return _danismanRepository.GetAll();
        }
        public List<Danisman> GetListAll()
        {
            return _danismanRepository.GetListAll();
        }

        public Danisman GetById(int id)
        {
            return _danismanRepository.GetById(id);
        }

        public void Update(Danisman entity)
        {
            _danismanRepository.Update(entity);
        }
    }
}
