using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5517;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5517MappingExtensions
{
    public static TABLE5517Dto ToDto(this TABLE5517 entity)
    {
        if (entity == null) return null!;
        return new TABLE5517Dto
        {
            NTYPLOAN_MOV = entity.NTYPLOAN_MOV,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5517 ToEntity(this CreateTABLE5517Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5517
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5517 entity, UpdateTABLE5517Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
