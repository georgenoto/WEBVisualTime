using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MEDBENEFITS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_MEDBENEFITSMappingExtensions
{
    public static TAB_MEDBENEFITSDto ToDto(this TAB_MEDBENEFITS entity)
    {
        if (entity == null) return null!;
        return new TAB_MEDBENEFITSDto
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
            NID = entity.NID,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            DEFFECDATE = entity.DEFFECDATE,
            SCLIENT = entity.SCLIENT,
            NGROUP_INSU = entity.NGROUP_INSU,
            NROLE = entity.NROLE,
            NQUANTITY = entity.NQUANTITY,
            NAMOUNT_BENE = entity.NAMOUNT_BENE,
            NPERCEN_HOSPITAL = entity.NPERCEN_HOSPITAL,
            NPERCEN_AMBULATORY = entity.NPERCEN_AMBULATORY,
            NDED_TYPE = entity.NDED_TYPE,
            TABLE269SDESCRIPT = entity.TABLE269?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            SCAREN_TYPE = entity.SCAREN_TYPE,
            TABLE52SDESCRIPT = entity.TABLE52?.SDESCRIPT,
            NCAREN_QUANT = entity.NCAREN_QUANT,
            NOFFICE_PROD = entity.NOFFICE_PROD,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NAMOUNT_COPAY = entity.NAMOUNT_COPAY,
            NFRANCFIX = entity.NFRANCFIX,
            NAGESTART = entity.NAGESTART,
            NAGEEND = entity.NAGEEND,
            SSEXCLIEN = entity.SSEXCLIEN,
            TABLE18SDESCRIPT = entity.TABLE18?.SDESCRIPT,
            NPROVIDER = entity.NPROVIDER,
            TAB_PROVIDERSSTATREGT = entity.TAB_PROVIDER?.SSTATREGT,
            NATTENSYSTEM = entity.NATTENSYSTEM,
            TABLE9215SDESCRIPT = entity.TABLE9215?.SDESCRIPT,
            NTYPEEXHAUS = entity.NTYPEEXHAUS,
            TABLE9221SDESCRIPT = entity.TABLE9221?.SDESCRIPT,
            SILLNESS = entity.SILLNESS,
            TAB_AM_ILLSDESCRIPT = entity.TAB_AM_ILL?.SDESCRIPT,
            SCLARIFICACT = entity.SCLARIFICACT,
            NBENEFCATEG = entity.NBENEFCATEG,
            SBENEFCATEG_CODE = entity.SBENEFCATEG_CODE,
            SPRINT_DES = entity.SPRINT_DES,
            NIDMEDBENEF = entity.NIDMEDBENEF,
        };
    }

    public static TAB_MEDBENEFITS ToEntity(this CreateTAB_MEDBENEFITSDto dto)
    {
        if (dto == null) return null!;
        return new TAB_MEDBENEFITS
        {
            NROLE = dto.NROLE,
            NQUANTITY = dto.NQUANTITY,
            NAMOUNT_BENE = dto.NAMOUNT_BENE,
            NPERCEN_HOSPITAL = dto.NPERCEN_HOSPITAL,
            NPERCEN_AMBULATORY = dto.NPERCEN_AMBULATORY,
            NDED_TYPE = dto.NDED_TYPE,
            NUSERCODE = dto.NUSERCODE,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            SCAREN_TYPE = dto.SCAREN_TYPE,
            NCAREN_QUANT = dto.NCAREN_QUANT,
            NOFFICE_PROD = dto.NOFFICE_PROD,
            NAMOUNT_COPAY = dto.NAMOUNT_COPAY,
            NFRANCFIX = dto.NFRANCFIX,
            NAGESTART = dto.NAGESTART,
            NAGEEND = dto.NAGEEND,
            SSEXCLIEN = dto.SSEXCLIEN,
            NPROVIDER = dto.NPROVIDER,
            NATTENSYSTEM = dto.NATTENSYSTEM,
            NTYPEEXHAUS = dto.NTYPEEXHAUS,
            SILLNESS = dto.SILLNESS,
            SCLARIFICACT = dto.SCLARIFICACT,
            NBENEFCATEG = dto.NBENEFCATEG,
            SBENEFCATEG_CODE = dto.SBENEFCATEG_CODE,
            SPRINT_DES = dto.SPRINT_DES,
            NIDMEDBENEF = dto.NIDMEDBENEF,
        };
    }

    public static void UpdateEntity(this TAB_MEDBENEFITS entity, UpdateTAB_MEDBENEFITSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NROLE = dto.NROLE;
        entity.NQUANTITY = dto.NQUANTITY;
        entity.NAMOUNT_BENE = dto.NAMOUNT_BENE;
        entity.NPERCEN_HOSPITAL = dto.NPERCEN_HOSPITAL;
        entity.NPERCEN_AMBULATORY = dto.NPERCEN_AMBULATORY;
        entity.NDED_TYPE = dto.NDED_TYPE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SCAREN_TYPE = dto.SCAREN_TYPE;
        entity.NCAREN_QUANT = dto.NCAREN_QUANT;
        entity.NOFFICE_PROD = dto.NOFFICE_PROD;
        entity.NAMOUNT_COPAY = dto.NAMOUNT_COPAY;
        entity.NFRANCFIX = dto.NFRANCFIX;
        entity.NAGESTART = dto.NAGESTART;
        entity.NAGEEND = dto.NAGEEND;
        entity.SSEXCLIEN = dto.SSEXCLIEN;
        entity.NPROVIDER = dto.NPROVIDER;
        entity.NATTENSYSTEM = dto.NATTENSYSTEM;
        entity.NTYPEEXHAUS = dto.NTYPEEXHAUS;
        entity.SILLNESS = dto.SILLNESS;
        entity.SCLARIFICACT = dto.SCLARIFICACT;
        entity.NBENEFCATEG = dto.NBENEFCATEG;
        entity.SBENEFCATEG_CODE = dto.SBENEFCATEG_CODE;
        entity.SPRINT_DES = dto.SPRINT_DES;
        entity.NIDMEDBENEF = dto.NIDMEDBENEF;
    }
}
