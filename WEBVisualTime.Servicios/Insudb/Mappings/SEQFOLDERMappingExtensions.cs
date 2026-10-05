using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SEQFOLDER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SEQFOLDERMappingExtensions
{
    public static SEQFOLDERDto ToDto(this SEQFOLDER entity)
    {
        if (entity == null) return null!;
        return new SEQFOLDERDto
        {
            NQUERYTYPE = entity.NQUERYTYPE,
            NPARENT = entity.NPARENT,
            NFOLDER = entity.NFOLDER,
            FOLDERSSFOLDERNAME = entity.FOLDERS?.SFOLDERNAME,
            NSEQUENCE = entity.NSEQUENCE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static SEQFOLDER ToEntity(this CreateSEQFOLDERDto dto)
    {
        if (dto == null) return null!;
        return new SEQFOLDER
        {
            NSEQUENCE = dto.NSEQUENCE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this SEQFOLDER entity, UpdateSEQFOLDERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NSEQUENCE = dto.NSEQUENCE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
