using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MEDBENEFITS_CO;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_MEDBENEFITS_COMappingExtensions
{
    public static TAB_MEDBENEFITS_CODto ToDto(this TAB_MEDBENEFITS_CO entity)
    {
        if (entity == null) return null!;
        return new TAB_MEDBENEFITS_CODto
        {
            SCERTYPE = entity.SCERTYPE,
            POLICYSCERTYPESACCOUNTI = entity.POLICYSCERTYPE?.SACCOUNTI,
            NBRANCH = entity.NBRANCH,
            POLICYNBRANCHSACCOUNTI = entity.POLICYNBRANCH?.SACCOUNTI,
            NPRODUCT = entity.NPRODUCT,
            POLICYNPRODUCTSACCOUNTI = entity.POLICYNPRODUCT?.SACCOUNTI,
            NPOLICY = entity.NPOLICY,
            POLICYNPOLICYSACCOUNTI = entity.POLICYNPOLICY?.SACCOUNTI,
            NMODULEC = entity.NMODULEC,
            DEFFECDATE = entity.DEFFECDATE,
            NCOVER = entity.NCOVER,
            NGROUP = entity.NGROUP,
            NROLE = entity.NROLE,
            TABLE12SDESCRIPT = entity.TABLE12?.SDESCRIPT,
            NDED_TYPE = entity.NDED_TYPE,
            TABLE269SDESCRIPT = entity.TABLE269?.SDESCRIPT,
            NQUANTITY = entity.NQUANTITY,
            NAMOUNT_BENE = entity.NAMOUNT_BENE,
            NPERCEN_HOSPITAL = entity.NPERCEN_HOSPITAL,
            NPERCEN_AMBULATORY = entity.NPERCEN_AMBULATORY,
            SCHANALLO = entity.SCHANALLO,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
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
            NINDPRINT = entity.NINDPRINT,
            TABLE9220SDESCRIPT = entity.TABLE9220?.SDESCRIPT,
            NBENEFCATEG = entity.NBENEFCATEG,
            SBENEFCATEG_CODE = entity.SBENEFCATEG_CODE,
            SPRINT_DES = entity.SPRINT_DES,
            NIDMEDBENEF = entity.NIDMEDBENEF,
            NORDER = entity.NORDER,
            NID_SECUENCIA = entity.NID_SECUENCIA,
        };
    }

    public static TAB_MEDBENEFITS_CO ToEntity(this CreateTAB_MEDBENEFITS_CODto dto)
    {
        if (dto == null) return null!;
        return new TAB_MEDBENEFITS_CO
        {
            NROLE = dto.NROLE,
            NDED_TYPE = dto.NDED_TYPE,
            NQUANTITY = dto.NQUANTITY,
            NAMOUNT_BENE = dto.NAMOUNT_BENE,
            NPERCEN_HOSPITAL = dto.NPERCEN_HOSPITAL,
            NPERCEN_AMBULATORY = dto.NPERCEN_AMBULATORY,
            SCHANALLO = dto.SCHANALLO,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
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
            NINDPRINT = dto.NINDPRINT,
            NBENEFCATEG = dto.NBENEFCATEG,
            SBENEFCATEG_CODE = dto.SBENEFCATEG_CODE,
            SPRINT_DES = dto.SPRINT_DES,
            NORDER = dto.NORDER,
            NID_SECUENCIA = dto.NID_SECUENCIA,
        };
    }

    public static void UpdateEntity(this TAB_MEDBENEFITS_CO entity, UpdateTAB_MEDBENEFITS_CODto dto)
    {
        if (entity == null || dto == null) return;
        entity.NROLE = dto.NROLE;
        entity.NDED_TYPE = dto.NDED_TYPE;
        entity.NQUANTITY = dto.NQUANTITY;
        entity.NAMOUNT_BENE = dto.NAMOUNT_BENE;
        entity.NPERCEN_HOSPITAL = dto.NPERCEN_HOSPITAL;
        entity.NPERCEN_AMBULATORY = dto.NPERCEN_AMBULATORY;
        entity.SCHANALLO = dto.SCHANALLO;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
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
        entity.NINDPRINT = dto.NINDPRINT;
        entity.NBENEFCATEG = dto.NBENEFCATEG;
        entity.SBENEFCATEG_CODE = dto.SBENEFCATEG_CODE;
        entity.SPRINT_DES = dto.SPRINT_DES;
        entity.NORDER = dto.NORDER;
        entity.NID_SECUENCIA = dto.NID_SECUENCIA;
    }
}
