using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TOBLIGREIN;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TOBLIGREINMappingExtensions
{
    public static TOBLIGREINDto ToDto(this TOBLIGREIN entity)
    {
        if (entity == null) return null!;
        return new TOBLIGREINDto
        {
            NBRANCH = entity.NBRANCH,
            NBRANCH_REI = entity.NBRANCH_REI,
            SBUSSITYP = entity.SBUSSITYP,
            NCED_AMNT = entity.NCED_AMNT,
            NCED_PER = entity.NCED_PER,
            NCESS_CONC = entity.NCESS_CONC,
            NCESS_TYPE = entity.NCESS_TYPE,
            NCLAIM = entity.NCLAIM,
            NCOMPANY = entity.NCOMPANY,
            DCOMPDATE = entity.DCOMPDATE,
            NCURRENCY = entity.NCURRENCY,
            NPOLICY = entity.NPOLICY,
            NNUMBER = entity.NNUMBER,
            DINIT_DATE = entity.DINIT_DATE,
            DEND_DATE = entity.DEND_DATE,
            NINDIC_TR = entity.NINDIC_TR,
            NYEAR_SER_POL = entity.NYEAR_SER_POL,
            NTYPE = entity.NTYPE,
            NCAPITAL = entity.NCAPITAL,
            NSHARE = entity.NSHARE,
            NCOMMISSION = entity.NCOMMISSION,
            NCONCEPT = entity.NCONCEPT,
            NINTER_RATE = entity.NINTER_RATE,
            NTYPE_CESSI = entity.NTYPE_CESSI,
            NPREMIUM = entity.NPREMIUM,
            NRESER_PREM = entity.NRESER_PREM,
            DEFFECDATE = entity.DEFFECDATE,
            DEXPIRDAT = entity.DEXPIRDAT,
            NTYPE_REI = entity.NTYPE_REI,
            NYEAR_CONTR = entity.NYEAR_CONTR,
            SKEY = entity.SKEY,
        };
    }

    public static TOBLIGREIN ToEntity(this CreateTOBLIGREINDto dto)
    {
        if (dto == null) return null!;
        return new TOBLIGREIN
        {
            NBRANCH = dto.NBRANCH,
            NBRANCH_REI = dto.NBRANCH_REI,
            SBUSSITYP = dto.SBUSSITYP,
            NCED_AMNT = dto.NCED_AMNT,
            NCED_PER = dto.NCED_PER,
            NCESS_CONC = dto.NCESS_CONC,
            NCESS_TYPE = dto.NCESS_TYPE,
            NCLAIM = dto.NCLAIM,
            NCOMPANY = dto.NCOMPANY,
            DCOMPDATE = dto.DCOMPDATE,
            NCURRENCY = dto.NCURRENCY,
            NPOLICY = dto.NPOLICY,
            NNUMBER = dto.NNUMBER,
            DINIT_DATE = dto.DINIT_DATE,
            DEND_DATE = dto.DEND_DATE,
            NINDIC_TR = dto.NINDIC_TR,
            NYEAR_SER_POL = dto.NYEAR_SER_POL,
            NTYPE = dto.NTYPE,
            NCAPITAL = dto.NCAPITAL,
            NSHARE = dto.NSHARE,
            NCOMMISSION = dto.NCOMMISSION,
            NCONCEPT = dto.NCONCEPT,
            NINTER_RATE = dto.NINTER_RATE,
            NTYPE_CESSI = dto.NTYPE_CESSI,
            NPREMIUM = dto.NPREMIUM,
            NRESER_PREM = dto.NRESER_PREM,
            DEFFECDATE = dto.DEFFECDATE,
            DEXPIRDAT = dto.DEXPIRDAT,
            NTYPE_REI = dto.NTYPE_REI,
            NYEAR_CONTR = dto.NYEAR_CONTR,
            SKEY = dto.SKEY,
        };
    }

    public static void UpdateEntity(this TOBLIGREIN entity, UpdateTOBLIGREINDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NBRANCH = dto.NBRANCH;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.SBUSSITYP = dto.SBUSSITYP;
        entity.NCED_AMNT = dto.NCED_AMNT;
        entity.NCED_PER = dto.NCED_PER;
        entity.NCESS_CONC = dto.NCESS_CONC;
        entity.NCESS_TYPE = dto.NCESS_TYPE;
        entity.NCLAIM = dto.NCLAIM;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NPOLICY = dto.NPOLICY;
        entity.NNUMBER = dto.NNUMBER;
        entity.DINIT_DATE = dto.DINIT_DATE;
        entity.DEND_DATE = dto.DEND_DATE;
        entity.NINDIC_TR = dto.NINDIC_TR;
        entity.NYEAR_SER_POL = dto.NYEAR_SER_POL;
        entity.NTYPE = dto.NTYPE;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NSHARE = dto.NSHARE;
        entity.NCOMMISSION = dto.NCOMMISSION;
        entity.NCONCEPT = dto.NCONCEPT;
        entity.NINTER_RATE = dto.NINTER_RATE;
        entity.NTYPE_CESSI = dto.NTYPE_CESSI;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NRESER_PREM = dto.NRESER_PREM;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.NTYPE_REI = dto.NTYPE_REI;
        entity.NYEAR_CONTR = dto.NYEAR_CONTR;
        entity.SKEY = dto.SKEY;
    }
}
