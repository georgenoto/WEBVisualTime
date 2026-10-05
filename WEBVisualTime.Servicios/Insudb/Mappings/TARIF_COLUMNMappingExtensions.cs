using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TARIF_COLUMN;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TARIF_COLUMNMappingExtensions
{
    public static TARIF_COLUMNDto ToDto(this TARIF_COLUMN entity)
    {
        if (entity == null) return null!;
        return new TARIF_COLUMNDto
        {
            NID_COLUMN = entity.NID_COLUMN,
            STABLE = entity.STABLE,
            SCOLUMN = entity.SCOLUMN,
            SNAME_COL = entity.SNAME_COL,
            NDATA_TYPE = entity.NDATA_TYPE,
            NSIZE = entity.NSIZE,
            NDECIMAL = entity.NDECIMAL,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            STABLEFK = entity.STABLEFK,
        };
    }

    public static TARIF_COLUMN ToEntity(this CreateTARIF_COLUMNDto dto)
    {
        if (dto == null) return null!;
        return new TARIF_COLUMN
        {
            STABLE = dto.STABLE,
            SCOLUMN = dto.SCOLUMN,
            SNAME_COL = dto.SNAME_COL,
            NDATA_TYPE = dto.NDATA_TYPE,
            NSIZE = dto.NSIZE,
            NDECIMAL = dto.NDECIMAL,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            STABLEFK = dto.STABLEFK,
        };
    }

    public static void UpdateEntity(this TARIF_COLUMN entity, UpdateTARIF_COLUMNDto dto)
    {
        if (entity == null || dto == null) return;
        entity.STABLE = dto.STABLE;
        entity.SCOLUMN = dto.SCOLUMN;
        entity.SNAME_COL = dto.SNAME_COL;
        entity.NDATA_TYPE = dto.NDATA_TYPE;
        entity.NSIZE = dto.NSIZE;
        entity.NDECIMAL = dto.NDECIMAL;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.STABLEFK = dto.STABLEFK;
    }
}
