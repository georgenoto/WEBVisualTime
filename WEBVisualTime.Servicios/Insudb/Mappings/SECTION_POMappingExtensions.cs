using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SECTION_PO;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SECTION_POMappingExtensions
{
    public static SECTION_PODto ToDto(this SECTION_PO entity)
    {
        if (entity == null) return null!;
        return new SECTION_PODto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            SPOLITYPE = entity.SPOLITYPE,
            SCOMPON = entity.SCOMPON,
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            NTRATYPEP = entity.NTRATYPEP,
            TABLE5588SDESCRIPT = entity.TABLE5588?.SDESCRIPT,
            NSEQUENCE = entity.NSEQUENCE,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NID = entity.NID,
            NORIGIN = entity.NORIGIN,
            TABLE5580SDESCRIPT = entity.TABLE5580?.SDESCRIPT,
            NTYPE_AMEND = entity.NTYPE_AMEND,
            DNULLDATE = entity.DNULLDATE,
            SREPORT = entity.SREPORT,
            NORDER = entity.NORDER,
            SROUTINE = entity.SROUTINE,
            SDESCRIPT = entity.SDESCRIPT,
        };
    }

    public static SECTION_PO ToEntity(this CreateSECTION_PODto dto)
    {
        if (dto == null) return null!;
        return new SECTION_PO
        {
            NSEQUENCE = dto.NSEQUENCE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NORIGIN = dto.NORIGIN,
            NTYPE_AMEND = dto.NTYPE_AMEND,
            DNULLDATE = dto.DNULLDATE,
            SREPORT = dto.SREPORT,
            NORDER = dto.NORDER,
            SROUTINE = dto.SROUTINE,
            SDESCRIPT = dto.SDESCRIPT,
        };
    }

    public static void UpdateEntity(this SECTION_PO entity, UpdateSECTION_PODto dto)
    {
        if (entity == null || dto == null) return;
        entity.NSEQUENCE = dto.NSEQUENCE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NORIGIN = dto.NORIGIN;
        entity.NTYPE_AMEND = dto.NTYPE_AMEND;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SREPORT = dto.SREPORT;
        entity.NORDER = dto.NORDER;
        entity.SROUTINE = dto.SROUTINE;
        entity.SDESCRIPT = dto.SDESCRIPT;
    }
}
