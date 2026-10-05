using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INQUIRY_AS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class INQUIRY_ASMappingExtensions
{
    public static INQUIRY_ASDto ToDto(this INQUIRY_AS entity)
    {
        if (entity == null) return null!;
        return new INQUIRY_ASDto
        {
            NKEYNUM = entity.NKEYNUM,
            TABLE1014SDESCRIPT = entity.TABLE1014?.SDESCRIPT,
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static INQUIRY_AS ToEntity(this CreateINQUIRY_ASDto dto)
    {
        if (dto == null) return null!;
        return new INQUIRY_AS
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this INQUIRY_AS entity, UpdateINQUIRY_ASDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
