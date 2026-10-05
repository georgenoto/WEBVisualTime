using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.RELATIONS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class RELATIONSMappingExtensions
{
    public static RELATIONSDto ToDto(this RELATIONS entity)
    {
        if (entity == null) return null!;
        return new RELATIONSDto
        {
            SCLIENTR = entity.SCLIENTR,
            CLIENTSCLIENTRSACCOUNT_IN = entity.CLIENTSCLIENTR?.SACCOUNT_IN,
            SCLIENT = entity.SCLIENT,
            CLIENTSCLIENTSACCOUNT_IN = entity.CLIENTSCLIENT?.SACCOUNT_IN,
            DCOMPDATE = entity.DCOMPDATE,
            NRELASHIP = entity.NRELASHIP,
            TABLE15SDESCRIPT = entity.TABLE15?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static RELATIONS ToEntity(this CreateRELATIONSDto dto)
    {
        if (dto == null) return null!;
        return new RELATIONS
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this RELATIONS entity, UpdateRELATIONSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
