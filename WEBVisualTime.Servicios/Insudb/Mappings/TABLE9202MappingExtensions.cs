using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9202;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9202MappingExtensions
{
    public static TABLE9202Dto ToDto(this TABLE9202 entity)
    {
        if (entity == null) return null!;
        return new TABLE9202Dto
        {
            NCATEGORY = entity.NCATEGORY,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NINTERM_TYP = entity.NINTERM_TYP,
        };
    }

    public static TABLE9202 ToEntity(this CreateTABLE9202Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9202
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NINTERM_TYP = dto.NINTERM_TYP,
        };
    }

    public static void UpdateEntity(this TABLE9202 entity, UpdateTABLE9202Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NINTERM_TYP = dto.NINTERM_TYP;
    }
}
