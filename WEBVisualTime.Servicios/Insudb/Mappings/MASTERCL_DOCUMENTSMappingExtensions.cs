using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_DOCUMENTS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MASTERCL_DOCUMENTSMappingExtensions
{
    public static MASTERCL_DOCUMENTSDto ToDto(this MASTERCL_DOCUMENTS entity)
    {
        if (entity == null) return null!;
        return new MASTERCL_DOCUMENTSDto
        {
            NMASTERORDER = entity.NMASTERORDER,
            NCONSEC_MASTERORDERDOC = entity.NCONSEC_MASTERORDERDOC,
            NCASE_NUM = entity.NCASE_NUM,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            SCLIENT = entity.SCLIENT,
            NID = entity.NID,
            NDOC_CODE = entity.NDOC_CODE,
            NCONSEC = entity.NCONSEC,
            NAPPLY = entity.NAPPLY,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static MASTERCL_DOCUMENTS ToEntity(this CreateMASTERCL_DOCUMENTSDto dto)
    {
        if (dto == null) return null!;
        return new MASTERCL_DOCUMENTS
        {
            NCASE_NUM = dto.NCASE_NUM,
            NDEMAN_TYPE = dto.NDEMAN_TYPE,
            SCLIENT = dto.SCLIENT,
            NID = dto.NID,
            NDOC_CODE = dto.NDOC_CODE,
            NCONSEC = dto.NCONSEC,
            NAPPLY = dto.NAPPLY,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this MASTERCL_DOCUMENTS entity, UpdateMASTERCL_DOCUMENTSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCASE_NUM = dto.NCASE_NUM;
        entity.NDEMAN_TYPE = dto.NDEMAN_TYPE;
        entity.SCLIENT = dto.SCLIENT;
        entity.NID = dto.NID;
        entity.NDOC_CODE = dto.NDOC_CODE;
        entity.NCONSEC = dto.NCONSEC;
        entity.NAPPLY = dto.NAPPLY;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
