using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9266;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9266MappingExtensions
{
    public static TABLE9266Dto ToDto(this TABLE9266 entity)
    {
        if (entity == null) return null!;
        return new TABLE9266Dto
        {
            NMOVEMENT_TYPE = entity.NMOVEMENT_TYPE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9266 ToEntity(this CreateTABLE9266Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9266
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9266 entity, UpdateTABLE9266Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
