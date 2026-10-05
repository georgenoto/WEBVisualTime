using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COVERCOL_TMP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COVERCOL_TMPMappingExtensions
{
    public static COVERCOL_TMPDto ToDto(this COVERCOL_TMP entity)
    {
        if (entity == null) return null!;
        return new COVERCOL_TMPDto
        {
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            NIDCONSEC = entity.NIDCONSEC,
            NROW = entity.NROW,
            NCOLUMN = entity.NCOLUMN,
            STITTLE = entity.STITTLE,
            SVALUE = entity.SVALUE,
            SVALUE1 = entity.SVALUE1,
            SVALUE2 = entity.SVALUE2,
            SVALUE3 = entity.SVALUE3,
            SVALUE4 = entity.SVALUE4,
            SVALUE5 = entity.SVALUE5,
            SVALUE6 = entity.SVALUE6,
            SVALUE7 = entity.SVALUE7,
            SVALUE8 = entity.SVALUE8,
            SVALUE9 = entity.SVALUE9,
            STYPE = entity.STYPE,
            SDATATYPE = entity.SDATATYPE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SMATERNITY = entity.SMATERNITY,
        };
    }

    public static COVERCOL_TMP ToEntity(this CreateCOVERCOL_TMPDto dto)
    {
        if (dto == null) return null!;
        return new COVERCOL_TMP
        {
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            NIDCONSEC = dto.NIDCONSEC,
            NROW = dto.NROW,
            NCOLUMN = dto.NCOLUMN,
            STITTLE = dto.STITTLE,
            SVALUE = dto.SVALUE,
            SVALUE1 = dto.SVALUE1,
            SVALUE2 = dto.SVALUE2,
            SVALUE3 = dto.SVALUE3,
            SVALUE4 = dto.SVALUE4,
            SVALUE5 = dto.SVALUE5,
            SVALUE6 = dto.SVALUE6,
            SVALUE7 = dto.SVALUE7,
            SVALUE8 = dto.SVALUE8,
            SVALUE9 = dto.SVALUE9,
            STYPE = dto.STYPE,
            SDATATYPE = dto.SDATATYPE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SMATERNITY = dto.SMATERNITY,
        };
    }

    public static void UpdateEntity(this COVERCOL_TMP entity, UpdateCOVERCOL_TMPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.NIDCONSEC = dto.NIDCONSEC;
        entity.NROW = dto.NROW;
        entity.NCOLUMN = dto.NCOLUMN;
        entity.STITTLE = dto.STITTLE;
        entity.SVALUE = dto.SVALUE;
        entity.SVALUE1 = dto.SVALUE1;
        entity.SVALUE2 = dto.SVALUE2;
        entity.SVALUE3 = dto.SVALUE3;
        entity.SVALUE4 = dto.SVALUE4;
        entity.SVALUE5 = dto.SVALUE5;
        entity.SVALUE6 = dto.SVALUE6;
        entity.SVALUE7 = dto.SVALUE7;
        entity.SVALUE8 = dto.SVALUE8;
        entity.SVALUE9 = dto.SVALUE9;
        entity.STYPE = dto.STYPE;
        entity.SDATATYPE = dto.SDATATYPE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SMATERNITY = dto.SMATERNITY;
    }
}
