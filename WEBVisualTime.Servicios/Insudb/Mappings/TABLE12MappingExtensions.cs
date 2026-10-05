using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE12;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TABLE12MappingExtensions
{
    public static TABLE12Dto ToDto(this TABLE12 entity)
    {
        if (entity == null) return null!;
        return new TABLE12Dto
        {
            NROLE = entity.NROLE,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NTABLE9269 = entity.NTABLE9269,
            TABLE9269SDESCRIPT = entity.TABLE9269?.SDESCRIPT,
        };
    }

    public static TABLE12 ToEntity(this CreateTABLE12Dto dto)
    {
        if (dto == null) return null!;
        return new TABLE12
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NTABLE9269 = dto.NTABLE9269,
        };
    }

    public static void UpdateEntity(this TABLE12 entity, UpdateTABLE12Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTABLE9269 = dto.NTABLE9269;
    }
}
