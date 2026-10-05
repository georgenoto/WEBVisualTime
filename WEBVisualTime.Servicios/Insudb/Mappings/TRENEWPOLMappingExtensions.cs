using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TRENEWPOL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TRENEWPOLMappingExtensions
{
    public static TRENEWPOLDto ToDto(this TRENEWPOL entity)
    {
        if (entity == null) return null!;
        return new TRENEWPOLDto
        {
            SKEY = entity.SKEY,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            SCLIENT = entity.SCLIENT,
            DEXPIRDATE = entity.DEXPIRDATE,
            NINSAMOUNT = entity.NINSAMOUNT,
            NPREMIUNAN = entity.NPREMIUNAN,
            NINCIDENTYP = entity.NINCIDENTYP,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPENRECAMO = entity.NPENRECAMO,
            NQPAYCLAIM = entity.NQPAYCLAIM,
            NPAYCLAIMAMO = entity.NPAYCLAIMAMO,
            NQPENCLAIM = entity.NQPENCLAIM,
            NPENCLAIMAMO = entity.NPENCLAIMAMO,
            NQRECPEN = entity.NQRECPEN,
            NQCLAIM = entity.NQCLAIM,
            NCAPITAL = entity.NCAPITAL,
            NPREMIUM = entity.NPREMIUM,
            STEXT_ERR = entity.STEXT_ERR,
            DSTARTDATE = entity.DSTARTDATE,
            NOFFICE = entity.NOFFICE,
            NAGENCY = entity.NAGENCY,
            NOFFICEAGEN = entity.NOFFICEAGEN,
            NINTERMED = entity.NINTERMED,
            NCURRENCY = entity.NCURRENCY,
            NPAYFREQ = entity.NPAYFREQ,
            SCOLINVOT = entity.SCOLINVOT,
            NPREMIUMPROYECT = entity.NPREMIUMPROYECT,
            SWARNING = entity.SWARNING,
        };
    }

    public static TRENEWPOL ToEntity(this CreateTRENEWPOLDto dto)
    {
        if (dto == null) return null!;
        return new TRENEWPOL
        {
            SKEY = dto.SKEY,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            SCLIENT = dto.SCLIENT,
            DEXPIRDATE = dto.DEXPIRDATE,
            NINSAMOUNT = dto.NINSAMOUNT,
            NPREMIUNAN = dto.NPREMIUNAN,
            NINCIDENTYP = dto.NINCIDENTYP,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPENRECAMO = dto.NPENRECAMO,
            NQPAYCLAIM = dto.NQPAYCLAIM,
            NPAYCLAIMAMO = dto.NPAYCLAIMAMO,
            NQPENCLAIM = dto.NQPENCLAIM,
            NPENCLAIMAMO = dto.NPENCLAIMAMO,
            NQRECPEN = dto.NQRECPEN,
            NQCLAIM = dto.NQCLAIM,
            NCAPITAL = dto.NCAPITAL,
            NPREMIUM = dto.NPREMIUM,
            STEXT_ERR = dto.STEXT_ERR,
            DSTARTDATE = dto.DSTARTDATE,
            NOFFICE = dto.NOFFICE,
            NAGENCY = dto.NAGENCY,
            NOFFICEAGEN = dto.NOFFICEAGEN,
            NINTERMED = dto.NINTERMED,
            NCURRENCY = dto.NCURRENCY,
            NPAYFREQ = dto.NPAYFREQ,
            SCOLINVOT = dto.SCOLINVOT,
            NPREMIUMPROYECT = dto.NPREMIUMPROYECT,
            SWARNING = dto.SWARNING,
        };
    }

    public static void UpdateEntity(this TRENEWPOL entity, UpdateTRENEWPOLDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SKEY = dto.SKEY;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.SCLIENT = dto.SCLIENT;
        entity.DEXPIRDATE = dto.DEXPIRDATE;
        entity.NINSAMOUNT = dto.NINSAMOUNT;
        entity.NPREMIUNAN = dto.NPREMIUNAN;
        entity.NINCIDENTYP = dto.NINCIDENTYP;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPENRECAMO = dto.NPENRECAMO;
        entity.NQPAYCLAIM = dto.NQPAYCLAIM;
        entity.NPAYCLAIMAMO = dto.NPAYCLAIMAMO;
        entity.NQPENCLAIM = dto.NQPENCLAIM;
        entity.NPENCLAIMAMO = dto.NPENCLAIMAMO;
        entity.NQRECPEN = dto.NQRECPEN;
        entity.NQCLAIM = dto.NQCLAIM;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.STEXT_ERR = dto.STEXT_ERR;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.NOFFICE = dto.NOFFICE;
        entity.NAGENCY = dto.NAGENCY;
        entity.NOFFICEAGEN = dto.NOFFICEAGEN;
        entity.NINTERMED = dto.NINTERMED;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NPAYFREQ = dto.NPAYFREQ;
        entity.SCOLINVOT = dto.SCOLINVOT;
        entity.NPREMIUMPROYECT = dto.NPREMIUMPROYECT;
        entity.SWARNING = dto.SWARNING;
    }
}
