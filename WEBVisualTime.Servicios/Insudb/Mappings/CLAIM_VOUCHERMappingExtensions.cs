using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_VOUCHER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_VOUCHERMappingExtensions
{
    public static CLAIM_VOUCHERDto ToDto(this CLAIM_VOUCHER entity)
    {
        if (entity == null) return null!;
        return new CLAIM_VOUCHERDto
        {
            NCLAIM_VOUCHER = entity.NCLAIM_VOUCHER,
            NTYPEDOC_PAY = entity.NTYPEDOC_PAY,
            SCLINUMDOCU = entity.SCLINUMDOCU,
            DISSUEDAT = entity.DISSUEDAT,
            SELECTRONIC_DOC = entity.SELECTRONIC_DOC,
            SSENDER_NAME = entity.SSENDER_NAME,
            SCUF_NUMBER = entity.SCUF_NUMBER,
            SVOUCHER_SERIES = entity.SVOUCHER_SERIES,
            NVOUCHER_NUM = entity.NVOUCHER_NUM,
            SCONTROL_CODE = entity.SCONTROL_CODE,
            NSTATUS = entity.NSTATUS,
            TABLE9248SDESCRIPT = entity.TABLE9248?.SDESCRIPT,
            SOBSERV = entity.SOBSERV,
            NAMOUNT_DOCU = entity.NAMOUNT_DOCU,
            NEXCHANGE = entity.NEXCHANGE,
            NBALANCE = entity.NBALANCE,
            NCURRENCY = entity.NCURRENCY,
            NFOREIGNDOCTYPE = entity.NFOREIGNDOCTYPE,
            TABLE9247SDESCRIPT = entity.TABLE9247?.SDESCRIPT,
            NPROVIDER = entity.NPROVIDER,
            TAB_PROVIDERSSTATREGT = entity.TAB_PROVIDER?.SSTATREGT,
            SCLIENT = entity.SCLIENT,
            NNOTENUM = entity.NNOTENUM,
            NSEQUENCE_ID = entity.NSEQUENCE_ID,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NCODIGINT = entity.NCODIGINT,
            NAMOUNT_VAT = entity.NAMOUNT_VAT,
            NAMOUNT_FTT = entity.NAMOUNT_FTT,
            NAMOUNT_VAT_RATE = entity.NAMOUNT_VAT_RATE,
            NAMOUNT_FTT_RATE = entity.NAMOUNT_FTT_RATE,
            NAMOUNT_BASE = entity.NAMOUNT_BASE,
        };
    }

    public static CLAIM_VOUCHER ToEntity(this CreateCLAIM_VOUCHERDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_VOUCHER
        {
            NTYPEDOC_PAY = dto.NTYPEDOC_PAY,
            SCLINUMDOCU = dto.SCLINUMDOCU,
            DISSUEDAT = dto.DISSUEDAT,
            SELECTRONIC_DOC = dto.SELECTRONIC_DOC,
            SSENDER_NAME = dto.SSENDER_NAME,
            SCUF_NUMBER = dto.SCUF_NUMBER,
            SVOUCHER_SERIES = dto.SVOUCHER_SERIES,
            NVOUCHER_NUM = dto.NVOUCHER_NUM,
            SCONTROL_CODE = dto.SCONTROL_CODE,
            NSTATUS = dto.NSTATUS,
            SOBSERV = dto.SOBSERV,
            NAMOUNT_DOCU = dto.NAMOUNT_DOCU,
            NEXCHANGE = dto.NEXCHANGE,
            NBALANCE = dto.NBALANCE,
            NCURRENCY = dto.NCURRENCY,
            NFOREIGNDOCTYPE = dto.NFOREIGNDOCTYPE,
            NPROVIDER = dto.NPROVIDER,
            SCLIENT = dto.SCLIENT,
            NNOTENUM = dto.NNOTENUM,
            NSEQUENCE_ID = dto.NSEQUENCE_ID,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NCODIGINT = dto.NCODIGINT,
            NAMOUNT_VAT = dto.NAMOUNT_VAT,
            NAMOUNT_FTT = dto.NAMOUNT_FTT,
            NAMOUNT_VAT_RATE = dto.NAMOUNT_VAT_RATE,
            NAMOUNT_FTT_RATE = dto.NAMOUNT_FTT_RATE,
            NAMOUNT_BASE = dto.NAMOUNT_BASE,
        };
    }

    public static void UpdateEntity(this CLAIM_VOUCHER entity, UpdateCLAIM_VOUCHERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYPEDOC_PAY = dto.NTYPEDOC_PAY;
        entity.SCLINUMDOCU = dto.SCLINUMDOCU;
        entity.DISSUEDAT = dto.DISSUEDAT;
        entity.SELECTRONIC_DOC = dto.SELECTRONIC_DOC;
        entity.SSENDER_NAME = dto.SSENDER_NAME;
        entity.SCUF_NUMBER = dto.SCUF_NUMBER;
        entity.SVOUCHER_SERIES = dto.SVOUCHER_SERIES;
        entity.NVOUCHER_NUM = dto.NVOUCHER_NUM;
        entity.SCONTROL_CODE = dto.SCONTROL_CODE;
        entity.NSTATUS = dto.NSTATUS;
        entity.SOBSERV = dto.SOBSERV;
        entity.NAMOUNT_DOCU = dto.NAMOUNT_DOCU;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.NBALANCE = dto.NBALANCE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NFOREIGNDOCTYPE = dto.NFOREIGNDOCTYPE;
        entity.NPROVIDER = dto.NPROVIDER;
        entity.SCLIENT = dto.SCLIENT;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NSEQUENCE_ID = dto.NSEQUENCE_ID;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NCODIGINT = dto.NCODIGINT;
        entity.NAMOUNT_VAT = dto.NAMOUNT_VAT;
        entity.NAMOUNT_FTT = dto.NAMOUNT_FTT;
        entity.NAMOUNT_VAT_RATE = dto.NAMOUNT_VAT_RATE;
        entity.NAMOUNT_FTT_RATE = dto.NAMOUNT_FTT_RATE;
        entity.NAMOUNT_BASE = dto.NAMOUNT_BASE;
    }
}
