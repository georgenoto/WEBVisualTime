using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE15;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE15MappingExtensions
{
    public static TABLE15Dto ToDto(this TABLE15 entity)
    {
        if (entity == null) return null!;
        return new TABLE15Dto
        {
            NRELASHIP = entity.NRELASHIP,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE15 ToEntity(this CreateTABLE15Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE15
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE15 entity, UpdateTABLE15Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
