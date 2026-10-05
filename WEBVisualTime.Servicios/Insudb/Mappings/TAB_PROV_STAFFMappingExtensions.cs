using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_STAFF;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_PROV_STAFFMappingExtensions
{
    public static TAB_PROV_STAFFDto ToDto(this TAB_PROV_STAFF entity)
    {
        if (entity == null) return null!;
        return new TAB_PROV_STAFFDto
        {
            NPROVIDER = entity.NPROVIDER,
            TAB_PROVIDERNPROVIDERSSTATREGT = entity.TAB_PROVIDERNPROVIDER?.SSTATREGT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DEFFECDATE = entity.DEFFECDATE,
            NSERV_ESTRUCT = entity.NSERV_ESTRUCT,
            TABLE9258SDESCRIPT = entity.TABLE9258?.SDESCRIPT,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NPROVIDER_REL = entity.NPROVIDER_REL,
            TAB_PROVIDERNPROVIDER_RELSSTATREGT = entity.TAB_PROVIDERNPROVIDER_REL?.SSTATREGT,
        };
    }

    public static TAB_PROV_STAFF ToEntity(this CreateTAB_PROV_STAFFDto dto)
    {
        if (dto == null) return null!;
        return new TAB_PROV_STAFF
        {
            NSERV_ESTRUCT = dto.NSERV_ESTRUCT,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NPROVIDER_REL = dto.NPROVIDER_REL,
        };
    }

    public static void UpdateEntity(this TAB_PROV_STAFF entity, UpdateTAB_PROV_STAFFDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NSERV_ESTRUCT = dto.NSERV_ESTRUCT;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NPROVIDER_REL = dto.NPROVIDER_REL;
    }
}
