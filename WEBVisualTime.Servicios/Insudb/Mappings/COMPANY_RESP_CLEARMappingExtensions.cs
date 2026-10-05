using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY_RESP_CLEAR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COMPANY_RESP_CLEARMappingExtensions
{
    public static COMPANY_RESP_CLEARDto ToDto(this COMPANY_RESP_CLEAR entity)
    {
        if (entity == null) return null!;
        return new COMPANY_RESP_CLEARDto
        {
            NCOMPANY = entity.NCOMPANY,
            SACCOUNT = entity.SACCOUNT,
            SCLIENT = entity.SCLIENT,
            SBANKNAME = entity.SBANKNAME,
            DCOMPDATE = entity.DCOMPDATE,
            NCOUNTRY = entity.NCOUNTRY,
            DINPDATE = entity.DINPDATE,
            SSTATREGT = entity.SSTATREGT,
            NTAXRATE = entity.NTAXRATE,
            STYPE = entity.STYPE,
            SREGSVS = entity.SREGSVS,
            NUSERCODE = entity.NUSERCODE,
            SNATIONAL = entity.SNATIONAL,
            NCLASIFIC = entity.NCLASIFIC,
            SABA_ID = entity.SABA_ID,
            SWIFT_IT = entity.SWIFT_IT,
            NLOCAL = entity.NLOCAL,
            SCITY = entity.SCITY,
            NBANKCOUNTRY = entity.NBANKCOUNTRY,
        };
    }

    public static COMPANY_RESP_CLEAR ToEntity(this CreateCOMPANY_RESP_CLEARDto dto)
    {
        if (dto == null) return null!;
        return new COMPANY_RESP_CLEAR
        {
            NCOMPANY = dto.NCOMPANY,
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

    public static void UpdateEntity(this COMPANY_RESP_CLEAR entity, UpdateCOMPANY_RESP_CLEARDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCOMPANY = dto.NCOMPANY;
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
