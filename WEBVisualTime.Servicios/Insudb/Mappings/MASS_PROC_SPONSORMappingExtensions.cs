using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASS_PROC_SPONSOR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MASS_PROC_SPONSORMappingExtensions
{
    public static MASS_PROC_SPONSORDto ToDto(this MASS_PROC_SPONSOR entity)
    {
        if (entity == null) return null!;
        return new MASS_PROC_SPONSORDto
        {
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NPROCESS = entity.NPROCESS,
            SKEY = entity.SKEY,
            SLOT = entity.SLOT,
            STYPEEXECUTION = entity.STYPEEXECUTION,
            NSTATUS = entity.NSTATUS,
            DPROCESSDATE = entity.DPROCESSDATE,
            NTOTALRECPROC = entity.NTOTALRECPROC,
            NSUCCESSRECPROC = entity.NSUCCESSRECPROC,
            NERRORRECPROC = entity.NERRORRECPROC,
            NCOLLECTPREMIUM = entity.NCOLLECTPREMIUM,
            NSUSCRIBEDPOLICIES = entity.NSUSCRIBEDPOLICIES,
            NCANCELEDPOLICIES = entity.NCANCELEDPOLICIES,
            NMODIFIEDPOLICIES = entity.NMODIFIEDPOLICIES,
            NCLAIMSREPORTED = entity.NCLAIMSREPORTED,
            NDECLAREDCLAIMS = entity.NDECLAREDCLAIMS,
            NTOTALCLAIMSPAID = entity.NTOTALCLAIMSPAID,
            NCLAIMSPAID = entity.NCLAIMSPAID,
            NCANCELEDCLAIMS = entity.NCANCELEDCLAIMS,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NKEY = entity.NKEY,
            NCANCELEDCERTIFICATE = entity.NCANCELEDCERTIFICATE,
            NMODIFIEDCERTIFICATE = entity.NMODIFIEDCERTIFICATE,
            NPOLICY = entity.NPOLICY,
            NSUSCRIBEDCERTIFICATE = entity.NSUSCRIBEDCERTIFICATE,
            NSHEET_OUT = entity.NSHEET_OUT,
            NUSERINCHARGE = entity.NUSERINCHARGE,
            DRECEPTION_DAY = entity.DRECEPTION_DAY,
            NCOD_AGREE = entity.NCOD_AGREE,
            SFILENAME = entity.SFILENAME,
            DEXECUTE = entity.DEXECUTE,
            NMONTH = entity.NMONTH,
            NYEAR = entity.NYEAR,
        };
    }

    public static MASS_PROC_SPONSOR ToEntity(this CreateMASS_PROC_SPONSORDto dto)
    {
        if (dto == null) return null!;
        return new MASS_PROC_SPONSOR
        {
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NPROCESS = dto.NPROCESS,
            SLOT = dto.SLOT,
            STYPEEXECUTION = dto.STYPEEXECUTION,
            NSTATUS = dto.NSTATUS,
            DPROCESSDATE = dto.DPROCESSDATE,
            NTOTALRECPROC = dto.NTOTALRECPROC,
            NSUCCESSRECPROC = dto.NSUCCESSRECPROC,
            NERRORRECPROC = dto.NERRORRECPROC,
            NCOLLECTPREMIUM = dto.NCOLLECTPREMIUM,
            NSUSCRIBEDPOLICIES = dto.NSUSCRIBEDPOLICIES,
            NCANCELEDPOLICIES = dto.NCANCELEDPOLICIES,
            NMODIFIEDPOLICIES = dto.NMODIFIEDPOLICIES,
            NCLAIMSREPORTED = dto.NCLAIMSREPORTED,
            NDECLAREDCLAIMS = dto.NDECLAREDCLAIMS,
            NTOTALCLAIMSPAID = dto.NTOTALCLAIMSPAID,
            NCLAIMSPAID = dto.NCLAIMSPAID,
            NCANCELEDCLAIMS = dto.NCANCELEDCLAIMS,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NKEY = dto.NKEY,
            NCANCELEDCERTIFICATE = dto.NCANCELEDCERTIFICATE,
            NMODIFIEDCERTIFICATE = dto.NMODIFIEDCERTIFICATE,
            NPOLICY = dto.NPOLICY,
            NSUSCRIBEDCERTIFICATE = dto.NSUSCRIBEDCERTIFICATE,
            NSHEET_OUT = dto.NSHEET_OUT,
            NUSERINCHARGE = dto.NUSERINCHARGE,
            DRECEPTION_DAY = dto.DRECEPTION_DAY,
            SFILENAME = dto.SFILENAME,
            DEXECUTE = dto.DEXECUTE,
            NMONTH = dto.NMONTH,
            NYEAR = dto.NYEAR,
        };
    }

    public static void UpdateEntity(this MASS_PROC_SPONSOR entity, UpdateMASS_PROC_SPONSORDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NPROCESS = dto.NPROCESS;
        entity.SLOT = dto.SLOT;
        entity.STYPEEXECUTION = dto.STYPEEXECUTION;
        entity.NSTATUS = dto.NSTATUS;
        entity.DPROCESSDATE = dto.DPROCESSDATE;
        entity.NTOTALRECPROC = dto.NTOTALRECPROC;
        entity.NSUCCESSRECPROC = dto.NSUCCESSRECPROC;
        entity.NERRORRECPROC = dto.NERRORRECPROC;
        entity.NCOLLECTPREMIUM = dto.NCOLLECTPREMIUM;
        entity.NSUSCRIBEDPOLICIES = dto.NSUSCRIBEDPOLICIES;
        entity.NCANCELEDPOLICIES = dto.NCANCELEDPOLICIES;
        entity.NMODIFIEDPOLICIES = dto.NMODIFIEDPOLICIES;
        entity.NCLAIMSREPORTED = dto.NCLAIMSREPORTED;
        entity.NDECLAREDCLAIMS = dto.NDECLAREDCLAIMS;
        entity.NTOTALCLAIMSPAID = dto.NTOTALCLAIMSPAID;
        entity.NCLAIMSPAID = dto.NCLAIMSPAID;
        entity.NCANCELEDCLAIMS = dto.NCANCELEDCLAIMS;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NKEY = dto.NKEY;
        entity.NCANCELEDCERTIFICATE = dto.NCANCELEDCERTIFICATE;
        entity.NMODIFIEDCERTIFICATE = dto.NMODIFIEDCERTIFICATE;
        entity.NPOLICY = dto.NPOLICY;
        entity.NSUSCRIBEDCERTIFICATE = dto.NSUSCRIBEDCERTIFICATE;
        entity.NSHEET_OUT = dto.NSHEET_OUT;
        entity.NUSERINCHARGE = dto.NUSERINCHARGE;
        entity.DRECEPTION_DAY = dto.DRECEPTION_DAY;
        entity.SFILENAME = dto.SFILENAME;
        entity.DEXECUTE = dto.DEXECUTE;
        entity.NMONTH = dto.NMONTH;
        entity.NYEAR = dto.NYEAR;
    }
}
