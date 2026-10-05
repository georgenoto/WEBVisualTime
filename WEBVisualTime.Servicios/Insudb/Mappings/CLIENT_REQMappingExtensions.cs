using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_REQ;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLIENT_REQMappingExtensions
{
    public static CLIENT_REQDto ToDto(this CLIENT_REQ entity)
    {
        if (entity == null) return null!;
        return new CLIENT_REQDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NROLE = entity.NROLE,
            NTRATYPEP = entity.NTRATYPEP,
            NFIELD = entity.NFIELD,
            TABLE8017SDESCRIPT = entity.TABLE8017?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            SBIRTHDAI = entity.SBIRTHDAI,
            SCIVISTAI = entity.SCIVISTAI,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            SREQUIRED = entity.SREQUIRED,
            SOCCUPATI = entity.SOCCUPATI,
            SSEXINSUI = entity.SSEXINSUI,
            NUSERCODE = entity.NUSERCODE,
            STAX_SITUA = entity.STAX_SITUA,
            SADDRESS = entity.SADDRESS,
            SCREDITLINE = entity.SCREDITLINE,
        };
    }

    public static CLIENT_REQ ToEntity(this CreateCLIENT_REQDto dto)
    {
        if (dto == null) return null!;
        return new CLIENT_REQ
        {
            SBIRTHDAI = dto.SBIRTHDAI,
            SCIVISTAI = dto.SCIVISTAI,
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            SREQUIRED = dto.SREQUIRED,
            SOCCUPATI = dto.SOCCUPATI,
            SSEXINSUI = dto.SSEXINSUI,
            NUSERCODE = dto.NUSERCODE,
            STAX_SITUA = dto.STAX_SITUA,
            SADDRESS = dto.SADDRESS,
            SCREDITLINE = dto.SCREDITLINE,
        };
    }

    public static void UpdateEntity(this CLIENT_REQ entity, UpdateCLIENT_REQDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SBIRTHDAI = dto.SBIRTHDAI;
        entity.SCIVISTAI = dto.SCIVISTAI;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.SREQUIRED = dto.SREQUIRED;
        entity.SOCCUPATI = dto.SOCCUPATI;
        entity.SSEXINSUI = dto.SSEXINSUI;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.STAX_SITUA = dto.STAX_SITUA;
        entity.SADDRESS = dto.SADDRESS;
        entity.SCREDITLINE = dto.SCREDITLINE;
    }
}
