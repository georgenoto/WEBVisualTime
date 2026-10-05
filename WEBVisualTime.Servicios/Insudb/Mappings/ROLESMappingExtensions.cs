using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ROLES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class ROLESMappingExtensions
{
    public static ROLESDto ToDto(this ROLES entity)
    {
        if (entity == null) return null!;
        return new ROLESDto
        {
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            NROLE = entity.NROLE,
            TABLE12SDESCRIPT = entity.TABLE12?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            DBIRTHDATE = entity.DBIRTHDATE,
            SSEXCLIEN = entity.SSEXCLIEN,
            TABLE18SDESCRIPT = entity.TABLE18?.SDESCRIPT,
            SSMOKING = entity.SSMOKING,
            NTYPERISK = entity.NTYPERISK,
            TABLE5639SDESCRIPT = entity.TABLE5639?.SDESCRIPT,
            SVIP = entity.SVIP,
            NSTATUSROL = entity.NSTATUSROL,
            TABLE5561SDESCRIPT = entity.TABLE5561?.SDESCRIPT,
            NRATING = entity.NRATING,
            NTYPENAME = entity.NTYPENAME,
            TABLE5592SDESCRIPT = entity.TABLE5592?.SDESCRIPT,
            NCOVERPOS = entity.NCOVERPOS,
            DCONTINUE = entity.DCONTINUE,
            NCONTRAT_PAY = entity.NCONTRAT_PAY,
            SCONTINUED = entity.SCONTINUED,
            SPRINTNAME = entity.SPRINTNAME,
            SITEM = entity.SITEM,
            NWEIGHT = entity.NWEIGHT,
            NHEIGHT = entity.NHEIGHT,
            NIMC = entity.NIMC,
            NTYPELIST = entity.NTYPELIST,
            TABLE9203SDESCRIPT = entity.TABLE9203?.SDESCRIPT,
            DPEPSEARCH = entity.DPEPSEARCH,
            NUSERPEPSEARCH = entity.NUSERPEPSEARCH,
            SFPHYSICAL_CREDEN = entity.SFPHYSICAL_CREDEN,
            NCLASSTYPDOC = entity.NCLASSTYPDOC,
            FORMATVALUESNCLASSTYPDOCSDESCRIPT = entity.FORMATVALUESNCLASSTYPDOC?.SDESCRIPT,
            NTYPCLIENTDOC = entity.NTYPCLIENTDOC,
            FORMATVALUESNTYPCLIENTDOCSDESCRIPT = entity.FORMATVALUESNTYPCLIENTDOC?.SDESCRIPT,
            NCITY_RESIDENCE = entity.NCITY_RESIDENCE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            NSEVERITYPEP = entity.NSEVERITYPEP,
            NINDAUTHPEP = entity.NINDAUTHPEP,
            DPEPSTATUS = entity.DPEPSTATUS,
            NCAPITAL = entity.NCAPITAL,
            NUSERPEPAUTHREJ = entity.NUSERPEPAUTHREJ,
            NMOVEMENT = entity.NMOVEMENT,
            NMOVEMENT_NULL = entity.NMOVEMENT_NULL,
        };
    }

    public static ROLES ToEntity(this CreateROLESDto dto)
    {
        if (dto == null) return null!;
        return new ROLES
        {
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            NINTERMED = dto.NINTERMED,
            DBIRTHDATE = dto.DBIRTHDATE,
            SSEXCLIEN = dto.SSEXCLIEN,
            SSMOKING = dto.SSMOKING,
            NTYPERISK = dto.NTYPERISK,
            SVIP = dto.SVIP,
            NSTATUSROL = dto.NSTATUSROL,
            NRATING = dto.NRATING,
            NTYPENAME = dto.NTYPENAME,
            NCOVERPOS = dto.NCOVERPOS,
            DCONTINUE = dto.DCONTINUE,
            NCONTRAT_PAY = dto.NCONTRAT_PAY,
            SCONTINUED = dto.SCONTINUED,
            SPRINTNAME = dto.SPRINTNAME,
            SITEM = dto.SITEM,
            NWEIGHT = dto.NWEIGHT,
            NHEIGHT = dto.NHEIGHT,
            NIMC = dto.NIMC,
            NTYPELIST = dto.NTYPELIST,
            DPEPSEARCH = dto.DPEPSEARCH,
            NUSERPEPSEARCH = dto.NUSERPEPSEARCH,
            SFPHYSICAL_CREDEN = dto.SFPHYSICAL_CREDEN,
            NCLASSTYPDOC = dto.NCLASSTYPDOC,
            NTYPCLIENTDOC = dto.NTYPCLIENTDOC,
            NCITY_RESIDENCE = dto.NCITY_RESIDENCE,
            SSHORT_DES = dto.SSHORT_DES,
            NSEVERITYPEP = dto.NSEVERITYPEP,
            NINDAUTHPEP = dto.NINDAUTHPEP,
            DPEPSTATUS = dto.DPEPSTATUS,
            NCAPITAL = dto.NCAPITAL,
            NUSERPEPAUTHREJ = dto.NUSERPEPAUTHREJ,
            NMOVEMENT = dto.NMOVEMENT,
            NMOVEMENT_NULL = dto.NMOVEMENT_NULL,
        };
    }

    public static void UpdateEntity(this ROLES entity, UpdateROLESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NINTERMED = dto.NINTERMED;
        entity.DBIRTHDATE = dto.DBIRTHDATE;
        entity.SSEXCLIEN = dto.SSEXCLIEN;
        entity.SSMOKING = dto.SSMOKING;
        entity.NTYPERISK = dto.NTYPERISK;
        entity.SVIP = dto.SVIP;
        entity.NSTATUSROL = dto.NSTATUSROL;
        entity.NRATING = dto.NRATING;
        entity.NTYPENAME = dto.NTYPENAME;
        entity.NCOVERPOS = dto.NCOVERPOS;
        entity.DCONTINUE = dto.DCONTINUE;
        entity.NCONTRAT_PAY = dto.NCONTRAT_PAY;
        entity.SCONTINUED = dto.SCONTINUED;
        entity.SPRINTNAME = dto.SPRINTNAME;
        entity.SITEM = dto.SITEM;
        entity.NWEIGHT = dto.NWEIGHT;
        entity.NHEIGHT = dto.NHEIGHT;
        entity.NIMC = dto.NIMC;
        entity.NTYPELIST = dto.NTYPELIST;
        entity.DPEPSEARCH = dto.DPEPSEARCH;
        entity.NUSERPEPSEARCH = dto.NUSERPEPSEARCH;
        entity.SFPHYSICAL_CREDEN = dto.SFPHYSICAL_CREDEN;
        entity.NCLASSTYPDOC = dto.NCLASSTYPDOC;
        entity.NTYPCLIENTDOC = dto.NTYPCLIENTDOC;
        entity.NCITY_RESIDENCE = dto.NCITY_RESIDENCE;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.NSEVERITYPEP = dto.NSEVERITYPEP;
        entity.NINDAUTHPEP = dto.NINDAUTHPEP;
        entity.DPEPSTATUS = dto.DPEPSTATUS;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NUSERPEPAUTHREJ = dto.NUSERPEPAUTHREJ;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.NMOVEMENT_NULL = dto.NMOVEMENT_NULL;
    }
}
