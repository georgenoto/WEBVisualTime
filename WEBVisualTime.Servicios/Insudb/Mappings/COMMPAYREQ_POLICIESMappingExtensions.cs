using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_POLICIES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COMMPAYREQ_POLICIESMappingExtensions
{
    public static COMMPAYREQ_POLICIESDto ToDto(this COMMPAYREQ_POLICIES entity)
    {
        if (entity == null) return null!;
        return new COMMPAYREQ_POLICIESDto
        {
            NID_COMMPAYREQ = entity.NID_COMMPAYREQ,
            COMMPAYMENTREQUESTSSCLIENAME_HOLDER = entity.COMMPAYMENTREQUESTS?.SCLIENAME_HOLDER,
            NCONSEC = entity.NCONSEC,
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
            NMODULEC = entity.NMODULEC,
            NGROUP_INSU = entity.NGROUP_INSU,
            SPOLITYPE = entity.SPOLITYPE,
            NIND_POLICY = entity.NIND_POLICY,
            NIND_CURRENT_POLICY = entity.NIND_CURRENT_POLICY,
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            NINTERTYP = entity.NINTERTYP,
            INTERM_TYPSDESCRIPT = entity.INTERM_TYP?.SDESCRIPT,
            SCLIENAME_INTERMEDIA = entity.SCLIENAME_INTERMEDIA,
            DSTARTDATE = entity.DSTARTDATE,
            DEXPIRDAT = entity.DEXPIRDAT,
            NCURRENCY = entity.NCURRENCY,
            TABLE11SDESCRIPT = entity.TABLE11?.SDESCRIPT,
            NCAPITAL = entity.NCAPITAL,
            NBALANCECAPITAL = entity.NBALANCECAPITAL,
            NBALANCEDEDUC = entity.NBALANCEDEDUC,
            NPREMIUM = entity.NPREMIUM,
            NPREMIUMN = entity.NPREMIUMN,
            NPREMIUMNPAID = entity.NPREMIUMNPAID,
            NCLAIMSAMOUNTBASE_SETT = entity.NCLAIMSAMOUNTBASE_SETT,
            NCLAIMSAMOUNTBASE_PEND = entity.NCLAIMSAMOUNTBASE_PEND,
            NRATECLAIMS = entity.NRATECLAIMS,
            NRATEPROFIT = entity.NRATEPROFIT,
            NRATEPROJECTED_CLAIMS = entity.NRATEPROJECTED_CLAIMS,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
        };
    }

    public static COMMPAYREQ_POLICIES ToEntity(this CreateCOMMPAYREQ_POLICIESDto dto)
    {
        if (dto == null) return null!;
        return new COMMPAYREQ_POLICIES
        {
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            NMODULEC = dto.NMODULEC,
            NGROUP_INSU = dto.NGROUP_INSU,
            SPOLITYPE = dto.SPOLITYPE,
            NIND_POLICY = dto.NIND_POLICY,
            NIND_CURRENT_POLICY = dto.NIND_CURRENT_POLICY,
            NINTERMED = dto.NINTERMED,
            NINTERTYP = dto.NINTERTYP,
            SCLIENAME_INTERMEDIA = dto.SCLIENAME_INTERMEDIA,
            DSTARTDATE = dto.DSTARTDATE,
            DEXPIRDAT = dto.DEXPIRDAT,
            NCURRENCY = dto.NCURRENCY,
            NCAPITAL = dto.NCAPITAL,
            NBALANCECAPITAL = dto.NBALANCECAPITAL,
            NBALANCEDEDUC = dto.NBALANCEDEDUC,
            NPREMIUM = dto.NPREMIUM,
            NPREMIUMN = dto.NPREMIUMN,
            NPREMIUMNPAID = dto.NPREMIUMNPAID,
            NCLAIMSAMOUNTBASE_SETT = dto.NCLAIMSAMOUNTBASE_SETT,
            NCLAIMSAMOUNTBASE_PEND = dto.NCLAIMSAMOUNTBASE_PEND,
            NRATECLAIMS = dto.NRATECLAIMS,
            NRATEPROFIT = dto.NRATEPROFIT,
            NRATEPROJECTED_CLAIMS = dto.NRATEPROJECTED_CLAIMS,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this COMMPAYREQ_POLICIES entity, UpdateCOMMPAYREQ_POLICIESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.NMODULEC = dto.NMODULEC;
        entity.NGROUP_INSU = dto.NGROUP_INSU;
        entity.SPOLITYPE = dto.SPOLITYPE;
        entity.NIND_POLICY = dto.NIND_POLICY;
        entity.NIND_CURRENT_POLICY = dto.NIND_CURRENT_POLICY;
        entity.NINTERMED = dto.NINTERMED;
        entity.NINTERTYP = dto.NINTERTYP;
        entity.SCLIENAME_INTERMEDIA = dto.SCLIENAME_INTERMEDIA;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NBALANCECAPITAL = dto.NBALANCECAPITAL;
        entity.NBALANCEDEDUC = dto.NBALANCEDEDUC;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NPREMIUMN = dto.NPREMIUMN;
        entity.NPREMIUMNPAID = dto.NPREMIUMNPAID;
        entity.NCLAIMSAMOUNTBASE_SETT = dto.NCLAIMSAMOUNTBASE_SETT;
        entity.NCLAIMSAMOUNTBASE_PEND = dto.NCLAIMSAMOUNTBASE_PEND;
        entity.NRATECLAIMS = dto.NRATECLAIMS;
        entity.NRATEPROFIT = dto.NRATEPROFIT;
        entity.NRATEPROJECTED_CLAIMS = dto.NRATEPROJECTED_CLAIMS;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
