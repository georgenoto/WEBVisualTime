using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE78109;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE78109MappingExtensions
{
    public static TABLE78109Dto ToDto(this TABLE78109 entity)
    {
        if (entity == null) return null!;
        return new TABLE78109Dto
        {
            NSOAP_VEHTYPE = entity.NSOAP_VEHTYPE,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            SAACHCODE = entity.SAACHCODE,
        };
    }

    public static TABLE78109 ToEntity(this CreateTABLE78109Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE78109
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            SAACHCODE = dto.SAACHCODE,
        };
    }

    public static void UpdateEntity(this TABLE78109 entity, UpdateTABLE78109Dto dto)
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
