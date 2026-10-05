using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRAT_PAY;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CONTRAT_PAYMappingExtensions
{
    public static CONTRAT_PAYDto ToDto(this CONTRAT_PAY entity)
    {
        if (entity == null) return null!;
        return new CONTRAT_PAYDto
        {
            NCONTRAT_PAY = entity.NCONTRAT_PAY,
            NTYPE_CONTRAT = entity.NTYPE_CONTRAT,
            STYP_COM_IND = entity.STYP_COM_IND,
            NCOM_TABNUM = entity.NCOM_TABNUM,
            SCLIENT = entity.SCLIENT,
            SDESCRIPT = entity.SDESCRIPT,
            DSTARTDATE = entity.DSTARTDATE,
            NTYPE_CALC = entity.NTYPE_CALC,
            TABLE8100SDESCRIPT = entity.TABLE8100?.SDESCRIPT,
            NPERCENT = entity.NPERCENT,
            NAMOUNT = entity.NAMOUNT,
            NCURRENCY = entity.NCURRENCY,
            NAPLY = entity.NAPLY,
            TABLE8101SDESCRIPT = entity.TABLE8101?.SDESCRIPT,
            STAXIN = entity.STAXIN,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NTYP_ACCO = entity.NTYP_ACCO,
            DEXPIRDAT = entity.DEXPIRDAT,
            SROUTINE = entity.SROUTINE,
            DLASTCALCULATED = entity.DLASTCALCULATED,
        };
    }

    public static CONTRAT_PAY ToEntity(this CreateCONTRAT_PAYDto dto)
    {
        if (dto == null) return null!;
        return new CONTRAT_PAY
        {
            STYP_COM_IND = dto.STYP_COM_IND,
            NCOM_TABNUM = dto.NCOM_TABNUM,
            SCLIENT = dto.SCLIENT,
            SDESCRIPT = dto.SDESCRIPT,
            DSTARTDATE = dto.DSTARTDATE,
            NTYPE_CALC = dto.NTYPE_CALC,
            NPERCENT = dto.NPERCENT,
            NAMOUNT = dto.NAMOUNT,
            NCURRENCY = dto.NCURRENCY,
            NAPLY = dto.NAPLY,
            STAXIN = dto.STAXIN,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NTYP_ACCO = dto.NTYP_ACCO,
            DEXPIRDAT = dto.DEXPIRDAT,
            SROUTINE = dto.SROUTINE,
            DLASTCALCULATED = dto.DLASTCALCULATED,
        };
    }

    public static void UpdateEntity(this CONTRAT_PAY entity, UpdateCONTRAT_PAYDto dto)
    {
        if (entity == null || dto == null) return;
        entity.STYP_COM_IND = dto.STYP_COM_IND;
        entity.NCOM_TABNUM = dto.NCOM_TABNUM;
        entity.SCLIENT = dto.SCLIENT;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.NTYPE_CALC = dto.NTYPE_CALC;
        entity.NPERCENT = dto.NPERCENT;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NAPLY = dto.NAPLY;
        entity.STAXIN = dto.STAXIN;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTYP_ACCO = dto.NTYP_ACCO;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.SROUTINE = dto.SROUTINE;
        entity.DLASTCALCULATED = dto.DLASTCALCULATED;
    }
}
