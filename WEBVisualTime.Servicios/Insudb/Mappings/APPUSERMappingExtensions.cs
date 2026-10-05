using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.APPUSER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class APPUSERMappingExtensions
{
    public static APPUSERDto ToDto(this APPUSER entity)
    {
        if (entity == null) return null!;
        return new APPUSERDto
        {
            NIDUSER = entity.NIDUSER,
            SUSERNAME = entity.SUSERNAME,
            SNAME = entity.SNAME,
        };
    }

    public static APPUSER ToEntity(this CreateAPPUSERDto dto)
    {
        if (dto == null) return null!;
        return new APPUSER
        {
            SUSERNAME = dto.SUSERNAME,
            SNAME = dto.SNAME,
        };
    }

    public static void UpdateEntity(this APPUSER entity, UpdateAPPUSERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SUSERNAME = dto.SUSERNAME;
        entity.SNAME = dto.SNAME;
    }
}
