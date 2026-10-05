using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8006;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE8006MappingExtensions
{
    public static TABLE8006Dto ToDto(this TABLE8006 entity)
    {
        if (entity == null) return null!;
        return new TABLE8006Dto
        {
            NTYPEAFEC = entity.NTYPEAFEC,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE8006 ToEntity(this CreateTABLE8006Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE8006
        {
            NTYPEAFEC = dto.NTYPEAFEC,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE8006 entity, UpdateTABLE8006Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYPEAFEC = dto.NTYPEAFEC;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
