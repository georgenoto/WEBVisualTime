using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BILLS_NUM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BILLS_NUMMappingExtensions
{
    public static BILLS_NUMDto ToDto(this BILLS_NUM entity)
    {
        if (entity == null) return null!;
        return new BILLS_NUMDto
        {
            NINSUR_AREA = entity.NINSUR_AREA,
            TABLE5001SDESCRIPT = entity.TABLE5001?.SDESCRIPT,
            SBILLTYPE = entity.SBILLTYPE,
            NINITNUMB = entity.NINITNUMB,
            NENDNUMB = entity.NENDNUMB,
            NLASTBILL = entity.NLASTBILL,
            DLASTCLOSED = entity.DLASTCLOSED,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static BILLS_NUM ToEntity(this CreateBILLS_NUMDto dto)
    {
        if (dto == null) return null!;
        return new BILLS_NUM
        {
            NENDNUMB = dto.NENDNUMB,
            NLASTBILL = dto.NLASTBILL,
            DLASTCLOSED = dto.DLASTCLOSED,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this BILLS_NUM entity, UpdateBILLS_NUMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NENDNUMB = dto.NENDNUMB;
        entity.NLASTBILL = dto.NLASTBILL;
        entity.DLASTCLOSED = dto.DLASTCLOSED;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
