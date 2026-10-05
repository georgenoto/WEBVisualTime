using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.GROUPVARIABLES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class GROUPVARIABLESMappingExtensions
{
    public static GROUPVARIABLESDto ToDto(this GROUPVARIABLES entity)
    {
        if (entity == null) return null!;
        return new GROUPVARIABLESDto
        {
            NLETT_GROUP = entity.NLETT_GROUP,
            GROUPPARAMSSDESCRIPT = entity.GROUPPARAMS?.SDESCRIPT,
            SVARIABLE = entity.SVARIABLE,
            SDESCRIPT = entity.SDESCRIPT,
            STABLENAME = entity.STABLENAME,
            SCOLUMNAME = entity.SCOLUMNAME,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NTYPVARIABLE = entity.NTYPVARIABLE,
            STABVALUE = entity.STABVALUE,
            SALIASTABLE = entity.SALIASTABLE,
            SALIASCOLUMN = entity.SALIASCOLUMN,
        };
    }

    public static GROUPVARIABLES ToEntity(this CreateGROUPVARIABLESDto dto)
    {
        if (dto == null) return null!;
        return new GROUPVARIABLES
        {
            SDESCRIPT = dto.SDESCRIPT,
            STABLENAME = dto.STABLENAME,
            SCOLUMNAME = dto.SCOLUMNAME,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NTYPVARIABLE = dto.NTYPVARIABLE,
            STABVALUE = dto.STABVALUE,
            SALIASTABLE = dto.SALIASTABLE,
            SALIASCOLUMN = dto.SALIASCOLUMN,
        };
    }

    public static void UpdateEntity(this GROUPVARIABLES entity, UpdateGROUPVARIABLESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.STABLENAME = dto.STABLENAME;
        entity.SCOLUMNAME = dto.SCOLUMNAME;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NTYPVARIABLE = dto.NTYPVARIABLE;
        entity.STABVALUE = dto.STABVALUE;
        entity.SALIASTABLE = dto.SALIASTABLE;
        entity.SALIASCOLUMN = dto.SALIASCOLUMN;
    }
}
