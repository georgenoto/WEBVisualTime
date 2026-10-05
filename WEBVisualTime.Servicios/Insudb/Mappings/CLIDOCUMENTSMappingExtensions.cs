using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIDOCUMENTS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLIDOCUMENTSMappingExtensions
{
    public static CLIDOCUMENTSDto ToDto(this CLIDOCUMENTS entity)
    {
        if (entity == null) return null!;
        return new CLIDOCUMENTSDto
        {
            NTYPCLIENTDOC = entity.NTYPCLIENTDOC,
            SCLINUMDOCU = entity.SCLINUMDOCU,
            SCLIENT = entity.SCLIENT,
            DISSUEDAT = entity.DISSUEDAT,
            DEXPIRDAT = entity.DEXPIRDAT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NCLASSTYPDOC = entity.NCLASSTYPDOC,
            NTYPEXP = entity.NTYPEXP,
            SIDCOMPL = entity.SIDCOMPL,
        };
    }

    public static CLIDOCUMENTS ToEntity(this CreateCLIDOCUMENTSDto dto)
    {
        if (dto == null) return null!;
        return new CLIDOCUMENTS
        {
            DISSUEDAT = dto.DISSUEDAT,
            DEXPIRDAT = dto.DEXPIRDAT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NCLASSTYPDOC = dto.NCLASSTYPDOC,
            NTYPEXP = dto.NTYPEXP,
            SIDCOMPL = dto.SIDCOMPL,
        };
    }

    public static void UpdateEntity(this CLIDOCUMENTS entity, UpdateCLIDOCUMENTSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DISSUEDAT = dto.DISSUEDAT;
        entity.DEXPIRDAT = dto.DEXPIRDAT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NCLASSTYPDOC = dto.NCLASSTYPDOC;
        entity.NTYPEXP = dto.NTYPEXP;
        entity.SIDCOMPL = dto.SIDCOMPL;
    }
}
