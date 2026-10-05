using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COVER_QUOTA;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COVER_QUOTAMappingExtensions
{
    public static COVER_QUOTADto ToDto(this COVER_QUOTA entity)
    {
        if (entity == null) return null!;
        return new COVER_QUOTADto
        {
            SCERTYPE = entity.SCERTYPE,
            POLICYSCERTYPESACCOUNTI = entity.POLICYSCERTYPE?.SACCOUNTI,
            NBRANCH = entity.NBRANCH,
            POLICYNBRANCHSACCOUNTI = entity.POLICYNBRANCH?.SACCOUNTI,
            NPRODUCT = entity.NPRODUCT,
            POLICYNPRODUCTSACCOUNTI = entity.POLICYNPRODUCT?.SACCOUNTI,
            NPOLICY = entity.NPOLICY,
            POLICYNPOLICYSACCOUNTI = entity.POLICYNPOLICY?.SACCOUNTI,
            NGROUP = entity.NGROUP,
            NMODULEC = entity.NMODULEC,
            NROLE = entity.NROLE,
            TABLE12SDESCRIPT = entity.TABLE12?.SDESCRIPT,
            NCOVER = entity.NCOVER,
            NCAPITAL = entity.NCAPITAL,
            NTAXIVA = entity.NTAXIVA,
            NTAX = entity.NTAX,
            NPREMIUM = entity.NPREMIUM,
            NINSUCOUNT = entity.NINSUCOUNT,
            NINSURED = entity.NINSURED,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NCERTIF = entity.NCERTIF,
        };
    }

    public static COVER_QUOTA ToEntity(this CreateCOVER_QUOTADto dto)
    {
        if (dto == null) return null!;
        return new COVER_QUOTA
        {
            NCAPITAL = dto.NCAPITAL,
            NTAXIVA = dto.NTAXIVA,
            NTAX = dto.NTAX,
            NPREMIUM = dto.NPREMIUM,
            NINSUCOUNT = dto.NINSUCOUNT,
            NINSURED = dto.NINSURED,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NCERTIF = dto.NCERTIF,
        };
    }

    public static void UpdateEntity(this COVER_QUOTA entity, UpdateCOVER_QUOTADto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCAPITAL = dto.NCAPITAL;
        entity.NTAXIVA = dto.NTAXIVA;
        entity.NTAX = dto.NTAX;
        entity.NPREMIUM = dto.NPREMIUM;
        entity.NINSUCOUNT = dto.NINSUCOUNT;
        entity.NINSURED = dto.NINSURED;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NCERTIF = dto.NCERTIF;
    }
}
