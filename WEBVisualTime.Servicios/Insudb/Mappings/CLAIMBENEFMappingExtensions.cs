using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIMBENEF;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIMBENEFMappingExtensions
{
    public static CLAIMBENEFDto ToDto(this CLAIMBENEF entity)
    {
        if (entity == null) return null!;
        return new CLAIMBENEFDto
        {
            NCLAIM = entity.NCLAIM,
            CLAIM_CASENCLAIMSSTACASE = entity.CLAIM_CASENCLAIM?.SSTACASE,
            NCASE_NUM = entity.NCASE_NUM,
            CLAIM_CASENCASE_NUMSSTACASE = entity.CLAIM_CASENCASE_NUM?.SSTACASE,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            CLAIM_CASENDEMAN_TYPESSTACASE = entity.CLAIM_CASENDEMAN_TYPE?.SSTACASE,
            SCLIENT = entity.SCLIENT,
            CLIENTSCLIENTSACCOUNT_IN = entity.CLIENTSCLIENT?.SACCOUNT_IN,
            NBENE_TYPE = entity.NBENE_TYPE,
            TABLE184SDESCRIPT = entity.TABLE184?.SDESCRIPT,
            NID = entity.NID,
            NOFFICE_PAY = entity.NOFFICE_PAY,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            SDEMANDANT = entity.SDEMANDANT,
            NUSERCODE = entity.NUSERCODE,
            NRELATION = entity.NRELATION,
            TABLE15SDESCRIPT = entity.TABLE15?.SDESCRIPT,
            NPARTICIP = entity.NPARTICIP,
            SBENEF_TYP = entity.SBENEF_TYP,
            NAMOUNT = entity.NAMOUNT,
            DINIT_DATE = entity.DINIT_DATE,
            DEND_DATE = entity.DEND_DATE,
            SCLIENT_REP = entity.SCLIENT_REP,
            CLIENTSCLIENT_REPSACCOUNT_IN = entity.CLIENTSCLIENT_REP?.SACCOUNT_IN,
            DNEXT_PAY = entity.DNEXT_PAY,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            NCURRENCY = entity.NCURRENCY,
            SPAY_INSTALL = entity.SPAY_INSTALL,
            NOFFICEAGEN_PAY = entity.NOFFICEAGEN_PAY,
            TABLE5556SDESCRIPT = entity.TABLE5556?.SDESCRIPT,
            NAGENCY_PAY = entity.NAGENCY_PAY,
            AGENCIESSPAY = entity.AGENCIES?.SPAY,
            NNOTENUM = entity.NNOTENUM,
            DSHOWDATE = entity.DSHOWDATE,
            NPAYMENTADDRESS = entity.NPAYMENTADDRESS,
            TABLE7801SDESCRIPT = entity.TABLE7801?.SDESCRIPT,
        };
    }

    public static CLAIMBENEF ToEntity(this CreateCLAIMBENEFDto dto)
    {
        if (dto == null) return null!;
        return new CLAIMBENEF
        {
            NBENE_TYPE = dto.NBENE_TYPE,
            NOFFICE_PAY = dto.NOFFICE_PAY,
            DCOMPDATE = dto.DCOMPDATE,
            SDEMANDANT = dto.SDEMANDANT,
            NUSERCODE = dto.NUSERCODE,
            NRELATION = dto.NRELATION,
            NPARTICIP = dto.NPARTICIP,
            SBENEF_TYP = dto.SBENEF_TYP,
            NAMOUNT = dto.NAMOUNT,
            DINIT_DATE = dto.DINIT_DATE,
            DEND_DATE = dto.DEND_DATE,
            SCLIENT_REP = dto.SCLIENT_REP,
            DNEXT_PAY = dto.DNEXT_PAY,
            NMODULEC = dto.NMODULEC,
            NCOVER = dto.NCOVER,
            NCURRENCY = dto.NCURRENCY,
            SPAY_INSTALL = dto.SPAY_INSTALL,
            NOFFICEAGEN_PAY = dto.NOFFICEAGEN_PAY,
            NAGENCY_PAY = dto.NAGENCY_PAY,
            NNOTENUM = dto.NNOTENUM,
            DSHOWDATE = dto.DSHOWDATE,
            NPAYMENTADDRESS = dto.NPAYMENTADDRESS,
        };
    }

    public static void UpdateEntity(this CLAIMBENEF entity, UpdateCLAIMBENEFDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NBENE_TYPE = dto.NBENE_TYPE;
        entity.NOFFICE_PAY = dto.NOFFICE_PAY;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDEMANDANT = dto.SDEMANDANT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NRELATION = dto.NRELATION;
        entity.NPARTICIP = dto.NPARTICIP;
        entity.SBENEF_TYP = dto.SBENEF_TYP;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.DINIT_DATE = dto.DINIT_DATE;
        entity.DEND_DATE = dto.DEND_DATE;
        entity.SCLIENT_REP = dto.SCLIENT_REP;
        entity.DNEXT_PAY = dto.DNEXT_PAY;
        entity.NMODULEC = dto.NMODULEC;
        entity.NCOVER = dto.NCOVER;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.SPAY_INSTALL = dto.SPAY_INSTALL;
        entity.NOFFICEAGEN_PAY = dto.NOFFICEAGEN_PAY;
        entity.NAGENCY_PAY = dto.NAGENCY_PAY;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.DSHOWDATE = dto.DSHOWDATE;
        entity.NPAYMENTADDRESS = dto.NPAYMENTADDRESS;
    }
}
