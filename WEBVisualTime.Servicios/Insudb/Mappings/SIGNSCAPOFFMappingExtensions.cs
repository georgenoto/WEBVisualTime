using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SIGNSCAPOFF;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SIGNSCAPOFFMappingExtensions
{
    public static SIGNSCAPOFFDto ToDto(this SIGNSCAPOFF entity)
    {
        if (entity == null) return null!;
        return new SIGNSCAPOFFDto
        {
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NCURRENCY = entity.NCURRENCY,
            TABLE11SDESCRIPT = entity.TABLE11?.SDESCRIPT,
            NUSERSIGN = entity.NUSERSIGN,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            NORDSIGN = entity.NORDSIGN,
            NCAPMINSING = entity.NCAPMINSING,
            NCAPMAXSING = entity.NCAPMAXSING,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SSTATREG = entity.SSTATREG,
        };
    }

    public static SIGNSCAPOFF ToEntity(this CreateSIGNSCAPOFFDto dto)
    {
        if (dto == null) return null!;
        return new SIGNSCAPOFF
        {
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SSTATREG = dto.SSTATREG,
        };
    }

    public static void UpdateEntity(this SIGNSCAPOFF entity, UpdateSIGNSCAPOFFDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREG = dto.SSTATREG;
    }
}
