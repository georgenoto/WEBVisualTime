using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8007;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE8007MappingExtensions
{
    public static TABLE8007Dto ToDto(this TABLE8007 entity)
    {
        if (entity == null) return null!;
        return new TABLE8007Dto
        {
            NAFECBASADI = entity.NAFECBASADI,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE8007 ToEntity(this CreateTABLE8007Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE8007
        {
            NAFECBASADI = dto.NAFECBASADI,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE8007 entity, UpdateTABLE8007Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAFECBASADI = dto.NAFECBASADI;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
