using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETTLEMENT;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_SETTLEMENTMappingExtensions
{
    public static CLAIM_SETTLEMENTDto ToDto(this CLAIM_SETTLEMENT entity)
    {
        if (entity == null) return null!;
        return new CLAIM_SETTLEMENTDto
        {
            NSETTLEMENT_NUM = entity.NSETTLEMENT_NUM,
            NCURRENCY = entity.NCURRENCY,
            NEXCHANGE_REF = entity.NEXCHANGE_REF,
            NAMOUNT_PAY = entity.NAMOUNT_PAY,
            NPAYMENT_METHOD = entity.NPAYMENT_METHOD,
            TABLE9252SDESCRIPT = entity.TABLE9252?.SDESCRIPT,
            NPAYEE = entity.NPAYEE,
            TABLE9251SDESCRIPT = entity.TABLE9251?.SDESCRIPT,
            NSETTLEMENT_STAT = entity.NSETTLEMENT_STAT,
            TABLE9250SDESCRIPT = entity.TABLE9250?.SDESCRIPT,
            NSETTLEMENT_CONC = entity.NSETTLEMENT_CONC,
            TABLE9249SDESCRIPT = entity.TABLE9249?.SDESCRIPT,
            NNOTENUM = entity.NNOTENUM,
            NUSER_AMEND = entity.NUSER_AMEND,
            NSEQUENCE_ID = entity.NSEQUENCE_ID,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NTYPELIST = entity.NTYPELIST,
            TABLE9203SDESCRIPT = entity.TABLE9203?.SDESCRIPT,
            DPEPSEARCH = entity.DPEPSEARCH,
            NUSERPEPSEARCH = entity.NUSERPEPSEARCH,
            NSEVERITYPEP = entity.NSEVERITYPEP,
            TABLE9204SDESCRIPT = entity.TABLE9204?.SDESCRIPT,
            NINDAUTHPEP = entity.NINDAUTHPEP,
            DPEPSTATUS = entity.DPEPSTATUS,
            NUSERUIF = entity.NUSERUIF,
            NCLAIMANTTYPE = entity.NCLAIMANTTYPE,
            TABLE9212SDESCRIPT = entity.TABLE9212?.SDESCRIPT,
            SCLIENT2 = entity.SCLIENT2,
            NPROVIDER = entity.NPROVIDER,
            SCLIENT_PAYEE = entity.SCLIENT_PAYEE,
            DSETTLEMENTDAT = entity.DSETTLEMENTDAT,
            DPAYAUTH = entity.DPAYAUTH,
            NAMOUNT_ORDEN = entity.NAMOUNT_ORDEN,
            NAMOUNT_TOTAL = entity.NAMOUNT_TOTAL,
            NAMOUNT_DEDUCOIN = entity.NAMOUNT_DEDUCOIN,
            NAMOUNT_VAT = entity.NAMOUNT_VAT,
            NAMOUNT_FTT = entity.NAMOUNT_FTT,
            NAMOUNT_AGREE = entity.NAMOUNT_AGREE,
            NAMOUNT_ADJUST = entity.NAMOUNT_ADJUST,
            NSETTLEMENT_PAY = entity.NSETTLEMENT_PAY,
            NAMOUNT_VAT_LOSS = entity.NAMOUNT_VAT_LOSS,
            NAMOUNT_FTT_LOSS = entity.NAMOUNT_FTT_LOSS,
            NREQUEST_NU = entity.NREQUEST_NU,
            DLEDGERDAT = entity.DLEDGERDAT,
            NAMOUNT_BASE = entity.NAMOUNT_BASE,
            NBANKEXT = entity.NBANKEXT,
            SBANKACCOUNT = entity.SBANKACCOUNT,
            NACC_TYPE = entity.NACC_TYPE,
            TABLE190SDESCRIPT = entity.TABLE190?.SDESCRIPT,
            SREFUND = entity.SREFUND,
            SCLIENAMEPAYEE = entity.SCLIENAMEPAYEE,
            NTYPCLIENTDOC = entity.NTYPCLIENTDOC,
            SCLINUMDOCU = entity.SCLINUMDOCU,
            NOFFICE = entity.NOFFICE,
            SPHONE = entity.SPHONE,
            SCELLPHONE = entity.SCELLPHONE,
            SEMAIL = entity.SEMAIL,
            NUSER_PAYMETHODCREATE = entity.NUSER_PAYMETHODCREATE,
            DPAYMETHODCREATE = entity.DPAYMETHODCREATE,
            NUSER_PAYMETHODAMEN = entity.NUSER_PAYMETHODAMEN,
            DPAYMETHODAMEN = entity.DPAYMETHODAMEN,
            NSEQ_IDPAYMENTMETHOD = entity.NSEQ_IDPAYMENTMETHOD,
            NUSER_DERIVEDBY = entity.NUSER_DERIVEDBY,
            NUSER_AUTHORIZATION = entity.NUSER_AUTHORIZATION,
            DNULLDATE = entity.DNULLDATE,
            NNULLCODE = entity.NNULLCODE,
            TABLE9274SDESCRIPT = entity.TABLE9274?.SDESCRIPT,
            NSETTLEMENT_ORIG = entity.NSETTLEMENT_ORIG,
            NSEQ_IDLEDGERDOCUM = entity.NSEQ_IDLEDGERDOCUM,
            SCLIENT_BENEF = entity.SCLIENT_BENEF,
            SCLIENT_REP = entity.SCLIENT_REP,
        };
    }

    public static CLAIM_SETTLEMENT ToEntity(this CreateCLAIM_SETTLEMENTDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_SETTLEMENT
        {
            NCURRENCY = dto.NCURRENCY,
            NEXCHANGE_REF = dto.NEXCHANGE_REF,
            NAMOUNT_PAY = dto.NAMOUNT_PAY,
            NPAYMENT_METHOD = dto.NPAYMENT_METHOD,
            NPAYEE = dto.NPAYEE,
            NSETTLEMENT_STAT = dto.NSETTLEMENT_STAT,
            NSETTLEMENT_CONC = dto.NSETTLEMENT_CONC,
            NNOTENUM = dto.NNOTENUM,
            NUSER_AMEND = dto.NUSER_AMEND,
            NSEQUENCE_ID = dto.NSEQUENCE_ID,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NTYPELIST = dto.NTYPELIST,
            DPEPSEARCH = dto.DPEPSEARCH,
            NUSERPEPSEARCH = dto.NUSERPEPSEARCH,
            NSEVERITYPEP = dto.NSEVERITYPEP,
            NINDAUTHPEP = dto.NINDAUTHPEP,
            DPEPSTATUS = dto.DPEPSTATUS,
            NUSERUIF = dto.NUSERUIF,
            NCLAIMANTTYPE = dto.NCLAIMANTTYPE,
            SCLIENT2 = dto.SCLIENT2,
            NPROVIDER = dto.NPROVIDER,
            SCLIENT_PAYEE = dto.SCLIENT_PAYEE,
            DSETTLEMENTDAT = dto.DSETTLEMENTDAT,
            DPAYAUTH = dto.DPAYAUTH,
            NAMOUNT_ORDEN = dto.NAMOUNT_ORDEN,
            NAMOUNT_TOTAL = dto.NAMOUNT_TOTAL,
            NAMOUNT_DEDUCOIN = dto.NAMOUNT_DEDUCOIN,
            NAMOUNT_VAT = dto.NAMOUNT_VAT,
            NAMOUNT_FTT = dto.NAMOUNT_FTT,
            NAMOUNT_AGREE = dto.NAMOUNT_AGREE,
            NAMOUNT_ADJUST = dto.NAMOUNT_ADJUST,
            NSETTLEMENT_PAY = dto.NSETTLEMENT_PAY,
            NAMOUNT_VAT_LOSS = dto.NAMOUNT_VAT_LOSS,
            NAMOUNT_FTT_LOSS = dto.NAMOUNT_FTT_LOSS,
            NREQUEST_NU = dto.NREQUEST_NU,
            DLEDGERDAT = dto.DLEDGERDAT,
            NAMOUNT_BASE = dto.NAMOUNT_BASE,
            NBANKEXT = dto.NBANKEXT,
            SBANKACCOUNT = dto.SBANKACCOUNT,
            NACC_TYPE = dto.NACC_TYPE,
            SREFUND = dto.SREFUND,
            SCLIENAMEPAYEE = dto.SCLIENAMEPAYEE,
            NTYPCLIENTDOC = dto.NTYPCLIENTDOC,
            SCLINUMDOCU = dto.SCLINUMDOCU,
            NOFFICE = dto.NOFFICE,
            SPHONE = dto.SPHONE,
            SCELLPHONE = dto.SCELLPHONE,
            SEMAIL = dto.SEMAIL,
            NUSER_PAYMETHODCREATE = dto.NUSER_PAYMETHODCREATE,
            DPAYMETHODCREATE = dto.DPAYMETHODCREATE,
            NUSER_PAYMETHODAMEN = dto.NUSER_PAYMETHODAMEN,
            DPAYMETHODAMEN = dto.DPAYMETHODAMEN,
            NSEQ_IDPAYMENTMETHOD = dto.NSEQ_IDPAYMENTMETHOD,
            NUSER_DERIVEDBY = dto.NUSER_DERIVEDBY,
            NUSER_AUTHORIZATION = dto.NUSER_AUTHORIZATION,
            DNULLDATE = dto.DNULLDATE,
            NNULLCODE = dto.NNULLCODE,
            NSETTLEMENT_ORIG = dto.NSETTLEMENT_ORIG,
            NSEQ_IDLEDGERDOCUM = dto.NSEQ_IDLEDGERDOCUM,
            SCLIENT_BENEF = dto.SCLIENT_BENEF,
            SCLIENT_REP = dto.SCLIENT_REP,
        };
    }

    public static void UpdateEntity(this CLAIM_SETTLEMENT entity, UpdateCLAIM_SETTLEMENTDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NEXCHANGE_REF = dto.NEXCHANGE_REF;
        entity.NAMOUNT_PAY = dto.NAMOUNT_PAY;
        entity.NPAYMENT_METHOD = dto.NPAYMENT_METHOD;
        entity.NPAYEE = dto.NPAYEE;
        entity.NSETTLEMENT_STAT = dto.NSETTLEMENT_STAT;
        entity.NSETTLEMENT_CONC = dto.NSETTLEMENT_CONC;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NUSER_AMEND = dto.NUSER_AMEND;
        entity.NSEQUENCE_ID = dto.NSEQUENCE_ID;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTYPELIST = dto.NTYPELIST;
        entity.DPEPSEARCH = dto.DPEPSEARCH;
        entity.NUSERPEPSEARCH = dto.NUSERPEPSEARCH;
        entity.NSEVERITYPEP = dto.NSEVERITYPEP;
        entity.NINDAUTHPEP = dto.NINDAUTHPEP;
        entity.DPEPSTATUS = dto.DPEPSTATUS;
        entity.NUSERUIF = dto.NUSERUIF;
        entity.NCLAIMANTTYPE = dto.NCLAIMANTTYPE;
        entity.SCLIENT2 = dto.SCLIENT2;
        entity.NPROVIDER = dto.NPROVIDER;
        entity.SCLIENT_PAYEE = dto.SCLIENT_PAYEE;
        entity.DSETTLEMENTDAT = dto.DSETTLEMENTDAT;
        entity.DPAYAUTH = dto.DPAYAUTH;
        entity.NAMOUNT_ORDEN = dto.NAMOUNT_ORDEN;
        entity.NAMOUNT_TOTAL = dto.NAMOUNT_TOTAL;
        entity.NAMOUNT_DEDUCOIN = dto.NAMOUNT_DEDUCOIN;
        entity.NAMOUNT_VAT = dto.NAMOUNT_VAT;
        entity.NAMOUNT_FTT = dto.NAMOUNT_FTT;
        entity.NAMOUNT_AGREE = dto.NAMOUNT_AGREE;
        entity.NAMOUNT_ADJUST = dto.NAMOUNT_ADJUST;
        entity.NSETTLEMENT_PAY = dto.NSETTLEMENT_PAY;
        entity.NAMOUNT_VAT_LOSS = dto.NAMOUNT_VAT_LOSS;
        entity.NAMOUNT_FTT_LOSS = dto.NAMOUNT_FTT_LOSS;
        entity.NREQUEST_NU = dto.NREQUEST_NU;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.NAMOUNT_BASE = dto.NAMOUNT_BASE;
        entity.NBANKEXT = dto.NBANKEXT;
        entity.SBANKACCOUNT = dto.SBANKACCOUNT;
        entity.NACC_TYPE = dto.NACC_TYPE;
        entity.SREFUND = dto.SREFUND;
        entity.SCLIENAMEPAYEE = dto.SCLIENAMEPAYEE;
        entity.NTYPCLIENTDOC = dto.NTYPCLIENTDOC;
        entity.SCLINUMDOCU = dto.SCLINUMDOCU;
        entity.NOFFICE = dto.NOFFICE;
        entity.SPHONE = dto.SPHONE;
        entity.SCELLPHONE = dto.SCELLPHONE;
        entity.SEMAIL = dto.SEMAIL;
        entity.NUSER_PAYMETHODCREATE = dto.NUSER_PAYMETHODCREATE;
        entity.DPAYMETHODCREATE = dto.DPAYMETHODCREATE;
        entity.NUSER_PAYMETHODAMEN = dto.NUSER_PAYMETHODAMEN;
        entity.DPAYMETHODAMEN = dto.DPAYMETHODAMEN;
        entity.NSEQ_IDPAYMENTMETHOD = dto.NSEQ_IDPAYMENTMETHOD;
        entity.NUSER_DERIVEDBY = dto.NUSER_DERIVEDBY;
        entity.NUSER_AUTHORIZATION = dto.NUSER_AUTHORIZATION;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.NSETTLEMENT_ORIG = dto.NSETTLEMENT_ORIG;
        entity.NSEQ_IDLEDGERDOCUM = dto.NSEQ_IDLEDGERDOCUM;
        entity.SCLIENT_BENEF = dto.SCLIENT_BENEF;
        entity.SCLIENT_REP = dto.SCLIENT_REP;
    }
}
