using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.NOTES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class NOTESMappingExtensions
{
    public static NOTESDto ToDto(this NOTES entity)
    {
        if (entity == null) return null!;
        return new NOTESDto
        {
            NNOTENUM = entity.NNOTENUM,
            DCOMPDATE = entity.DCOMPDATE,
            NCONSEC = entity.NCONSEC,
            SDESCRIPT = entity.SDESCRIPT,
            TDS_TEXT = entity.TDS_TEXT,
            DNULLDATE = entity.DNULLDATE,
            NRECTYPE = entity.NRECTYPE,
            TABLE62SDESCRIPT = entity.TABLE62?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static NOTES ToEntity(this CreateNOTESDto dto)
    {
        if (dto == null) return null!;
        return new NOTES
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            TDS_TEXT = dto.TDS_TEXT,
            DNULLDATE = dto.DNULLDATE,
            NRECTYPE = dto.NRECTYPE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this NOTES entity, UpdateNOTESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.TDS_TEXT = dto.TDS_TEXT;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NRECTYPE = dto.NRECTYPE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
