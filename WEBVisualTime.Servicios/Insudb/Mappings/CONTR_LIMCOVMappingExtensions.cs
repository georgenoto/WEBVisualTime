using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTR_LIMCOV;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CONTR_LIMCOVMappingExtensions
{
    public static CONTR_LIMCOVDto ToDto(this CONTR_LIMCOV entity)
    {
        if (entity == null) return null!;
        return new CONTR_LIMCOVDto
        {
            NBRANCH_REI = entity.NBRANCH_REI,
            DEFFECDATE = entity.DEFFECDATE,
            NNUMBER = entity.NNUMBER,
            NTYPE = entity.NTYPE,
            NINSUR_AREA = entity.NINSUR_AREA,
            TABLE5001SDESCRIPT = entity.TABLE5001?.SDESCRIPT,
            NCOVERGEN = entity.NCOVERGEN,
            DNULLDATE = entity.DNULLDATE,
            NAMOUNT = entity.NAMOUNT,
            NLINES = entity.NLINES,
            NQUOTA_SHA = entity.NQUOTA_SHA,
            SROUTINE = entity.SROUTINE,
            NCOVERAPP = entity.NCOVERAPP,
            NPERCENT = entity.NPERCENT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NMAXAMOUNT = entity.NMAXAMOUNT,
        };
    }

    public static CONTR_LIMCOV ToEntity(this CreateCONTR_LIMCOVDto dto)
    {
        if (dto == null) return null!;
        return new CONTR_LIMCOV
        {
            DNULLDATE = dto.DNULLDATE,
            NAMOUNT = dto.NAMOUNT,
            NLINES = dto.NLINES,
            NQUOTA_SHA = dto.NQUOTA_SHA,
            SROUTINE = dto.SROUTINE,
            NCOVERAPP = dto.NCOVERAPP,
            NPERCENT = dto.NPERCENT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NMAXAMOUNT = dto.NMAXAMOUNT,
        };
    }

    public static void UpdateEntity(this CONTR_LIMCOV entity, UpdateCONTR_LIMCOVDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NLINES = dto.NLINES;
        entity.NQUOTA_SHA = dto.NQUOTA_SHA;
        entity.SROUTINE = dto.SROUTINE;
        entity.NCOVERAPP = dto.NCOVERAPP;
        entity.NPERCENT = dto.NPERCENT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NMAXAMOUNT = dto.NMAXAMOUNT;
    }
}
