using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class WINDOWSMappingExtensions
{
    public static WINDOWSDto ToDto(this WINDOWS entity)
    {
        if (entity == null) return null!;
        return new WINDOWSDto
        {
            SCODISPL = entity.SCODISPL,
            NAMELEVEL = entity.NAMELEVEL,
            SCODISP = entity.SCODISP,
            NIMG_INDEX = entity.NIMG_INDEX,
            SCODMEN = entity.SCODMEN,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SDIRECTGO = entity.SDIRECTGO,
            NG_IDENTI = entity.NG_IDENTI,
            NINQLEVEL = entity.NINQLEVEL,
            NMODULES = entity.NMODULES,
            TABLE87SDESCRIPT = entity.TABLE87?.SDESCRIPT,
            SPSEUDO = entity.SPSEUDO,
            NSEQUENCE = entity.NSEQUENCE,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            NWINDOWTY = entity.NWINDOWTY,
            TABLE88SDESCRIPT = entity.TABLE88?.SDESCRIPT,
            SHELPPATH = entity.SHELPPATH,
            NHEIGHT = entity.NHEIGHT,
            SAUTOREP = entity.SAUTOREP,
            SQUOTE = entity.SQUOTE,
            NTYPE_REPORT = entity.NTYPE_REPORT,
            SINDLETTER = entity.SINDLETTER,
            NLENGTH_NOTES = entity.NLENGTH_NOTES,
            SFILEPATH = entity.SFILEPATH,
            SWINDOWURL = entity.SWINDOWURL,
        };
    }

    public static WINDOWS ToEntity(this CreateWINDOWSDto dto)
    {
        if (dto == null) return null!;
        return new WINDOWS
        {
            NAMELEVEL = dto.NAMELEVEL,
            SCODISP = dto.SCODISP,
            NIMG_INDEX = dto.NIMG_INDEX,
            SCODMEN = dto.SCODMEN,
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SDIRECTGO = dto.SDIRECTGO,
            NG_IDENTI = dto.NG_IDENTI,
            NINQLEVEL = dto.NINQLEVEL,
            NMODULES = dto.NMODULES,
            SPSEUDO = dto.SPSEUDO,
            NSEQUENCE = dto.NSEQUENCE,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NWINDOWTY = dto.NWINDOWTY,
            SHELPPATH = dto.SHELPPATH,
            NHEIGHT = dto.NHEIGHT,
            SAUTOREP = dto.SAUTOREP,
            SQUOTE = dto.SQUOTE,
            NTYPE_REPORT = dto.NTYPE_REPORT,
            SINDLETTER = dto.SINDLETTER,
            NLENGTH_NOTES = dto.NLENGTH_NOTES,
            SFILEPATH = dto.SFILEPATH,
            SWINDOWURL = dto.SWINDOWURL,
        };
    }

    public static void UpdateEntity(this WINDOWS entity, UpdateWINDOWSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMELEVEL = dto.NAMELEVEL;
        entity.SCODISP = dto.SCODISP;
        entity.NIMG_INDEX = dto.NIMG_INDEX;
        entity.SCODMEN = dto.SCODMEN;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SDIRECTGO = dto.SDIRECTGO;
        entity.NG_IDENTI = dto.NG_IDENTI;
        entity.NINQLEVEL = dto.NINQLEVEL;
        entity.NMODULES = dto.NMODULES;
        entity.SPSEUDO = dto.SPSEUDO;
        entity.NSEQUENCE = dto.NSEQUENCE;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NWINDOWTY = dto.NWINDOWTY;
        entity.SHELPPATH = dto.SHELPPATH;
        entity.NHEIGHT = dto.NHEIGHT;
        entity.SAUTOREP = dto.SAUTOREP;
        entity.SQUOTE = dto.SQUOTE;
        entity.NTYPE_REPORT = dto.NTYPE_REPORT;
        entity.SINDLETTER = dto.SINDLETTER;
        entity.NLENGTH_NOTES = dto.NLENGTH_NOTES;
        entity.SFILEPATH = dto.SFILEPATH;
        entity.SWINDOWURL = dto.SWINDOWURL;
    }
}
