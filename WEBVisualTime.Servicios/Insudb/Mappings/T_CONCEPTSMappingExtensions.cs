using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_CONCEPTS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class T_CONCEPTSMappingExtensions
{
    public static T_CONCEPTSDto ToDto(this T_CONCEPTS entity)
    {
        if (entity == null) return null!;
        return new T_CONCEPTSDto
        {
            NBORDEREAUX = entity.NBORDEREAUX,
            SSEL = entity.SSEL,
            NTRANSAC = entity.NTRANSAC,
            NCONCEPT = entity.NCONCEPT,
            CASH_CONCEPTSNCONCEPTSSTATREGT = entity.CASH_CONCEPTSNCONCEPT?.SSTATREGT,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPROPONUM = entity.NPROPONUM,
            NCERTIF = entity.NCERTIF,
            SCLIENT = entity.SCLIENT,
            NORICURR = entity.NORICURR,
            TABLE11NORICURRSDESCRIPT = entity.TABLE11NORICURR?.SDESCRIPT,
            NORIAMOUNT = entity.NORIAMOUNT,
            NCURRENCY = entity.NCURRENCY,
            TABLE11NCURRENCYSDESCRIPT = entity.TABLE11NCURRENCY?.SDESCRIPT,
            NAMOUNT = entity.NAMOUNT,
            NEXCHANGE = entity.NEXCHANGE,
            DVALDATE = entity.DVALDATE,
            NCHANGESDAT = entity.NCHANGESDAT,
            TABLE5642SDESCRIPT = entity.TABLE5642?.SDESCRIPT,
            NCLAIM = entity.NCLAIM,
            NCASE_NUM = entity.NCASE_NUM,
            NBANK_CODE = entity.NBANK_CODE,
            BANK_AGREENBANK_CODESFORMAT = entity.BANK_AGREENBANK_CODE?.SFORMAT,
            NBANK_AGREE = entity.NBANK_AGREE,
            NAGREEMENT = entity.NAGREEMENT,
            NNOTENUM = entity.NNOTENUM,
            NSUPORT_ID = entity.NSUPORT_ID,
            NTYPESUPPORT = entity.NTYPESUPPORT,
            TABLE5570SDESCRIPT = entity.TABLE5570?.SDESCRIPT,
            DCOLLECTION = entity.DCOLLECTION,
            SACTION = entity.SACTION,
            NCASH_ID = entity.NCASH_ID,
            NMOV_TYPE = entity.NMOV_TYPE,
            NTYP_ACCO = entity.NTYP_ACCO,
            NINTERMED = entity.NINTERMED,
            NCOMPANY = entity.NCOMPANY,
            CASH_CONCEPTSNCOMPANYSSTATREGT = entity.CASH_CONCEPTSNCOMPANY?.SSTATREGT,
            STYPE_BANKAGREE = entity.STYPE_BANKAGREE,
            BANK_AGREESTYPE_BANKAGREESFORMAT = entity.BANK_AGREESTYPE_BANKAGREE?.SFORMAT,
            NACCOUNT = entity.NACCOUNT,
            BANK_AGREENACCOUNTSFORMAT = entity.BANK_AGREENACCOUNT?.SFORMAT,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            NBULLETINS = entity.NBULLETINS,
            NLOAN = entity.NLOAN,
            NAMOUNTDEC = entity.NAMOUNTDEC,
            NLOANS = entity.NLOANS,
            NPOLICY = entity.NPOLICY,
            NREQUEST_NU = entity.NREQUEST_NU,
            NBORDEREAUXUSED = entity.NBORDEREAUXUSED,
        };
    }

    public static T_CONCEPTS ToEntity(this CreateT_CONCEPTSDto dto)
    {
        if (dto == null) return null!;
        return new T_CONCEPTS
        {
            SSEL = dto.SSEL,
            NCONCEPT = dto.NCONCEPT,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPROPONUM = dto.NPROPONUM,
            NCERTIF = dto.NCERTIF,
            SCLIENT = dto.SCLIENT,
            NORICURR = dto.NORICURR,
            NORIAMOUNT = dto.NORIAMOUNT,
            NCURRENCY = dto.NCURRENCY,
            NAMOUNT = dto.NAMOUNT,
            NEXCHANGE = dto.NEXCHANGE,
            DVALDATE = dto.DVALDATE,
            NCHANGESDAT = dto.NCHANGESDAT,
            NCLAIM = dto.NCLAIM,
            NCASE_NUM = dto.NCASE_NUM,
            NBANK_CODE = dto.NBANK_CODE,
            NBANK_AGREE = dto.NBANK_AGREE,
            NAGREEMENT = dto.NAGREEMENT,
            NNOTENUM = dto.NNOTENUM,
            NSUPORT_ID = dto.NSUPORT_ID,
            NTYPESUPPORT = dto.NTYPESUPPORT,
            DCOLLECTION = dto.DCOLLECTION,
            SACTION = dto.SACTION,
            NCASH_ID = dto.NCASH_ID,
            NMOV_TYPE = dto.NMOV_TYPE,
            NTYP_ACCO = dto.NTYP_ACCO,
            NINTERMED = dto.NINTERMED,
            NCOMPANY = dto.NCOMPANY,
            STYPE_BANKAGREE = dto.STYPE_BANKAGREE,
            NACCOUNT = dto.NACCOUNT,
            NDEMAN_TYPE = dto.NDEMAN_TYPE,
            NBULLETINS = dto.NBULLETINS,
            NLOAN = dto.NLOAN,
            NAMOUNTDEC = dto.NAMOUNTDEC,
            NLOANS = dto.NLOANS,
            NPOLICY = dto.NPOLICY,
            NREQUEST_NU = dto.NREQUEST_NU,
            NBORDEREAUXUSED = dto.NBORDEREAUXUSED,
        };
    }

    public static void UpdateEntity(this T_CONCEPTS entity, UpdateT_CONCEPTSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SSEL = dto.SSEL;
        entity.NCONCEPT = dto.NCONCEPT;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPROPONUM = dto.NPROPONUM;
        entity.NCERTIF = dto.NCERTIF;
        entity.SCLIENT = dto.SCLIENT;
        entity.NORICURR = dto.NORICURR;
        entity.NORIAMOUNT = dto.NORIAMOUNT;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.DVALDATE = dto.DVALDATE;
        entity.NCHANGESDAT = dto.NCHANGESDAT;
        entity.NCLAIM = dto.NCLAIM;
        entity.NCASE_NUM = dto.NCASE_NUM;
        entity.NBANK_CODE = dto.NBANK_CODE;
        entity.NBANK_AGREE = dto.NBANK_AGREE;
        entity.NAGREEMENT = dto.NAGREEMENT;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NSUPORT_ID = dto.NSUPORT_ID;
        entity.NTYPESUPPORT = dto.NTYPESUPPORT;
        entity.DCOLLECTION = dto.DCOLLECTION;
        entity.SACTION = dto.SACTION;
        entity.NCASH_ID = dto.NCASH_ID;
        entity.NMOV_TYPE = dto.NMOV_TYPE;
        entity.NTYP_ACCO = dto.NTYP_ACCO;
        entity.NINTERMED = dto.NINTERMED;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.STYPE_BANKAGREE = dto.STYPE_BANKAGREE;
        entity.NACCOUNT = dto.NACCOUNT;
        entity.NDEMAN_TYPE = dto.NDEMAN_TYPE;
        entity.NBULLETINS = dto.NBULLETINS;
        entity.NLOAN = dto.NLOAN;
        entity.NAMOUNTDEC = dto.NAMOUNTDEC;
        entity.NLOANS = dto.NLOANS;
        entity.NPOLICY = dto.NPOLICY;
        entity.NREQUEST_NU = dto.NREQUEST_NU;
        entity.NBORDEREAUXUSED = dto.NBORDEREAUXUSED;
    }
}
