using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_TYPERR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_TYPERRMappingExtensions
{
    public static TAB_TYPERRDto ToDto(this TAB_TYPERR entity)
    {
        if (entity == null) return null!;
        return new TAB_TYPERRDto
        {
            NTYPE_ERR = entity.NTYPE_ERR,
            NTYPEERR_PA = entity.NTYPEERR_PA,
            TAB_TYPERRParentSDESCRIPT = entity.TAB_TYPERRParent?.SDESCRIPT,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            STRANSITI = entity.STRANSITI,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_TYPERR ToEntity(this CreateTAB_TYPERRDto dto)
    {
        if (dto == null) return null!;
        return new TAB_TYPERR
        {
            NTYPEERR_PA = dto.NTYPEERR_PA,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            STRANSITI = dto.STRANSITI,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_TYPERR entity, UpdateTAB_TYPERRDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NTYPEERR_PA = dto.NTYPEERR_PA;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.STRANSITI = dto.STRANSITI;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
