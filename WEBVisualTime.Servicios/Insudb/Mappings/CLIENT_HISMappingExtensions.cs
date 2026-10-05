using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_HIS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLIENT_HISMappingExtensions
{
    public static CLIENT_HISDto ToDto(this CLIENT_HIS entity)
    {
        if (entity == null) return null!;
        return new CLIENT_HISDto
        {
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DEFFECDATE = entity.DEFFECDATE,
            SCLIENAME = entity.SCLIENAME,
            SFIRSTNAME = entity.SFIRSTNAME,
            SLASTNAME = entity.SLASTNAME,
            SLASTNAME2 = entity.SLASTNAME2,
            SSEXCLIEN = entity.SSEXCLIEN,
            TABLE18SDESCRIPT = entity.TABLE18?.SDESCRIPT,
            NCIVILSTA = entity.NCIVILSTA,
            TABLE14SDESCRIPT = entity.TABLE14?.SDESCRIPT,
            SBLOCKADE = entity.SBLOCKADE,
            NHEALTH_ORG = entity.NHEALTH_ORG,
            TABLE5523SDESCRIPT = entity.TABLE5523?.SDESCRIPT,
            NAFP = entity.NAFP,
            TABLE5524SDESCRIPT = entity.TABLE5524?.SDESCRIPT,
            DWEDD = entity.DWEDD,
            NINCAPACITY = entity.NINCAPACITY,
            TABLE5549SDESCRIPT = entity.TABLE5549?.SDESCRIPT,
            NINCAP_COD = entity.NINCAP_COD,
            TABLE5550SDESCRIPT = entity.TABLE5550?.SDESCRIPT,
            DDRIVERDAT = entity.DDRIVERDAT,
            DDRIVEXPDAT = entity.DDRIVEXPDAT,
            NTYPDRIVER = entity.NTYPDRIVER,
            TABLE5504SDESCRIPT = entity.TABLE5504?.SDESCRIPT,
            NLIMITDRIV = entity.NLIMITDRIV,
            TABLE5521SDESCRIPT = entity.TABLE5521?.SDESCRIPT,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SLEGALNAME = entity.SLEGALNAME,
            DINCAPACITY = entity.DINCAPACITY,
            NID = entity.NID,
            DDEPENDANT = entity.DDEPENDANT,
            DINDEPENDANT = entity.DINDEPENDANT,
        };
    }

    public static CLIENT_HIS ToEntity(this CreateCLIENT_HISDto dto)
    {
        if (dto == null) return null!;
        return new CLIENT_HIS
        {
            SCLIENAME = dto.SCLIENAME,
            SFIRSTNAME = dto.SFIRSTNAME,
            SLASTNAME = dto.SLASTNAME,
            SLASTNAME2 = dto.SLASTNAME2,
            SSEXCLIEN = dto.SSEXCLIEN,
            NCIVILSTA = dto.NCIVILSTA,
            SBLOCKADE = dto.SBLOCKADE,
            NHEALTH_ORG = dto.NHEALTH_ORG,
            NAFP = dto.NAFP,
            DWEDD = dto.DWEDD,
            NINCAPACITY = dto.NINCAPACITY,
            NINCAP_COD = dto.NINCAP_COD,
            DDRIVERDAT = dto.DDRIVERDAT,
            DDRIVEXPDAT = dto.DDRIVEXPDAT,
            NTYPDRIVER = dto.NTYPDRIVER,
            NLIMITDRIV = dto.NLIMITDRIV,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SLEGALNAME = dto.SLEGALNAME,
            DINCAPACITY = dto.DINCAPACITY,
            NID = dto.NID,
            DDEPENDANT = dto.DDEPENDANT,
            DINDEPENDANT = dto.DINDEPENDANT,
        };
    }

    public static void UpdateEntity(this CLIENT_HIS entity, UpdateCLIENT_HISDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCLIENAME = dto.SCLIENAME;
        entity.SFIRSTNAME = dto.SFIRSTNAME;
        entity.SLASTNAME = dto.SLASTNAME;
        entity.SLASTNAME2 = dto.SLASTNAME2;
        entity.SSEXCLIEN = dto.SSEXCLIEN;
        entity.NCIVILSTA = dto.NCIVILSTA;
        entity.SBLOCKADE = dto.SBLOCKADE;
        entity.NHEALTH_ORG = dto.NHEALTH_ORG;
        entity.NAFP = dto.NAFP;
        entity.DWEDD = dto.DWEDD;
        entity.NINCAPACITY = dto.NINCAPACITY;
        entity.NINCAP_COD = dto.NINCAP_COD;
        entity.DDRIVERDAT = dto.DDRIVERDAT;
        entity.DDRIVEXPDAT = dto.DDRIVEXPDAT;
        entity.NTYPDRIVER = dto.NTYPDRIVER;
        entity.NLIMITDRIV = dto.NLIMITDRIV;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SLEGALNAME = dto.SLEGALNAME;
        entity.DINCAPACITY = dto.DINCAPACITY;
        entity.NID = dto.NID;
        entity.DDEPENDANT = dto.DDEPENDANT;
        entity.DINDEPENDANT = dto.DINDEPENDANT;
    }
}
