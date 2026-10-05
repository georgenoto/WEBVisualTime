using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8603;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE8603MappingExtensions
{
    public static TABLE8603Dto ToDto(this TABLE8603 entity)
    {
        if (entity == null) return null!;
        return new TABLE8603Dto
        {
            SMEDSPECIALIALTY = entity.SMEDSPECIALIALTY,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE8603 ToEntity(this CreateTABLE8603Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE8603
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE8603 entity, UpdateTABLE8603Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
