using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE226;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE226MappingExtensions
{
    public static TABLE226Dto ToDto(this TABLE226 entity)
    {
        if (entity == null) return null!;
        return new TABLE226Dto
        {
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            NVEHTYPE = entity.NVEHTYPE,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SAACHCODE = entity.SAACHCODE,
        };
    }

    public static TABLE226 ToEntity(this CreateTABLE226Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE226
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SAACHCODE = dto.SAACHCODE,
        };
    }

    public static void UpdateEntity(this TABLE226 entity, UpdateTABLE226Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SAACHCODE = dto.SAACHCODE;
    }
}
