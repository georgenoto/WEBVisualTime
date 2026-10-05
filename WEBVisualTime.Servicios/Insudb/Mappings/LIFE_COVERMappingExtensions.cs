using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LIFE_COVER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class LIFE_COVERMappingExtensions
{
    public static LIFE_COVERDto ToDto(this LIFE_COVER entity)
    {
        if (entity == null) return null!;
        return new LIFE_COVERDto
        {
            NBRANCH = entity.NBRANCH,
            NCOVER = entity.NCOVER,
            NPRODUCT = entity.NPRODUCT,
            NMODULEC = entity.NMODULEC,
            DEFFECDATE = entity.DEFFECDATE,
            SADDSUINI = entity.SADDSUINI,
            SADDREINI = entity.SADDREINI,
            SADDTAXIN = entity.SADDTAXIN,
            NCOVERGEN = entity.NCOVERGEN,
            TAB_LIFCOVSCACALFRI = entity.TAB_LIFCOV?.SCACALFRI,
            NBILL_ITEM = entity.NBILL_ITEM,
            NBRANCH_GEN = entity.NBRANCH_GEN,
            TABLE634SDESCRIPT = entity.TABLE634?.SDESCRIPT,
            NBRANCH_EST = entity.NBRANCH_EST,
            TABLE71SDESCRIPT = entity.TABLE71?.SDESCRIPT,
            NBRANCH_LED = entity.NBRANCH_LED,
            TABLE75SDESCRIPT = entity.TABLE75?.SDESCRIPT,
            NBRANCH_REI = entity.NBRANCH_REI,
            TABLE5000SDESCRIPT = entity.TABLE5000?.SDESCRIPT,
            NCAEXTEXP = entity.NCAEXTEXP,
            SMORTACOF = entity.SMORTACOF,
            NCAINTEXP = entity.NCAINTEXP,
            SMORTACOM = entity.SMORTACOM,
            NRETARIF = entity.NRETARIF,
            TABLE5559SDESCRIPT = entity.TABLE5559?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            SCOVERUSE = entity.SCOVERUSE,
            NCURRENCY = entity.NCURRENCY,
            NINTEREST = entity.NINTEREST,
            DNULLDATE = entity.DNULLDATE,
            NNOTENUM = entity.NNOTENUM,
            NPREXTEXP = entity.NPREXTEXP,
            NPRINTEXP = entity.NPRINTEXP,
            SROURESER = entity.SROURESER,
            SROUSURRE = entity.SROUSURRE,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            SCONTROL = entity.SCONTROL,
            NPER_TABMOR = entity.NPER_TABMOR,
            SCALREIN = entity.SCALREIN,
            SDEPEND = entity.SDEPEND,
            SSURV = entity.SSURV,
            SREINORIGCOND = entity.SREINORIGCOND,
            SCONDSVS = entity.SCONDSVS,
            SROUCLATEC = entity.SROUCLATEC,
            SROUTRESRISK = entity.SROUTRESRISK,
            NRATECLA = entity.NRATECLA,
            NFIXAMOCLA = entity.NFIXAMOCLA,
            NMINAMOCLA = entity.NMINAMOCLA,
            NMAXAMOCLA = entity.NMAXAMOCLA,
            NDISCCLA = entity.NDISCCLA,
            NDISC_AMOCLA = entity.NDISC_AMOCLA,
            NFRANCDAYS = entity.NFRANCDAYS,
            SRESOLUTION = entity.SRESOLUTION,
            SGOVAPRNAME = entity.SGOVAPRNAME,
            DRESDATE = entity.DRESDATE,
            STECPREMIND = entity.STECPREMIND,
            SRISPREMIND = entity.SRISPREMIND,
        };
    }

    public static LIFE_COVER ToEntity(this CreateLIFE_COVERDto dto)
    {
        if (dto == null) return null!;
        return new LIFE_COVER
        {
            SADDSUINI = dto.SADDSUINI,
            SADDREINI = dto.SADDREINI,
            SADDTAXIN = dto.SADDTAXIN,
            NCOVERGEN = dto.NCOVERGEN,
            NBILL_ITEM = dto.NBILL_ITEM,
            NBRANCH_GEN = dto.NBRANCH_GEN,
            NBRANCH_EST = dto.NBRANCH_EST,
            NBRANCH_LED = dto.NBRANCH_LED,
            NBRANCH_REI = dto.NBRANCH_REI,
            NCAEXTEXP = dto.NCAEXTEXP,
            SMORTACOF = dto.SMORTACOF,
            NCAINTEXP = dto.NCAINTEXP,
            SMORTACOM = dto.SMORTACOM,
            NRETARIF = dto.NRETARIF,
            DCOMPDATE = dto.DCOMPDATE,
            SCOVERUSE = dto.SCOVERUSE,
            NCURRENCY = dto.NCURRENCY,
            NINTEREST = dto.NINTEREST,
            DNULLDATE = dto.DNULLDATE,
            NNOTENUM = dto.NNOTENUM,
            NPREXTEXP = dto.NPREXTEXP,
            NPRINTEXP = dto.NPRINTEXP,
            SROURESER = dto.SROURESER,
            SROUSURRE = dto.SROUSURRE,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            SCONTROL = dto.SCONTROL,
            NPER_TABMOR = dto.NPER_TABMOR,
            SCALREIN = dto.SCALREIN,
            SDEPEND = dto.SDEPEND,
            SSURV = dto.SSURV,
            SREINORIGCOND = dto.SREINORIGCOND,
            SCONDSVS = dto.SCONDSVS,
            SROUCLATEC = dto.SROUCLATEC,
            SROUTRESRISK = dto.SROUTRESRISK,
            NRATECLA = dto.NRATECLA,
            NFIXAMOCLA = dto.NFIXAMOCLA,
            NMINAMOCLA = dto.NMINAMOCLA,
            NMAXAMOCLA = dto.NMAXAMOCLA,
            NDISCCLA = dto.NDISCCLA,
            NDISC_AMOCLA = dto.NDISC_AMOCLA,
            NFRANCDAYS = dto.NFRANCDAYS,
            SRESOLUTION = dto.SRESOLUTION,
            SGOVAPRNAME = dto.SGOVAPRNAME,
            DRESDATE = dto.DRESDATE,
            STECPREMIND = dto.STECPREMIND,
            SRISPREMIND = dto.SRISPREMIND,
        };
    }

    public static void UpdateEntity(this LIFE_COVER entity, UpdateLIFE_COVERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SADDSUINI = dto.SADDSUINI;
        entity.SADDREINI = dto.SADDREINI;
        entity.SADDTAXIN = dto.SADDTAXIN;
        entity.NCOVERGEN = dto.NCOVERGEN;
        entity.NBILL_ITEM = dto.NBILL_ITEM;
        entity.NBRANCH_GEN = dto.NBRANCH_GEN;
        entity.NBRANCH_EST = dto.NBRANCH_EST;
        entity.NBRANCH_LED = dto.NBRANCH_LED;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.NCAEXTEXP = dto.NCAEXTEXP;
        entity.SMORTACOF = dto.SMORTACOF;
        entity.NCAINTEXP = dto.NCAINTEXP;
        entity.SMORTACOM = dto.SMORTACOM;
        entity.NRETARIF = dto.NRETARIF;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SCOVERUSE = dto.SCOVERUSE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NINTEREST = dto.NINTEREST;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NPREXTEXP = dto.NPREXTEXP;
        entity.NPRINTEXP = dto.NPRINTEXP;
        entity.SROURESER = dto.SROURESER;
        entity.SROUSURRE = dto.SROUSURRE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCONTROL = dto.SCONTROL;
        entity.NPER_TABMOR = dto.NPER_TABMOR;
        entity.SCALREIN = dto.SCALREIN;
        entity.SDEPEND = dto.SDEPEND;
        entity.SSURV = dto.SSURV;
        entity.SREINORIGCOND = dto.SREINORIGCOND;
        entity.SCONDSVS = dto.SCONDSVS;
        entity.SROUCLATEC = dto.SROUCLATEC;
        entity.SROUTRESRISK = dto.SROUTRESRISK;
        entity.NRATECLA = dto.NRATECLA;
        entity.NFIXAMOCLA = dto.NFIXAMOCLA;
        entity.NMINAMOCLA = dto.NMINAMOCLA;
        entity.NMAXAMOCLA = dto.NMAXAMOCLA;
        entity.NDISCCLA = dto.NDISCCLA;
        entity.NDISC_AMOCLA = dto.NDISC_AMOCLA;
        entity.NFRANCDAYS = dto.NFRANCDAYS;
        entity.SRESOLUTION = dto.SRESOLUTION;
        entity.SGOVAPRNAME = dto.SGOVAPRNAME;
        entity.DRESDATE = dto.DRESDATE;
        entity.STECPREMIND = dto.STECPREMIND;
        entity.SRISPREMIND = dto.SRISPREMIND;
    }
}
