using System.Collections.Generic;
using System.Linq;
using GeekGirlsDemo.Business.Entities;
using GeekGirlsDemo.Business.Repositories;

namespace GeekGirlsDemo.Business.Services
{
    public class MagazineService : IMagazineService
    {
        private readonly MemoryMagazineRepository _repository = new MemoryMagazineRepository();

        public ICollection<Magazine> GetMagazinesByYear(int year)
        {
            return _repository.GetAll().Where(m => m.Year == year).ToList();
        }

        public void AddMagazine(Magazine magazine)
        {
            _repository.Add(magazine);
        }
    }
}
