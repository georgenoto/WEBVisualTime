using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_DOCUM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_SETT_DOCUMMappingExtensions
{
    public static CLAIM_SETT_DOCUMDto ToDto(this CLAIM_SETT_DOCUM entity)
    {
        if (entity == null) return null!;
        return new CLAIM_SETT_DOCUMDto
        {
            NSEQ_IDLEDGERDOCUM = entity.NSEQ_IDLEDGERDOCUM,
            NCONSEC_DOC = entity.NCONSEC_DOC,
            DRECEPDATE = entity.DRECEPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            NSTATUS_DOC = entity.NSTATUS_DOC,
            TABLE203SDESCRIPT = entity.TABLE203?.SDESCRIPT,
            NDOC_CODE = entity.NDOC_CODE,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NSETTLEMENT_NUM = entity.NSETTLEMENT_NUM,
        };
    }

    public static CLAIM_SETT_DOCUM ToEntity(this CreateCLAIM_SETT_DOCUMDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_SETT_DOCUM
        {
            NSEQ_IDLEDGERDOCUM = dto.NSEQ_IDLEDGERDOCUM,
            DRECEPDATE = dto.DRECEPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            NSTATUS_DOC = dto.NSTATUS_DOC,
            NDOC_CODE = dto.NDOC_CODE,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
        };
    }

    public static void UpdateEntity(this CLAIM_SETT_DOCUM entity, UpdateCLAIM_SETT_DOCUMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NSEQ_IDLEDGERDOCUM = dto.NSEQ_IDLEDGERDOCUM;
        entity.DRECEPDATE = dto.DRECEPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NSTATUS_DOC = dto.NSTATUS_DOC;
        entity.NDOC_CODE = dto.NDOC_CODE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
    }
}
