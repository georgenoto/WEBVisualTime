using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.OFF_ACC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class OFF_ACCMappingExtensions
{
    public static OFF_ACCDto ToDto(this OFF_ACC entity)
    {
        if (entity == null) return null!;
        return new OFF_ACCDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            SECUR_SCHESLONGDESC = entity.SECUR_SCHE?.SLONGDESC,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            SIND_INQU = entity.SIND_INQU,
            SIND_UPDA = entity.SIND_UPDA,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static OFF_ACC ToEntity(this CreateOFF_ACCDto dto)
    {
        if (dto == null) return null!;
        return new OFF_ACC
        {
            DCOMPDATE = dto.DCOMPDATE,
            SIND_INQU = dto.SIND_INQU,
            SIND_UPDA = dto.SIND_UPDA,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this OFF_ACC entity, UpdateOFF_ACCDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SIND_INQU = dto.SIND_INQU;
        entity.SIND_UPDA = dto.SIND_UPDA;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
