using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9005;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9005MappingExtensions
{
    public static TABLE9005Dto ToDto(this TABLE9005 entity)
    {
        if (entity == null) return null!;
        return new TABLE9005Dto
        {
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NBUSINESSTY = entity.NBUSINESSTY,
        };
    }

    public static TABLE9005 ToEntity(this CreateTABLE9005Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9005
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9005 entity, UpdateTABLE9005Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
