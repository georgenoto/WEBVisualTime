using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_LOG_PROC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MASSIVE_LOG_PROCMappingExtensions
{
    public static MASSIVE_LOG_PROCDto ToDto(this MASSIVE_LOG_PROC entity)
    {
        if (entity == null) return null!;
        return new MASSIVE_LOG_PROCDto
        {
            SKEY = entity.SKEY,
            MASS_PROC_SPONSORSKEYSLOT = entity.MASS_PROC_SPONSORSKEY?.SLOT,
            NKEY = entity.NKEY,
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NCLAIM = entity.NCLAIM,
            DSTARTDATE = entity.DSTARTDATE,
            NRECEIPT = entity.NRECEIPT,
            NDIGIT = entity.NDIGIT,
            NPAYNUMBE = entity.NPAYNUMBE,
            NSEQ = entity.NSEQ,
            DEXPIRDAT = entity.DEXPIRDAT,
            NCAPITAL = entity.NCAPITAL,
            NPREMIUM = entity.NPREMIUM,
            NDECLAREDCLAIM = entity.NDECLAREDCLAIM,
            NCLAIMSPAID = entity.NCLAIMSPAID,
            NRECEIPTPAID = entity.NRECEIPTPAID,
            SCANCELEDCLAIMS = entity.SCANCELEDCLAIMS,
            DNULLDATE = entity.DNULLDATE,
            NROLE = entity.NROLE,
            SCLIENT = entity.SCLIENT,
            SITEM = entity.SITEM,
            NROW = entity.NROW,
            NCOMBPOLICY = entity.NCOMBPOLICY,
            NCOMMISION = entity.NCOMMISION,
            NSTIPEND_AMOUNT = entity.NSTIPEND_AMOUNT,
            NCOD_AGREE = entity.NCOD_AGREE,
            MASS_PROC_SPONSORNCOD_AGREESLOT = entity.MASS_PROC_SPONSORNCOD_AGREE?.SLOT,
            NAMOUNT_ORI = entity.NAMOUNT_ORI,
            NAMOUNT_LOC = entity.NAMOUNT_LOC,
            NACTION = entity.NACTION,
            SLOT = entity.SLOT,
            SCOMERPRODUCT = entity.SCOMERPRODUCT,
            SOFFICIALPOL = entity.SOFFICIALPOL,
            NPREMIUMN = entity.NPREMIUMN,
            NPAYFREQ = entity.NPAYFREQ,
            NWAY_PAY = entity.NWAY_PAY,
            SPREVNUMPOL = entity.SPREVNUMPOL,
            DDATEORIGINCERT = entity.DDATEORIGINCERT,
        };
    }

    public static MASSIVE_LOG_PROC ToEntity(this CreateMASSIVE_LOG_PROCDto dto)
    {
        if (dto == null) return null!;
        return new MASSIVE_LOG_PROC
        {
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NCLAIM = dto.NCLAIM,
            DSTARTDATE = dto.DSTARTDATE,
            NRECEIPT = dto.NRECEIPT,
            NDIGIT = dto.NDIGIT,
            NPAYNUMBE = dto.NPAYNUMBE,
            DEXPIRDAT = dto.DEXPIRDAT,
            NCAPITAL = dto.NCAPITAL,
            NPREMIUM = dto.NPREMIUM,
            NDECLAREDCLAIM = dto.NDECLAREDCLAIM,
            NCLAIMSPAID = dto.NCLAIMSPAID,
            NRECEIPTPAID = dto.NRECEIPTPAID,
            SCANCELEDCLAIMS = dto.SCANCELEDCLAIMS,
            DNULLDATE = dto.DNULLDATE,
            NROLE = dto.NROLE,
            SCLIENT = dto.SCLIENT,
            SITEM = dto.SITEM,
            NCOMBPOLICY = dto.NCOMBPOLICY,
            NCOMMISION = dto.NCOMMISION,
            NSTIPEND_AMOUNT = dto.NSTIPEND_AMOUNT,
            NCOD_AGREE = dto.NCOD_AGREE,
            NAMOUNT_ORI = dto.NAMOUNT_ORI,
            NAMOUNT_LOC = dto.NAMOUNT_LOC,
            NACTION = dto.NACTION,
            SLOT = dto.SLOT,
            SCOMERPRODUCT = dto.SCOMERPRODUCT,
            SOFFICIALPOL = dto.SOFFICIALPOL,
            NPREMIUMN = dto.NPREMIUMN,
            NPAYFREQ = dto.NPAYFREQ,
            NWAY_PAY = dto.NWAY_PAY,
            SPREVNUMPOL = dto.SPREVNUMPOL,
            DDATEORIGINCERT = dto.DDATEORIGINCERT,
        };
    }

    public static void UpdateEntity(this MASSIVE_LOG_PROC entity, UpdateMASSIVE_LOG_PROCDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NCLAIM = dto.NCLAIM;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.NDIGIT = dto.NDIGIT;
        entity.NPAYNUMBE = dto.NPAYNUMBE;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NDECLAREDCLAIM = dto.NDECLAREDCLAIM;
        entity.NCLAIMSPAID = dto.NCLAIMSPAID;
        entity.NRECEIPTPAID = dto.NRECEIPTPAID;
        entity.SCANCELEDCLAIMS = dto.SCANCELEDCLAIMS;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NROLE = dto.NROLE;
        entity.SCLIENT = dto.SCLIENT;
        entity.SITEM = dto.SITEM;
        entity.NCOMBPOLICY = dto.NCOMBPOLICY;
        entity.NCOMMISION = dto.NCOMMISION;
        entity.NSTIPEND_AMOUNT = dto.NSTIPEND_AMOUNT;
        entity.NCOD_AGREE = dto.NCOD_AGREE;
        entity.NAMOUNT_ORI = dto.NAMOUNT_ORI;
        entity.NAMOUNT_LOC = dto.NAMOUNT_LOC;
        entity.NACTION = dto.NACTION;
        entity.SLOT = dto.SLOT;
        entity.SCOMERPRODUCT = dto.SCOMERPRODUCT;
        entity.SOFFICIALPOL = dto.SOFFICIALPOL;
        entity.NPREMIUMN = dto.NPREMIUMN;
        entity.NPAYFREQ = dto.NPAYFREQ;
        entity.NWAY_PAY = dto.NWAY_PAY;
        entity.SPREVNUMPOL = dto.SPREVNUMPOL;
        entity.DDATEORIGINCERT = dto.DDATEORIGINCERT;
    }
}
