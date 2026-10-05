using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE901;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE901MappingExtensions
{
    public static TABLE901Dto ToDto(this TABLE901 entity)
    {
        if (entity == null) return null!;
        return new TABLE901Dto
        {
            NCODIGINT = entity.NCODIGINT,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE901 ToEntity(this CreateTABLE901Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE901
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE901 entity, UpdateTABLE901Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
