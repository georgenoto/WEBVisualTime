using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MUNICIPALITY;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MUNICIPALITYMappingExtensions
{
    public static MUNICIPALITYDto ToDto(this MUNICIPALITY entity)
    {
        if (entity == null) return null!;
        return new MUNICIPALITYDto
        {
            NMUNICIPALITY = entity.NMUNICIPALITY,
            NLOCAL = entity.NLOCAL,
            TAB_LOCATSDESCRIPT = entity.TAB_LOCAT?.SDESCRIPT,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static MUNICIPALITY ToEntity(this CreateMUNICIPALITYDto dto)
    {
        if (dto == null) return null!;
        return new MUNICIPALITY
        {
            NLOCAL = dto.NLOCAL,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this MUNICIPALITY entity, UpdateMUNICIPALITYDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NLOCAL = dto.NLOCAL;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
