using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_RESP_CLEAR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLIENT_RESP_CLEARMappingExtensions
{
    public static CLIENT_RESP_CLEARDto ToDto(this CLIENT_RESP_CLEAR entity)
    {
        if (entity == null) return null!;
        return new CLIENT_RESP_CLEARDto
        {
            SCLIENT = entity.SCLIENT,
            SACCOUNT_IN = entity.SACCOUNT_IN,
            NINVOICING = entity.NINVOICING,
            NCIVILSTA = entity.NCIVILSTA,
            DAPROBDATE = entity.DAPROBDATE,
            DBIRTHDAT = entity.DBIRTHDAT,
            SBLOCKADE = entity.SBLOCKADE,
            NCLASS = entity.NCLASS,
            SFIRSTNAME = entity.SFIRSTNAME,
            SLASTNAME = entity.SLASTNAME,
            DCOMPDATE = entity.DCOMPDATE,
            DDEATHDAT = entity.DDEATHDAT,
            DDRIVERDAT = entity.DDRIVERDAT,
            NHEIGHT = entity.NHEIGHT,
            DINPDATE = entity.DINPDATE,
            NHOUSE_TYPE = entity.NHOUSE_TYPE,
            SLICENSE = entity.SLICENSE,
            NNOTENUM = entity.NNOTENUM,
            NOFFICE = entity.NOFFICE,
            NQ_CARS = entity.NQ_CARS,
            NQ_CHILD = entity.NQ_CHILD,
            NRATE = entity.NRATE,
            STAX_CODE = entity.STAX_CODE,
            SSEXCLIEN = entity.SSEXCLIEN,
            SSMOKING = entity.SSMOKING,
            SCUIT = entity.SCUIT,
            NTITLE = entity.NTITLE,
            NUSERCODE = entity.NUSERCODE,
            NWEIGHT = entity.NWEIGHT,
            SAUTO_CHAR = entity.SAUTO_CHAR,
            SCREDIT_CARD = entity.SCREDIT_CARD,
            NECONOMIC_L = entity.NECONOMIC_L,
            NEMPL_QUA = entity.NEMPL_QUA,
            NIMAGENUM = entity.NIMAGENUM,
            NPERSON_TYP = entity.NPERSON_TYP,
            NAREA = entity.NAREA,
            DDRIVEXPDAT = entity.DDRIVEXPDAT,
            NTYPDRIVER = entity.NTYPDRIVER,
            NDISABILITY = entity.NDISABILITY,
            NLIMITDRIV = entity.NLIMITDRIV,
            SLEGALNAME = entity.SLEGALNAME,
            SLASTNAME2 = entity.SLASTNAME2,
            NHEALTH_ORG = entity.NHEALTH_ORG,
            NAFP = entity.NAFP,
            DWEDD = entity.DWEDD,
            SBILL_IND = entity.SBILL_IND,
            NINCAPACITY = entity.NINCAPACITY,
            DINCAPACITY = entity.DINCAPACITY,
            NINCAP_COD = entity.NINCAP_COD,
            NNATIONALITY = entity.NNATIONALITY,
            SDIGIT = entity.SDIGIT,
            DRETIREMENT = entity.DRETIREMENT,
            DINDEPENDANT = entity.DINDEPENDANT,
            DDEPENDANT = entity.DDEPENDANT,
            NMAILINGPREF = entity.NMAILINGPREF,
            NLANGUAGE = entity.NLANGUAGE,
            NSPECIALITY = entity.NSPECIALITY,
            NCOMP_TYPE = entity.NCOMP_TYPE,
            SCLIENAME = entity.SCLIENAME,
            SLEDGERPROCESS = entity.SLEDGERPROCESS,
            SCOMPLCOD = entity.SCOMPLCOD,
            NTYPECOMPANY = entity.NTYPECOMPANY,
            SFATCA = entity.SFATCA,
            SCLIENTPEP = entity.SCLIENTPEP,
            SUSPERSON = entity.SUSPERSON,
            NADDRESSID = entity.NADDRESSID,
            NPHONEID = entity.NPHONEID,
            SCRS = entity.SCRS,
            SMARRIEDSURNAME = entity.SMARRIEDSURNAME,
            SSPOUSENAME = entity.SSPOUSENAME,
            SOTHERTITLE = entity.SOTHERTITLE,
            SOTHERSPECIALITY = entity.SOTHERSPECIALITY,
            NRESIDENCECOUNTRY = entity.NRESIDENCECOUNTRY,
            NBIRTHCOUNTRY = entity.NBIRTHCOUNTRY,
            NPOSITION_CLI = entity.NPOSITION_CLI,
        };
    }

    public static CLIENT_RESP_CLEAR ToEntity(this CreateCLIENT_RESP_CLEARDto dto)
    {
        if (dto == null) return null!;
        return new CLIENT_RESP_CLEAR
        {
            SCLIENT = dto.SCLIENT,
            SACCOUNT_IN = dto.SACCOUNT_IN,
            NINVOICING = dto.NINVOICING,
            NCIVILSTA = dto.NCIVILSTA,
            DAPROBDATE = dto.DAPROBDATE,
            DBIRTHDAT = dto.DBIRTHDAT,
            SBLOCKADE = dto.SBLOCKADE,
            NCLASS = dto.NCLASS,
            SFIRSTNAME = dto.SFIRSTNAME,
            SLASTNAME = dto.SLASTNAME,
            DCOMPDATE = dto.DCOMPDATE,
            DDEATHDAT = dto.DDEATHDAT,
            DDRIVERDAT = dto.DDRIVERDAT,
            NHEIGHT = dto.NHEIGHT,
            DINPDATE = dto.DINPDATE,
            NHOUSE_TYPE = dto.NHOUSE_TYPE,
            SLICENSE = dto.SLICENSE,
            NNOTENUM = dto.NNOTENUM,
            NOFFICE = dto.NOFFICE,
            NQ_CARS = dto.NQ_CARS,
            NQ_CHILD = dto.NQ_CHILD,
            NRATE = dto.NRATE,
            STAX_CODE = dto.STAX_CODE,
            SSEXCLIEN = dto.SSEXCLIEN,
            SSMOKING = dto.SSMOKING,
            SCUIT = dto.SCUIT,
            NTITLE = dto.NTITLE,
            NUSERCODE = dto.NUSERCODE,
            NWEIGHT = dto.NWEIGHT,
            SAUTO_CHAR = dto.SAUTO_CHAR,
            SCREDIT_CARD = dto.SCREDIT_CARD,
            NECONOMIC_L = dto.NECONOMIC_L,
            NEMPL_QUA = dto.NEMPL_QUA,
            NIMAGENUM = dto.NIMAGENUM,
            NPERSON_TYP = dto.NPERSON_TYP,
            NAREA = dto.NAREA,
            DDRIVEXPDAT = dto.DDRIVEXPDAT,
            NTYPDRIVER = dto.NTYPDRIVER,
            NDISABILITY = dto.NDISABILITY,
            NLIMITDRIV = dto.NLIMITDRIV,
            SLEGALNAME = dto.SLEGALNAME,
            SLASTNAME2 = dto.SLASTNAME2,
            NHEALTH_ORG = dto.NHEALTH_ORG,
            NAFP = dto.NAFP,
            DWEDD = dto.DWEDD,
            SBILL_IND = dto.SBILL_IND,
            NINCAPACITY = dto.NINCAPACITY,
            DINCAPACITY = dto.DINCAPACITY,
            NINCAP_COD = dto.NINCAP_COD,
            NNATIONALITY = dto.NNATIONALITY,
            SDIGIT = dto.SDIGIT,
            DRETIREMENT = dto.DRETIREMENT,
            DINDEPENDANT = dto.DINDEPENDANT,
            DDEPENDANT = dto.DDEPENDANT,
            NMAILINGPREF = dto.NMAILINGPREF,
            NLANGUAGE = dto.NLANGUAGE,
            NSPECIALITY = dto.NSPECIALITY,
            NCOMP_TYPE = dto.NCOMP_TYPE,
            SCLIENAME = dto.SCLIENAME,
            SLEDGERPROCESS = dto.SLEDGERPROCESS,
            SCOMPLCOD = dto.SCOMPLCOD,
            NTYPECOMPANY = dto.NTYPECOMPANY,
            SFATCA = dto.SFATCA,
            SCLIENTPEP = dto.SCLIENTPEP,
            SUSPERSON = dto.SUSPERSON,
            NADDRESSID = dto.NADDRESSID,
            NPHONEID = dto.NPHONEID,
            SCRS = dto.SCRS,
            SMARRIEDSURNAME = dto.SMARRIEDSURNAME,
            SSPOUSENAME = dto.SSPOUSENAME,
            SOTHERTITLE = dto.SOTHERTITLE,
            SOTHERSPECIALITY = dto.SOTHERSPECIALITY,
            NRESIDENCECOUNTRY = dto.NRESIDENCECOUNTRY,
            NBIRTHCOUNTRY = dto.NBIRTHCOUNTRY,
            NPOSITION_CLI = dto.NPOSITION_CLI,
        };
    }

    public static void UpdateEntity(this CLIENT_RESP_CLEAR entity, UpdateCLIENT_RESP_CLEARDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCLIENT = dto.SCLIENT;
        entity.SACCOUNT_IN = dto.SACCOUNT_IN;
        entity.NINVOICING = dto.NINVOICING;
        entity.NCIVILSTA = dto.NCIVILSTA;
        entity.DAPROBDATE = dto.DAPROBDATE;
        entity.DBIRTHDAT = dto.DBIRTHDAT;
        entity.SBLOCKADE = dto.SBLOCKADE;
        entity.NCLASS = dto.NCLASS;
        entity.SFIRSTNAME = dto.SFIRSTNAME;
        entity.SLASTNAME = dto.SLASTNAME;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DDEATHDAT = dto.DDEATHDAT;
        entity.DDRIVERDAT = dto.DDRIVERDAT;
        entity.NHEIGHT = dto.NHEIGHT;
        entity.DINPDATE = dto.DINPDATE;
        entity.NHOUSE_TYPE = dto.NHOUSE_TYPE;
        entity.SLICENSE = dto.SLICENSE;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.NOFFICE = dto.NOFFICE;
        entity.NQ_CARS = dto.NQ_CARS;
        entity.NQ_CHILD = dto.NQ_CHILD;
        entity.NRATE = dto.NRATE;
        entity.STAX_CODE = dto.STAX_CODE;
        entity.SSEXCLIEN = dto.SSEXCLIEN;
        entity.SSMOKING = dto.SSMOKING;
        entity.SCUIT = dto.SCUIT;
        entity.NTITLE = dto.NTITLE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NWEIGHT = dto.NWEIGHT;
        entity.SAUTO_CHAR = dto.SAUTO_CHAR;
        entity.SCREDIT_CARD = dto.SCREDIT_CARD;
        entity.NECONOMIC_L = dto.NECONOMIC_L;
        entity.NEMPL_QUA = dto.NEMPL_QUA;
        entity.NIMAGENUM = dto.NIMAGENUM;
        entity.NPERSON_TYP = dto.NPERSON_TYP;
        entity.NAREA = dto.NAREA;
        entity.DDRIVEXPDAT = dto.DDRIVEXPDAT;
        entity.NTYPDRIVER = dto.NTYPDRIVER;
        entity.NDISABILITY = dto.NDISABILITY;
        entity.NLIMITDRIV = dto.NLIMITDRIV;
        entity.SLEGALNAME = dto.SLEGALNAME;
        entity.SLASTNAME2 = dto.SLASTNAME2;
        entity.NHEALTH_ORG = dto.NHEALTH_ORG;
        entity.NAFP = dto.NAFP;
        entity.DWEDD = dto.DWEDD;
        entity.SBILL_IND = dto.SBILL_IND;
        entity.NINCAPACITY = dto.NINCAPACITY;
        entity.DINCAPACITY = dto.DINCAPACITY;
        entity.NINCAP_COD = dto.NINCAP_COD;
        entity.NNATIONALITY = dto.NNATIONALITY;
        entity.SDIGIT = dto.SDIGIT;
        entity.DRETIREMENT = dto.DRETIREMENT;
        entity.DINDEPENDANT = dto.DINDEPENDANT;
        entity.DDEPENDANT = dto.DDEPENDANT;
        entity.NMAILINGPREF = dto.NMAILINGPREF;
        entity.NLANGUAGE = dto.NLANGUAGE;
        entity.NSPECIALITY = dto.NSPECIALITY;
        entity.NCOMP_TYPE = dto.NCOMP_TYPE;
        entity.SCLIENAME = dto.SCLIENAME;
        entity.SLEDGERPROCESS = dto.SLEDGERPROCESS;
        entity.SCOMPLCOD = dto.SCOMPLCOD;
        entity.NTYPECOMPANY = dto.NTYPECOMPANY;
        entity.SFATCA = dto.SFATCA;
        entity.SCLIENTPEP = dto.SCLIENTPEP;
        entity.SUSPERSON = dto.SUSPERSON;
        entity.NADDRESSID = dto.NADDRESSID;
        entity.NPHONEID = dto.NPHONEID;
        entity.SCRS = dto.SCRS;
        entity.SMARRIEDSURNAME = dto.SMARRIEDSURNAME;
        entity.SSPOUSENAME = dto.SSPOUSENAME;
        entity.SOTHERTITLE = dto.SOTHERTITLE;
        entity.SOTHERSPECIALITY = dto.SOTHERSPECIALITY;
        entity.NRESIDENCECOUNTRY = dto.NRESIDENCECOUNTRY;
        entity.NBIRTHCOUNTRY = dto.NBIRTHCOUNTRY;
        entity.NPOSITION_CLI = dto.NPOSITION_CLI;
    }
}
