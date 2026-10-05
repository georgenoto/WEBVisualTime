using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DURINSU_PROD;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DURINSU_PRODMappingExtensions
{
    public static DURINSU_PRODDto ToDto(this DURINSU_PROD entity)
    {
        if (entity == null) return null!;
        return new DURINSU_PRODDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            DEFFECDATE = entity.DEFFECDATE,
            NIDURAFIX = entity.NIDURAFIX,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NTYPDURINS = entity.NTYPDURINS,
            TABLE5589SDESCRIPT = entity.TABLE5589?.SDESCRIPT,
            NMINDURINS = entity.NMINDURINS,
        };
    }

    public static DURINSU_PROD ToEntity(this CreateDURINSU_PRODDto dto)
    {
        if (dto == null) return null!;
        return new DURINSU_PROD
        {
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NMINDURINS = dto.NMINDURINS,
        };
    }

    public static void UpdateEntity(this DURINSU_PROD entity, UpdateDURINSU_PRODDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NMINDURINS = dto.NMINDURINS;
    }
}
