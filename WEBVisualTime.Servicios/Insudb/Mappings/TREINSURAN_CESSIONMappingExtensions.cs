using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TREINSURAN_CESSION;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TREINSURAN_CESSIONMappingExtensions
{
    public static TREINSURAN_CESSIONDto ToDto(this TREINSURAN_CESSION entity)
    {
        if (entity == null) return null!;
        return new TREINSURAN_CESSIONDto
        {
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            NTYPE_REIN = entity.NTYPE_REIN,
            SCLIENT = entity.SCLIENT,
            DEFFECDATE = entity.DEFFECDATE,
            NCOMPANY = entity.NCOMPANY,
            NCOVAPPSCOPE = entity.NCOVAPPSCOPE,
            NBRANCH_REI = entity.NBRANCH_REI,
            NSHARE = entity.NSHARE,
            NRATE = entity.NRATE,
            NLIMITFROM = entity.NLIMITFROM,
            NLIMIT = entity.NLIMIT,
            NCAPITAL = entity.NCAPITAL,
            NCOMMISSI = entity.NCOMMISSI,
            NPREMIUM_AGREE = entity.NPREMIUM_AGREE,
            NPREMIUM = entity.NPREMIUM,
            NCOMMISSIONAMOUNT = entity.NCOMMISSIONAMOUNT,
            NTAXPERCEN = entity.NTAXPERCEN,
            NTAXAMOUNT = entity.NTAXAMOUNT,
            SKEY = entity.SKEY,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NORDER = entity.NORDER,
            NCURRENCY = entity.NCURRENCY,
            NNUMBER = entity.NNUMBER,
            DISSUEDATE = entity.DISSUEDATE,
        };
    }

    public static TREINSURAN_CESSION ToEntity(this CreateTREINSURAN_CESSIONDto dto)
    {
        if (dto == null) return null!;
        return new TREINSURAN_CESSION
        {
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            NMODULEC = dto.NMODULEC,
            NCOVER = dto.NCOVER,
            NTYPE_REIN = dto.NTYPE_REIN,
            SCLIENT = dto.SCLIENT,
            DEFFECDATE = dto.DEFFECDATE,
            NCOMPANY = dto.NCOMPANY,
            NCOVAPPSCOPE = dto.NCOVAPPSCOPE,
            NBRANCH_REI = dto.NBRANCH_REI,
            NSHARE = dto.NSHARE,
            NRATE = dto.NRATE,
            NLIMITFROM = dto.NLIMITFROM,
            NLIMIT = dto.NLIMIT,
            NCAPITAL = dto.NCAPITAL,
            NCOMMISSI = dto.NCOMMISSI,
            NPREMIUM_AGREE = dto.NPREMIUM_AGREE,
            NPREMIUM = dto.NPREMIUM,
            NCOMMISSIONAMOUNT = dto.NCOMMISSIONAMOUNT,
            NTAXPERCEN = dto.NTAXPERCEN,
            NTAXAMOUNT = dto.NTAXAMOUNT,
            SKEY = dto.SKEY,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NORDER = dto.NORDER,
            NCURRENCY = dto.NCURRENCY,
            NNUMBER = dto.NNUMBER,
            DISSUEDATE = dto.DISSUEDATE,
        };
    }

    public static void UpdateEntity(this TREINSURAN_CESSION entity, UpdateTREINSURAN_CESSIONDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.NMODULEC = dto.NMODULEC;
        entity.NCOVER = dto.NCOVER;
        entity.NTYPE_REIN = dto.NTYPE_REIN;
        entity.SCLIENT = dto.SCLIENT;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.NCOVAPPSCOPE = dto.NCOVAPPSCOPE;
        entity.NBRANCH_REI = dto.NBRANCH_REI;
        entity.NSHARE = dto.NSHARE;
        entity.NRATE = dto.NRATE;
        entity.NLIMITFROM = dto.NLIMITFROM;
        entity.NLIMIT = dto.NLIMIT;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NCOMMISSI = dto.NCOMMISSI;
        entity.NPREMIUM_AGREE = dto.NPREMIUM_AGREE;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NCOMMISSIONAMOUNT = dto.NCOMMISSIONAMOUNT;
        entity.NTAXPERCEN = dto.NTAXPERCEN;
        entity.NTAXAMOUNT = dto.NTAXAMOUNT;
        entity.SKEY = dto.SKEY;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NORDER = dto.NORDER;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NNUMBER = dto.NNUMBER;
        entity.DISSUEDATE = dto.DISSUEDATE;
    }
}
