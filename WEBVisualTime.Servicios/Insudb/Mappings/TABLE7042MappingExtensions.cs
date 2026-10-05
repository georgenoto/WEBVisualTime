using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7042;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE7042MappingExtensions
{
    public static TABLE7042Dto ToDto(this TABLE7042 entity)
    {
        if (entity == null) return null!;
        return new TABLE7042Dto
        {
            NVEHBRAND = entity.NVEHBRAND,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            SAACHCODE = entity.SAACHCODE,
        };
    }

    public static TABLE7042 ToEntity(this CreateTABLE7042Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE7042
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            SAACHCODE = dto.SAACHCODE,
        };
    }

    public static void UpdateEntity(this TABLE7042 entity, UpdateTABLE7042Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SAACHCODE = dto.SAACHCODE;
    }
}
