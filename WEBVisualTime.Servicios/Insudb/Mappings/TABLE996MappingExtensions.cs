using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE996;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE996MappingExtensions
{
    public static TABLE996Dto ToDto(this TABLE996 entity)
    {
        if (entity == null) return null!;
        return new TABLE996Dto
        {
            NSECUR_CIA = entity.NSECUR_CIA,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE996 ToEntity(this CreateTABLE996Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE996
        {
            NSECUR_CIA = dto.NSECUR_CIA,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE996 entity, UpdateTABLE996Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.NSECUR_CIA = dto.NSECUR_CIA;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
