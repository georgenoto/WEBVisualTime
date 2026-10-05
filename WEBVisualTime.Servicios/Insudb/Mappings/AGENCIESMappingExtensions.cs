using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.AGENCIES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class AGENCIESMappingExtensions
{
    public static AGENCIESDto ToDto(this AGENCIES entity)
    {
        if (entity == null) return null!;
        return new AGENCIESDto
        {
            NAGENCY = entity.NAGENCY,
            TABLE5555SDESCRIPT = entity.TABLE5555?.SDESCRIPT,
            NOFFICEAGEN = entity.NOFFICEAGEN,
            TABLE5556SDESCRIPT = entity.TABLE5556?.SDESCRIPT,
            NBRAN_OFF = entity.NBRAN_OFF,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            SPAY = entity.SPAY,
        };
    }

    public static AGENCIES ToEntity(this CreateAGENCIESDto dto)
    {
        if (dto == null) return null!;
        return new AGENCIES
        {
            NOFFICEAGEN = dto.NOFFICEAGEN,
            NBRAN_OFF = dto.NBRAN_OFF,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            SPAY = dto.SPAY,
        };
    }

    public static void UpdateEntity(this AGENCIES entity, UpdateAGENCIESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NOFFICEAGEN = dto.NOFFICEAGEN;
        entity.NBRAN_OFF = dto.NBRAN_OFF;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SPAY = dto.SPAY;
    }
}
