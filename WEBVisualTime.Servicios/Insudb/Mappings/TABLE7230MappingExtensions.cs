using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7230;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE7230MappingExtensions
{
    public static TABLE7230Dto ToDto(this TABLE7230 entity)
    {
        if (entity == null) return null!;
        return new TABLE7230Dto
        {
            NDEDUCTIBLE_MET = entity.NDEDUCTIBLE_MET,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSTATREGT = entity.SSTATREGT,
        };
    }

    public static TABLE7230 ToEntity(this CreateTABLE7230Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE7230
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
        };
    }

    public static void UpdateEntity(this TABLE7230 entity, UpdateTABLE7230Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
    }
}
