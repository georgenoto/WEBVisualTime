using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_SYS_EXE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_SYS_EXEMappingExtensions
{
    public static TAB_SYS_EXEDto ToDto(this TAB_SYS_EXE entity)
    {
        if (entity == null) return null!;
        return new TAB_SYS_EXEDto
        {
            NEXE_CODE = entity.NEXE_CODE,
            DCOMPDATE = entity.DCOMPDATE,
            SEXE_NAME = entity.SEXE_NAME,
            SDESCRIPT = entity.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            SFOLDERNAME = entity.SFOLDERNAME,
        };
    }

    public static TAB_SYS_EXE ToEntity(this CreateTAB_SYS_EXEDto dto)
    {
        if (dto == null) return null!;
        return new TAB_SYS_EXE
        {
            DCOMPDATE = dto.DCOMPDATE,
            SEXE_NAME = dto.SEXE_NAME,
            SDESCRIPT = dto.SDESCRIPT,
            NUSERCODE = dto.NUSERCODE,
            SFOLDERNAME = dto.SFOLDERNAME,
        };
    }

    public static void UpdateEntity(this TAB_SYS_EXE entity, UpdateTAB_SYS_EXEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SEXE_NAME = dto.SEXE_NAME;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SFOLDERNAME = dto.SFOLDERNAME;
    }
}
