using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5708;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5708MappingExtensions
{
    public static TABLE5708Dto ToDto(this TABLE5708 entity)
    {
        if (entity == null) return null!;
        return new TABLE5708Dto
        {
            NTYPE_MOVE = entity.NTYPE_MOVE,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NTYPE = entity.NTYPE,
            SPB_BMG = entity.SPB_BMG,
            NLOAD_TYPE = entity.NLOAD_TYPE,
        };
    }

    public static TABLE5708 ToEntity(this CreateTABLE5708Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5708
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NTYPE = dto.NTYPE,
            SPB_BMG = dto.SPB_BMG,
            NLOAD_TYPE = dto.NLOAD_TYPE,
        };
    }

    public static void UpdateEntity(this TABLE5708 entity, UpdateTABLE5708Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTYPE = dto.NTYPE;
        entity.SPB_BMG = dto.SPB_BMG;
        entity.NLOAD_TYPE = dto.NLOAD_TYPE;
    }
}
