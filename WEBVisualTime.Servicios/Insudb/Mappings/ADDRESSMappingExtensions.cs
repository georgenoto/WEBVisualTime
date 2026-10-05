using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ADDRESS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class ADDRESSMappingExtensions
{
    public static ADDRESSDto ToDto(this ADDRESS entity)
    {
        if (entity == null) return null!;
        return new ADDRESSDto
        {
            NRECOWNER = entity.NRECOWNER,
            SKEYADDRESS = entity.SKEYADDRESS,
            SRECTYPE = entity.SRECTYPE,
            DEFFECDATE = entity.DEFFECDATE,
            SSTREET = entity.SSTREET,
            SSTREET1 = entity.SSTREET1,
            SZONE = entity.SZONE,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            SCERTYPE = entity.SCERTYPE,
            SE_MAIL = entity.SE_MAIL,
            DCOMPDATE = entity.DCOMPDATE,
            NLAT_SECOND = entity.NLAT_SECOND,
            NLON_SECOND = entity.NLON_SECOND,
            NLAT_COORD = entity.NLAT_COORD,
            NLON_COORD = entity.NLON_COORD,
            NCONTRAT = entity.NCONTRAT,
            NLAT_CARDIN = entity.NLAT_CARDIN,
            NLAT_MINUTE = entity.NLAT_MINUTE,
            NLON_CARDIN = entity.NLON_CARDIN,
            NLON_MINUTE = entity.NLON_MINUTE,
            NCERTIF = entity.NCERTIF,
            NCLAIM = entity.NCLAIM,
            NPOLICY = entity.NPOLICY,
            NZIP_CODE = entity.NZIP_CODE,
            NLAT_GRADE = entity.NLAT_GRADE,
            NCOUNTRY = entity.NCOUNTRY,
            TABLE66SDESCRIPT = entity.TABLE66?.SDESCRIPT,
            NLON_GRADE = entity.NLON_GRADE,
            NUSERCODE = entity.NUSERCODE,
            NBK_AGENCY = entity.NBK_AGENCY,
            NBANK_CODE = entity.NBANK_CODE,
            NBRANCH = entity.NBRANCH,
            NOFFICE = entity.NOFFICE,
            NPROVINCE = entity.NPROVINCE,
            PROVINCESDESCRIPT = entity.PROVINCE?.SDESCRIPT,
            NPRODUCT = entity.NPRODUCT,
            NLOCAL = entity.NLOCAL,
            TAB_LOCATSDESCRIPT = entity.TAB_LOCAT?.SDESCRIPT,
            DNULLDATE = entity.DNULLDATE,
            SBUILD = entity.SBUILD,
            NMUNICIPALITY = entity.NMUNICIPALITY,
            MUNICIPALITYSDESCRIPT = entity.MUNICIPALITY?.SDESCRIPT,
            NFLOOR = entity.NFLOOR,
            SDEPARTMENT = entity.SDEPARTMENT,
            SPOPULATION = entity.SPOPULATION,
            SINFOR = entity.SINFOR,
            SPOBOX = entity.SPOBOX,
            SDESCADD = entity.SDESCADD,
            NCOD_AGREE = entity.NCOD_AGREE,
            SCOSTCENTER = entity.SCOSTCENTER,
            NNOTINFORMEMAIL = entity.NNOTINFORMEMAIL,
            SLEDGERPROCESS = entity.SLEDGERPROCESS,
            NTYPEOFADDRESS = entity.NTYPEOFADDRESS,
            SINVALID_IND = entity.SINVALID_IND,
            SSEND_MAIL = entity.SSEND_MAIL,
            SMAIL = entity.SMAIL,
            SBILL = entity.SBILL,
            NDELEGATION = entity.NDELEGATION,
            NNORMSTATUS = entity.NNORMSTATUS,
            DNORMDATE = entity.DNORMDATE,
            SZIP_CODE = entity.SZIP_CODE,
            SINDSENTEMAIL = entity.SINDSENTEMAIL,
            SELEVATION = entity.SELEVATION,
        };
    }

    public static ADDRESS ToEntity(this CreateADDRESSDto dto)
    {
        if (dto == null) return null!;
        return new ADDRESS
        {
            SRECTYPE = dto.SRECTYPE,
            SSTREET = dto.SSTREET,
            SSTREET1 = dto.SSTREET1,
            SZONE = dto.SZONE,
            SCLIENT = dto.SCLIENT,
            SCERTYPE = dto.SCERTYPE,
            SE_MAIL = dto.SE_MAIL,
            DCOMPDATE = dto.DCOMPDATE,
            NLAT_SECOND = dto.NLAT_SECOND,
            NLON_SECOND = dto.NLON_SECOND,
            NLAT_COORD = dto.NLAT_COORD,
            NLON_COORD = dto.NLON_COORD,
            NCONTRAT = dto.NCONTRAT,
            NLAT_CARDIN = dto.NLAT_CARDIN,
            NLAT_MINUTE = dto.NLAT_MINUTE,
            NLON_CARDIN = dto.NLON_CARDIN,
            NLON_MINUTE = dto.NLON_MINUTE,
            NCERTIF = dto.NCERTIF,
            NCLAIM = dto.NCLAIM,
            NPOLICY = dto.NPOLICY,
            NZIP_CODE = dto.NZIP_CODE,
            NLAT_GRADE = dto.NLAT_GRADE,
            NCOUNTRY = dto.NCOUNTRY,
            NLON_GRADE = dto.NLON_GRADE,
            NUSERCODE = dto.NUSERCODE,
            NBK_AGENCY = dto.NBK_AGENCY,
            NBANK_CODE = dto.NBANK_CODE,
            NBRANCH = dto.NBRANCH,
            NOFFICE = dto.NOFFICE,
            NPROVINCE = dto.NPROVINCE,
            NPRODUCT = dto.NPRODUCT,
            NLOCAL = dto.NLOCAL,
            DNULLDATE = dto.DNULLDATE,
            SBUILD = dto.SBUILD,
            NMUNICIPALITY = dto.NMUNICIPALITY,
            NFLOOR = dto.NFLOOR,
            SDEPARTMENT = dto.SDEPARTMENT,
            SPOPULATION = dto.SPOPULATION,
            SINFOR = dto.SINFOR,
            SPOBOX = dto.SPOBOX,
            SDESCADD = dto.SDESCADD,
            NCOD_AGREE = dto.NCOD_AGREE,
            SCOSTCENTER = dto.SCOSTCENTER,
            NNOTINFORMEMAIL = dto.NNOTINFORMEMAIL,
            SLEDGERPROCESS = dto.SLEDGERPROCESS,
            NTYPEOFADDRESS = dto.NTYPEOFADDRESS,
            SINVALID_IND = dto.SINVALID_IND,
            SSEND_MAIL = dto.SSEND_MAIL,
            SMAIL = dto.SMAIL,
            SBILL = dto.SBILL,
            NDELEGATION = dto.NDELEGATION,
            NNORMSTATUS = dto.NNORMSTATUS,
            DNORMDATE = dto.DNORMDATE,
            SZIP_CODE = dto.SZIP_CODE,
            SINDSENTEMAIL = dto.SINDSENTEMAIL,
            SELEVATION = dto.SELEVATION,
        };
    }

    public static void UpdateEntity(this ADDRESS entity, UpdateADDRESSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SRECTYPE = dto.SRECTYPE;
        entity.SSTREET = dto.SSTREET;
        entity.SSTREET1 = dto.SSTREET1;
        entity.SZONE = dto.SZONE;
        entity.SCLIENT = dto.SCLIENT;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.SE_MAIL = dto.SE_MAIL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NLAT_SECOND = dto.NLAT_SECOND;
        entity.NLON_SECOND = dto.NLON_SECOND;
        entity.NLAT_COORD = dto.NLAT_COORD;
        entity.NLON_COORD = dto.NLON_COORD;
        entity.NCONTRAT = dto.NCONTRAT;
        entity.NLAT_CARDIN = dto.NLAT_CARDIN;
        entity.NLAT_MINUTE = dto.NLAT_MINUTE;
        entity.NLON_CARDIN = dto.NLON_CARDIN;
        entity.NLON_MINUTE = dto.NLON_MINUTE;
        entity.NCERTIF = dto.NCERTIF;
        entity.NCLAIM = dto.NCLAIM;
        entity.NPOLICY = dto.NPOLICY;
        entity.NZIP_CODE = dto.NZIP_CODE;
        entity.NLAT_GRADE = dto.NLAT_GRADE;
        entity.NCOUNTRY = dto.NCOUNTRY;
        entity.NLON_GRADE = dto.NLON_GRADE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NBK_AGENCY = dto.NBK_AGENCY;
        entity.NBANK_CODE = dto.NBANK_CODE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NOFFICE = dto.NOFFICE;
        entity.NPROVINCE = dto.NPROVINCE;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NLOCAL = dto.NLOCAL;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SBUILD = dto.SBUILD;
        entity.NMUNICIPALITY = dto.NMUNICIPALITY;
        entity.NFLOOR = dto.NFLOOR;
        entity.SDEPARTMENT = dto.SDEPARTMENT;
        entity.SPOPULATION = dto.SPOPULATION;
        entity.SINFOR = dto.SINFOR;
        entity.SPOBOX = dto.SPOBOX;
        entity.SDESCADD = dto.SDESCADD;
        entity.NCOD_AGREE = dto.NCOD_AGREE;
        entity.SCOSTCENTER = dto.SCOSTCENTER;
        entity.NNOTINFORMEMAIL = dto.NNOTINFORMEMAIL;
        entity.SLEDGERPROCESS = dto.SLEDGERPROCESS;
        entity.NTYPEOFADDRESS = dto.NTYPEOFADDRESS;
        entity.SINVALID_IND = dto.SINVALID_IND;
        entity.SSEND_MAIL = dto.SSEND_MAIL;
        entity.SMAIL = dto.SMAIL;
        entity.SBILL = dto.SBILL;
        entity.NDELEGATION = dto.NDELEGATION;
        entity.NNORMSTATUS = dto.NNORMSTATUS;
        entity.DNORMDATE = dto.DNORMDATE;
        entity.SZIP_CODE = dto.SZIP_CODE;
        entity.SINDSENTEMAIL = dto.SINDSENTEMAIL;
        entity.SELEVATION = dto.SELEVATION;
    }
}
