using System.Collections.Generic;
using SampleWebApi.Models;

namespace SampleWebApi.Repositories
{
    public interface IOfficeRepository
    {
        List<OfficeEntity> GetAll();
        OfficeEntity GetSingle(int id);
        OfficeEntity Add(OfficeEntity toAdd);
        OfficeEntity Update(OfficeEntity toUpdate);
        void Delete(int id);
    }
}
