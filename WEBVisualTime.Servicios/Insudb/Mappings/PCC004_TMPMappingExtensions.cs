using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PCC004_TMP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PCC004_TMPMappingExtensions
{
    public static PCC004_TMPDto ToDto(this PCC004_TMP entity)
    {
        if (entity == null) return null!;
        return new PCC004_TMPDto
        {
            DISSUEDATFORM = entity.DISSUEDATFORM,
            SLEGALNAME_COMPANY = entity.SLEGALNAME_COMPANY,
            SCLINUMDOCU_COMPANY = entity.SCLINUMDOCU_COMPANY,
            SDESCADD_COMPANY = entity.SDESCADD_COMPANY,
            NLOCAL_COMPANY = entity.NLOCAL_COMPANY,
            SZONA_COMPANY = entity.SZONA_COMPANY,
            SPHONE_COMPANY = entity.SPHONE_COMPANY,
            NPERSON_TYP = entity.NPERSON_TYP,
            SFIRSTNAME = entity.SFIRSTNAME,
            SLASTNAME = entity.SLASTNAME,
            SLASTNAME2 = entity.SLASTNAME2,
            NTYPCLIENTDOC = entity.NTYPCLIENTDOC,
            SCLINUMDOCU = entity.SCLINUMDOCU,
            SIDCOMPL = entity.SIDCOMPL,
            NNATIONALITY = entity.NNATIONALITY,
            NTITLE = entity.NTITLE,
            NRESIDENCECOUNTRY = entity.NRESIDENCECOUNTRY,
            NSPECIALITY = entity.NSPECIALITY,
            SCOMPANYWORKS = entity.SCOMPANYWORKS,
            NPOSITION_CLI = entity.NPOSITION_CLI,
            SDESCADD_LABOUR = entity.SDESCADD_LABOUR,
            SLEGALNAME = entity.SLEGALNAME,
            NAREA = entity.NAREA,
            NLOCAL = entity.NLOCAL,
            SZONA = entity.SZONA,
            SDESCADD_DOMICILE = entity.SDESCADD_DOMICILE,
            SPHONE = entity.SPHONE,
            NIND_OPERATION = entity.NIND_OPERATION,
            NIND_PREMIUMCLAIM = entity.NIND_PREMIUMCLAIM,
            NIND_INSURANCE = entity.NIND_INSURANCE,
            NIND_TERM = entity.NIND_TERM,
            NCURRENCY = entity.NCURRENCY,
            SCLIENAME_INTERMEDIARY = entity.SCLIENAME_INTERMEDIARY,
            SCLIENAME_TITULAR = entity.SCLIENAME_TITULAR,
            NIND_BRANCH = entity.NIND_BRANCH,
            NPOLICY = entity.NPOLICY,
            SBANKACCOUNT = entity.SBANKACCOUNT,
            SCHEQUE = entity.SCHEQUE,
            NBANKEXT = entity.NBANKEXT,
            NINDREPOSITION = entity.NINDREPOSITION,
            SORIGENRESOURCES = entity.SORIGENRESOURCES,
            SDESTINYRESOURCES = entity.SDESTINYRESOURCES,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NSETTLEMENT_NUM = entity.NSETTLEMENT_NUM,
            NBORDEREAUX = entity.NBORDEREAUX,
            NACCUMULATED_PAY = entity.NACCUMULATED_PAY,
            SREMARKS = entity.SREMARKS,
            SPHONE_PART = entity.SPHONE_PART,
            NLOCAL_PART = entity.NLOCAL_PART,
            SZONE_PART = entity.SZONE_PART,
            SCLIENAME_BROKER = entity.SCLIENAME_BROKER,
            NIND_CASHFLOW = entity.NIND_CASHFLOW,
            SDESCRIPT_CITY = entity.SDESCRIPT_CITY,
        };
    }

    public static PCC004_TMP ToEntity(this CreatePCC004_TMPDto dto)
    {
        if (dto == null) return null!;
        return new PCC004_TMP
        {
            DISSUEDATFORM = dto.DISSUEDATFORM,
            SLEGALNAME_COMPANY = dto.SLEGALNAME_COMPANY,
            SCLINUMDOCU_COMPANY = dto.SCLINUMDOCU_COMPANY,
            SDESCADD_COMPANY = dto.SDESCADD_COMPANY,
            NLOCAL_COMPANY = dto.NLOCAL_COMPANY,
            SZONA_COMPANY = dto.SZONA_COMPANY,
            SPHONE_COMPANY = dto.SPHONE_COMPANY,
            NPERSON_TYP = dto.NPERSON_TYP,
            SFIRSTNAME = dto.SFIRSTNAME,
            SLASTNAME = dto.SLASTNAME,
            SLASTNAME2 = dto.SLASTNAME2,
            NTYPCLIENTDOC = dto.NTYPCLIENTDOC,
            SCLINUMDOCU = dto.SCLINUMDOCU,
            SIDCOMPL = dto.SIDCOMPL,
            NNATIONALITY = dto.NNATIONALITY,
            NTITLE = dto.NTITLE,
            NRESIDENCECOUNTRY = dto.NRESIDENCECOUNTRY,
            NSPECIALITY = dto.NSPECIALITY,
            SCOMPANYWORKS = dto.SCOMPANYWORKS,
            NPOSITION_CLI = dto.NPOSITION_CLI,
            SDESCADD_LABOUR = dto.SDESCADD_LABOUR,
            SLEGALNAME = dto.SLEGALNAME,
            NAREA = dto.NAREA,
            NLOCAL = dto.NLOCAL,
            SZONA = dto.SZONA,
            SDESCADD_DOMICILE = dto.SDESCADD_DOMICILE,
            SPHONE = dto.SPHONE,
            NIND_OPERATION = dto.NIND_OPERATION,
            NIND_PREMIUMCLAIM = dto.NIND_PREMIUMCLAIM,
            NIND_INSURANCE = dto.NIND_INSURANCE,
            NIND_TERM = dto.NIND_TERM,
            NCURRENCY = dto.NCURRENCY,
            SCLIENAME_INTERMEDIARY = dto.SCLIENAME_INTERMEDIARY,
            SCLIENAME_TITULAR = dto.SCLIENAME_TITULAR,
            NIND_BRANCH = dto.NIND_BRANCH,
            NPOLICY = dto.NPOLICY,
            SBANKACCOUNT = dto.SBANKACCOUNT,
            SCHEQUE = dto.SCHEQUE,
            NBANKEXT = dto.NBANKEXT,
            NINDREPOSITION = dto.NINDREPOSITION,
            SORIGENRESOURCES = dto.SORIGENRESOURCES,
            SDESTINYRESOURCES = dto.SDESTINYRESOURCES,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NSETTLEMENT_NUM = dto.NSETTLEMENT_NUM,
            NBORDEREAUX = dto.NBORDEREAUX,
            NACCUMULATED_PAY = dto.NACCUMULATED_PAY,
            SREMARKS = dto.SREMARKS,
            SPHONE_PART = dto.SPHONE_PART,
            NLOCAL_PART = dto.NLOCAL_PART,
            SZONE_PART = dto.SZONE_PART,
            SCLIENAME_BROKER = dto.SCLIENAME_BROKER,
            NIND_CASHFLOW = dto.NIND_CASHFLOW,
            SDESCRIPT_CITY = dto.SDESCRIPT_CITY,
        };
    }

    public static void UpdateEntity(this PCC004_TMP entity, UpdatePCC004_TMPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DISSUEDATFORM = dto.DISSUEDATFORM;
        entity.SLEGALNAME_COMPANY = dto.SLEGALNAME_COMPANY;
        entity.SCLINUMDOCU_COMPANY = dto.SCLINUMDOCU_COMPANY;
        entity.SDESCADD_COMPANY = dto.SDESCADD_COMPANY;
        entity.NLOCAL_COMPANY = dto.NLOCAL_COMPANY;
        entity.SZONA_COMPANY = dto.SZONA_COMPANY;
        entity.SPHONE_COMPANY = dto.SPHONE_COMPANY;
        entity.NPERSON_TYP = dto.NPERSON_TYP;
        entity.SFIRSTNAME = dto.SFIRSTNAME;
        entity.SLASTNAME = dto.SLASTNAME;
        entity.SLASTNAME2 = dto.SLASTNAME2;
        entity.NTYPCLIENTDOC = dto.NTYPCLIENTDOC;
        entity.SCLINUMDOCU = dto.SCLINUMDOCU;
        entity.SIDCOMPL = dto.SIDCOMPL;
        entity.NNATIONALITY = dto.NNATIONALITY;
        entity.NTITLE = dto.NTITLE;
        entity.NRESIDENCECOUNTRY = dto.NRESIDENCECOUNTRY;
        entity.NSPECIALITY = dto.NSPECIALITY;
        entity.SCOMPANYWORKS = dto.SCOMPANYWORKS;
        entity.NPOSITION_CLI = dto.NPOSITION_CLI;
        entity.SDESCADD_LABOUR = dto.SDESCADD_LABOUR;
        entity.SLEGALNAME = dto.SLEGALNAME;
        entity.NAREA = dto.NAREA;
        entity.NLOCAL = dto.NLOCAL;
        entity.SZONA = dto.SZONA;
        entity.SDESCADD_DOMICILE = dto.SDESCADD_DOMICILE;
        entity.SPHONE = dto.SPHONE;
        entity.NIND_OPERATION = dto.NIND_OPERATION;
        entity.NIND_PREMIUMCLAIM = dto.NIND_PREMIUMCLAIM;
        entity.NIND_INSURANCE = dto.NIND_INSURANCE;
        entity.NIND_TERM = dto.NIND_TERM;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.SCLIENAME_INTERMEDIARY = dto.SCLIENAME_INTERMEDIARY;
        entity.SCLIENAME_TITULAR = dto.SCLIENAME_TITULAR;
        entity.NIND_BRANCH = dto.NIND_BRANCH;
        entity.NPOLICY = dto.NPOLICY;
        entity.SBANKACCOUNT = dto.SBANKACCOUNT;
        entity.SCHEQUE = dto.SCHEQUE;
        entity.NBANKEXT = dto.NBANKEXT;
        entity.NINDREPOSITION = dto.NINDREPOSITION;
        entity.SORIGENRESOURCES = dto.SORIGENRESOURCES;
        entity.SDESTINYRESOURCES = dto.SDESTINYRESOURCES;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NSETTLEMENT_NUM = dto.NSETTLEMENT_NUM;
        entity.NBORDEREAUX = dto.NBORDEREAUX;
        entity.NACCUMULATED_PAY = dto.NACCUMULATED_PAY;
        entity.SREMARKS = dto.SREMARKS;
        entity.SPHONE_PART = dto.SPHONE_PART;
        entity.NLOCAL_PART = dto.NLOCAL_PART;
        entity.SZONE_PART = dto.SZONE_PART;
        entity.SCLIENAME_BROKER = dto.SCLIENAME_BROKER;
        entity.NIND_CASHFLOW = dto.NIND_CASHFLOW;
        entity.SDESCRIPT_CITY = dto.SDESCRIPT_CITY;
    }
}
