using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COLSHEET;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COLSHEETMappingExtensions
{
    public static COLSHEETDto ToDto(this COLSHEET entity)
    {
        if (entity == null) return null!;
        return new COLSHEETDto
        {
            NID = entity.NID,
            NIDREC = entity.NIDREC,
            SCOLUMNNAME = entity.SCOLUMNNAME,
            NORDER = entity.NORDER,
            SSELECTED = entity.SSELECTED,
            SREQUIRE = entity.SREQUIRE,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            SVALUE = entity.SVALUE,
        };
    }

    public static COLSHEET ToEntity(this CreateCOLSHEETDto dto)
    {
        if (dto == null) return null!;
        return new COLSHEET
        {
            SCOLUMNNAME = dto.SCOLUMNNAME,
            NORDER = dto.NORDER,
            SSELECTED = dto.SSELECTED,
            SREQUIRE = dto.SREQUIRE,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            SVALUE = dto.SVALUE,
        };
    }

    public static void UpdateEntity(this COLSHEET entity, UpdateCOLSHEETDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCOLUMNNAME = dto.SCOLUMNNAME;
        entity.NORDER = dto.NORDER;
        entity.SSELECTED = dto.SSELECTED;
        entity.SREQUIRE = dto.SREQUIRE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SVALUE = dto.SVALUE;
    }
}
