using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TCOMMISS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TCOMMISSMappingExtensions
{
    public static TCOMMISSDto ToDto(this TCOMMISS entity)
    {
        if (entity == null) return null!;
        return new TCOMMISSDto
        {
            SKEY = entity.SKEY,
            NINTERMED = entity.NINTERMED,
            NCOMMISSION = entity.NCOMMISSION,
            NSHARE = entity.NSHARE,
            NCURRENCY = entity.NCURRENCY,
            NCOM_AFEC = entity.NCOM_AFEC,
            NCOM_EXEN = entity.NCOM_EXEN,
            NPERCENT = entity.NPERCENT,
        };
    }

    public static TCOMMISS ToEntity(this CreateTCOMMISSDto dto)
    {
        if (dto == null) return null!;
        return new TCOMMISS
        {
            SKEY = dto.SKEY,
            NINTERMED = dto.NINTERMED,
            NCOMMISSION = dto.NCOMMISSION,
            NSHARE = dto.NSHARE,
            NCURRENCY = dto.NCURRENCY,
            NCOM_AFEC = dto.NCOM_AFEC,
            NCOM_EXEN = dto.NCOM_EXEN,
            NPERCENT = dto.NPERCENT,
        };
    }

    public static void UpdateEntity(this TCOMMISS entity, UpdateTCOMMISSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SKEY = dto.SKEY;
        entity.NINTERMED = dto.NINTERMED;
        entity.NCOMMISSION = dto.NCOMMISSION;
        entity.NSHARE = dto.NSHARE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NCOM_AFEC = dto.NCOM_AFEC;
        entity.NCOM_EXEN = dto.NCOM_EXEN;
        entity.NPERCENT = dto.NPERCENT;
    }
}
