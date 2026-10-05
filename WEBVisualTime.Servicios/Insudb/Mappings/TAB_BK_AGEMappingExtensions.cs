using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_BK_AGE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_BK_AGEMappingExtensions
{
    public static TAB_BK_AGEDto ToDto(this TAB_BK_AGE entity)
    {
        if (entity == null) return null!;
        return new TAB_BK_AGEDto
        {
            NBANK_CODE = entity.NBANK_CODE,
            TABLE7SDESCRIPT = entity.TABLE7?.SDESCRIPT,
            NBK_AGENCY = entity.NBK_AGENCY,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SSHORT_DES = entity.SSHORT_DES,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            SN_ABA = entity.SN_ABA,
        };
    }

    public static TAB_BK_AGE ToEntity(this CreateTAB_BK_AGEDto dto)
    {
        if (dto == null) return null!;
        return new TAB_BK_AGE
        {
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SSHORT_DES = dto.SSHORT_DES,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            SN_ABA = dto.SN_ABA,
        };
    }

    public static void UpdateEntity(this TAB_BK_AGE entity, UpdateTAB_BK_AGEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SSHORT_DES = dto.SSHORT_DES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SN_ABA = dto.SN_ABA;
    }
}
