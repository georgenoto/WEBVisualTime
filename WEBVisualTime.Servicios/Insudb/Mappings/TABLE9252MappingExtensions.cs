using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9252;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9252MappingExtensions
{
    public static TABLE9252Dto ToDto(this TABLE9252 entity)
    {
        if (entity == null) return null!;
        return new TABLE9252Dto
        {
            NPAYMENT_METHOD = entity.NPAYMENT_METHOD,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9252 ToEntity(this CreateTABLE9252Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9252
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9252 entity, UpdateTABLE9252Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
