using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DURPAY_PROD;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DURPAY_PRODMappingExtensions
{
    public static DURPAY_PRODDto ToDto(this DURPAY_PROD entity)
    {
        if (entity == null) return null!;
        return new DURPAY_PRODDto
        {
            NID = entity.NID,
            DEFFECDATE = entity.DEFFECDATE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NIDURAFIX = entity.NIDURAFIX,
            NPDURAFIX = entity.NPDURAFIX,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NTYPDURINS = entity.NTYPDURINS,
            TABLE5589NTYPDURINSSDESCRIPT = entity.TABLE5589NTYPDURINS?.SDESCRIPT,
            NTYPDURPAY = entity.NTYPDURPAY,
            TABLE5589NTYPDURPAYSDESCRIPT = entity.TABLE5589NTYPDURPAY?.SDESCRIPT,
        };
    }

    public static DURPAY_PROD ToEntity(this CreateDURPAY_PRODDto dto)
    {
        if (dto == null) return null!;
        return new DURPAY_PROD
        {
            NIDURAFIX = dto.NIDURAFIX,
            NPDURAFIX = dto.NPDURAFIX,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NTYPDURINS = dto.NTYPDURINS,
            NTYPDURPAY = dto.NTYPDURPAY,
        };
    }

    public static void UpdateEntity(this DURPAY_PROD entity, UpdateDURPAY_PRODDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NIDURAFIX = dto.NIDURAFIX;
        entity.NPDURAFIX = dto.NPDURAFIX;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NTYPDURINS = dto.NTYPDURINS;
        entity.NTYPDURPAY = dto.NTYPDURPAY;
    }
}
