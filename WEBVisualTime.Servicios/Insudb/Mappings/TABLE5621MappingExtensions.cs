using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5621;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE5621MappingExtensions
{
    public static TABLE5621Dto ToDto(this TABLE5621 entity)
    {
        if (entity == null) return null!;
        return new TABLE5621Dto
        {
            NTODAYSDEPOSIT = entity.NTODAYSDEPOSIT,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE5621 ToEntity(this CreateTABLE5621Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE5621
        {
            NTODAYSDEPOSIT = dto.NTODAYSDEPOSIT,
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE5621 entity, UpdateTABLE5621Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTODAYSDEPOSIT = dto.NTODAYSDEPOSIT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
