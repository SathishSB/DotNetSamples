using SampleWebApi.Models;

namespace SampleWebApi.Services
{
    public interface IOfficeMapper
    {
        OfficeDto MapToDto(OfficeEntity houseEntity);
        OfficeEntity MapToEntity(OfficeDto houseDto);
    }
}