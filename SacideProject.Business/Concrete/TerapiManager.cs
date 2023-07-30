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
    public class TerapiManager : ITerapiService
    {
        private ITerapiRepository _terapiRepository;

        public TerapiManager(ITerapiRepository terapiRepository)
        {
            _terapiRepository = terapiRepository;
        }
        public void Create(Terapi entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Terapi entity)
        {
            throw new NotImplementedException();
        }

        public List<Terapi> GetAll()
        {
            return _terapiRepository.GetAll();
        }

        public Terapi GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Terapi> GetListAll()
        {
            return _terapiRepository.GetListAll();
        }

        public void Update(Terapi entity)
        {
            throw new NotImplementedException();
        }
    }
}
