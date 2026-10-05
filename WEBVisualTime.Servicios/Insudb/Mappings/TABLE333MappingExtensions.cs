using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE333;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE333MappingExtensions
{
    public static TABLE333Dto ToDto(this TABLE333 entity)
    {
        if (entity == null) return null!;
        return new TABLE333Dto
        {
            NTYPE_MOVE = entity.NTYPE_MOVE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static TABLE333 ToEntity(this CreateTABLE333Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE333
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this TABLE333 entity, UpdateTABLE333Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
