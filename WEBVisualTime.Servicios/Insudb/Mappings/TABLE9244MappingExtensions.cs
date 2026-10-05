using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9244;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9244MappingExtensions
{
    public static TABLE9244Dto ToDto(this TABLE9244 entity)
    {
        if (entity == null) return null!;
        return new TABLE9244Dto
        {
            NACTIONCLAIM = entity.NACTIONCLAIM,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREG = entity.SSTATREG,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9244 ToEntity(this CreateTABLE9244Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9244
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREG = dto.SSTATREG,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9244 entity, UpdateTABLE9244Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREG = dto.SSTATREG;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
