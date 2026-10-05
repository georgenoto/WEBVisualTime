using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.AGREEMENT_AL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class AGREEMENT_ALMappingExtensions
{
    public static AGREEMENT_ALDto ToDto(this AGREEMENT_AL entity)
    {
        if (entity == null) return null!;
        return new AGREEMENT_ALDto
        {
            NAGREEMENT = entity.NAGREEMENT,
            SDESCRIPT = entity.SDESCRIPT,
            DSTARTDATE = entity.DSTARTDATE,
            DNULLDATE = entity.DNULLDATE,
            SLEVELINT = entity.SLEVELINT,
            DCOMPDATE = entity.DCOMPDATE,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            NAGREE_TYPE = entity.NAGREE_TYPE,
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
        };
    }

    public static AGREEMENT_AL ToEntity(this CreateAGREEMENT_ALDto dto)
    {
        if (dto == null) return null!;
        return new AGREEMENT_AL
        {
            SDESCRIPT = dto.SDESCRIPT,
            DSTARTDATE = dto.DSTARTDATE,
            DNULLDATE = dto.DNULLDATE,
            SLEVELINT = dto.SLEVELINT,
            DCOMPDATE = dto.DCOMPDATE,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            NAGREE_TYPE = dto.NAGREE_TYPE,
            NINTERMED = dto.NINTERMED,
        };
    }

    public static void UpdateEntity(this AGREEMENT_AL entity, UpdateAGREEMENT_ALDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.DSTARTDATE = dto.DSTARTDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SLEVELINT = dto.SLEVELINT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NAGREE_TYPE = dto.NAGREE_TYPE;
        entity.NINTERMED = dto.NINTERMED;
    }
}
