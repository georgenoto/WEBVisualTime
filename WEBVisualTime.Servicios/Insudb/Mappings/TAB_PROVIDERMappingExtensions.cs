using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_PROVIDERMappingExtensions
{
    public static TAB_PROVIDERDto ToDto(this TAB_PROVIDER entity)
    {
        if (entity == null) return null!;
        return new TAB_PROVIDERDto
        {
            NPROVIDER = entity.NPROVIDER,
            NTYPEPROV = entity.NTYPEPROV,
            TAB_PROV_SUBTYPESNTYPEPROVSDESCRIPT = entity.TAB_PROV_SUBTYPESNTYPEPROV?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DCOMPDATE = entity.DCOMPDATE,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DINPDATE = entity.DINPDATE,
            DOUTDATE = entity.DOUTDATE,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NMAX_SERV_ORD = entity.NMAX_SERV_ORD,
            NTYPESUPPORT = entity.NTYPESUPPORT,
            TABLE5570SDESCRIPT = entity.TABLE5570?.SDESCRIPT,
            NPER_DISC = entity.NPER_DISC,
            SCONCESIONARY = entity.SCONCESIONARY,
            SAGENCYDESC = entity.SAGENCYDESC,
            NCLASS_PROV = entity.NCLASS_PROV,
            TABLE9253SDESCRIPT = entity.TABLE9253?.SDESCRIPT,
            NCATEG_PROV = entity.NCATEG_PROV,
            TABLE9259SDESCRIPT = entity.TABLE9259?.SDESCRIPT,
            NTYPEDISC_PROV = entity.NTYPEDISC_PROV,
            TABLE9254SDESCRIPT = entity.TABLE9254?.SDESCRIPT,
            NSUBTYPEPROV = entity.NSUBTYPEPROV,
            TAB_PROV_SUBTYPESNSUBTYPEPROVSDESCRIPT = entity.TAB_PROV_SUBTYPESNSUBTYPEPROV?.SDESCRIPT,
            DREQDATE = entity.DREQDATE,
            DREGDATE = entity.DREGDATE,
            NDISC_PROV = entity.NDISC_PROV,
            NCURRDISC_PROV = entity.NCURRDISC_PROV,
            NAMODISC_PROV = entity.NAMODISC_PROV,
            NPAYMENT_METHOD = entity.NPAYMENT_METHOD,
            TABLE9252SDESCRIPT = entity.TABLE9252?.SDESCRIPT,
            NJOINED = entity.NJOINED,
            NCOD_INSTEDUC = entity.NCOD_INSTEDUC,
            TABLE9255SDESCRIPT = entity.TABLE9255?.SDESCRIPT,
            NCOD_MEDCOLLEGE = entity.NCOD_MEDCOLLEGE,
            TABLE9256SDESCRIPT = entity.TABLE9256?.SDESCRIPT,
            SINTERNATIONALPROVIDER = entity.SINTERNATIONALPROVIDER,
        };
    }

    public static TAB_PROVIDER ToEntity(this CreateTAB_PROVIDERDto dto)
    {
        if (dto == null) return null!;
        return new TAB_PROVIDER
        {
            NTYPEPROV = dto.NTYPEPROV,
            SCLIENT = dto.SCLIENT,
            DCOMPDATE = dto.DCOMPDATE,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DINPDATE = dto.DINPDATE,
            DOUTDATE = dto.DOUTDATE,
            NOFFICE = dto.NOFFICE,
            NMAX_SERV_ORD = dto.NMAX_SERV_ORD,
            NTYPESUPPORT = dto.NTYPESUPPORT,
            NPER_DISC = dto.NPER_DISC,
            SCONCESIONARY = dto.SCONCESIONARY,
            SAGENCYDESC = dto.SAGENCYDESC,
            NCLASS_PROV = dto.NCLASS_PROV,
            NCATEG_PROV = dto.NCATEG_PROV,
            NTYPEDISC_PROV = dto.NTYPEDISC_PROV,
            NSUBTYPEPROV = dto.NSUBTYPEPROV,
            DREQDATE = dto.DREQDATE,
            DREGDATE = dto.DREGDATE,
            NDISC_PROV = dto.NDISC_PROV,
            NCURRDISC_PROV = dto.NCURRDISC_PROV,
            NAMODISC_PROV = dto.NAMODISC_PROV,
            NPAYMENT_METHOD = dto.NPAYMENT_METHOD,
            NJOINED = dto.NJOINED,
            NCOD_INSTEDUC = dto.NCOD_INSTEDUC,
            NCOD_MEDCOLLEGE = dto.NCOD_MEDCOLLEGE,
            SINTERNATIONALPROVIDER = dto.SINTERNATIONALPROVIDER,
        };
    }

    public static void UpdateEntity(this TAB_PROVIDER entity, UpdateTAB_PROVIDERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYPEPROV = dto.NTYPEPROV;
        entity.SCLIENT = dto.SCLIENT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DINPDATE = dto.DINPDATE;
        entity.DOUTDATE = dto.DOUTDATE;
        entity.NOFFICE = dto.NOFFICE;
        entity.NMAX_SERV_ORD = dto.NMAX_SERV_ORD;
        entity.NTYPESUPPORT = dto.NTYPESUPPORT;
        entity.NPER_DISC = dto.NPER_DISC;
        entity.SCONCESIONARY = dto.SCONCESIONARY;
        entity.SAGENCYDESC = dto.SAGENCYDESC;
        entity.NCLASS_PROV = dto.NCLASS_PROV;
        entity.NCATEG_PROV = dto.NCATEG_PROV;
        entity.NTYPEDISC_PROV = dto.NTYPEDISC_PROV;
        entity.NSUBTYPEPROV = dto.NSUBTYPEPROV;
        entity.DREQDATE = dto.DREQDATE;
        entity.DREGDATE = dto.DREGDATE;
        entity.NDISC_PROV = dto.NDISC_PROV;
        entity.NCURRDISC_PROV = dto.NCURRDISC_PROV;
        entity.NAMODISC_PROV = dto.NAMODISC_PROV;
        entity.NPAYMENT_METHOD = dto.NPAYMENT_METHOD;
        entity.NJOINED = dto.NJOINED;
        entity.NCOD_INSTEDUC = dto.NCOD_INSTEDUC;
        entity.NCOD_MEDCOLLEGE = dto.NCOD_MEDCOLLEGE;
        entity.SINTERNATIONALPROVIDER = dto.SINTERNATIONALPROVIDER;
    }
}
