using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_HIS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_HISMappingExtensions
{
    public static CLAIM_HISDto ToDto(this CLAIM_HIS entity)
    {
        if (entity == null) return null!;
        return new CLAIM_HISDto
        {
            NCLAIM = entity.NCLAIM,
            CLAIM_CASENCLAIMSSTACASE = entity.CLAIM_CASENCLAIM?.SSTACASE,
            NCASE_NUM = entity.NCASE_NUM,
            CLAIM_CASENCASE_NUMSSTACASE = entity.CLAIM_CASENCASE_NUM?.SSTACASE,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            CLAIM_CASENDEMAN_TYPESSTACASE = entity.CLAIM_CASENDEMAN_TYPE?.SSTACASE,
            NTRANSAC = entity.NTRANSAC,
            NAMOUNT = entity.NAMOUNT,
            NOPER_TYPE = entity.NOPER_TYPE,
            TABLE140SDESCRIPT = entity.TABLE140?.SDESCRIPT,
            SCESSICOI = entity.SCESSICOI,
            NCURRENCY = entity.NCURRENCY,
            NEXCHANGE = entity.NEXCHANGE,
            SEXECUTED = entity.SEXECUTED,
            NINC_AMOUNT = entity.NINC_AMOUNT,
            NINCOMETAX = entity.NINCOMETAX,
            SIND_AUT = entity.SIND_AUT,
            SIND_ORDER = entity.SIND_ORDER,
            SIND_REV = entity.SIND_REV,
            NLOC_AMOUNT = entity.NLOC_AMOUNT,
            DOPERDATE = entity.DOPERDATE,
            SORDER_NUM = entity.SORDER_NUM,
            NPAY_TYPE = entity.NPAY_TYPE,
            TABLE199SDESCRIPT = entity.TABLE199?.SDESCRIPT,
            DPOSTED = entity.DPOSTED,
            NSERV_ORDER = entity.NSERV_ORDER,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NBORDEREAUX = entity.NBORDEREAUX,
            COLFORMREFSTYPE = entity.COLFORMREF?.STYPE,
            NPAY_FORM = entity.NPAY_FORM,
            TABLE138SDESCRIPT = entity.TABLE138?.SDESCRIPT,
            SREINSU_IND = entity.SREINSU_IND,
            SCOINSU_IND = entity.SCOINSU_IND,
            NCASH_ID = entity.NCASH_ID,
            NDOC_TYPE = entity.NDOC_TYPE,
            TABLE5570SDESCRIPT = entity.TABLE5570?.SDESCRIPT,
            NBILL = entity.NBILL,
            DBILL_DATE = entity.DBILL_DATE,
            SCO_PAY = entity.SCO_PAY,
            NNOTENUM = entity.NNOTENUM,
            NID = entity.NID,
            SINDMARGIN = entity.SINDMARGIN,
            SPAY_RENT = entity.SPAY_RENT,
            SIND_TRANFER = entity.SIND_TRANFER,
            NPROCEEDINGNUM = entity.NPROCEEDINGNUM,
            NTRANSCLAIMREV = entity.NTRANSCLAIMREV,
            NDDR = entity.NDDR,
            NDEDUCTIBLE_METHOD = entity.NDEDUCTIBLE_METHOD,
            SIND_RASA = entity.SIND_RASA,
            SINDPROCESS = entity.SINDPROCESS,
            NDED_AMOUNT = entity.NDED_AMOUNT,
            DBACKUPDATE = entity.DBACKUPDATE,
            NRECOVER = entity.NRECOVER,
            NRELATION = entity.NRELATION,
            NRASA = entity.NRASA,
            DCTB_DATE = entity.DCTB_DATE,
            SPOSTEDSEQUENCE = entity.SPOSTEDSEQUENCE,
            DLEDGERDAT = entity.DLEDGERDAT,
            NSETTLEMENT_NUM = entity.NSETTLEMENT_NUM,
            NAMOUNT_BASE = entity.NAMOUNT_BASE,
            NAMOUNT_VAT = entity.NAMOUNT_VAT,
            NAMOUNT_FTT = entity.NAMOUNT_FTT,
            NAMOUNT_AGREE = entity.NAMOUNT_AGREE,
            NAMOUNT_ADJUST = entity.NAMOUNT_ADJUST,
            NAMOUNT_VAT_LOSS = entity.NAMOUNT_VAT_LOSS,
            NAMOUNT_FTT_LOSS = entity.NAMOUNT_FTT_LOSS,
            NSETTLEMENT_PAY = entity.NSETTLEMENT_PAY,
            NSETTLEMENT_CONC = entity.NSETTLEMENT_CONC,
        };
    }

    public static CLAIM_HIS ToEntity(this CreateCLAIM_HISDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_HIS
        {
            NAMOUNT = dto.NAMOUNT,
            NOPER_TYPE = dto.NOPER_TYPE,
            SCESSICOI = dto.SCESSICOI,
            NCURRENCY = dto.NCURRENCY,
            NEXCHANGE = dto.NEXCHANGE,
            SEXECUTED = dto.SEXECUTED,
            NINC_AMOUNT = dto.NINC_AMOUNT,
            NINCOMETAX = dto.NINCOMETAX,
            SIND_AUT = dto.SIND_AUT,
            SIND_ORDER = dto.SIND_ORDER,
            SIND_REV = dto.SIND_REV,
            NLOC_AMOUNT = dto.NLOC_AMOUNT,
            DOPERDATE = dto.DOPERDATE,
            SORDER_NUM = dto.SORDER_NUM,
            NPAY_TYPE = dto.NPAY_TYPE,
            DPOSTED = dto.DPOSTED,
            NSERV_ORDER = dto.NSERV_ORDER,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            SCLIENT = dto.SCLIENT,
            NBORDEREAUX = dto.NBORDEREAUX,
            NPAY_FORM = dto.NPAY_FORM,
            SREINSU_IND = dto.SREINSU_IND,
            SCOINSU_IND = dto.SCOINSU_IND,
            NCASH_ID = dto.NCASH_ID,
            NDOC_TYPE = dto.NDOC_TYPE,
            NBILL = dto.NBILL,
            DBILL_DATE = dto.DBILL_DATE,
            SCO_PAY = dto.SCO_PAY,
            NNOTENUM = dto.NNOTENUM,
            NID = dto.NID,
            SINDMARGIN = dto.SINDMARGIN,
            SPAY_RENT = dto.SPAY_RENT,
            SIND_TRANFER = dto.SIND_TRANFER,
            NPROCEEDINGNUM = dto.NPROCEEDINGNUM,
            NTRANSCLAIMREV = dto.NTRANSCLAIMREV,
            NDDR = dto.NDDR,
            NDEDUCTIBLE_METHOD = dto.NDEDUCTIBLE_METHOD,
            SIND_RASA = dto.SIND_RASA,
            SINDPROCESS = dto.SINDPROCESS,
            NDED_AMOUNT = dto.NDED_AMOUNT,
            DBACKUPDATE = dto.DBACKUPDATE,
            NRECOVER = dto.NRECOVER,
            NRELATION = dto.NRELATION,
            NRASA = dto.NRASA,
            DCTB_DATE = dto.DCTB_DATE,
            SPOSTEDSEQUENCE = dto.SPOSTEDSEQUENCE,
            DLEDGERDAT = dto.DLEDGERDAT,
            NSETTLEMENT_NUM = dto.NSETTLEMENT_NUM,
            NAMOUNT_BASE = dto.NAMOUNT_BASE,
            NAMOUNT_VAT = dto.NAMOUNT_VAT,
            NAMOUNT_FTT = dto.NAMOUNT_FTT,
            NAMOUNT_AGREE = dto.NAMOUNT_AGREE,
            NAMOUNT_ADJUST = dto.NAMOUNT_ADJUST,
            NAMOUNT_VAT_LOSS = dto.NAMOUNT_VAT_LOSS,
            NAMOUNT_FTT_LOSS = dto.NAMOUNT_FTT_LOSS,
            NSETTLEMENT_PAY = dto.NSETTLEMENT_PAY,
            NSETTLEMENT_CONC = dto.NSETTLEMENT_CONC,
        };
    }

    public static void UpdateEntity(this CLAIM_HIS entity, UpdateCLAIM_HISDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NOPER_TYPE = dto.NOPER_TYPE;
        entity.SCESSICOI = dto.SCESSICOI;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.SEXECUTED = dto.SEXECUTED;
        entity.NINC_AMOUNT = dto.NINC_AMOUNT;
        entity.NINCOMETAX = dto.NINCOMETAX;
        entity.SIND_AUT = dto.SIND_AUT;
        entity.SIND_ORDER = dto.SIND_ORDER;
        entity.SIND_REV = dto.SIND_REV;
        entity.NLOC_AMOUNT = dto.NLOC_AMOUNT;
        entity.DOPERDATE = dto.DOPERDATE;
        entity.SORDER_NUM = dto.SORDER_NUM;
        entity.NPAY_TYPE = dto.NPAY_TYPE;
        entity.DPOSTED = dto.DPOSTED;
        entity.NSERV_ORDER = dto.NSERV_ORDER;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SCLIENT = dto.SCLIENT;
        entity.NBORDEREAUX = dto.NBORDEREAUX;
        entity.NPAY_FORM = dto.NPAY_FORM;
        entity.SREINSU_IND = dto.SREINSU_IND;
        entity.SCOINSU_IND = dto.SCOINSU_IND;
        entity.NCASH_ID = dto.NCASH_ID;
        entity.NDOC_TYPE = dto.NDOC_TYPE;
        entity.NBILL = dto.NBILL;
        entity.DBILL_DATE = dto.DBILL_DATE;
        entity.SCO_PAY = dto.SCO_PAY;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NID = dto.NID;
        entity.SINDMARGIN = dto.SINDMARGIN;
        entity.SPAY_RENT = dto.SPAY_RENT;
        entity.SIND_TRANFER = dto.SIND_TRANFER;
        entity.NPROCEEDINGNUM = dto.NPROCEEDINGNUM;
        entity.NTRANSCLAIMREV = dto.NTRANSCLAIMREV;
        entity.NDDR = dto.NDDR;
        entity.NDEDUCTIBLE_METHOD = dto.NDEDUCTIBLE_METHOD;
        entity.SIND_RASA = dto.SIND_RASA;
        entity.SINDPROCESS = dto.SINDPROCESS;
        entity.NDED_AMOUNT = dto.NDED_AMOUNT;
        entity.DBACKUPDATE = dto.DBACKUPDATE;
        entity.NRECOVER = dto.NRECOVER;
        entity.NRELATION = dto.NRELATION;
        entity.NRASA = dto.NRASA;
        entity.DCTB_DATE = dto.DCTB_DATE;
        entity.SPOSTEDSEQUENCE = dto.SPOSTEDSEQUENCE;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.NSETTLEMENT_NUM = dto.NSETTLEMENT_NUM;
        entity.NAMOUNT_BASE = dto.NAMOUNT_BASE;
        entity.NAMOUNT_VAT = dto.NAMOUNT_VAT;
        entity.NAMOUNT_FTT = dto.NAMOUNT_FTT;
        entity.NAMOUNT_AGREE = dto.NAMOUNT_AGREE;
        entity.NAMOUNT_ADJUST = dto.NAMOUNT_ADJUST;
        entity.NAMOUNT_VAT_LOSS = dto.NAMOUNT_VAT_LOSS;
        entity.NAMOUNT_FTT_LOSS = dto.NAMOUNT_FTT_LOSS;
        entity.NSETTLEMENT_PAY = dto.NSETTLEMENT_PAY;
        entity.NSETTLEMENT_CONC = dto.NSETTLEMENT_CONC;
    }
}
