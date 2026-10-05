using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SEQUEN_POL;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SEQUEN_POLMappingExtensions
{
    public static SEQUEN_POLDto ToDto(this SEQUEN_POL entity)
    {
        if (entity == null) return null!;
        return new SEQUEN_POLDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            SBUSSITYP = entity.SBUSSITYP,
            NTRATYPEP = entity.NTRATYPEP,
            TABLE5588SDESCRIPT = entity.TABLE5588?.SDESCRIPT,
            SPOLITYPE = entity.SPOLITYPE,
            SCOMPON = entity.SCOMPON,
            NSEQUENCE = entity.NSEQUENCE,
            DEFFECDATE = entity.DEFFECDATE,
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            SREQUIRE = entity.SREQUIRE,
            NUSERCODE = entity.NUSERCODE,
            SAUTOMATIC = entity.SAUTOMATIC,
            NTYPE_AMEND = entity.NTYPE_AMEND,
        };
    }

    public static SEQUEN_POL ToEntity(this CreateSEQUEN_POLDto dto)
    {
        if (dto == null) return null!;
        return new SEQUEN_POL
        {
            SCODISPL = dto.SCODISPL,
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            SREQUIRE = dto.SREQUIRE,
            NUSERCODE = dto.NUSERCODE,
            SAUTOMATIC = dto.SAUTOMATIC,
        };
    }

    public static void UpdateEntity(this SEQUEN_POL entity, UpdateSEQUEN_POLDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCODISPL = dto.SCODISPL;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SREQUIRE = dto.SREQUIRE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SAUTOMATIC = dto.SAUTOMATIC;
    }
}
