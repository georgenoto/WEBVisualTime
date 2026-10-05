using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.HOMOLOG_TABLE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class HOMOLOG_TABLEMappingExtensions
{
    public static HOMOLOG_TABLEDto ToDto(this HOMOLOG_TABLE entity)
    {
        if (entity == null) return null!;
        return new HOMOLOG_TABLEDto
        {
            NSYSTEM = entity.NSYSTEM,
            NTABLE = entity.NTABLE,
            NID = entity.NID,
            SCOLUMNNAME_VT = entity.SCOLUMNNAME_VT,
            SCODVALUE_VT = entity.SCODVALUE_VT,
            SVALUE_VT = entity.SVALUE_VT,
            STABLENAME = entity.STABLENAME,
            SCOLUMNNAME = entity.SCOLUMNNAME,
            SCODVALUE = entity.SCODVALUE,
            SPREDOM = entity.SPREDOM,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static HOMOLOG_TABLE ToEntity(this CreateHOMOLOG_TABLEDto dto)
    {
        if (dto == null) return null!;
        return new HOMOLOG_TABLE
        {
            NSYSTEM = dto.NSYSTEM,
            NTABLE = dto.NTABLE,
            NID = dto.NID,
            SCOLUMNNAME_VT = dto.SCOLUMNNAME_VT,
            SCODVALUE_VT = dto.SCODVALUE_VT,
            SVALUE_VT = dto.SVALUE_VT,
            STABLENAME = dto.STABLENAME,
            SCOLUMNNAME = dto.SCOLUMNNAME,
            SCODVALUE = dto.SCODVALUE,
            SPREDOM = dto.SPREDOM,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this HOMOLOG_TABLE entity, UpdateHOMOLOG_TABLEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NSYSTEM = dto.NSYSTEM;
        entity.NTABLE = dto.NTABLE;
        entity.NID = dto.NID;
        entity.SCOLUMNNAME_VT = dto.SCOLUMNNAME_VT;
        entity.SCODVALUE_VT = dto.SCODVALUE_VT;
        entity.SVALUE_VT = dto.SVALUE_VT;
        entity.STABLENAME = dto.STABLENAME;
        entity.SCOLUMNNAME = dto.SCOLUMNNAME;
        entity.SCODVALUE = dto.SCODVALUE;
        entity.SPREDOM = dto.SPREDOM;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
