using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PRODMASTER;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PRODMASTERMappingExtensions
{
    public static PRODMASTERDto ToDto(this PRODMASTER entity)
    {
        if (entity == null) return null!;
        return new PRODMASTERDto
        {
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            NPRODUCT = entity.NPRODUCT,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            SBRANCHT = entity.SBRANCHT,
            TABLE37SDESCRIPT = entity.TABLE37?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            SREALIND = entity.SREALIND,
            NCOMPANY = entity.NCOMPANY,
            SPREFFIX = entity.SPREFFIX,
        };
    }

    public static PRODMASTER ToEntity(this CreatePRODMASTERDto dto)
    {
        if (dto == null) return null!;
        return new PRODMASTER
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            SBRANCHT = dto.SBRANCHT,
            DCOMPDATE = dto.DCOMPDATE,
            SREALIND = dto.SREALIND,
            NCOMPANY = dto.NCOMPANY,
            SPREFFIX = dto.SPREFFIX,
        };
    }

    public static void UpdateEntity(this PRODMASTER entity, UpdatePRODMASTERDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SBRANCHT = dto.SBRANCHT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SREALIND = dto.SREALIND;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.SPREFFIX = dto.SPREFFIX;
    }
}
