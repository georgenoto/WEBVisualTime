using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE160;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE160MappingExtensions
{
    public static TABLE160Dto ToDto(this TABLE160 entity)
    {
        if (entity == null) return null!;
        return new TABLE160Dto
        {
            NPAY_CONCEP = entity.NPAY_CONCEP,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NTABLE159 = entity.NTABLE159,
        };
    }

    public static TABLE160 ToEntity(this CreateTABLE160Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE160
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NTABLE159 = dto.NTABLE159,
        };
    }

    public static void UpdateEntity(this TABLE160 entity, UpdateTABLE160Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTABLE159 = dto.NTABLE159;
    }
}
