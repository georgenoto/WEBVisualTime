using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TREHABILITATE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TREHABILITATEMappingExtensions
{
    public static TREHABILITATEDto ToDto(this TREHABILITATE entity)
    {
        if (entity == null) return null!;
        return new TREHABILITATEDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            NSTATQUOTA = entity.NSTATQUOTA,
            NCAPITAL = entity.NCAPITAL,
            SCURRENCY = entity.SCURRENCY,
            SNAME_EXEC = entity.SNAME_EXEC,
            DEFFECDATE = entity.DEFFECDATE,
            SCLIENT_AGE = entity.SCLIENT_AGE,
            SCLIENAME_AGE = entity.SCLIENAME_AGE,
            NPAYFREQ = entity.NPAYFREQ,
            SKEY = entity.SKEY,
            NID = entity.NID,
            NRECEIPT_A = entity.NRECEIPT_A,
            DEFFECDATE_A = entity.DEFFECDATE_A,
            NPREMIUM_A = entity.NPREMIUM_A,
            SCLIENT_A = entity.SCLIENT_A,
            SCLIENAME_A = entity.SCLIENAME_A,
            NRECEIPT_D = entity.NRECEIPT_D,
            DEFFECDATE_D = entity.DEFFECDATE_D,
            NPREMIUM_D = entity.NPREMIUM_D,
            STRATYPEI = entity.STRATYPEI,
            SCLIENT_D = entity.SCLIENT_D,
            SCLIENAME_D = entity.SCLIENAME_D,
            NAGENCY = entity.NAGENCY,
            NPREMIUM_TOT = entity.NPREMIUM_TOT,
            SADDRESS = entity.SADDRESS,
            SLOCAL = entity.SLOCAL,
            SMUNICIPALITY = entity.SMUNICIPALITY,
            SPHONE = entity.SPHONE,
            SMODULEC = entity.SMODULEC,
            DLIMITDATE = entity.DLIMITDATE,
            NCOUNT = entity.NCOUNT,
            NEXCHANGE = entity.NEXCHANGE,
            NPREMIUM_P = entity.NPREMIUM_P,
            NINTEREST_P = entity.NINTEREST_P,
            NINTEREST_O = entity.NINTEREST_O,
            NPROPONUM = entity.NPROPONUM,
            SCERTYPE = entity.SCERTYPE,
            DNULLDATE = entity.DNULLDATE,
        };
    }

    public static TREHABILITATE ToEntity(this CreateTREHABILITATEDto dto)
    {
        if (dto == null) return null!;
        return new TREHABILITATE
        {
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            NSTATQUOTA = dto.NSTATQUOTA,
            NCAPITAL = dto.NCAPITAL,
            SCURRENCY = dto.SCURRENCY,
            SNAME_EXEC = dto.SNAME_EXEC,
            DEFFECDATE = dto.DEFFECDATE,
            SCLIENT_AGE = dto.SCLIENT_AGE,
            SCLIENAME_AGE = dto.SCLIENAME_AGE,
            NPAYFREQ = dto.NPAYFREQ,
            SKEY = dto.SKEY,
            NID = dto.NID,
            NRECEIPT_A = dto.NRECEIPT_A,
            DEFFECDATE_A = dto.DEFFECDATE_A,
            NPREMIUM_A = dto.NPREMIUM_A,
            SCLIENT_A = dto.SCLIENT_A,
            SCLIENAME_A = dto.SCLIENAME_A,
            NRECEIPT_D = dto.NRECEIPT_D,
            DEFFECDATE_D = dto.DEFFECDATE_D,
            NPREMIUM_D = dto.NPREMIUM_D,
            STRATYPEI = dto.STRATYPEI,
            SCLIENT_D = dto.SCLIENT_D,
            SCLIENAME_D = dto.SCLIENAME_D,
            NAGENCY = dto.NAGENCY,
            NPREMIUM_TOT = dto.NPREMIUM_TOT,
            SADDRESS = dto.SADDRESS,
            SLOCAL = dto.SLOCAL,
            SMUNICIPALITY = dto.SMUNICIPALITY,
            SPHONE = dto.SPHONE,
            SMODULEC = dto.SMODULEC,
            DLIMITDATE = dto.DLIMITDATE,
            NCOUNT = dto.NCOUNT,
            NEXCHANGE = dto.NEXCHANGE,
            NPREMIUM_P = dto.NPREMIUM_P,
            NINTEREST_P = dto.NINTEREST_P,
            NINTEREST_O = dto.NINTEREST_O,
            NPROPONUM = dto.NPROPONUM,
            SCERTYPE = dto.SCERTYPE,
            DNULLDATE = dto.DNULLDATE,
        };
    }

    public static void UpdateEntity(this TREHABILITATE entity, UpdateTREHABILITATEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.NSTATQUOTA = dto.NSTATQUOTA;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.SCURRENCY = dto.SCURRENCY;
        entity.SNAME_EXEC = dto.SNAME_EXEC;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.SCLIENT_AGE = dto.SCLIENT_AGE;
        entity.SCLIENAME_AGE = dto.SCLIENAME_AGE;
        entity.NPAYFREQ = dto.NPAYFREQ;
        entity.SKEY = dto.SKEY;
        entity.NID = dto.NID;
        entity.NRECEIPT_A = dto.NRECEIPT_A;
        entity.DEFFECDATE_A = dto.DEFFECDATE_A;
        entity.NPREMIUM_A = dto.NPREMIUM_A;
        entity.SCLIENT_A = dto.SCLIENT_A;
        entity.SCLIENAME_A = dto.SCLIENAME_A;
        entity.NRECEIPT_D = dto.NRECEIPT_D;
        entity.DEFFECDATE_D = dto.DEFFECDATE_D;
        entity.NPREMIUM_D = dto.NPREMIUM_D;
        entity.STRATYPEI = dto.STRATYPEI;
        entity.SCLIENT_D = dto.SCLIENT_D;
        entity.SCLIENAME_D = dto.SCLIENAME_D;
        entity.NAGENCY = dto.NAGENCY;
        entity.NPREMIUM_TOT = dto.NPREMIUM_TOT;
        entity.SADDRESS = dto.SADDRESS;
        entity.SLOCAL = dto.SLOCAL;
        entity.SMUNICIPALITY = dto.SMUNICIPALITY;
        entity.SPHONE = dto.SPHONE;
        entity.SMODULEC = dto.SMODULEC;
        entity.DLIMITDATE = dto.DLIMITDATE;
        entity.NCOUNT = dto.NCOUNT;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.NPREMIUM_P = dto.NPREMIUM_P;
        entity.NINTEREST_P = dto.NINTEREST_P;
        entity.NINTEREST_O = dto.NINTEREST_O;
        entity.NPROPONUM = dto.NPROPONUM;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.DNULLDATE = dto.DNULLDATE;
    }
}
