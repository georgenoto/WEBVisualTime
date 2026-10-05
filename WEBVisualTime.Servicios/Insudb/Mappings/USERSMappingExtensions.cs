using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class USERSMappingExtensions
{
    public static USERSDto ToDto(this USERS entity)
    {
        if (entity == null) return null!;
        return new USERSDto
        {
            NUSERCODE = entity.NUSERCODE,
            SACCESSWO = entity.SACCESSWO,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DCOMPDATE = entity.DCOMPDATE,
            SINITIALS = entity.SINITIALS,
            SSCHE_CODE = entity.SSCHE_CODE,
            SECUR_SCHESLONGDESC = entity.SECUR_SCHE?.SLONGDESC,
            SSTATREGT = entity.SSTATREGT,
            STYPE = entity.STYPE,
            TABLE105SDESCRIPT = entity.TABLE105?.SDESCRIPT,
            NDEPARTME = entity.NDEPARTME,
            TABLE84SDESCRIPT = entity.TABLE84?.SDESCRIPT,
            SMENU = entity.SMENU,
            SCHNEXTLOGON = entity.SCHNEXTLOGON,
            SNEVERCHANGE = entity.SNEVERCHANGE,
            SNEVEREXPIRES = entity.SNEVEREXPIRES,
            SLOCKEDOUT = entity.SLOCKEDOUT,
            DFROMDATE = entity.DFROMDATE,
            NOFFICEAGEN = entity.NOFFICEAGEN,
            NAGENCY = entity.NAGENCY,
            NFAILED_LOGON_ATTEMPTS = entity.NFAILED_LOGON_ATTEMPTS,
            DPASSWORD_EXPIRES = entity.DPASSWORD_EXPIRES,
        };
    }

    public static USERS ToEntity(this CreateUSERSDto dto)
    {
        if (dto == null) return null!;
        return new USERS
        {
            SACCESSWO = dto.SACCESSWO,
            NOFFICE = dto.NOFFICE,
            SCLIENT = dto.SCLIENT,
            DCOMPDATE = dto.DCOMPDATE,
            SINITIALS = dto.SINITIALS,
            SSCHE_CODE = dto.SSCHE_CODE,
            SSTATREGT = dto.SSTATREGT,
            STYPE = dto.STYPE,
            NDEPARTME = dto.NDEPARTME,
            SMENU = dto.SMENU,
            SCHNEXTLOGON = dto.SCHNEXTLOGON,
            SNEVERCHANGE = dto.SNEVERCHANGE,
            SNEVEREXPIRES = dto.SNEVEREXPIRES,
            SLOCKEDOUT = dto.SLOCKEDOUT,
            DFROMDATE = dto.DFROMDATE,
            NOFFICEAGEN = dto.NOFFICEAGEN,
            NAGENCY = dto.NAGENCY,
            NFAILED_LOGON_ATTEMPTS = dto.NFAILED_LOGON_ATTEMPTS,
            DPASSWORD_EXPIRES = dto.DPASSWORD_EXPIRES,
        };
    }

    public static void UpdateEntity(this USERS entity, UpdateUSERSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SACCESSWO = dto.SACCESSWO;
        entity.NOFFICE = dto.NOFFICE;
        entity.SCLIENT = dto.SCLIENT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SINITIALS = dto.SINITIALS;
        entity.SSCHE_CODE = dto.SSCHE_CODE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.STYPE = dto.STYPE;
        entity.NDEPARTME = dto.NDEPARTME;
        entity.SMENU = dto.SMENU;
        entity.SCHNEXTLOGON = dto.SCHNEXTLOGON;
        entity.SNEVERCHANGE = dto.SNEVERCHANGE;
        entity.SNEVEREXPIRES = dto.SNEVEREXPIRES;
        entity.SLOCKEDOUT = dto.SLOCKEDOUT;
        entity.DFROMDATE = dto.DFROMDATE;
        entity.NOFFICEAGEN = dto.NOFFICEAGEN;
        entity.NAGENCY = dto.NAGENCY;
        entity.NFAILED_LOGON_ATTEMPTS = dto.NFAILED_LOGON_ATTEMPTS;
        entity.DPASSWORD_EXPIRES = dto.DPASSWORD_EXPIRES;
    }
}
