using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_BENEF;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MASTERCL_BENEFMappingExtensions
{
    public static MASTERCL_BENEFDto ToDto(this MASTERCL_BENEF entity)
    {
        if (entity == null) return null!;
        return new MASTERCL_BENEFDto
        {
            NMASTERORDER = entity.NMASTERORDER,
            NCONSEC = entity.NCONSEC,
            SCLIENT_BENEF = entity.SCLIENT_BENEF,
            SCLIENT_REP = entity.SCLIENT_REP,
            NCLAIM = entity.NCLAIM,
            NCASE_NUM = entity.NCASE_NUM,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            NCLAIMBENEF_ID = entity.NCLAIMBENEF_ID,
            NBENE_TYPE = entity.NBENE_TYPE,
            NRELATION = entity.NRELATION,
            NPARTICIP = entity.NPARTICIP,
            NORDER_NUM = entity.NORDER_NUM,
            SCLIENAME_BEN = entity.SCLIENAME_BEN,
            NTYPCLIENTDOC_BEN = entity.NTYPCLIENTDOC_BEN,
            SCLINUMDOCU_BEN = entity.SCLINUMDOCU_BEN,
            SPHONE_BEN = entity.SPHONE_BEN,
            SCELLPHONE_BEN = entity.SCELLPHONE_BEN,
            SEMAIL_BEN = entity.SEMAIL_BEN,
            SCLIENAME_REP = entity.SCLIENAME_REP,
            NTYPCLIENTDOC_REP = entity.NTYPCLIENTDOC_REP,
            SCLINUMDOCU_REP = entity.SCLINUMDOCU_REP,
            SPHONE_REP = entity.SPHONE_REP,
            SCELLPHONE_REP = entity.SCELLPHONE_REP,
            SEMAIL_REP = entity.SEMAIL_REP,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
        };
    }

    public static MASTERCL_BENEF ToEntity(this CreateMASTERCL_BENEFDto dto)
    {
        if (dto == null) return null!;
        return new MASTERCL_BENEF
        {
            SCLIENT_BENEF = dto.SCLIENT_BENEF,
            SCLIENT_REP = dto.SCLIENT_REP,
            NCLAIM = dto.NCLAIM,
            NCASE_NUM = dto.NCASE_NUM,
            NDEMAN_TYPE = dto.NDEMAN_TYPE,
            NCLAIMBENEF_ID = dto.NCLAIMBENEF_ID,
            NBENE_TYPE = dto.NBENE_TYPE,
            NRELATION = dto.NRELATION,
            NPARTICIP = dto.NPARTICIP,
            NORDER_NUM = dto.NORDER_NUM,
            SCLIENAME_BEN = dto.SCLIENAME_BEN,
            NTYPCLIENTDOC_BEN = dto.NTYPCLIENTDOC_BEN,
            SCLINUMDOCU_BEN = dto.SCLINUMDOCU_BEN,
            SPHONE_BEN = dto.SPHONE_BEN,
            SCELLPHONE_BEN = dto.SCELLPHONE_BEN,
            SEMAIL_BEN = dto.SEMAIL_BEN,
            SCLIENAME_REP = dto.SCLIENAME_REP,
            NTYPCLIENTDOC_REP = dto.NTYPCLIENTDOC_REP,
            SCLINUMDOCU_REP = dto.SCLINUMDOCU_REP,
            SPHONE_REP = dto.SPHONE_REP,
            SCELLPHONE_REP = dto.SCELLPHONE_REP,
            SEMAIL_REP = dto.SEMAIL_REP,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this MASTERCL_BENEF entity, UpdateMASTERCL_BENEFDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCLIENT_BENEF = dto.SCLIENT_BENEF;
        entity.SCLIENT_REP = dto.SCLIENT_REP;
        entity.NCLAIM = dto.NCLAIM;
        entity.NCASE_NUM = dto.NCASE_NUM;
        entity.NDEMAN_TYPE = dto.NDEMAN_TYPE;
        entity.NCLAIMBENEF_ID = dto.NCLAIMBENEF_ID;
        entity.NBENE_TYPE = dto.NBENE_TYPE;
        entity.NRELATION = dto.NRELATION;
        entity.NPARTICIP = dto.NPARTICIP;
        entity.NORDER_NUM = dto.NORDER_NUM;
        entity.SCLIENAME_BEN = dto.SCLIENAME_BEN;
        entity.NTYPCLIENTDOC_BEN = dto.NTYPCLIENTDOC_BEN;
        entity.SCLINUMDOCU_BEN = dto.SCLINUMDOCU_BEN;
        entity.SPHONE_BEN = dto.SPHONE_BEN;
        entity.SCELLPHONE_BEN = dto.SCELLPHONE_BEN;
        entity.SEMAIL_BEN = dto.SEMAIL_BEN;
        entity.SCLIENAME_REP = dto.SCLIENAME_REP;
        entity.NTYPCLIENTDOC_REP = dto.NTYPCLIENTDOC_REP;
        entity.SCLINUMDOCU_REP = dto.SCLINUMDOCU_REP;
        entity.SPHONE_REP = dto.SPHONE_REP;
        entity.SCELLPHONE_REP = dto.SCELLPHONE_REP;
        entity.SEMAIL_REP = dto.SEMAIL_REP;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
