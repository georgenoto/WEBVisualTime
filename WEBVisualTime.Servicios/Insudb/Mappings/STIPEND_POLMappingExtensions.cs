using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.STIPEND_POL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class STIPEND_POLMappingExtensions
{
    public static STIPEND_POLDto ToDto(this STIPEND_POL entity)
    {
        if (entity == null) return null!;
        return new STIPEND_POLDto
        {
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            NROLE = entity.NROLE,
            SCLIENT = entity.SCLIENT,
            NTYPE_CONTRAT = entity.NTYPE_CONTRAT,
            DEFFECDATE = entity.DEFFECDATE,
            NUSERCODE = entity.NUSERCODE,
            SCOMMITYP = entity.SCOMMITYP,
            TABLE47SDESCRIPT = entity.TABLE47?.SDESCRIPT,
            NCONTRAT_PAY = entity.NCONTRAT_PAY,
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            NAMOUNT = entity.NAMOUNT,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NPERCENT = entity.NPERCENT,
            NSHARE = entity.NSHARE,
        };
    }

    public static STIPEND_POL ToEntity(this CreateSTIPEND_POLDto dto)
    {
        if (dto == null) return null!;
        return new STIPEND_POL
        {
            NUSERCODE = dto.NUSERCODE,
            SCOMMITYP = dto.SCOMMITYP,
            NCONTRAT_PAY = dto.NCONTRAT_PAY,
            NINTERMED = dto.NINTERMED,
            NAMOUNT = dto.NAMOUNT,
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NPERCENT = dto.NPERCENT,
            NSHARE = dto.NSHARE,
        };
    }

    public static void UpdateEntity(this STIPEND_POL entity, UpdateSTIPEND_POLDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCOMMITYP = dto.SCOMMITYP;
        entity.NCONTRAT_PAY = dto.NCONTRAT_PAY;
        entity.NINTERMED = dto.NINTERMED;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NPERCENT = dto.NPERCENT;
        entity.NSHARE = dto.NSHARE;
    }
}
