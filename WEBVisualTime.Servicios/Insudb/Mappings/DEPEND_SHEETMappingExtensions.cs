using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DEPEND_SHEET;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DEPEND_SHEETMappingExtensions
{
    public static DEPEND_SHEETDto ToDto(this DEPEND_SHEET entity)
    {
        if (entity == null) return null!;
        return new DEPEND_SHEETDto
        {
            NSHEET_FATHER = entity.NSHEET_FATHER,
            NSHEET_CHILD = entity.NSHEET_CHILD,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static DEPEND_SHEET ToEntity(this CreateDEPEND_SHEETDto dto)
    {
        if (dto == null) return null!;
        return new DEPEND_SHEET
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this DEPEND_SHEET entity, UpdateDEPEND_SHEETDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
