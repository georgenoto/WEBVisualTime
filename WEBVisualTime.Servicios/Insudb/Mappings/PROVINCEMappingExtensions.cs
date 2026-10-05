using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROVINCE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PROVINCEMappingExtensions
{
    public static PROVINCEDto ToDto(this PROVINCE entity)
    {
        if (entity == null) return null!;
        return new PROVINCEDto
        {
            NPROVINCE = entity.NPROVINCE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            NDGI_CODE = entity.NDGI_CODE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static PROVINCE ToEntity(this CreatePROVINCEDto dto)
    {
        if (dto == null) return null!;
        return new PROVINCE
        {
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            NDGI_CODE = dto.NDGI_CODE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this PROVINCE entity, UpdatePROVINCEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.NDGI_CODE = dto.NDGI_CODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
