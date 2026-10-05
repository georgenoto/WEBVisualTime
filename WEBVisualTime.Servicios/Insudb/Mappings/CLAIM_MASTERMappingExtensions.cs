using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_MASTER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_MASTERMappingExtensions
{
    public static CLAIM_MASTERDto ToDto(this CLAIM_MASTER entity)
    {
        if (entity == null) return null!;
        return new CLAIM_MASTERDto
        {
            NBORDEREAUX_CL = entity.NBORDEREAUX_CL,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NCOVER = entity.NCOVER,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SKEY = entity.SKEY,
            SFILENAME = entity.SFILENAME,
            NPROVIDER = entity.NPROVIDER,
            NOFFICE = entity.NOFFICE,
            NSTATUS = entity.NSTATUS,
            SSTATUS_PROC = entity.SSTATUS_PROC,
            NPAY_PROVIDER = entity.NPAY_PROVIDER,
        };
    }

    public static CLAIM_MASTER ToEntity(this CreateCLAIM_MASTERDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_MASTER
        {
            SCLIENT = dto.SCLIENT,
            NCOVER = dto.NCOVER,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SKEY = dto.SKEY,
            SFILENAME = dto.SFILENAME,
            NPROVIDER = dto.NPROVIDER,
            NOFFICE = dto.NOFFICE,
            NSTATUS = dto.NSTATUS,
            SSTATUS_PROC = dto.SSTATUS_PROC,
            NPAY_PROVIDER = dto.NPAY_PROVIDER,
        };
    }

    public static void UpdateEntity(this CLAIM_MASTER entity, UpdateCLAIM_MASTERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCLIENT = dto.SCLIENT;
        entity.NCOVER = dto.NCOVER;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SKEY = dto.SKEY;
        entity.SFILENAME = dto.SFILENAME;
        entity.NPROVIDER = dto.NPROVIDER;
        entity.NOFFICE = dto.NOFFICE;
        entity.NSTATUS = dto.NSTATUS;
        entity.SSTATUS_PROC = dto.SSTATUS_PROC;
        entity.NPAY_PROVIDER = dto.NPAY_PROVIDER;
    }
}
