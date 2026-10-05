using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9300;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9300MappingExtensions
{
    public static TABLE9300Dto ToDto(this TABLE9300 entity)
    {
        if (entity == null) return null!;
        return new TABLE9300Dto
        {
            NPROMISSORYNOTE = entity.NPROMISSORYNOTE,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9300 ToEntity(this CreateTABLE9300Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9300
        {
            NPROMISSORYNOTE = dto.NPROMISSORYNOTE,
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9300 entity, UpdateTABLE9300Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.NPROMISSORYNOTE = dto.NPROMISSORYNOTE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
