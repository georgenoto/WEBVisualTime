using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_STAT;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CASH_STATMappingExtensions
{
    public static CASH_STATDto ToDto(this CASH_STAT entity)
    {
        if (entity == null) return null!;
        return new CASH_STATDto
        {
            NCASHNUM = entity.NCASHNUM,
            DSTATDATE = entity.DSTATDATE,
            NSTATUS = entity.NSTATUS,
            TABLE5562SDESCRIPT = entity.TABLE5562?.SDESCRIPT,
            NID = entity.NID,
            NCASH_ID = entity.NCASH_ID,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static CASH_STAT ToEntity(this CreateCASH_STATDto dto)
    {
        if (dto == null) return null!;
        return new CASH_STAT
        {
            NSTATUS = dto.NSTATUS,
            NCASH_ID = dto.NCASH_ID,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this CASH_STAT entity, UpdateCASH_STATDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NSTATUS = dto.NSTATUS;
        entity.NCASH_ID = dto.NCASH_ID;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
