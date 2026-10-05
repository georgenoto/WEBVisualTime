using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.REQUEST;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class REQUESTMappingExtensions
{
    public static REQUESTDto ToDto(this REQUEST entity)
    {
        if (entity == null) return null!;
        return new REQUESTDto
        {
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NORIGIN = entity.NORIGIN,
            TABLE5580SDESCRIPT = entity.TABLE5580?.SDESCRIPT,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            STYP_SURR = entity.STYP_SURR,
            SPAYORDER = entity.SPAYORDER,
            TABLE193SDESCRIPT = entity.TABLE193?.SDESCRIPT,
            SNULL_REC = entity.SNULL_REC,
            NAMOUNT = entity.NAMOUNT,
            SDESCRIPT = entity.SDESCRIPT,
            NNOTENUM = entity.NNOTENUM,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NNULLCODE = entity.NNULLCODE,
            TABLE13SDESCRIPT = entity.TABLE13?.SDESCRIPT,
            NTYP_REC = entity.NTYP_REC,
            SREH_LREC = entity.SREH_LREC,
            NINTERESTRATE = entity.NINTERESTRATE,
            NTYPEPAY = entity.NTYPEPAY,
            TABLE5527SDESCRIPT = entity.TABLE5527?.SDESCRIPT,
            DMOVDATE = entity.DMOVDATE,
            NREQUEST_NU = entity.NREQUEST_NU,
            SCLIPAYSURR = entity.SCLIPAYSURR,
            CLIENTSCLIPAYSURRSACCOUNT_IN = entity.CLIENTSCLIPAYSURR?.SACCOUNT_IN,
            SCERTPAYSURR = entity.SCERTPAYSURR,
            CERTIFICATSCERTPAYSURRSCUMUL_CODE = entity.CERTIFICATSCERTPAYSURR?.SCUMUL_CODE,
            NBRAPAYSURR = entity.NBRAPAYSURR,
            CERTIFICATNBRAPAYSURRSCUMUL_CODE = entity.CERTIFICATNBRAPAYSURR?.SCUMUL_CODE,
            NPROPAYSURR = entity.NPROPAYSURR,
            CERTIFICATNPROPAYSURRSCUMUL_CODE = entity.CERTIFICATNPROPAYSURR?.SCUMUL_CODE,
            NPOLPAYSURR = entity.NPOLPAYSURR,
            CERTIFICATNPOLPAYSURRSCUMUL_CODE = entity.CERTIFICATNPOLPAYSURR?.SCUMUL_CODE,
            NCERPAYSURR = entity.NCERPAYSURR,
            CERTIFICATNCERPAYSURRSCUMUL_CODE = entity.CERTIFICATNCERPAYSURR?.SCUMUL_CODE,
            NAGENCY = entity.NAGENCY,
            NSURR_REASON = entity.NSURR_REASON,
            TABLE5635SDESCRIPT = entity.TABLE5635?.SDESCRIPT,
            NTYPE_PAYMENT = entity.NTYPE_PAYMENT,
            TABLE5636SDESCRIPT = entity.TABLE5636?.SDESCRIPT,
            NINSTITUTION = entity.NINSTITUTION,
            TAB_FN_INSTITUTIONSNAME = entity.TAB_FN_INSTITUTION?.SNAME,
            SCLIENTINSTITUTION = entity.SCLIENTINSTITUTION,
            CLIENTSCLIENTINSTITUTIONSACCOUNT_IN = entity.CLIENTSCLIENTINSTITUTION?.SACCOUNT_IN,
            SRETURN_IND = entity.SRETURN_IND,
            NRETURN_RAT = entity.NRETURN_RAT,
            NORIGIN_APV = entity.NORIGIN_APV,
            NCOSTAMOUNT = entity.NCOSTAMOUNT,
            NTAX = entity.NTAX,
            NTAX_RENT = entity.NTAX_RENT,
            NFUNDS = entity.NFUNDS,
            NSIGNAL = entity.NSIGNAL,
            NUNITSCHANGE = entity.NUNITSCHANGE,
            NCURRENCY = entity.NCURRENCY,
            NSELL_COST = entity.NSELL_COST,
            NBUY_COST = entity.NBUY_COST,
            NSWI_COST = entity.NSWI_COST,
            NVALUECHANGE = entity.NVALUECHANGE,
            NSWITCHORIGIN = entity.NSWITCHORIGIN,
            SSWITCHSTATUS = entity.SSWITCHSTATUS,
            SIND_INSUR = entity.SIND_INSUR,
            DPAYMENTDATE = entity.DPAYMENTDATE,
            NTYP_PROFITWORKER = entity.NTYP_PROFITWORKER,
            NCOST_COV_DEV = entity.NCOST_COV_DEV,
            NRENTABILITY = entity.NRENTABILITY,
            NAMOUNT_REC_DEV = entity.NAMOUNT_REC_DEV,
            NAMOUNT_DEV = entity.NAMOUNT_DEV,
            SSWITCHORIGIN = entity.SSWITCHORIGIN,
            NPROPONUM = entity.NPROPONUM,
        };
    }

    public static REQUEST ToEntity(this CreateREQUESTDto dto)
    {
        if (dto == null) return null!;
        return new REQUEST
        {
            NORIGIN = dto.NORIGIN,
            DNULLDATE = dto.DNULLDATE,
            STYP_SURR = dto.STYP_SURR,
            SPAYORDER = dto.SPAYORDER,
            SNULL_REC = dto.SNULL_REC,
            NAMOUNT = dto.NAMOUNT,
            SDESCRIPT = dto.SDESCRIPT,
            NNOTENUM = dto.NNOTENUM,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NNULLCODE = dto.NNULLCODE,
            NTYP_REC = dto.NTYP_REC,
            SREH_LREC = dto.SREH_LREC,
            NINTERESTRATE = dto.NINTERESTRATE,
            NTYPEPAY = dto.NTYPEPAY,
            DMOVDATE = dto.DMOVDATE,
            NREQUEST_NU = dto.NREQUEST_NU,
            SCLIPAYSURR = dto.SCLIPAYSURR,
            SCERTPAYSURR = dto.SCERTPAYSURR,
            NBRAPAYSURR = dto.NBRAPAYSURR,
            NPROPAYSURR = dto.NPROPAYSURR,
            NPOLPAYSURR = dto.NPOLPAYSURR,
            NCERPAYSURR = dto.NCERPAYSURR,
            NAGENCY = dto.NAGENCY,
            NSURR_REASON = dto.NSURR_REASON,
            NTYPE_PAYMENT = dto.NTYPE_PAYMENT,
            NINSTITUTION = dto.NINSTITUTION,
            SCLIENTINSTITUTION = dto.SCLIENTINSTITUTION,
            SRETURN_IND = dto.SRETURN_IND,
            NRETURN_RAT = dto.NRETURN_RAT,
            NORIGIN_APV = dto.NORIGIN_APV,
            NCOSTAMOUNT = dto.NCOSTAMOUNT,
            NTAX = dto.NTAX,
            NTAX_RENT = dto.NTAX_RENT,
            NSIGNAL = dto.NSIGNAL,
            NUNITSCHANGE = dto.NUNITSCHANGE,
            NCURRENCY = dto.NCURRENCY,
            NSELL_COST = dto.NSELL_COST,
            NBUY_COST = dto.NBUY_COST,
            NSWI_COST = dto.NSWI_COST,
            NVALUECHANGE = dto.NVALUECHANGE,
            NSWITCHORIGIN = dto.NSWITCHORIGIN,
            SSWITCHSTATUS = dto.SSWITCHSTATUS,
            SIND_INSUR = dto.SIND_INSUR,
            DPAYMENTDATE = dto.DPAYMENTDATE,
            NTYP_PROFITWORKER = dto.NTYP_PROFITWORKER,
            NCOST_COV_DEV = dto.NCOST_COV_DEV,
            NRENTABILITY = dto.NRENTABILITY,
            NAMOUNT_REC_DEV = dto.NAMOUNT_REC_DEV,
            NAMOUNT_DEV = dto.NAMOUNT_DEV,
            SSWITCHORIGIN = dto.SSWITCHORIGIN,
            NPROPONUM = dto.NPROPONUM,
        };
    }

    public static void UpdateEntity(this REQUEST entity, UpdateREQUESTDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NORIGIN = dto.NORIGIN;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.STYP_SURR = dto.STYP_SURR;
        entity.SPAYORDER = dto.SPAYORDER;
        entity.SNULL_REC = dto.SNULL_REC;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.NTYP_REC = dto.NTYP_REC;
        entity.SREH_LREC = dto.SREH_LREC;
        entity.NINTERESTRATE = dto.NINTERESTRATE;
        entity.NTYPEPAY = dto.NTYPEPAY;
        entity.DMOVDATE = dto.DMOVDATE;
        entity.NREQUEST_NU = dto.NREQUEST_NU;
        entity.SCLIPAYSURR = dto.SCLIPAYSURR;
        entity.SCERTPAYSURR = dto.SCERTPAYSURR;
        entity.NBRAPAYSURR = dto.NBRAPAYSURR;
        entity.NPROPAYSURR = dto.NPROPAYSURR;
        entity.NPOLPAYSURR = dto.NPOLPAYSURR;
        entity.NCERPAYSURR = dto.NCERPAYSURR;
        entity.NAGENCY = dto.NAGENCY;
        entity.NSURR_REASON = dto.NSURR_REASON;
        entity.NTYPE_PAYMENT = dto.NTYPE_PAYMENT;
        entity.NINSTITUTION = dto.NINSTITUTION;
        entity.SCLIENTINSTITUTION = dto.SCLIENTINSTITUTION;
        entity.SRETURN_IND = dto.SRETURN_IND;
        entity.NRETURN_RAT = dto.NRETURN_RAT;
        entity.NORIGIN_APV = dto.NORIGIN_APV;
        entity.NCOSTAMOUNT = dto.NCOSTAMOUNT;
        entity.NTAX = dto.NTAX;
        entity.NTAX_RENT = dto.NTAX_RENT;
        entity.NSIGNAL = dto.NSIGNAL;
        entity.NUNITSCHANGE = dto.NUNITSCHANGE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NSELL_COST = dto.NSELL_COST;
        entity.NBUY_COST = dto.NBUY_COST;
        entity.NSWI_COST = dto.NSWI_COST;
        entity.NVALUECHANGE = dto.NVALUECHANGE;
        entity.NSWITCHORIGIN = dto.NSWITCHORIGIN;
        entity.SSWITCHSTATUS = dto.SSWITCHSTATUS;
        entity.SIND_INSUR = dto.SIND_INSUR;
        entity.DPAYMENTDATE = dto.DPAYMENTDATE;
        entity.NTYP_PROFITWORKER = dto.NTYP_PROFITWORKER;
        entity.NCOST_COV_DEV = dto.NCOST_COV_DEV;
        entity.NRENTABILITY = dto.NRENTABILITY;
        entity.NAMOUNT_REC_DEV = dto.NAMOUNT_REC_DEV;
        entity.NAMOUNT_DEV = dto.NAMOUNT_DEV;
        entity.SSWITCHORIGIN = dto.SSWITCHORIGIN;
        entity.NPROPONUM = dto.NPROPONUM;
    }
}
