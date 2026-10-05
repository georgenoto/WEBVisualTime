using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_DOCUMENTS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLORDER_DOCUMENTSMappingExtensions
{
    public static CLORDER_DOCUMENTSDto ToDto(this CLORDER_DOCUMENTS entity)
    {
        if (entity == null) return null!;
        return new CLORDER_DOCUMENTSDto
        {
            NCLAIM = entity.NCLAIM,
            DOCUMENTSNCLAIMSDESCRIPT = entity.DOCUMENTSNCLAIM?.SDESCRIPT,
            NCASE_NUM = entity.NCASE_NUM,
            DOCUMENTSNCASE_NUMSDESCRIPT = entity.DOCUMENTSNCASE_NUM?.SDESCRIPT,
            NDEMAN_TYPE = entity.NDEMAN_TYPE,
            TABLE692SDESCRIPT = entity.TABLE692?.SDESCRIPT,
            SCLIENT = entity.SCLIENT,
            DOCUMENTSSCLIENTSDESCRIPT = entity.DOCUMENTSSCLIENT?.SDESCRIPT,
            NID = entity.NID,
            DOCUMENTSNIDSDESCRIPT = entity.DOCUMENTSNID?.SDESCRIPT,
            NDOC_CODE = entity.NDOC_CODE,
            DOCUMENTSNDOC_CODESDESCRIPT = entity.DOCUMENTSNDOC_CODE?.SDESCRIPT,
            NCONSEC = entity.NCONSEC,
            DOCUMENTSNCONSECSDESCRIPT = entity.DOCUMENTSNCONSEC?.SDESCRIPT,
            NORDER_NUM = entity.NORDER_NUM,
            NCONSEC_ORDERDOC = entity.NCONSEC_ORDERDOC,
            NAPPLY = entity.NAPPLY,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static CLORDER_DOCUMENTS ToEntity(this CreateCLORDER_DOCUMENTSDto dto)
    {
        if (dto == null) return null!;
        return new CLORDER_DOCUMENTS
        {
            NAPPLY = dto.NAPPLY,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this CLORDER_DOCUMENTS entity, UpdateCLORDER_DOCUMENTSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAPPLY = dto.NAPPLY;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
