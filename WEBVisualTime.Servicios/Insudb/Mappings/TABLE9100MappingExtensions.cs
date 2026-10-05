using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9100;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9100MappingExtensions
{
    public static TABLE9100Dto ToDto(this TABLE9100 entity)
    {
        if (entity == null) return null!;
        return new TABLE9100Dto
        {
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NSHIPUSE = entity.NSHIPUSE,
        };
    }

    public static TABLE9100 ToEntity(this CreateTABLE9100Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9100
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9100 entity, UpdateTABLE9100Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
