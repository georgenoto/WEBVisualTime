using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8205;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE8205MappingExtensions
{
    public static TABLE8205Dto ToDto(this TABLE8205 entity)
    {
        if (entity == null) return null!;
        return new TABLE8205Dto
        {
            NSECTION = entity.NSECTION,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TABLE8205 ToEntity(this CreateTABLE8205Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE8205
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TABLE8205 entity, UpdateTABLE8205Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
