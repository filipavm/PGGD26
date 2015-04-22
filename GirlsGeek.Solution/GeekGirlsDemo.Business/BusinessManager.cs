using GeekGirlsDemo.Business.Services;

namespace GeekGirlsDemo.Business
{
    public class BusinessManager
    {

        #region Variables
        private static IMagazineService _magazineService;
        #endregion 


        #region Properties

        public static IMagazineService MagazineService
        {
            get { return _magazineService ?? (_magazineService = new MagazineService()); }
        }

        #endregion



    }
}
