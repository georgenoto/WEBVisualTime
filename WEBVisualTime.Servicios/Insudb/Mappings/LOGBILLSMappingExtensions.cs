using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LOGBILLS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class LOGBILLSMappingExtensions
{
    public static LOGBILLSDto ToDto(this LOGBILLS entity)
    {
        if (entity == null) return null!;
        return new LOGBILLSDto
        {
            NINSUR_AREA = entity.NINSUR_AREA,
            NOPERTYPE = entity.NOPERTYPE,
            SCLIENT = entity.SCLIENT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            NBORDEREAUX = entity.NBORDEREAUX,
            NCURRENCY = entity.NCURRENCY,
            NAMOUNT = entity.NAMOUNT,
            DSTATDATE = entity.DSTATDATE,
            NSTATUSCODE = entity.NSTATUSCODE,
            SSTATUSDESC = entity.SSTATUSDESC,
            SBILLNUMSFE = entity.SBILLNUMSFE,
            NBILLNUM = entity.NBILLNUM,
            SPROCESSED = entity.SPROCESSED,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NRECEIPTCORP = entity.NRECEIPTCORP,
        };
    }

    public static LOGBILLS ToEntity(this CreateLOGBILLSDto dto)
    {
        if (dto == null) return null!;
        return new LOGBILLS
        {
            NCURRENCY = dto.NCURRENCY,
            NAMOUNT = dto.NAMOUNT,
            DSTATDATE = dto.DSTATDATE,
            NSTATUSCODE = dto.NSTATUSCODE,
            SSTATUSDESC = dto.SSTATUSDESC,
            SBILLNUMSFE = dto.SBILLNUMSFE,
            NBILLNUM = dto.NBILLNUM,
            SPROCESSED = dto.SPROCESSED,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NRECEIPTCORP = dto.NRECEIPTCORP,
        };
    }

    public static void UpdateEntity(this LOGBILLS entity, UpdateLOGBILLSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.DSTATDATE = dto.DSTATDATE;
        entity.NSTATUSCODE = dto.NSTATUSCODE;
        entity.SSTATUSDESC = dto.SSTATUSDESC;
        entity.SBILLNUMSFE = dto.SBILLNUMSFE;
        entity.NBILLNUM = dto.NBILLNUM;
        entity.SPROCESSED = dto.SPROCESSED;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NRECEIPTCORP = dto.NRECEIPTCORP;
    }
}
