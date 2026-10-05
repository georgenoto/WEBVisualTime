using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.NONWORKINGDAYFACTOR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class NONWORKINGDAYFACTORMappingExtensions
{
    public static NONWORKINGDAYFACTORDto ToDto(this NONWORKINGDAYFACTOR entity)
    {
        if (entity == null) return null!;
        return new NONWORKINGDAYFACTORDto
        {
            NIDFACTOR = entity.NIDFACTOR,
            NIDUSER = entity.NIDUSER,
            APPUSERSUSERNAME = entity.APPUSER?.SUSERNAME,
            NFACTOR = entity.NFACTOR,
            DCREATIONDATE = entity.DCREATIONDATE,
        };
    }

    public static NONWORKINGDAYFACTOR ToEntity(this CreateNONWORKINGDAYFACTORDto dto)
    {
        if (dto == null) return null!;
        return new NONWORKINGDAYFACTOR
        {
            NIDUSER = dto.NIDUSER,
            NFACTOR = dto.NFACTOR,
            DCREATIONDATE = dto.DCREATIONDATE,
        };
    }

    public static void UpdateEntity(this NONWORKINGDAYFACTOR entity, UpdateNONWORKINGDAYFACTORDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NIDUSER = dto.NIDUSER;
        entity.NFACTOR = dto.NFACTOR;
        entity.DCREATIONDATE = dto.DCREATIONDATE;
    }
}
