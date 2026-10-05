using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM_MO;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PREMIUM_MOMappingExtensions
{
    public static PREMIUM_MODto ToDto(this PREMIUM_MO entity)
    {
        if (entity == null) return null!;
        return new PREMIUM_MODto
        {
            NRECEIPT = entity.NRECEIPT,
            PREMIUMNRECEIPTSCESSIONS = entity.PREMIUMNRECEIPT?.SCESSIONS,
            NPRODUCT = entity.NPRODUCT,
            PREMIUMNPRODUCTSCESSIONS = entity.PREMIUMNPRODUCT?.SCESSIONS,
            NBRANCH = entity.NBRANCH,
            PREMIUMNBRANCHSCESSIONS = entity.PREMIUMNBRANCH?.SCESSIONS,
            SCERTYPE = entity.SCERTYPE,
            PREMIUMSCERTYPESCESSIONS = entity.PREMIUMSCERTYPE?.SCESSIONS,
            NDIGIT = entity.NDIGIT,
            PREMIUMNDIGITSCESSIONS = entity.PREMIUMNDIGIT?.SCESSIONS,
            NPAYNUMBE = entity.NPAYNUMBE,
            PREMIUMNPAYNUMBESCESSIONS = entity.PREMIUMNPAYNUMBE?.SCESSIONS,
            NTRANSAC = entity.NTRANSAC,
            NAMOUNT = entity.NAMOUNT,
            NCARD_TYPE = entity.NCARD_TYPE,
            TABLE183SDESCRIPT = entity.TABLE183?.SDESCRIPT,
            SAUX_ACCOUN = entity.SAUX_ACCOUN,
            NBALANCE = entity.NBALANCE,
            NBANK_CODE = entity.NBANK_CODE,
            TABLE7SDESCRIPT = entity.TABLE7?.SDESCRIPT,
            NBORDEREAUX = entity.NBORDEREAUX,
            COLFORMREFSTYPE = entity.COLFORMREF?.STYPE,
            DCAR_DATEXP = entity.DCAR_DATEXP,
            SCARD_NUM = entity.SCARD_NUM,
            NCASH_MOV = entity.NCASH_MOV,
            NCAUSE_AMEN = entity.NCAUSE_AMEN,
            TABLE77SDESCRIPT = entity.TABLE77?.SDESCRIPT,
            SCESSICOI = entity.SCESSICOI,
            SCHANG_ACC = entity.SCHANG_ACC,
            DCOMPDATE = entity.DCOMPDATE,
            NCURRENCY = entity.NCURRENCY,
            SDOCNUMBE = entity.SDOCNUMBE,
            SIND_REVER = entity.SIND_REVER,
            NINT_MORA = entity.NINT_MORA,
            SINTERMEI = entity.SINTERMEI,
            NNULLCODE = entity.NNULLCODE,
            TABLE95SDESCRIPT = entity.TABLE95?.SDESCRIPT,
            SPAY_FORM = entity.SPAY_FORM,
            TABLE182SDESCRIPT = entity.TABLE182?.SDESCRIPT,
            DPOSTED = entity.DPOSTED,
            NPREMIUM = entity.NPREMIUM,
            NRECEIPT_FA = entity.NRECEIPT_FA,
            DSTATDATE = entity.DSTATDATE,
            SSTATISI = entity.SSTATISI,
            NUSERCODE = entity.NUSERCODE,
            DLEDGERDAT = entity.DLEDGERDAT,
            NTYPE = entity.NTYPE,
            TABLE6SDESCRIPT = entity.TABLE6?.SDESCRIPT,
            NEXCHANGE = entity.NEXCHANGE,
            SINDASSOCPRO = entity.SINDASSOCPRO,
            NPAYSOONDISC = entity.NPAYSOONDISC,
            SIND_ASIS = entity.SIND_ASIS,
            SIND_COMI = entity.SIND_COMI,
            NBULLETINS = entity.NBULLETINS,
            NCASHNUM = entity.NCASHNUM,
            NPAYREJECT = entity.NPAYREJECT,
            NCOLLECTOR = entity.NCOLLECTOR,
            NBILLNUM = entity.NBILLNUM,
            SBILLTYPE = entity.SBILLTYPE,
            SIND_SOAP = entity.SIND_SOAP,
            SINDCHEQUE = entity.SINDCHEQUE,
            NID = entity.NID,
            NRELRECEIPT = entity.NRELRECEIPT,
            SPROCESS_IND = entity.SPROCESS_IND,
            SSTIPENDS = entity.SSTIPENDS,
            NPAY_SOURCE = entity.NPAY_SOURCE,
            STYPREVERSE = entity.STYPREVERSE,
            NAMOUNT_LOC = entity.NAMOUNT_LOC,
            NCOD_AGREE = entity.NCOD_AGREE,
            NCONTRAT = entity.NCONTRAT,
            DCTB_DATE = entity.DCTB_DATE,
            SPOSTEDSEQUENCE = entity.SPOSTEDSEQUENCE,
            NCOLLECTOR_ASSIG = entity.NCOLLECTOR_ASSIG,
            NBORDEREAUX_ADV = entity.NBORDEREAUX_ADV,
            NBILLNUM_OLD = entity.NBILLNUM_OLD,
        };
    }

    public static PREMIUM_MO ToEntity(this CreatePREMIUM_MODto dto)
    {
        if (dto == null) return null!;
        return new PREMIUM_MO
        {
            NAMOUNT = dto.NAMOUNT,
            NCARD_TYPE = dto.NCARD_TYPE,
            SAUX_ACCOUN = dto.SAUX_ACCOUN,
            NBALANCE = dto.NBALANCE,
            NBANK_CODE = dto.NBANK_CODE,
            NBORDEREAUX = dto.NBORDEREAUX,
            DCAR_DATEXP = dto.DCAR_DATEXP,
            SCARD_NUM = dto.SCARD_NUM,
            NCASH_MOV = dto.NCASH_MOV,
            NCAUSE_AMEN = dto.NCAUSE_AMEN,
            SCESSICOI = dto.SCESSICOI,
            SCHANG_ACC = dto.SCHANG_ACC,
            DCOMPDATE = dto.DCOMPDATE,
            NCURRENCY = dto.NCURRENCY,
            SDOCNUMBE = dto.SDOCNUMBE,
            SIND_REVER = dto.SIND_REVER,
            NINT_MORA = dto.NINT_MORA,
            SINTERMEI = dto.SINTERMEI,
            NNULLCODE = dto.NNULLCODE,
            SPAY_FORM = dto.SPAY_FORM,
            DPOSTED = dto.DPOSTED,
            NPREMIUM = dto.NPREMIUM,
            NRECEIPT_FA = dto.NRECEIPT_FA,
            DSTATDATE = dto.DSTATDATE,
            SSTATISI = dto.SSTATISI,
            NUSERCODE = dto.NUSERCODE,
            DLEDGERDAT = dto.DLEDGERDAT,
            NTYPE = dto.NTYPE,
            NEXCHANGE = dto.NEXCHANGE,
            SINDASSOCPRO = dto.SINDASSOCPRO,
            NPAYSOONDISC = dto.NPAYSOONDISC,
            SIND_ASIS = dto.SIND_ASIS,
            SIND_COMI = dto.SIND_COMI,
            NBULLETINS = dto.NBULLETINS,
            NCASHNUM = dto.NCASHNUM,
            NPAYREJECT = dto.NPAYREJECT,
            NCOLLECTOR = dto.NCOLLECTOR,
            NBILLNUM = dto.NBILLNUM,
            SBILLTYPE = dto.SBILLTYPE,
            SIND_SOAP = dto.SIND_SOAP,
            SINDCHEQUE = dto.SINDCHEQUE,
            NID = dto.NID,
            NRELRECEIPT = dto.NRELRECEIPT,
            SPROCESS_IND = dto.SPROCESS_IND,
            SSTIPENDS = dto.SSTIPENDS,
            NPAY_SOURCE = dto.NPAY_SOURCE,
            STYPREVERSE = dto.STYPREVERSE,
            NAMOUNT_LOC = dto.NAMOUNT_LOC,
            NCOD_AGREE = dto.NCOD_AGREE,
            NCONTRAT = dto.NCONTRAT,
            DCTB_DATE = dto.DCTB_DATE,
            SPOSTEDSEQUENCE = dto.SPOSTEDSEQUENCE,
            NCOLLECTOR_ASSIG = dto.NCOLLECTOR_ASSIG,
            NBORDEREAUX_ADV = dto.NBORDEREAUX_ADV,
            NBILLNUM_OLD = dto.NBILLNUM_OLD,
        };
    }

    public static void UpdateEntity(this PREMIUM_MO entity, UpdatePREMIUM_MODto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NCARD_TYPE = dto.NCARD_TYPE;
        entity.SAUX_ACCOUN = dto.SAUX_ACCOUN;
        entity.NBALANCE = dto.NBALANCE;
        entity.NBANK_CODE = dto.NBANK_CODE;
        entity.NBORDEREAUX = dto.NBORDEREAUX;
        entity.DCAR_DATEXP = dto.DCAR_DATEXP;
        entity.SCARD_NUM = dto.SCARD_NUM;
        entity.NCASH_MOV = dto.NCASH_MOV;
        entity.NCAUSE_AMEN = dto.NCAUSE_AMEN;
        entity.SCESSICOI = dto.SCESSICOI;
        entity.SCHANG_ACC = dto.SCHANG_ACC;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.SDOCNUMBE = dto.SDOCNUMBE;
        entity.SIND_REVER = dto.SIND_REVER;
        entity.NINT_MORA = dto.NINT_MORA;
        entity.SINTERMEI = dto.SINTERMEI;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.SPAY_FORM = dto.SPAY_FORM;
        entity.DPOSTED = dto.DPOSTED;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NRECEIPT_FA = dto.NRECEIPT_FA;
        entity.DSTATDATE = dto.DSTATDATE;
        entity.SSTATISI = dto.SSTATISI;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.NTYPE = dto.NTYPE;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.SINDASSOCPRO = dto.SINDASSOCPRO;
        entity.NPAYSOONDISC = dto.NPAYSOONDISC;
        entity.SIND_ASIS = dto.SIND_ASIS;
        entity.SIND_COMI = dto.SIND_COMI;
        entity.NBULLETINS = dto.NBULLETINS;
        entity.NCASHNUM = dto.NCASHNUM;
        entity.NPAYREJECT = dto.NPAYREJECT;
        entity.NCOLLECTOR = dto.NCOLLECTOR;
        entity.NBILLNUM = dto.NBILLNUM;
        entity.SBILLTYPE = dto.SBILLTYPE;
        entity.SIND_SOAP = dto.SIND_SOAP;
        entity.SINDCHEQUE = dto.SINDCHEQUE;
        entity.NID = dto.NID;
        entity.NRELRECEIPT = dto.NRELRECEIPT;
        entity.SPROCESS_IND = dto.SPROCESS_IND;
        entity.SSTIPENDS = dto.SSTIPENDS;
        entity.NPAY_SOURCE = dto.NPAY_SOURCE;
        entity.STYPREVERSE = dto.STYPREVERSE;
        entity.NAMOUNT_LOC = dto.NAMOUNT_LOC;
        entity.NCOD_AGREE = dto.NCOD_AGREE;
        entity.NCONTRAT = dto.NCONTRAT;
        entity.DCTB_DATE = dto.DCTB_DATE;
        entity.SPOSTEDSEQUENCE = dto.SPOSTEDSEQUENCE;
        entity.NCOLLECTOR_ASSIG = dto.NCOLLECTOR_ASSIG;
        entity.NBORDEREAUX_ADV = dto.NBORDEREAUX_ADV;
        entity.NBILLNUM_OLD = dto.NBILLNUM_OLD;
    }
}
