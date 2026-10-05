using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERM_TYP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class INTERM_TYPMappingExtensions
{
    public static INTERM_TYPDto ToDto(this INTERM_TYP entity)
    {
        if (entity == null) return null!;
        return new INTERM_TYPDto
        {
            NINTERTYP = entity.NINTERTYP,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SPARTICIN = entity.SPARTICIN,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NTYP_ACCO = entity.NTYP_ACCO,
            TABLE400SDESCRIPT = entity.TABLE400?.SDESCRIPT,
            SIND_FECU = entity.SIND_FECU,
            SGEN_CERTIF = entity.SGEN_CERTIF,
            NRECEPTYP = entity.NRECEPTYP,
        };
    }

    public static INTERM_TYP ToEntity(this CreateINTERM_TYPDto dto)
    {
        if (dto == null) return null!;
        return new INTERM_TYP
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SPARTICIN = dto.SPARTICIN,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NTYP_ACCO = dto.NTYP_ACCO,
            SIND_FECU = dto.SIND_FECU,
            SGEN_CERTIF = dto.SGEN_CERTIF,
            NRECEPTYP = dto.NRECEPTYP,
        };
    }

    public static void UpdateEntity(this INTERM_TYP entity, UpdateINTERM_TYPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SPARTICIN = dto.SPARTICIN;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTYP_ACCO = dto.NTYP_ACCO;
        entity.SIND_FECU = dto.SIND_FECU;
        entity.SGEN_CERTIF = dto.SGEN_CERTIF;
        entity.NRECEPTYP = dto.NRECEPTYP;
    }
}
