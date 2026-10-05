using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TREINSURAN;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TREINSURANMappingExtensions
{
    public static TREINSURANDto ToDto(this TREINSURAN entity)
    {
        if (entity == null) return null!;
        return new TREINSURANDto
        {
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            NBRANCH_REI = entity.NBRANCH_REI,
            NTYPE = entity.NTYPE,
            NNUMBER = entity.NNUMBER,
            NCAPITAL = entity.NCAPITAL,
            NCAPITALMAX = entity.NCAPITALMAX,
            NQUOTASHA = entity.NQUOTASHA,
            SKEY = entity.SKEY,
            NCURRENCY = entity.NCURRENCY,
            NCOVER = entity.NCOVER,
            NMODULEC = entity.NMODULEC,
            SCLIENT = entity.SCLIENT,
            DEFFECDATE = entity.DEFFECDATE,
            NCOMPANY = entity.NCOMPANY,
            NCOMMISSI = entity.NCOMMISSI,
            DCOMPDATE = entity.DCOMPDATE,
            SHEAP_CODE = entity.SHEAP_CODE,
            NINTER_RATE = entity.NINTER_RATE,
            DNULLDATE = entity.DNULLDATE,
            NCHANGE = entity.NCHANGE,
            NACEP_CODE = entity.NACEP_CODE,
            SMANUALMOV = entity.SMANUALMOV,
            SCOVERDESC = entity.SCOVERDESC,
            NREST = entity.NREST,
            NPREMIUM = entity.NPREMIUM,
            NCAPITAL_REI = entity.NCAPITAL_REI,
            NRESER_RATE = entity.NRESER_RATE,
            SCLIENAME = entity.SCLIENAME,
            DACCEDATE = entity.DACCEDATE,
            SCOMPANY = entity.SCOMPANY,
            NRESERVE = entity.NRESERVE,
            NCOVERGEN = entity.NCOVERGEN,
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

    public static TREINSURAN ToEntity(this CreateTREINSURANDto dto)
    {
        if (dto == null) return null!;
        return new TREINSURAN
        {
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            NBRANCH_REI = dto.NBRANCH_REI,
            NTYPE = dto.NTYPE,
            NNUMBER = dto.NNUMBER,
            NCAPITAL = dto.NCAPITAL,
            NCAPITALMAX = dto.NCAPITALMAX,
            NQUOTASHA = dto.NQUOTASHA,
            SKEY = dto.SKEY,
            NCURRENCY = dto.NCURRENCY,
            NCOVER = dto.NCOVER,
            NMODULEC = dto.NMODULEC,
            SCLIENT = dto.SCLIENT,
            DEFFECDATE = dto.DEFFECDATE,
            NCOMPANY = dto.NCOMPANY,
            NCOMMISSI = dto.NCOMMISSI,
            DCOMPDATE = dto.DCOMPDATE,
            SHEAP_CODE = dto.SHEAP_CODE,
            NINTER_RATE = dto.NINTER_RATE,
            DNULLDATE = dto.DNULLDATE,
            NCHANGE = dto.NCHANGE,
            NACEP_CODE = dto.NACEP_CODE,
            SMANUALMOV = dto.SMANUALMOV,
            SCOVERDESC = dto.SCOVERDESC,
            NREST = dto.NREST,
            NPREMIUM = dto.NPREMIUM,
            NCAPITAL_REI = dto.NCAPITAL_REI,
            NRESER_RATE = dto.NRESER_RATE,
            SCLIENAME = dto.SCLIENAME,
            DACCEDATE = dto.DACCEDATE,
            SCOMPANY = dto.SCOMPANY,
            NRESERVE = dto.NRESERVE,
            NCOVERGEN = dto.NCOVERGEN,
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

    public static void UpdateEntity(this TREINSURAN entity, UpdateTREINSURANDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.NTYPE = dto.NTYPE;
        entity.NNUMBER = dto.NNUMBER;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NCAPITALMAX = dto.NCAPITALMAX;
        entity.NQUOTASHA = dto.NQUOTASHA;
        entity.SKEY = dto.SKEY;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NCOVER = dto.NCOVER;
        entity.NMODULEC = dto.NMODULEC;
        entity.SCLIENT = dto.SCLIENT;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.NCOMMISSI = dto.NCOMMISSI;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SHEAP_CODE = dto.SHEAP_CODE;
        entity.NINTER_RATE = dto.NINTER_RATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NCHANGE = dto.NCHANGE;
        entity.NACEP_CODE = dto.NACEP_CODE;
        entity.SMANUALMOV = dto.SMANUALMOV;
        entity.SCOVERDESC = dto.SCOVERDESC;
        entity.NREST = dto.NREST;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NCAPITAL_REI = dto.NCAPITAL_REI;
        entity.NRESER_RATE = dto.NRESER_RATE;
        entity.SCLIENAME = dto.SCLIENAME;
        entity.DACCEDATE = dto.DACCEDATE;
        entity.SCOMPANY = dto.SCOMPANY;
        entity.NRESERVE = dto.NRESERVE;
        entity.NCOVERGEN = dto.NCOVERGEN;
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
