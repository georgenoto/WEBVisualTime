using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REINSURAN;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REINSURANMappingExtensions
{
    public static REINSURANDto ToDto(this REINSURAN entity)
    {
        if (entity == null) return null!;
        return new REINSURANDto
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
            NBRANCH_REI = entity.NBRANCH_REI,
            TABLE5000SDESCRIPT = entity.TABLE5000?.SDESCRIPT,
            NMODULEC = entity.NMODULEC,
            NTYPE_REIN = entity.NTYPE_REIN,
            TABLE173SDESCRIPT = entity.TABLE173?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NCOVER = entity.NCOVER,
            DEFFECDATE = entity.DEFFECDATE,
            NCOMPANY = entity.NCOMPANY,
            COMPANYSACCOUNT = entity.COMPANY?.SACCOUNT,
            DACCEDATE = entity.DACCEDATE,
            NCAPITAL = entity.NCAPITAL,
            NCOMMISSI = entity.NCOMMISSI,
            DCOMPDATE = entity.DCOMPDATE,
            NCURRENCY = entity.NCURRENCY,
            SHEAP_CODE = entity.SHEAP_CODE,
            NINTER_RATE = entity.NINTER_RATE,
            DNULLDATE = entity.DNULLDATE,
            NNUMBER = entity.NNUMBER,
            NRESER_RATE = entity.NRESER_RATE,
            NSHARE = entity.NSHARE,
            NUSERCODE = entity.NUSERCODE,
            NCHANGE = entity.NCHANGE,
            TABLE5531SDESCRIPT = entity.TABLE5531?.SDESCRIPT,
            NACEP_CODE = entity.NACEP_CODE,
            SMANUALMOV = entity.SMANUALMOV,
            NCAPITAL_REI = entity.NCAPITAL_REI,
            NORDEN = entity.NORDEN,
            NSHARE_REI = entity.NSHARE_REI,
            NPREMIUM_AGREE = entity.NPREMIUM_AGREE,
            NEXCESS = entity.NEXCESS,
            NRETENTION = entity.NRETENTION,
            NSPCPRIORITY = entity.NSPCPRIORITY,
            NCOMPANYBROKER = entity.NCOMPANYBROKER,
            NFACPERCENTREQ = entity.NFACPERCENTREQ,
            NFACBRANCH_REIREQ = entity.NFACBRANCH_REIREQ,
            NFACPERCENTREQ_COV = entity.NFACPERCENTREQ_COV,
            NCOVAPPSCOPE = entity.NCOVAPPSCOPE,
            NLIMITFROM = entity.NLIMITFROM,
            NLIMIT = entity.NLIMIT,
            NAGGREGATELIMIT = entity.NAGGREGATELIMIT,
            NPERCENT = entity.NPERCENT,
            NAMOUNT_CONT = entity.NAMOUNT_CONT,
        };
    }

    public static REINSURAN ToEntity(this CreateREINSURANDto dto)
    {
        if (dto == null) return null!;
        return new REINSURAN
        {
            DACCEDATE = dto.DACCEDATE,
            NCAPITAL = dto.NCAPITAL,
            NCOMMISSI = dto.NCOMMISSI,
            DCOMPDATE = dto.DCOMPDATE,
            NCURRENCY = dto.NCURRENCY,
            SHEAP_CODE = dto.SHEAP_CODE,
            NINTER_RATE = dto.NINTER_RATE,
            DNULLDATE = dto.DNULLDATE,
            NNUMBER = dto.NNUMBER,
            NRESER_RATE = dto.NRESER_RATE,
            NSHARE = dto.NSHARE,
            NUSERCODE = dto.NUSERCODE,
            NCHANGE = dto.NCHANGE,
            NACEP_CODE = dto.NACEP_CODE,
            SMANUALMOV = dto.SMANUALMOV,
            NCAPITAL_REI = dto.NCAPITAL_REI,
            NORDEN = dto.NORDEN,
            NSHARE_REI = dto.NSHARE_REI,
            NPREMIUM_AGREE = dto.NPREMIUM_AGREE,
            NEXCESS = dto.NEXCESS,
            NRETENTION = dto.NRETENTION,
            NSPCPRIORITY = dto.NSPCPRIORITY,
            NCOMPANYBROKER = dto.NCOMPANYBROKER,
            NFACPERCENTREQ = dto.NFACPERCENTREQ,
            NFACBRANCH_REIREQ = dto.NFACBRANCH_REIREQ,
            NFACPERCENTREQ_COV = dto.NFACPERCENTREQ_COV,
            NCOVAPPSCOPE = dto.NCOVAPPSCOPE,
            NLIMITFROM = dto.NLIMITFROM,
            NLIMIT = dto.NLIMIT,
            NAGGREGATELIMIT = dto.NAGGREGATELIMIT,
            NPERCENT = dto.NPERCENT,
            NAMOUNT_CONT = dto.NAMOUNT_CONT,
        };
    }

    public static void UpdateEntity(this REINSURAN entity, UpdateREINSURANDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DACCEDATE = dto.DACCEDATE;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NCOMMISSI = dto.NCOMMISSI;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.SHEAP_CODE = dto.SHEAP_CODE;
        entity.NINTER_RATE = dto.NINTER_RATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NNUMBER = dto.NNUMBER;
        entity.NRESER_RATE = dto.NRESER_RATE;
        entity.NSHARE = dto.NSHARE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NCHANGE = dto.NCHANGE;
        entity.NACEP_CODE = dto.NACEP_CODE;
        entity.SMANUALMOV = dto.SMANUALMOV;
        entity.NCAPITAL_REI = dto.NCAPITAL_REI;
        entity.NORDEN = dto.NORDEN;
        entity.NSHARE_REI = dto.NSHARE_REI;
        entity.NPREMIUM_AGREE = dto.NPREMIUM_AGREE;
        entity.NEXCESS = dto.NEXCESS;
        entity.NRETENTION = dto.NRETENTION;
        entity.NSPCPRIORITY = dto.NSPCPRIORITY;
        entity.NCOMPANYBROKER = dto.NCOMPANYBROKER;
        entity.NFACPERCENTREQ = dto.NFACPERCENTREQ;
        entity.NFACBRANCH_REIREQ = dto.NFACBRANCH_REIREQ;
        entity.NFACPERCENTREQ_COV = dto.NFACPERCENTREQ_COV;
        entity.NCOVAPPSCOPE = dto.NCOVAPPSCOPE;
        entity.NLIMITFROM = dto.NLIMITFROM;
        entity.NLIMIT = dto.NLIMIT;
        entity.NAGGREGATELIMIT = dto.NAGGREGATELIMIT;
        entity.NPERCENT = dto.NPERCENT;
        entity.NAMOUNT_CONT = dto.NAMOUNT_CONT;
    }
}
