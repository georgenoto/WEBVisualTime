using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.GROUP_COLUMNS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class GROUP_COLUMNSMappingExtensions
{
    public static GROUP_COLUMNSDto ToDto(this GROUP_COLUMNS entity)
    {
        if (entity == null) return null!;
        return new GROUP_COLUMNSDto
        {
            NSHEET = entity.NSHEET,
            TABLE697SDESCRIPT = entity.TABLE697?.SDESCRIPT,
            NIDREC = entity.NIDREC,
            SFIELD = entity.SFIELD,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SCOLUMNNAME = entity.SCOLUMNNAME,
            NORDER = entity.NORDER,
            SVALUESLIST = entity.SVALUESLIST,
            STABLE = entity.STABLE,
            SREQUIRE = entity.SREQUIRE,
            SCOMMENT = entity.SCOMMENT,
            SUPDATEIND = entity.SUPDATEIND,
        };
    }

    public static GROUP_COLUMNS ToEntity(this CreateGROUP_COLUMNSDto dto)
    {
        if (dto == null) return null!;
        return new GROUP_COLUMNS
        {
            NSHEET = dto.NSHEET,
            SFIELD = dto.SFIELD,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SCOLUMNNAME = dto.SCOLUMNNAME,
            NORDER = dto.NORDER,
            SVALUESLIST = dto.SVALUESLIST,
            STABLE = dto.STABLE,
            SREQUIRE = dto.SREQUIRE,
            SCOMMENT = dto.SCOMMENT,
            SUPDATEIND = dto.SUPDATEIND,
        };
    }

    public static void UpdateEntity(this GROUP_COLUMNS entity, UpdateGROUP_COLUMNSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NSHEET = dto.NSHEET;
        entity.SFIELD = dto.SFIELD;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCOLUMNNAME = dto.SCOLUMNNAME;
        entity.NORDER = dto.NORDER;
        entity.SVALUESLIST = dto.SVALUESLIST;
        entity.STABLE = dto.STABLE;
        entity.SREQUIRE = dto.SREQUIRE;
        entity.SCOMMENT = dto.SCOMMENT;
        entity.SUPDATEIND = dto.SUPDATEIND;
    }
}
