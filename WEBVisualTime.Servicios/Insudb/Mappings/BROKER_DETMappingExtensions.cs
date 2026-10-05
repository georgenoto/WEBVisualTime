using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BROKER_DET;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BROKER_DETMappingExtensions
{
    public static BROKER_DETDto ToDto(this BROKER_DET entity)
    {
        if (entity == null) return null!;
        return new BROKER_DETDto
        {
            NCOMPANY_BR = entity.NCOMPANY_BR,
            NCOMPANY = entity.NCOMPANY,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            NID = entity.NID,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static BROKER_DET ToEntity(this CreateBROKER_DETDto dto)
    {
        if (dto == null) return null!;
        return new BROKER_DET
        {
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this BROKER_DET entity, UpdateBROKER_DETDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
