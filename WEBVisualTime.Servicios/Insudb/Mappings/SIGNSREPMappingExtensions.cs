using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SIGNSREP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SIGNSREPMappingExtensions
{
    public static SIGNSREPDto ToDto(this SIGNSREP entity)
    {
        if (entity == null) return null!;
        return new SIGNSREPDto
        {
            NUSERSIGN = entity.NUSERSIGN,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            DEFFECDATE = entity.DEFFECDATE,
            SPOSITION = entity.SPOSITION,
            SPATHSING = entity.SPATHSING,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSTATREG = entity.SSTATREG,
        };
    }

    public static SIGNSREP ToEntity(this CreateSIGNSREPDto dto)
    {
        if (dto == null) return null!;
        return new SIGNSREP
        {
            SPOSITION = dto.SPOSITION,
            SPATHSING = dto.SPATHSING,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSTATREG = dto.SSTATREG,
        };
    }

    public static void UpdateEntity(this SIGNSREP entity, UpdateSIGNSREPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SPOSITION = dto.SPOSITION;
        entity.SPATHSING = dto.SPATHSING;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREG = dto.SSTATREG;
    }
}
