using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE58;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE58MappingExtensions
{
    public static TABLE58Dto ToDto(this TABLE58 entity)
    {
        if (entity == null) return null!;
        return new TABLE58Dto
        {
            NTYPE_INDEX = entity.NTYPE_INDEX,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            SCOMMENTS = entity.SCOMMENTS,
        };
    }

    public static TABLE58 ToEntity(this CreateTABLE58Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE58
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            SCOMMENTS = dto.SCOMMENTS,
        };
    }

    public static void UpdateEntity(this TABLE58 entity, UpdateTABLE58Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCOMMENTS = dto.SCOMMENTS;
    }
}
