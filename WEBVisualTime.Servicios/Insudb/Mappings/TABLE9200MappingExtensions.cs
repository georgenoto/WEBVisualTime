using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9200;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9200MappingExtensions
{
    public static TABLE9200Dto ToDto(this TABLE9200 entity)
    {
        if (entity == null) return null!;
        return new TABLE9200Dto
        {
            NDATETYPE = entity.NDATETYPE,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TABLE9200 ToEntity(this CreateTABLE9200Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9200
        {
            NDATETYPE = dto.NDATETYPE,
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TABLE9200 entity, UpdateTABLE9200Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.NDATETYPE = dto.NDATETYPE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
