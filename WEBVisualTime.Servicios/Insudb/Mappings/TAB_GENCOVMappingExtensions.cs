using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_GENCOV;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_GENCOVMappingExtensions
{
    public static TAB_GENCOVDto ToDto(this TAB_GENCOV entity)
    {
        if (entity == null) return null!;
        return new TAB_GENCOVDto
        {
            NCOVERGEN = entity.NCOVERGEN,
            SAUTOMREP = entity.SAUTOMREP,
            NBRANCH_LED = entity.NBRANCH_LED,
            TABLE75SDESCRIPT = entity.TABLE75?.SDESCRIPT,
            NBRANCH_EST = entity.NBRANCH_EST,
            TABLE71SDESCRIPT = entity.TABLE71?.SDESCRIPT,
            NBRANCH_GEN = entity.NBRANCH_GEN,
            TABLE634SDESCRIPT = entity.TABLE634?.SDESCRIPT,
            NBRANCH_REI = entity.NBRANCH_REI,
            TABLE5000SDESCRIPT = entity.TABLE5000?.SDESCRIPT,
            NCACALFIX = entity.NCACALFIX,
            SCACALFRI = entity.SCACALFRI,
            SCACALILI = entity.SCACALILI,
            SCACALREI = entity.SCACALREI,
            DCOMPDATE = entity.DCOMPDATE,
            NCOVER_IN = entity.NCOVER_IN,
            NCURRENCY = entity.NCURRENCY,
            SDESCRIPT = entity.SDESCRIPT,
            SFRANCAPL = entity.SFRANCAPL,
            TABLE33SDESCRIPT = entity.TABLE33?.SDESCRIPT,
            NFRANCFIX = entity.NFRANCFIX,
            NFRANCMAX = entity.NFRANCMAX,
            NFRANCMIN = entity.NFRANCMIN,
            NFRANCRAT = entity.NFRANCRAT,
            SFRANTYPE = entity.SFRANTYPE,
            TABLE64SDESCRIPT = entity.TABLE64?.SDESCRIPT,
            NMEDRESER = entity.NMEDRESER,
            NPREMIFIX = entity.NPREMIFIX,
            NPREMIMAX = entity.NPREMIMAX,
            NPREMIMIN = entity.NPREMIMIN,
            NPREMIRAT = entity.NPREMIRAT,
            SROUCAPIT = entity.SROUCAPIT,
            SROUFRANC = entity.SROUFRANC,
            SROUPREMI = entity.SROUPREMI,
            SROURESER = entity.SROURESER,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            SCONDSVS = entity.SCONDSVS,
            SINFORPROV = entity.SINFORPROV,
            SPROVIDER = entity.SPROVIDER,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            SRISK = entity.SRISK,
            NFRANCRATCLA = entity.NFRANCRATCLA,
            NFRANCFIXCLA = entity.NFRANCFIXCLA,
            NFRANXMINCLA = entity.NFRANXMINCLA,
            NFRANXMAXCLA = entity.NFRANXMAXCLA,
            SROUFRANCCLA = entity.SROUFRANCCLA,
            STAXHEREDITY = entity.STAXHEREDITY,
            DSTARTDATE = entity.DSTARTDATE,
            DOCCURDAT = entity.DOCCURDAT,
        };
    }

    public static TAB_GENCOV ToEntity(this CreateTAB_GENCOVDto dto)
    {
        if (dto == null) return null!;
        return new TAB_GENCOV
        {
            SAUTOMREP = dto.SAUTOMREP,
            NBRANCH_LED = dto.NBRANCH_LED,
            NBRANCH_EST = dto.NBRANCH_EST,
            NBRANCH_GEN = dto.NBRANCH_GEN,
            NBRANCH_REI = dto.NBRANCH_REI,
            NCACALFIX = dto.NCACALFIX,
            SCACALFRI = dto.SCACALFRI,
            SCACALILI = dto.SCACALILI,
            SCACALREI = dto.SCACALREI,
            DCOMPDATE = dto.DCOMPDATE,
            NCOVER_IN = dto.NCOVER_IN,
            NCURRENCY = dto.NCURRENCY,
            SDESCRIPT = dto.SDESCRIPT,
            SFRANCAPL = dto.SFRANCAPL,
            NFRANCFIX = dto.NFRANCFIX,
            NFRANCMAX = dto.NFRANCMAX,
            NFRANCMIN = dto.NFRANCMIN,
            NFRANCRAT = dto.NFRANCRAT,
            SFRANTYPE = dto.SFRANTYPE,
            NMEDRESER = dto.NMEDRESER,
            NPREMIFIX = dto.NPREMIFIX,
            NPREMIMAX = dto.NPREMIMAX,
            NPREMIMIN = dto.NPREMIMIN,
            NPREMIRAT = dto.NPREMIRAT,
            SROUCAPIT = dto.SROUCAPIT,
            SROUFRANC = dto.SROUFRANC,
            SROUPREMI = dto.SROUPREMI,
            SROURESER = dto.SROURESER,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            SCONDSVS = dto.SCONDSVS,
            SINFORPROV = dto.SINFORPROV,
            SPROVIDER = dto.SPROVIDER,
            SRISK = dto.SRISK,
            NFRANCRATCLA = dto.NFRANCRATCLA,
            NFRANCFIXCLA = dto.NFRANCFIXCLA,
            NFRANXMINCLA = dto.NFRANXMINCLA,
            NFRANXMAXCLA = dto.NFRANXMAXCLA,
            SROUFRANCCLA = dto.SROUFRANCCLA,
            STAXHEREDITY = dto.STAXHEREDITY,
            DSTARTDATE = dto.DSTARTDATE,
            DOCCURDAT = dto.DOCCURDAT,
        };
    }

    public static void UpdateEntity(this TAB_GENCOV entity, UpdateTAB_GENCOVDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SAUTOMREP = dto.SAUTOMREP;
        entity.NBRANCH_LED = dto.NBRANCH_LED;
        entity.NBRANCH_EST = dto.NBRANCH_EST;
        entity.NBRANCH_GEN = dto.NBRANCH_GEN;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.NCACALFIX = dto.NCACALFIX;
        entity.SCACALFRI = dto.SCACALFRI;
        entity.SCACALILI = dto.SCACALILI;
        entity.SCACALREI = dto.SCACALREI;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCOVER_IN = dto.NCOVER_IN;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SFRANCAPL = dto.SFRANCAPL;
        entity.NFRANCFIX = dto.NFRANCFIX;
        entity.NFRANCMAX = dto.NFRANCMAX;
        entity.NFRANCMIN = dto.NFRANCMIN;
        entity.NFRANCRAT = dto.NFRANCRAT;
        entity.SFRANTYPE = dto.SFRANTYPE;
        entity.NMEDRESER = dto.NMEDRESER;
        entity.NPREMIFIX = dto.NPREMIFIX;
        entity.NPREMIMAX = dto.NPREMIMAX;
        entity.NPREMIMIN = dto.NPREMIMIN;
        entity.NPREMIRAT = dto.NPREMIRAT;
        entity.SROUCAPIT = dto.SROUCAPIT;
        entity.SROUFRANC = dto.SROUFRANC;
        entity.SROUPREMI = dto.SROUPREMI;
        entity.SROURESER = dto.SROURESER;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCONDSVS = dto.SCONDSVS;
        entity.SINFORPROV = dto.SINFORPROV;
        entity.SPROVIDER = dto.SPROVIDER;
        entity.SRISK = dto.SRISK;
        entity.NFRANCRATCLA = dto.NFRANCRATCLA;
        entity.NFRANCFIXCLA = dto.NFRANCFIXCLA;
        entity.NFRANXMINCLA = dto.NFRANXMINCLA;
        entity.NFRANXMAXCLA = dto.NFRANXMAXCLA;
        entity.SROUFRANCCLA = dto.SROUFRANCCLA;
        entity.STAXHEREDITY = dto.STAXHEREDITY;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.DOCCURDAT = dto.DOCCURDAT;
    }
}
