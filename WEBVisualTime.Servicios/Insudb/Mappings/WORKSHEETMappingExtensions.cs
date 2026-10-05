using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.WORKSHEET;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class WORKSHEETMappingExtensions
{
    public static WORKSHEETDto ToDto(this WORKSHEET entity)
    {
        if (entity == null) return null!;
        return new WORKSHEETDto
        {
            NBRANCH = entity.NBRANCH,
            NID = entity.NID,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            SVALUESLIST = entity.SVALUESLIST,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SDESCRIPT = entity.SDESCRIPT,
        };
    }

    public static WORKSHEET ToEntity(this CreateWORKSHEETDto dto)
    {
        if (dto == null) return null!;
        return new WORKSHEET
        {
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            SVALUESLIST = dto.SVALUESLIST,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SDESCRIPT = dto.SDESCRIPT,
        };
    }

    public static void UpdateEntity(this WORKSHEET entity, UpdateWORKSHEETDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.SVALUESLIST = dto.SVALUESLIST;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SDESCRIPT = dto.SDESCRIPT;
    }
}
