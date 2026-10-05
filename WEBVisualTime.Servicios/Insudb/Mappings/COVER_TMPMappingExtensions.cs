using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COVER_TMP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COVER_TMPMappingExtensions
{
    public static COVER_TMPDto ToDto(this COVER_TMP entity)
    {
        if (entity == null) return null!;
        return new COVER_TMPDto
        {
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            NIDCONSEC = entity.NIDCONSEC,
            NROW = entity.NROW,
            NCOLUMN = entity.NCOLUMN,
            SVALUE = entity.SVALUE,
            SSECTION = entity.SSECTION,
            SDATATYPE = entity.SDATATYPE,
            SUPDATE = entity.SUPDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static COVER_TMP ToEntity(this CreateCOVER_TMPDto dto)
    {
        if (dto == null) return null!;
        return new COVER_TMP
        {
            NROW = dto.NROW,
            NCOLUMN = dto.NCOLUMN,
            SVALUE = dto.SVALUE,
            SSECTION = dto.SSECTION,
            SDATATYPE = dto.SDATATYPE,
            SUPDATE = dto.SUPDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this COVER_TMP entity, UpdateCOVER_TMPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NROW = dto.NROW;
        entity.NCOLUMN = dto.NCOLUMN;
        entity.SVALUE = dto.SVALUE;
        entity.SSECTION = dto.SSECTION;
        entity.SDATATYPE = dto.SDATATYPE;
        entity.SUPDATE = dto.SUPDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
