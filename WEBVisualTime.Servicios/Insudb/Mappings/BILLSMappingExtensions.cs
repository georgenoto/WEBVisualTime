using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BILLS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BILLSMappingExtensions
{
    public static BILLSDto ToDto(this BILLS entity)
    {
        if (entity == null) return null!;
        return new BILLSDto
        {
            NINSUR_AREA = entity.NINSUR_AREA,
            TABLE5001SDESCRIPT = entity.TABLE5001?.SDESCRIPT,
            SBILLTYPE = entity.SBILLTYPE,
            SBILLING = entity.SBILLING,
            NBILLNUM = entity.NBILLNUM,
            NCURRENCY = entity.NCURRENCY,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NAMOUNT = entity.NAMOUNT,
            NAMO_AFEC = entity.NAMO_AFEC,
            NAMO_EXEN = entity.NAMO_EXEN,
            NIVA = entity.NIVA,
            NCRE_NOTE = entity.NCRE_NOTE,
            NNEWBILL = entity.NNEWBILL,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NBILLSTAT = entity.NBILLSTAT,
            TABLE5564SDESCRIPT = entity.TABLE5564?.SDESCRIPT,
            DSTATDATE = entity.DSTATDATE,
            DVALDATE = entity.DVALDATE,
            SKEYADDRESS = entity.SKEYADDRESS,
            NRECOWNER = entity.NRECOWNER,
            SBILL_IND = entity.SBILL_IND,
            SORIGIN = entity.SORIGIN,
            NPREVBILL = entity.NPREVBILL,
            DISSUEDAT = entity.DISSUEDAT,
            SBILLFULLNUM = entity.SBILLFULLNUM,
            SAUTHORIZATION = entity.SAUTHORIZATION,
            NRUCPRINT = entity.NRUCPRINT,
            NIDTRANSACTION = entity.NIDTRANSACTION,
            SBILLNUMSFE = entity.SBILLNUMSFE,
            NBORDEREAUX = entity.NBORDEREAUX,
            NPOLICY = entity.NPOLICY,
            NNULLCODE = entity.NNULLCODE,
            NCERTIF = entity.NCERTIF,
            NRECEIPTCORP = entity.NRECEIPTCORP,
        };
    }

    public static BILLS ToEntity(this CreateBILLSDto dto)
    {
        if (dto == null) return null!;
        return new BILLS
        {
            NCURRENCY = dto.NCURRENCY,
            SCLIENT = dto.SCLIENT,
            NAMOUNT = dto.NAMOUNT,
            NAMO_AFEC = dto.NAMO_AFEC,
            NAMO_EXEN = dto.NAMO_EXEN,
            NIVA = dto.NIVA,
            NCRE_NOTE = dto.NCRE_NOTE,
            NNEWBILL = dto.NNEWBILL,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NBILLSTAT = dto.NBILLSTAT,
            DSTATDATE = dto.DSTATDATE,
            DVALDATE = dto.DVALDATE,
            SKEYADDRESS = dto.SKEYADDRESS,
            NRECOWNER = dto.NRECOWNER,
            SBILL_IND = dto.SBILL_IND,
            SORIGIN = dto.SORIGIN,
            NPREVBILL = dto.NPREVBILL,
            DISSUEDAT = dto.DISSUEDAT,
            SBILLFULLNUM = dto.SBILLFULLNUM,
            SAUTHORIZATION = dto.SAUTHORIZATION,
            NRUCPRINT = dto.NRUCPRINT,
            NIDTRANSACTION = dto.NIDTRANSACTION,
            SBILLNUMSFE = dto.SBILLNUMSFE,
            NBORDEREAUX = dto.NBORDEREAUX,
            NPOLICY = dto.NPOLICY,
            NNULLCODE = dto.NNULLCODE,
            NCERTIF = dto.NCERTIF,
            NRECEIPTCORP = dto.NRECEIPTCORP,
        };
    }

    public static void UpdateEntity(this BILLS entity, UpdateBILLSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.SCLIENT = dto.SCLIENT;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NAMO_AFEC = dto.NAMO_AFEC;
        entity.NAMO_EXEN = dto.NAMO_EXEN;
        entity.NIVA = dto.NIVA;
        entity.NCRE_NOTE = dto.NCRE_NOTE;
        entity.NNEWBILL = dto.NNEWBILL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NBILLSTAT = dto.NBILLSTAT;
        entity.DSTATDATE = dto.DSTATDATE;
        entity.DVALDATE = dto.DVALDATE;
        entity.SKEYADDRESS = dto.SKEYADDRESS;
        entity.NRECOWNER = dto.NRECOWNER;
        entity.SBILL_IND = dto.SBILL_IND;
        entity.SORIGIN = dto.SORIGIN;
        entity.NPREVBILL = dto.NPREVBILL;
        entity.DISSUEDAT = dto.DISSUEDAT;
        entity.SBILLFULLNUM = dto.SBILLFULLNUM;
        entity.SAUTHORIZATION = dto.SAUTHORIZATION;
        entity.NRUCPRINT = dto.NRUCPRINT;
        entity.NIDTRANSACTION = dto.NIDTRANSACTION;
        entity.SBILLNUMSFE = dto.SBILLNUMSFE;
        entity.NBORDEREAUX = dto.NBORDEREAUX;
        entity.NPOLICY = dto.NPOLICY;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.NCERTIF = dto.NCERTIF;
        entity.NRECEIPTCORP = dto.NRECEIPTCORP;
    }
}
