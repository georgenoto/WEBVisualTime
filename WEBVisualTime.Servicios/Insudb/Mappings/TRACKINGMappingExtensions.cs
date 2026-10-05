using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TRACKING;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TRACKINGMappingExtensions
{
    public static TRACKINGDto ToDto(this TRACKING entity)
    {
        if (entity == null) return null!;
        return new TRACKINGDto
        {
            ID = entity.ID,
            FACTTIME = entity.FACTTIME,
            HOSTSOURCE = entity.HOSTSOURCE,
            FORMPATH = entity.FORMPATH,
            URLREFERRER = entity.URLREFERRER,
            USERAGENT = entity.USERAGENT,
            FORMID = entity.FORMID,
            PURCHASEORDER = entity.PURCHASEORDER,
            REMARK = entity.REMARK,
            CALLEDFROMID = entity.CALLEDFROMID,
        };
    }

    public static TRACKING ToEntity(this CreateTRACKINGDto dto)
    {
        if (dto == null) return null!;
        return new TRACKING
        {
            FACTTIME = dto.FACTTIME,
            HOSTSOURCE = dto.HOSTSOURCE,
            FORMPATH = dto.FORMPATH,
            URLREFERRER = dto.URLREFERRER,
            USERAGENT = dto.USERAGENT,
            FORMID = dto.FORMID,
            PURCHASEORDER = dto.PURCHASEORDER,
            REMARK = dto.REMARK,
            CALLEDFROMID = dto.CALLEDFROMID,
        };
    }

    public static void UpdateEntity(this TRACKING entity, UpdateTRACKINGDto dto)
    {
        if (entity == null || dto == null) return;
        entity.FACTTIME = dto.FACTTIME;
        entity.HOSTSOURCE = dto.HOSTSOURCE;
        entity.FORMPATH = dto.FORMPATH;
        entity.URLREFERRER = dto.URLREFERRER;
        entity.USERAGENT = dto.USERAGENT;
        entity.FORMID = dto.FORMID;
        entity.PURCHASEORDER = dto.PURCHASEORDER;
        entity.REMARK = dto.REMARK;
        entity.CALLEDFROMID = dto.CALLEDFROMID;
    }
}
