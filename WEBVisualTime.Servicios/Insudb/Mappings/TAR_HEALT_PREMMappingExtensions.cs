using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAR_HEALT_PREM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAR_HEALT_PREMMappingExtensions
{
    public static TAR_HEALT_PREMDto ToDto(this TAR_HEALT_PREM entity)
    {
        if (entity == null) return null!;
        return new TAR_HEALT_PREMDto
        {
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            NPRODUCT = entity.NPRODUCT,
            PRODMASTERSDESCRIPT = entity.PRODMASTER?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            NROLE = entity.NROLE,
            NMODULEC = entity.NMODULEC,
            NCOVER = entity.NCOVER,
            NGEOGRAPHAREA = entity.NGEOGRAPHAREA,
            TABLE9214SDESCRIPT = entity.TABLE9214?.SDESCRIPT,
            NATTENSYSTEM = entity.NATTENSYSTEM,
            TABLE9215SDESCRIPT = entity.TABLE9215?.SDESCRIPT,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NCAPITAL_INIT = entity.NCAPITAL_INIT,
            NCAPITAL_END = entity.NCAPITAL_END,
            NPOLICY_YEAR_INIT = entity.NPOLICY_YEAR_INIT,
            NPOLICY_YEAR_END = entity.NPOLICY_YEAR_END,
            NCURRENCY = entity.NCURRENCY,
            NAGE_INIT = entity.NAGE_INIT,
            NAGE_END = entity.NAGE_END,
            NAMOUNTF = entity.NAMOUNTF,
            NAMOUNTM = entity.NAMOUNTM,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAR_HEALT_PREM ToEntity(this CreateTAR_HEALT_PREMDto dto)
    {
        if (dto == null) return null!;
        return new TAR_HEALT_PREM
        {
            NAMOUNTF = dto.NAMOUNTF,
            NAMOUNTM = dto.NAMOUNTM,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAR_HEALT_PREM entity, UpdateTAR_HEALT_PREMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNTF = dto.NAMOUNTF;
        entity.NAMOUNTM = dto.NAMOUNTM;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
