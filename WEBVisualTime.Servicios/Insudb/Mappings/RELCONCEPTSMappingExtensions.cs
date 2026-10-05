using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RELCONCEPTS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class RELCONCEPTSMappingExtensions
{
    public static RELCONCEPTSDto ToDto(this RELCONCEPTS entity)
    {
        if (entity == null) return null!;
        return new RELCONCEPTSDto
        {
            SSEL = entity.SSEL,
            NBORDEREAUX = entity.NBORDEREAUX,
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
            NCHANGEDAT = entity.NCHANGEDAT,
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
            NBORDEREAUXUSED = entity.NBORDEREAUXUSED,
            NAMOUNTDEC = entity.NAMOUNTDEC,
            NLOANS = entity.NLOANS,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NRELRECOVER = entity.NRELRECOVER,
            NRETENTIONTAXCODE = entity.NRETENTIONTAXCODE,
            NRETENTIONCODE = entity.NRETENTIONCODE,
            NRETENTIONSERIES = entity.NRETENTIONSERIES,
            DAUTORIZATIONDATE = entity.DAUTORIZATIONDATE,
            DENDINGDATE = entity.DENDINGDATE,
            NRETENTION = entity.NRETENTION,
            NTAXRETENTION = entity.NTAXRETENTION,
            NRETENTIONBASE = entity.NRETENTIONBASE,
            NAUTORIZATIONNUMBER = entity.NAUTORIZATIONNUMBER,
            NBILLNUM = entity.NBILLNUM,
            NTAXAMOU = entity.NTAXAMOU,
            NPOLICY = entity.NPOLICY,
            NREQUEST_NU = entity.NREQUEST_NU,
        };
    }

    public static RELCONCEPTS ToEntity(this CreateRELCONCEPTSDto dto)
    {
        if (dto == null) return null!;
        return new RELCONCEPTS
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
            NCHANGEDAT = dto.NCHANGEDAT,
            NCLAIM = dto.NCLAIM,
            NCASE_NUM = dto.NCASE_NUM,
            NBANK_CODE = dto.NBANK_CODE,
            NBANK_AGREE = dto.NBANK_AGREE,
            NAGREEMENT = dto.NAGREEMENT,
            NNOTENUM = dto.NNOTENUM,
            NSUPORT_ID = dto.NSUPORT_ID,
            NTYPESUPPORT = dto.NTYPESUPPORT,
            DCOLLECTION = dto.DCOLLECTION,
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
            NBORDEREAUXUSED = dto.NBORDEREAUXUSED,
            NAMOUNTDEC = dto.NAMOUNTDEC,
            NLOANS = dto.NLOANS,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NRELRECOVER = dto.NRELRECOVER,
            NRETENTIONTAXCODE = dto.NRETENTIONTAXCODE,
            NRETENTIONCODE = dto.NRETENTIONCODE,
            NRETENTIONSERIES = dto.NRETENTIONSERIES,
            DAUTORIZATIONDATE = dto.DAUTORIZATIONDATE,
            DENDINGDATE = dto.DENDINGDATE,
            NRETENTION = dto.NRETENTION,
            NTAXRETENTION = dto.NTAXRETENTION,
            NRETENTIONBASE = dto.NRETENTIONBASE,
            NAUTORIZATIONNUMBER = dto.NAUTORIZATIONNUMBER,
            NBILLNUM = dto.NBILLNUM,
            NTAXAMOU = dto.NTAXAMOU,
            NPOLICY = dto.NPOLICY,
            NREQUEST_NU = dto.NREQUEST_NU,
        };
    }

    public static void UpdateEntity(this RELCONCEPTS entity, UpdateRELCONCEPTSDto dto)
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
        entity.NCHANGEDAT = dto.NCHANGEDAT;
        entity.NCLAIM = dto.NCLAIM;
        entity.NCASE_NUM = dto.NCASE_NUM;
        entity.NBANK_CODE = dto.NBANK_CODE;
        entity.NBANK_AGREE = dto.NBANK_AGREE;
        entity.NAGREEMENT = dto.NAGREEMENT;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NSUPORT_ID = dto.NSUPORT_ID;
        entity.NTYPESUPPORT = dto.NTYPESUPPORT;
        entity.DCOLLECTION = dto.DCOLLECTION;
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
        entity.NBORDEREAUXUSED = dto.NBORDEREAUXUSED;
        entity.NAMOUNTDEC = dto.NAMOUNTDEC;
        entity.NLOANS = dto.NLOANS;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NRELRECOVER = dto.NRELRECOVER;
        entity.NRETENTIONTAXCODE = dto.NRETENTIONTAXCODE;
        entity.NRETENTIONCODE = dto.NRETENTIONCODE;
        entity.NRETENTIONSERIES = dto.NRETENTIONSERIES;
        entity.DAUTORIZATIONDATE = dto.DAUTORIZATIONDATE;
        entity.DENDINGDATE = dto.DENDINGDATE;
        entity.NRETENTION = dto.NRETENTION;
        entity.NTAXRETENTION = dto.NTAXRETENTION;
        entity.NRETENTIONBASE = dto.NRETENTIONBASE;
        entity.NAUTORIZATIONNUMBER = dto.NAUTORIZATIONNUMBER;
        entity.NBILLNUM = dto.NBILLNUM;
        entity.NTAXAMOU = dto.NTAXAMOU;
        entity.NPOLICY = dto.NPOLICY;
        entity.NREQUEST_NU = dto.NREQUEST_NU;
    }
}
