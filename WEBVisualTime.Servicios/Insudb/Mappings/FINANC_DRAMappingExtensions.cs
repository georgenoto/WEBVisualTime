using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANC_DRA;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class FINANC_DRAMappingExtensions
{
    public static FINANC_DRADto ToDto(this FINANC_DRA entity)
    {
        if (entity == null) return null!;
        return new FINANC_DRADto
        {
            NAMOUNT = entity.NAMOUNT,
            NSTAT_DRAFT = entity.NSTAT_DRAFT,
            TABLE253SDESCRIPT = entity.TABLE253?.SDESCRIPT,
            NAMOUNT_NET = entity.NAMOUNT_NET,
            NCLAIM = entity.NCLAIM,
            CLAIMSCERTYPE = entity.CLAIM?.SCERTYPE,
            NCOMMISSION = entity.NCOMMISSION,
            DCOMPDATE = entity.DCOMPDATE,
            NCONTRAT = entity.NCONTRAT,
            NDRAFT = entity.NDRAFT,
            DEXPIRDAT = entity.DEXPIRDAT,
            NINTAMMOU = entity.NINTAMMOU,
            NSTATPRINT = entity.NSTATPRINT,
            TABLE282SDESCRIPT = entity.TABLE282?.SDESCRIPT,
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            DSTAT_DATE = entity.DSTAT_DATE,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            NBULLETINS = entity.NBULLETINS,
            NAMO_AFEC = entity.NAMO_AFEC,
            NAMO_EXEN = entity.NAMO_EXEN,
            NIVA = entity.NIVA,
            NCOM_AFEC = entity.NCOM_AFEC,
            NCOM_EXEN = entity.NCOM_EXEN,
            DLIMITDATE = entity.DLIMITDATE,
            NBORDEREAUX = entity.NBORDEREAUX,
            COLFORMREFSTYPE = entity.COLFORMREF?.STYPE,
            SINDCHEQUE = entity.SINDCHEQUE,
            DCOLLSUS_INI = entity.DCOLLSUS_INI,
            DCOLLSUS_END = entity.DCOLLSUS_END,
            NSUS_REASON = entity.NSUS_REASON,
            TABLE5566SDESCRIPT = entity.TABLE5566?.SDESCRIPT,
            SSUS_ORIGI = entity.SSUS_ORIGI,
            NCOLLECTOR = entity.NCOLLECTOR,
            NBILLNUM = entity.NBILLNUM,
            SBILLTYPE = entity.SBILLTYPE,
            NWAY_PAY = entity.NWAY_PAY,
            TABLE5002SDESCRIPT = entity.TABLE5002?.SDESCRIPT,
            SDOCNUMBE = entity.SDOCNUMBE,
            NRETENTIONTAXCODE = entity.NRETENTIONTAXCODE,
            NRETENTIONCODE = entity.NRETENTIONCODE,
            NRETENTIONSERIES = entity.NRETENTIONSERIES,
            DAUTORIZATIONDATE = entity.DAUTORIZATIONDATE,
            DENDINGDATE = entity.DENDINGDATE,
            NRETENTION = entity.NRETENTION,
            NTAXRETENTION = entity.NTAXRETENTION,
            NRETENTIONBASE = entity.NRETENTIONBASE,
            NAUTORIZATIONNUMBER = entity.NAUTORIZATIONNUMBER,
            NEMISRIGHT = entity.NEMISRIGHT,
            NIVA_SSC = entity.NIVA_SSC,
            NIVA_SBK = entity.NIVA_SBK,
            NIVA_OTHER = entity.NIVA_OTHER,
            NIVA_OTHER_DESC = entity.NIVA_OTHER_DESC,
            NIVA_OTHER_DESCOMPEN = entity.NIVA_OTHER_DESCOMPEN,
            NIVA_PERCENT = entity.NIVA_PERCENT,
            NBORDEREAUX_ADV = entity.NBORDEREAUX_ADV,
        };
    }

    public static FINANC_DRA ToEntity(this CreateFINANC_DRADto dto)
    {
        if (dto == null) return null!;
        return new FINANC_DRA
        {
            NAMOUNT = dto.NAMOUNT,
            NSTAT_DRAFT = dto.NSTAT_DRAFT,
            NAMOUNT_NET = dto.NAMOUNT_NET,
            NCLAIM = dto.NCLAIM,
            NCOMMISSION = dto.NCOMMISSION,
            DCOMPDATE = dto.DCOMPDATE,
            DEXPIRDAT = dto.DEXPIRDAT,
            NINTAMMOU = dto.NINTAMMOU,
            NSTATPRINT = dto.NSTATPRINT,
            NINTERMED = dto.NINTERMED,
            DSTAT_DATE = dto.DSTAT_DATE,
            NUSERCODE = dto.NUSERCODE,
            NBULLETINS = dto.NBULLETINS,
            NAMO_AFEC = dto.NAMO_AFEC,
            NAMO_EXEN = dto.NAMO_EXEN,
            NIVA = dto.NIVA,
            NCOM_AFEC = dto.NCOM_AFEC,
            NCOM_EXEN = dto.NCOM_EXEN,
            DLIMITDATE = dto.DLIMITDATE,
            NBORDEREAUX = dto.NBORDEREAUX,
            SINDCHEQUE = dto.SINDCHEQUE,
            DCOLLSUS_INI = dto.DCOLLSUS_INI,
            DCOLLSUS_END = dto.DCOLLSUS_END,
            NSUS_REASON = dto.NSUS_REASON,
            SSUS_ORIGI = dto.SSUS_ORIGI,
            NCOLLECTOR = dto.NCOLLECTOR,
            NBILLNUM = dto.NBILLNUM,
            SBILLTYPE = dto.SBILLTYPE,
            NWAY_PAY = dto.NWAY_PAY,
            SDOCNUMBE = dto.SDOCNUMBE,
            NRETENTIONTAXCODE = dto.NRETENTIONTAXCODE,
            NRETENTIONCODE = dto.NRETENTIONCODE,
            NRETENTIONSERIES = dto.NRETENTIONSERIES,
            DAUTORIZATIONDATE = dto.DAUTORIZATIONDATE,
            DENDINGDATE = dto.DENDINGDATE,
            NRETENTION = dto.NRETENTION,
            NTAXRETENTION = dto.NTAXRETENTION,
            NRETENTIONBASE = dto.NRETENTIONBASE,
            NAUTORIZATIONNUMBER = dto.NAUTORIZATIONNUMBER,
            NEMISRIGHT = dto.NEMISRIGHT,
            NIVA_SSC = dto.NIVA_SSC,
            NIVA_SBK = dto.NIVA_SBK,
            NIVA_OTHER = dto.NIVA_OTHER,
            NIVA_OTHER_DESC = dto.NIVA_OTHER_DESC,
            NIVA_OTHER_DESCOMPEN = dto.NIVA_OTHER_DESCOMPEN,
            NIVA_PERCENT = dto.NIVA_PERCENT,
            NBORDEREAUX_ADV = dto.NBORDEREAUX_ADV,
        };
    }

    public static void UpdateEntity(this FINANC_DRA entity, UpdateFINANC_DRADto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NSTAT_DRAFT = dto.NSTAT_DRAFT;
        entity.NAMOUNT_NET = dto.NAMOUNT_NET;
        entity.NCLAIM = dto.NCLAIM;
        entity.NCOMMISSION = dto.NCOMMISSION;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.NINTAMMOU = dto.NINTAMMOU;
        entity.NSTATPRINT = dto.NSTATPRINT;
        entity.NINTERMED = dto.NINTERMED;
        entity.DSTAT_DATE = dto.DSTAT_DATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NBULLETINS = dto.NBULLETINS;
        entity.NAMO_AFEC = dto.NAMO_AFEC;
        entity.NAMO_EXEN = dto.NAMO_EXEN;
        entity.NIVA = dto.NIVA;
        entity.NCOM_AFEC = dto.NCOM_AFEC;
        entity.NCOM_EXEN = dto.NCOM_EXEN;
        entity.DLIMITDATE = dto.DLIMITDATE;
        entity.NBORDEREAUX = dto.NBORDEREAUX;
        entity.SINDCHEQUE = dto.SINDCHEQUE;
        entity.DCOLLSUS_INI = dto.DCOLLSUS_INI;
        entity.DCOLLSUS_END = dto.DCOLLSUS_END;
        entity.NSUS_REASON = dto.NSUS_REASON;
        entity.SSUS_ORIGI = dto.SSUS_ORIGI;
        entity.NCOLLECTOR = dto.NCOLLECTOR;
        entity.NBILLNUM = dto.NBILLNUM;
        entity.SBILLTYPE = dto.SBILLTYPE;
        entity.NWAY_PAY = dto.NWAY_PAY;
        entity.SDOCNUMBE = dto.SDOCNUMBE;
        entity.NRETENTIONTAXCODE = dto.NRETENTIONTAXCODE;
        entity.NRETENTIONCODE = dto.NRETENTIONCODE;
        entity.NRETENTIONSERIES = dto.NRETENTIONSERIES;
        entity.DAUTORIZATIONDATE = dto.DAUTORIZATIONDATE;
        entity.DENDINGDATE = dto.DENDINGDATE;
        entity.NRETENTION = dto.NRETENTION;
        entity.NTAXRETENTION = dto.NTAXRETENTION;
        entity.NRETENTIONBASE = dto.NRETENTIONBASE;
        entity.NAUTORIZATIONNUMBER = dto.NAUTORIZATIONNUMBER;
        entity.NEMISRIGHT = dto.NEMISRIGHT;
        entity.NIVA_SSC = dto.NIVA_SSC;
        entity.NIVA_SBK = dto.NIVA_SBK;
        entity.NIVA_OTHER = dto.NIVA_OTHER;
        entity.NIVA_OTHER_DESC = dto.NIVA_OTHER_DESC;
        entity.NIVA_OTHER_DESCOMPEN = dto.NIVA_OTHER_DESCOMPEN;
        entity.NIVA_PERCENT = dto.NIVA_PERCENT;
        entity.NBORDEREAUX_ADV = dto.NBORDEREAUX_ADV;
    }
}
