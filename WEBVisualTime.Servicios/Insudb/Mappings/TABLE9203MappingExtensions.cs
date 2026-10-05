using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9203;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE9203MappingExtensions
{
    public static TABLE9203Dto ToDto(this TABLE9203 entity)
    {
        if (entity == null) return null!;
        return new TABLE9203Dto
        {
            NTYPELIST = entity.NTYPELIST,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NTABLE9204 = entity.NTABLE9204,
        };
    }

    public static TABLE9203 ToEntity(this CreateTABLE9203Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE9203
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NTABLE9204 = dto.NTABLE9204,
        };
    }

    public static void UpdateEntity(this TABLE9203 entity, UpdateTABLE9203Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTABLE9204 = dto.NTABLE9204;
    }
}
