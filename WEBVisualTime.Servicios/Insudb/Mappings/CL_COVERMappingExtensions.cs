using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_COVER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CL_COVERMappingExtensions
{
    public static CL_COVERDto ToDto(this CL_COVER entity)
    {
        if (entity == null) return null!;
        return new CL_COVERDto
        {
            NCLAIM = entity.NCLAIM,
            CLAIM_CASENCLAIMSSTACASE = entity.CLAIM_CASENCLAIM?.SSTACASE,
            NCOVER = entity.NCOVER,
            NCASE_NUM = entity.NCASE_NUM,
            CLAIM_CASENCASE_NUMSSTACASE = entity.CLAIM_CASENCASE_NUM?.SSTACASE,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            CLAIM_CASENDEMAN_TYPESSTACASE = entity.CLAIM_CASENDEMAN_TYPE?.SSTACASE,
            NMODULEC = entity.NMODULEC,
            NCURRENCY = entity.NCURRENCY,
            NBRANCH_EST = entity.NBRANCH_EST,
            TABLE71SDESCRIPT = entity.TABLE71?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NBRANCH_LED = entity.NBRANCH_LED,
            TABLE75SDESCRIPT = entity.TABLE75?.SDESCRIPT,
            NBRANCH_REI = entity.NBRANCH_REI,
            TABLE5000SDESCRIPT = entity.TABLE5000?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NCOST_RECU = entity.NCOST_RECU,
            NDAMAGES = entity.NDAMAGES,
            NEXP_AMOUNT = entity.NEXP_AMOUNT,
            NFRA_AMOUNT = entity.NFRA_AMOUNT,
            SFRANTYPE = entity.SFRANTYPE,
            TABLE64SDESCRIPT = entity.TABLE64?.SDESCRIPT,
            NGROUP = entity.NGROUP,
            NLOC_COS_RE = entity.NLOC_COS_RE,
            NLOC_PAY_AM = entity.NLOC_PAY_AM,
            NLOC_REC_AM = entity.NLOC_REC_AM,
            NLOC_RESERV = entity.NLOC_RESERV,
            NPAY_AMOUNT = entity.NPAY_AMOUNT,
            NQUANTITY = entity.NQUANTITY,
            NREC_AMOUNT = entity.NREC_AMOUNT,
            NRESERVE = entity.NRESERVE,
            SRESERVSTAT = entity.SRESERVSTAT,
            NUSERCODE = entity.NUSERCODE,
            NDAMPROF = entity.NDAMPROF,
            NTAX_AMO = entity.NTAX_AMO,
            SBILL_IND = entity.SBILL_IND,
            NRATEEQCOST = entity.NRATEEQCOST,
            NDEPRECIATEBASE = entity.NDEPRECIATEBASE,
            NDEPRECIATERATE = entity.NDEPRECIATERATE,
            NDEPRECIATEAMOUNT = entity.NDEPRECIATEAMOUNT,
            NRASA = entity.NRASA,
            NFRANCDAYS = entity.NFRANCDAYS,
            NDAYDEDAMOUNT = entity.NDAYDEDAMOUNT,
            NORIG_RESERVE = entity.NORIG_RESERVE,
        };
    }

    public static CL_COVER ToEntity(this CreateCL_COVERDto dto)
    {
        if (dto == null) return null!;
        return new CL_COVER
        {
            NBRANCH_EST = dto.NBRANCH_EST,
            NBRANCH_LED = dto.NBRANCH_LED,
            NBRANCH_REI = dto.NBRANCH_REI,
            DCOMPDATE = dto.DCOMPDATE,
            NCOST_RECU = dto.NCOST_RECU,
            NDAMAGES = dto.NDAMAGES,
            NEXP_AMOUNT = dto.NEXP_AMOUNT,
            NFRA_AMOUNT = dto.NFRA_AMOUNT,
            SFRANTYPE = dto.SFRANTYPE,
            NGROUP = dto.NGROUP,
            NLOC_COS_RE = dto.NLOC_COS_RE,
            NLOC_PAY_AM = dto.NLOC_PAY_AM,
            NLOC_REC_AM = dto.NLOC_REC_AM,
            NLOC_RESERV = dto.NLOC_RESERV,
            NPAY_AMOUNT = dto.NPAY_AMOUNT,
            NQUANTITY = dto.NQUANTITY,
            NREC_AMOUNT = dto.NREC_AMOUNT,
            NRESERVE = dto.NRESERVE,
            SRESERVSTAT = dto.SRESERVSTAT,
            NUSERCODE = dto.NUSERCODE,
            NDAMPROF = dto.NDAMPROF,
            NTAX_AMO = dto.NTAX_AMO,
            SBILL_IND = dto.SBILL_IND,
            NRATEEQCOST = dto.NRATEEQCOST,
            NDEPRECIATEBASE = dto.NDEPRECIATEBASE,
            NDEPRECIATERATE = dto.NDEPRECIATERATE,
            NDEPRECIATEAMOUNT = dto.NDEPRECIATEAMOUNT,
            NRASA = dto.NRASA,
            NFRANCDAYS = dto.NFRANCDAYS,
            NDAYDEDAMOUNT = dto.NDAYDEDAMOUNT,
            NORIG_RESERVE = dto.NORIG_RESERVE,
        };
    }

    public static void UpdateEntity(this CL_COVER entity, UpdateCL_COVERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NBRANCH_EST = dto.NBRANCH_EST;
        entity.NBRANCH_LED = dto.NBRANCH_LED;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCOST_RECU = dto.NCOST_RECU;
        entity.NDAMAGES = dto.NDAMAGES;
        entity.NEXP_AMOUNT = dto.NEXP_AMOUNT;
        entity.NFRA_AMOUNT = dto.NFRA_AMOUNT;
        entity.SFRANTYPE = dto.SFRANTYPE;
        entity.NGROUP = dto.NGROUP;
        entity.NLOC_COS_RE = dto.NLOC_COS_RE;
        entity.NLOC_PAY_AM = dto.NLOC_PAY_AM;
        entity.NLOC_REC_AM = dto.NLOC_REC_AM;
        entity.NLOC_RESERV = dto.NLOC_RESERV;
        entity.NPAY_AMOUNT = dto.NPAY_AMOUNT;
        entity.NQUANTITY = dto.NQUANTITY;
        entity.NREC_AMOUNT = dto.NREC_AMOUNT;
        entity.NRESERVE = dto.NRESERVE;
        entity.SRESERVSTAT = dto.SRESERVSTAT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NDAMPROF = dto.NDAMPROF;
        entity.NTAX_AMO = dto.NTAX_AMO;
        entity.SBILL_IND = dto.SBILL_IND;
        entity.NRATEEQCOST = dto.NRATEEQCOST;
        entity.NDEPRECIATEBASE = dto.NDEPRECIATEBASE;
        entity.NDEPRECIATERATE = dto.NDEPRECIATERATE;
        entity.NDEPRECIATEAMOUNT = dto.NDEPRECIATEAMOUNT;
        entity.NRASA = dto.NRASA;
        entity.NFRANCDAYS = dto.NFRANCDAYS;
        entity.NDAYDEDAMOUNT = dto.NDAYDEDAMOUNT;
        entity.NORIG_RESERVE = dto.NORIG_RESERVE;
    }
}
