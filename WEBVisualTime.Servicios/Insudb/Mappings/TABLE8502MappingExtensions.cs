using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8502;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE8502MappingExtensions
{
    public static TABLE8502Dto ToDto(this TABLE8502 entity)
    {
        if (entity == null) return null!;
        return new TABLE8502Dto
        {
            NTYPECALCULATEPREMSOAT = entity.NTYPECALCULATEPREMSOAT,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE8502 ToEntity(this CreateTABLE8502Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE8502
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE8502 entity, UpdateTABLE8502Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
