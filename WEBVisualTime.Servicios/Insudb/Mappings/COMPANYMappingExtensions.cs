using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COMPANYMappingExtensions
{
    public static COMPANYDto ToDto(this COMPANY entity)
    {
        if (entity == null) return null!;
        return new COMPANYDto
        {
            NCOMPANY = entity.NCOMPANY,
            SACCOUNT = entity.SACCOUNT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            SBANKNAME = entity.SBANKNAME,
            DCOMPDATE = entity.DCOMPDATE,
            NCOUNTRY = entity.NCOUNTRY,
            TABLE66SDESCRIPT = entity.TABLE66?.SDESCRIPT,
            DINPDATE = entity.DINPDATE,
            SSTATREGT = entity.SSTATREGT,
            NTAXRATE = entity.NTAXRATE,
            STYPE = entity.STYPE,
            SREGSVS = entity.SREGSVS,
            NUSERCODE = entity.NUSERCODE,
            SNATIONAL = entity.SNATIONAL,
            NCLASIFIC = entity.NCLASIFIC,
            TABLE5563SDESCRIPT = entity.TABLE5563?.SDESCRIPT,
            SABA_ID = entity.SABA_ID,
            SWIFT_IT = entity.SWIFT_IT,
            NLOCAL = entity.NLOCAL,
            TAB_LOCATSDESCRIPT = entity.TAB_LOCAT?.SDESCRIPT,
            SCITY = entity.SCITY,
            NBANKCOUNTRY = entity.NBANKCOUNTRY,
        };
    }

    public static COMPANY ToEntity(this CreateCOMPANYDto dto)
    {
        if (dto == null) return null!;
        return new COMPANY
        {
            SACCOUNT = dto.SACCOUNT,
            SCLIENT = dto.SCLIENT,
            SBANKNAME = dto.SBANKNAME,
            DCOMPDATE = dto.DCOMPDATE,
            NCOUNTRY = dto.NCOUNTRY,
            DINPDATE = dto.DINPDATE,
            SSTATREGT = dto.SSTATREGT,
            NTAXRATE = dto.NTAXRATE,
            STYPE = dto.STYPE,
            SREGSVS = dto.SREGSVS,
            NUSERCODE = dto.NUSERCODE,
            SNATIONAL = dto.SNATIONAL,
            NCLASIFIC = dto.NCLASIFIC,
            SABA_ID = dto.SABA_ID,
            SWIFT_IT = dto.SWIFT_IT,
            NLOCAL = dto.NLOCAL,
            SCITY = dto.SCITY,
            NBANKCOUNTRY = dto.NBANKCOUNTRY,
        };
    }

    public static void UpdateEntity(this COMPANY entity, UpdateCOMPANYDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SACCOUNT = dto.SACCOUNT;
        entity.SCLIENT = dto.SCLIENT;
        entity.SBANKNAME = dto.SBANKNAME;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCOUNTRY = dto.NCOUNTRY;
        entity.DINPDATE = dto.DINPDATE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NTAXRATE = dto.NTAXRATE;
        entity.STYPE = dto.STYPE;
        entity.SREGSVS = dto.SREGSVS;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SNATIONAL = dto.SNATIONAL;
        entity.NCLASIFIC = dto.NCLASIFIC;
        entity.SABA_ID = dto.SABA_ID;
        entity.SWIFT_IT = dto.SWIFT_IT;
        entity.NLOCAL = dto.NLOCAL;
        entity.SCITY = dto.SCITY;
        entity.NBANKCOUNTRY = dto.NBANKCOUNTRY;
    }
}
