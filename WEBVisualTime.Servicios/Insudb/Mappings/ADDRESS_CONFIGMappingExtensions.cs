using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ADDRESS_CONFIG;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class ADDRESS_CONFIGMappingExtensions
{
    public static ADDRESS_CONFIGDto ToDto(this ADDRESS_CONFIG entity)
    {
        if (entity == null) return null!;
        return new ADDRESS_CONFIGDto
        {
            COUNTRY = entity.COUNTRY,
            ADDRESS_SETTINGS = entity.ADDRESS_SETTINGS,
            PHONE_SETTINGS = entity.PHONE_SETTINGS,
            NUSERCODE = entity.NUSERCODE,
            UPDATEDATE = entity.UPDATEDATE,
        };
    }

    public static ADDRESS_CONFIG ToEntity(this CreateADDRESS_CONFIGDto dto)
    {
        if (dto == null) return null!;
        return new ADDRESS_CONFIG
        {
            ADDRESS_SETTINGS = dto.ADDRESS_SETTINGS,
            PHONE_SETTINGS = dto.PHONE_SETTINGS,
            NUSERCODE = dto.NUSERCODE,
            UPDATEDATE = dto.UPDATEDATE,
        };
    }

    public static void UpdateEntity(this ADDRESS_CONFIG entity, UpdateADDRESS_CONFIGDto dto)
    {
        if (entity == null || dto == null) return;
        entity.ADDRESS_SETTINGS = dto.ADDRESS_SETTINGS;
        entity.PHONE_SETTINGS = dto.PHONE_SETTINGS;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.UPDATEDATE = dto.UPDATEDATE;
    }
}
