using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DEVLOCALRECORDSDELETED;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DEVLOCALRECORDSDELETEDMappingExtensions
{
    public static DEVLOCALRECORDSDELETEDDto ToDto(this DEVLOCALRECORDSDELETED entity)
    {
        if (entity == null) return null!;
        return new DEVLOCALRECORDSDELETEDDto
        {
            LOCALRECDELID = entity.LOCALRECDELID,
            NAME = entity.NAME,
            DELDATE = entity.DELDATE,
            PKEY = entity.PKEY,
            LOCALTABLEID = entity.LOCALTABLEID,
        };
    }

    public static DEVLOCALRECORDSDELETED ToEntity(this CreateDEVLOCALRECORDSDELETEDDto dto)
    {
        if (dto == null) return null!;
        return new DEVLOCALRECORDSDELETED
        {
            DELDATE = dto.DELDATE,
            PKEY = dto.PKEY,
            LOCALTABLEID = dto.LOCALTABLEID,
        };
    }

    public static void UpdateEntity(this DEVLOCALRECORDSDELETED entity, UpdateDEVLOCALRECORDSDELETEDDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DELDATE = dto.DELDATE;
        entity.PKEY = dto.PKEY;
        entity.LOCALTABLEID = dto.LOCALTABLEID;
    }
}
