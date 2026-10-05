using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9245;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9245MappingExtensions
{
    public static TABLE9245Dto ToDto(this TABLE9245 entity)
    {
        if (entity == null) return null!;
        return new TABLE9245Dto
        {
            NACTIONTYPE = entity.NACTIONTYPE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREG = entity.SSTATREG,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9245 ToEntity(this CreateTABLE9245Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9245
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREG = dto.SSTATREG,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9245 entity, UpdateTABLE9245Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREG = dto.SSTATREG;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
