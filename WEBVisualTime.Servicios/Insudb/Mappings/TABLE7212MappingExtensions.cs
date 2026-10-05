using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7212;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE7212MappingExtensions
{
    public static TABLE7212Dto ToDto(this TABLE7212 entity)
    {
        if (entity == null) return null!;
        return new TABLE7212Dto
        {
            NTYPE = entity.NTYPE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TABLE7212 ToEntity(this CreateTABLE7212Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE7212
        {
            NTYPE = dto.NTYPE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TABLE7212 entity, UpdateTABLE7212Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYPE = dto.NTYPE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
