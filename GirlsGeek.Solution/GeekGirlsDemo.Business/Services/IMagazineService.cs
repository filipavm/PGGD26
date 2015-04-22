using System.Collections.Generic;
using GeekGirlsDemo.Business.Entities;

namespace GeekGirlsDemo.Business.Services
{
    public interface IMagazineService
    {
        ICollection<Magazine> GetMagazinesByYear(int year);

        void AddMagazine(Magazine magazine);
    }
}
