using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SELLCHANNEL_PROD;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SELLCHANNEL_PRODMappingExtensions
{
    public static SELLCHANNEL_PRODDto ToDto(this SELLCHANNEL_PROD entity)
    {
        if (entity == null) return null!;
        return new SELLCHANNEL_PRODDto
        {
            DEFFECDATE = entity.DEFFECDATE,
            NCLASSIFICATION = entity.NCLASSIFICATION,
            TABLE9223SDESCRIPT = entity.TABLE9223?.SDESCRIPT,
            NINTERTYP = entity.NINTERTYP,
            INTERM_TYPSDESCRIPT = entity.INTERM_TYP?.SDESCRIPT,
            NSELLCHANNEL = entity.NSELLCHANNEL,
            TABLE5532SDESCRIPT = entity.TABLE5532?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            DNULLDATE = entity.DNULLDATE,
        };
    }

    public static SELLCHANNEL_PROD ToEntity(this CreateSELLCHANNEL_PRODDto dto)
    {
        if (dto == null) return null!;
        return new SELLCHANNEL_PROD
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            DNULLDATE = dto.DNULLDATE,
        };
    }

    public static void UpdateEntity(this SELLCHANNEL_PROD entity, UpdateSELLCHANNEL_PRODDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DNULLDATE = dto.DNULLDATE;
    }
}
