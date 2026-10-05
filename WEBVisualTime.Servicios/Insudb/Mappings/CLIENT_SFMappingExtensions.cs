using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_SF;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLIENT_SFMappingExtensions
{
    public static CLIENT_SFDto ToDto(this CLIENT_SF entity)
    {
        if (entity == null) return null!;
        return new CLIENT_SFDto
        {
            SCLIENT = entity.SCLIENT,
            SDIGIT = entity.SDIGIT,
            NPOSITION = entity.NPOSITION,
            TABLE8004SDESCRIPT = entity.TABLE8004?.SDESCRIPT,
            DSTARTCONDITION = entity.DSTARTCONDITION,
            DENDCONDITION = entity.DENDCONDITION,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NPLACEBIRTH = entity.NPLACEBIRTH,
            NSECOND_NATIONALITY = entity.NSECOND_NATIONALITY,
            NRESIDENT_FORMER = entity.NRESIDENT_FORMER,
            SUSADDRES = entity.SUSADDRES,
            SUSLEGAL_PERSON = entity.SUSLEGAL_PERSON,
            SUSPHONE = entity.SUSPHONE,
            SUSACCOUNT = entity.SUSACCOUNT,
            SSSN = entity.SSSN,
            SUS_ITINNUM = entity.SUS_ITINNUM,
            SUS_IRSIND = entity.SUS_IRSIND,
            SPLACEBIRTH = entity.SPLACEBIRTH,
            NTYPELIST = entity.NTYPELIST,
        };
    }

    public static CLIENT_SF ToEntity(this CreateCLIENT_SFDto dto)
    {
        if (dto == null) return null!;
        return new CLIENT_SF
        {
            SDIGIT = dto.SDIGIT,
            NPOSITION = dto.NPOSITION,
            DSTARTCONDITION = dto.DSTARTCONDITION,
            DENDCONDITION = dto.DENDCONDITION,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NPLACEBIRTH = dto.NPLACEBIRTH,
            NSECOND_NATIONALITY = dto.NSECOND_NATIONALITY,
            NRESIDENT_FORMER = dto.NRESIDENT_FORMER,
            SUSADDRES = dto.SUSADDRES,
            SUSLEGAL_PERSON = dto.SUSLEGAL_PERSON,
            SUSPHONE = dto.SUSPHONE,
            SUSACCOUNT = dto.SUSACCOUNT,
            SSSN = dto.SSSN,
            SUS_ITINNUM = dto.SUS_ITINNUM,
            SUS_IRSIND = dto.SUS_IRSIND,
            SPLACEBIRTH = dto.SPLACEBIRTH,
        };
    }

    public static void UpdateEntity(this CLIENT_SF entity, UpdateCLIENT_SFDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDIGIT = dto.SDIGIT;
        entity.NPOSITION = dto.NPOSITION;
        entity.DSTARTCONDITION = dto.DSTARTCONDITION;
        entity.DENDCONDITION = dto.DENDCONDITION;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NPLACEBIRTH = dto.NPLACEBIRTH;
        entity.NSECOND_NATIONALITY = dto.NSECOND_NATIONALITY;
        entity.NRESIDENT_FORMER = dto.NRESIDENT_FORMER;
        entity.SUSADDRES = dto.SUSADDRES;
        entity.SUSLEGAL_PERSON = dto.SUSLEGAL_PERSON;
        entity.SUSPHONE = dto.SUSPHONE;
        entity.SUSACCOUNT = dto.SUSACCOUNT;
        entity.SSSN = dto.SSSN;
        entity.SUS_ITINNUM = dto.SUS_ITINNUM;
        entity.SUS_IRSIND = dto.SUS_IRSIND;
        entity.SPLACEBIRTH = dto.SPLACEBIRTH;
    }
}
