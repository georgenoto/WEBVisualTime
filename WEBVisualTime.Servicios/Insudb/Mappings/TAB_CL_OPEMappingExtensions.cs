using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_CL_OPE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_CL_OPEMappingExtensions
{
    public static TAB_CL_OPEDto ToDto(this TAB_CL_OPE entity)
    {
        if (entity == null) return null!;
        return new TAB_CL_OPEDto
        {
            NOPER_TYPE = entity.NOPER_TYPE,
            TABLE140NOPER_TYPESDESCRIPT = entity.TABLE140NOPER_TYPE?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NGEN_OPERA = entity.NGEN_OPERA,
            TABLE140NGEN_OPERASDESCRIPT = entity.TABLE140NGEN_OPERA?.SDESCRIPT,
            NIND_REV = entity.NIND_REV,
            NPAY_IND = entity.NPAY_IND,
            TABLE294NPAY_INDSDESCRIPT = entity.TABLE294NPAY_IND?.SDESCRIPT,
            NREC_ESP_IN = entity.NREC_ESP_IN,
            TABLE294NREC_ESP_INSDESCRIPT = entity.TABLE294NREC_ESP_IN?.SDESCRIPT,
            NRECOVER_IN = entity.NRECOVER_IN,
            TABLE294NRECOVER_INSDESCRIPT = entity.TABLE294NRECOVER_IN?.SDESCRIPT,
            NRESERVE_IN = entity.NRESERVE_IN,
            TABLE294NRESERVE_INSDESCRIPT = entity.TABLE294NRESERVE_IN?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_CL_OPE ToEntity(this CreateTAB_CL_OPEDto dto)
    {
        if (dto == null) return null!;
        return new TAB_CL_OPE
        {
            DCOMPDATE = dto.DCOMPDATE,
            NGEN_OPERA = dto.NGEN_OPERA,
            NIND_REV = dto.NIND_REV,
            NPAY_IND = dto.NPAY_IND,
            NREC_ESP_IN = dto.NREC_ESP_IN,
            NRECOVER_IN = dto.NRECOVER_IN,
            NRESERVE_IN = dto.NRESERVE_IN,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_CL_OPE entity, UpdateTAB_CL_OPEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NGEN_OPERA = dto.NGEN_OPERA;
        entity.NIND_REV = dto.NIND_REV;
        entity.NPAY_IND = dto.NPAY_IND;
        entity.NREC_ESP_IN = dto.NREC_ESP_IN;
        entity.NRECOVER_IN = dto.NRECOVER_IN;
        entity.NRESERVE_IN = dto.NRESERVE_IN;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
