using SampleWebApi.Models;

namespace SampleWebApi.Services
{
    public class OfficeMapper : IOfficeMapper
    {
        public OfficeDto MapToDto(OfficeEntity houseEntity)
        {
            return new OfficeDto()
            {
                Id = houseEntity.Id,
                ZipCode = houseEntity.ZipCode,
                City = houseEntity.City,
                Street = houseEntity.Street
            };
        }

        public OfficeEntity MapToEntity(OfficeDto houseDto)
        {
            return new OfficeEntity()
            {
                Id = houseDto.Id,
                ZipCode = houseDto.ZipCode,
                City = houseDto.City,
                Street = houseDto.Street
            };
        }
    }
}