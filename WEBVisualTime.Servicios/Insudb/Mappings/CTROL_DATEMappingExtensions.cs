using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CTROL_DATE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CTROL_DATEMappingExtensions
{
    public static CTROL_DATEDto ToDto(this CTROL_DATE entity)
    {
        if (entity == null) return null!;
        return new CTROL_DATEDto
        {
            NTYPE_PROCE = entity.NTYPE_PROCE,
            TABLE526SDESCRIPT = entity.TABLE526?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            DNEXTDATEPROC = entity.DNEXTDATEPROC,
        };
    }

    public static CTROL_DATE ToEntity(this CreateCTROL_DATEDto dto)
    {
        if (dto == null) return null!;
        return new CTROL_DATE
        {
            DEFFECDATE = dto.DEFFECDATE,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            DNEXTDATEPROC = dto.DNEXTDATEPROC,
        };
    }

    public static void UpdateEntity(this CTROL_DATE entity, UpdateCTROL_DATEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNEXTDATEPROC = dto.DNEXTDATEPROC;
    }
}
