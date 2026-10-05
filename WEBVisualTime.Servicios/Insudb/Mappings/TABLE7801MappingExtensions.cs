using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7801;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE7801MappingExtensions
{
    public static TABLE7801Dto ToDto(this TABLE7801 entity)
    {
        if (entity == null) return null!;
        return new TABLE7801Dto
        {
            NPAYMENTADDRESS = entity.NPAYMENTADDRESS,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE7801 ToEntity(this CreateTABLE7801Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE7801
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE7801 entity, UpdateTABLE7801Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
