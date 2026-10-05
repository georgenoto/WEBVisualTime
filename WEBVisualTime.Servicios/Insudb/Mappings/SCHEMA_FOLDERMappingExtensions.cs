using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHEMA_FOLDER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SCHEMA_FOLDERMappingExtensions
{
    public static SCHEMA_FOLDERDto ToDto(this SCHEMA_FOLDER entity)
    {
        if (entity == null) return null!;
        return new SCHEMA_FOLDERDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            NFOLDER = entity.NFOLDER,
            NINQLEVEL = entity.NINQLEVEL,
            SPERMITTED = entity.SPERMITTED,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static SCHEMA_FOLDER ToEntity(this CreateSCHEMA_FOLDERDto dto)
    {
        if (dto == null) return null!;
        return new SCHEMA_FOLDER
        {
            NINQLEVEL = dto.NINQLEVEL,
            SPERMITTED = dto.SPERMITTED,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this SCHEMA_FOLDER entity, UpdateSCHEMA_FOLDERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NINQLEVEL = dto.NINQLEVEL;
        entity.SPERMITTED = dto.SPERMITTED;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
