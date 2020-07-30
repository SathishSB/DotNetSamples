using System.Collections.Generic;
using System.Linq;
using SampleWebApi.Models;

namespace SampleWebApi.Repositories
{
    public class OfficeRepository : IOfficeRepository
    {
        readonly Dictionary<int, OfficeEntity> _houses = new Dictionary<int, OfficeEntity>();

        public OfficeRepository()
        {
            _houses.Add(1, new OfficeEntity() { City = "Town1", Id = 1, Street = "Street1", ZipCode = 1234 });
            _houses.Add(2, new OfficeEntity() { City = "Town2", Id = 2, Street = "Street2", ZipCode = 1234 });
            _houses.Add(3, new OfficeEntity() { City = "Town3", Id = 3, Street = "Street3", ZipCode = 1234 });
            _houses.Add(4, new OfficeEntity() { City = "Town4", Id = 4, Street = "Street4", ZipCode = 1234 });
        }

        public List<OfficeEntity> GetAll()
        {
            return _houses.Select(x => x.Value).ToList();
        }

        public OfficeEntity GetSingle(int id)
        {
            return _houses.FirstOrDefault(x => x.Key == id).Value;
        }

        public OfficeEntity Add(OfficeEntity toAdd)
        {
            int newId = !GetAll().Any() ? 1 : GetAll().Max(x => x.Id) + 1;
            toAdd.Id = newId;
            _houses.Add(newId, toAdd);
            return toAdd;
        }

        public OfficeEntity Update(OfficeEntity toUpdate)
        {
            OfficeEntity single = GetSingle(toUpdate.Id);

            if (single == null)
            {
                return null;
            }

            _houses[single.Id] = toUpdate;
            return toUpdate;
        }

        public void Delete(int id)
        {
            _houses.Remove(id);
        }
    }
}