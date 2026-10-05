using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8018;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE8018MappingExtensions
{
    public static TABLE8018Dto ToDto(this TABLE8018 entity)
    {
        if (entity == null) return null!;
        return new TABLE8018Dto
        {
            NNOTINFORMEMAIL = entity.NNOTINFORMEMAIL,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE8018 ToEntity(this CreateTABLE8018Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE8018
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE8018 entity, UpdateTABLE8018Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
