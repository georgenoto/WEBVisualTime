using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS_RESP_CLEAR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class USERS_RESP_CLEARMappingExtensions
{
    public static USERS_RESP_CLEARDto ToDto(this USERS_RESP_CLEAR entity)
    {
        if (entity == null) return null!;
        return new USERS_RESP_CLEARDto
        {
            NUSERCODE = entity.NUSERCODE,
            SACCESSWO = entity.SACCESSWO,
            NOFFICE = entity.NOFFICE,
            SCLIENT = entity.SCLIENT,
            DCOMPDATE = entity.DCOMPDATE,
            SINITIALS = entity.SINITIALS,
            SSCHE_CODE = entity.SSCHE_CODE,
            SSTATREGT = entity.SSTATREGT,
            STYPE = entity.STYPE,
            NDEPARTME = entity.NDEPARTME,
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

    public static USERS_RESP_CLEAR ToEntity(this CreateUSERS_RESP_CLEARDto dto)
    {
        if (dto == null) return null!;
        return new USERS_RESP_CLEAR
        {
            NUSERCODE = dto.NUSERCODE,
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

    public static void UpdateEntity(this USERS_RESP_CLEAR entity, UpdateUSERS_RESP_CLEARDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NUSERCODE = dto.NUSERCODE;
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
