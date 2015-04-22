using System.Collections.Generic;
using GeekGirlsDemo.Business.Data;
using GeekGirlsDemo.Business.Entities;

namespace GeekGirlsDemo.Business.Repositories
{
    /// <summary>
    /// Basic Implementation
    /// </summary>
    public class MemoryMagazineRepository : IRepository<Magazine,int>
    {
        public static int ID = MagazineData.Magazines.Count;

        public IEnumerable<Magazine> GetAll()
        {
            return MagazineData.Magazines.Values;
        }

        public Magazine Get(int key)
        {
            return MagazineData.Magazines.ContainsKey(key) ? MagazineData.Magazines[key] : null;
        }

        public void Add(Magazine entity)
        {
            entity.Id = ID + 1;
            MagazineData.Magazines.Add(++ID, entity);
        }

        public void Update(Magazine entity)
        {
            if (MagazineData.Magazines.ContainsKey(entity.Id))
                MagazineData.Magazines[entity.Id] = entity;
        }

        public void Remove(int key)
        {
            if (MagazineData.Magazines.ContainsKey(key))
                MagazineData.Magazines.Remove(key);
        }
    }
}
