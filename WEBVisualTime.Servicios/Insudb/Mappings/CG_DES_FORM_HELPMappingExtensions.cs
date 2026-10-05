using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CG_DES_FORM_HELP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CG_DES_FORM_HELPMappingExtensions
{
    public static CG_DES_FORM_HELPDto ToDto(this CG_DES_FORM_HELP entity)
    {
        if (entity == null) return null!;
        return new CG_DES_FORM_HELPDto
        {
            HLP_APPLN = entity.HLP_APPLN,
            HLP_INDEX = entity.HLP_INDEX,
            HLP_MODTAB_NAME = entity.HLP_MODTAB_NAME,
            HLP_GENERATED = entity.HLP_GENERATED,
            HLP_SEQ = entity.HLP_SEQ,
            HLP_TEXT = entity.HLP_TEXT,
            HLP_TYPE = entity.HLP_TYPE,
        };
    }

    public static CG_DES_FORM_HELP ToEntity(this CreateCG_DES_FORM_HELPDto dto)
    {
        if (dto == null) return null!;
        return new CG_DES_FORM_HELP
        {
            HLP_APPLN = dto.HLP_APPLN,
            HLP_INDEX = dto.HLP_INDEX,
            HLP_MODTAB_NAME = dto.HLP_MODTAB_NAME,
            HLP_GENERATED = dto.HLP_GENERATED,
            HLP_SEQ = dto.HLP_SEQ,
            HLP_TEXT = dto.HLP_TEXT,
            HLP_TYPE = dto.HLP_TYPE,
        };
    }

    public static void UpdateEntity(this CG_DES_FORM_HELP entity, UpdateCG_DES_FORM_HELPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.HLP_APPLN = dto.HLP_APPLN;
        entity.HLP_INDEX = dto.HLP_INDEX;
        entity.HLP_MODTAB_NAME = dto.HLP_MODTAB_NAME;
        entity.HLP_GENERATED = dto.HLP_GENERATED;
        entity.HLP_SEQ = dto.HLP_SEQ;
        entity.HLP_TEXT = dto.HLP_TEXT;
        entity.HLP_TYPE = dto.HLP_TYPE;
    }
}
