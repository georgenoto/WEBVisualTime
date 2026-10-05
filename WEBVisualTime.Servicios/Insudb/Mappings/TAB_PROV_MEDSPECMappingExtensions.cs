using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_MEDSPEC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_PROV_MEDSPECMappingExtensions
{
    public static TAB_PROV_MEDSPECDto ToDto(this TAB_PROV_MEDSPEC entity)
    {
        if (entity == null) return null!;
        return new TAB_PROV_MEDSPECDto
        {
            NPROVIDER = entity.NPROVIDER,
            TAB_PROVIDERSSTATREGT = entity.TAB_PROVIDER?.SSTATREGT,
            SMEDSPECIALIALTY = entity.SMEDSPECIALIALTY,
            TABLE8603SDESCRIPT = entity.TABLE8603?.SDESCRIPT,
            NMAIN_MEDSPECIALIALTY = entity.NMAIN_MEDSPECIALIALTY,
            SREG_MEDICALPROF = entity.SREG_MEDICALPROF,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_PROV_MEDSPEC ToEntity(this CreateTAB_PROV_MEDSPECDto dto)
    {
        if (dto == null) return null!;
        return new TAB_PROV_MEDSPEC
        {
            NMAIN_MEDSPECIALIALTY = dto.NMAIN_MEDSPECIALIALTY,
            SREG_MEDICALPROF = dto.SREG_MEDICALPROF,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_PROV_MEDSPEC entity, UpdateTAB_PROV_MEDSPECDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NMAIN_MEDSPECIALIALTY = dto.NMAIN_MEDSPECIALIALTY;
        entity.SREG_MEDICALPROF = dto.SREG_MEDICALPROF;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
