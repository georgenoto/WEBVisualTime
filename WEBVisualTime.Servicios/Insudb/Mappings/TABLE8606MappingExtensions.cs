using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8606;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE8606MappingExtensions
{
    public static TABLE8606Dto ToDto(this TABLE8606 entity)
    {
        if (entity == null) return null!;
        return new TABLE8606Dto
        {
            NTYPE_GROUP = entity.NTYPE_GROUP,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE8606 ToEntity(this CreateTABLE8606Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE8606
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE8606 entity, UpdateTABLE8606Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
