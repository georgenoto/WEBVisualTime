using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7200;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE7200MappingExtensions
{
    public static TABLE7200Dto ToDto(this TABLE7200 entity)
    {
        if (entity == null) return null!;
        return new TABLE7200Dto
        {
            NCODIGINT = entity.NCODIGINT,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE7200 ToEntity(this CreateTABLE7200Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE7200
        {
            NCODIGINT = dto.NCODIGINT,
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE7200 entity, UpdateTABLE7200Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCODIGINT = dto.NCODIGINT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
