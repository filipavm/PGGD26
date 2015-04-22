using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using GeekGirlsDemo.Business;
using GeekGirlsDemo.Business.Entities;

namespace GeekGirlsDemo.AppWithSPA.Controllers
{
    public class MagazinesController : ApiController
    {
        public async Task<ICollection<Magazine>> GetMagazinesByYear(int year)
        {
            return await Task.Run(() => BusinessManager.MagazineService.GetMagazinesByYear(year));
        }

        public async Task AddMagazine(Magazine magazine)
        {
            await Task.Run(() => BusinessManager.MagazineService.AddMagazine(magazine));
        }
    }
}