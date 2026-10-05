using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTER_MASS_SPONSOR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MASTER_MASS_SPONSORMappingExtensions
{
    public static MASTER_MASS_SPONSORDto ToDto(this MASTER_MASS_SPONSOR entity)
    {
        if (entity == null) return null!;
        return new MASTER_MASS_SPONSORDto
        {
            NCOD_AGREE = entity.NCOD_AGREE,
            NSELLCHANNEL = entity.NSELLCHANNEL,
            NPROCESS = entity.NPROCESS,
            NSHEET = entity.NSHEET,
            NBUSIN = entity.NBUSIN,
            NBUSOUT = entity.NBUSOUT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SCOLLECTDEBT = entity.SCOLLECTDEBT,
            SCOLLCURRDEBT = entity.SCOLLCURRDEBT,
            SMAIL = entity.SMAIL,
            NSHEET_OUT = entity.NSHEET_OUT,
            DRECEPTION_DAY = entity.DRECEPTION_DAY,
            NUSERINCHARGE = entity.NUSERINCHARGE,
            NKEY = entity.NKEY,
            SDESCRIPT = entity.SDESCRIPT,
            NPERIOD = entity.NPERIOD,
            DLAST_DATE = entity.DLAST_DATE,
            NDAYSFREQ = entity.NDAYSFREQ,
        };
    }

    public static MASTER_MASS_SPONSOR ToEntity(this CreateMASTER_MASS_SPONSORDto dto)
    {
        if (dto == null) return null!;
        return new MASTER_MASS_SPONSOR
        {
            NCOD_AGREE = dto.NCOD_AGREE,
            NSELLCHANNEL = dto.NSELLCHANNEL,
            NPROCESS = dto.NPROCESS,
            NSHEET = dto.NSHEET,
            NBUSIN = dto.NBUSIN,
            NBUSOUT = dto.NBUSOUT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SCOLLECTDEBT = dto.SCOLLECTDEBT,
            SCOLLCURRDEBT = dto.SCOLLCURRDEBT,
            SMAIL = dto.SMAIL,
            NSHEET_OUT = dto.NSHEET_OUT,
            DRECEPTION_DAY = dto.DRECEPTION_DAY,
            NUSERINCHARGE = dto.NUSERINCHARGE,
            NKEY = dto.NKEY,
            SDESCRIPT = dto.SDESCRIPT,
            NPERIOD = dto.NPERIOD,
            DLAST_DATE = dto.DLAST_DATE,
            NDAYSFREQ = dto.NDAYSFREQ,
        };
    }

    public static void UpdateEntity(this MASTER_MASS_SPONSOR entity, UpdateMASTER_MASS_SPONSORDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCOD_AGREE = dto.NCOD_AGREE;
        entity.NSELLCHANNEL = dto.NSELLCHANNEL;
        entity.NPROCESS = dto.NPROCESS;
        entity.NSHEET = dto.NSHEET;
        entity.NBUSIN = dto.NBUSIN;
        entity.NBUSOUT = dto.NBUSOUT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCOLLECTDEBT = dto.SCOLLECTDEBT;
        entity.SCOLLCURRDEBT = dto.SCOLLCURRDEBT;
        entity.SMAIL = dto.SMAIL;
        entity.NSHEET_OUT = dto.NSHEET_OUT;
        entity.DRECEPTION_DAY = dto.DRECEPTION_DAY;
        entity.NUSERINCHARGE = dto.NUSERINCHARGE;
        entity.NKEY = dto.NKEY;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NPERIOD = dto.NPERIOD;
        entity.DLAST_DATE = dto.DLAST_DATE;
        entity.NDAYSFREQ = dto.NDAYSFREQ;
    }
}
