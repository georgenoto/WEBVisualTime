using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_TMP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLIENT_TMPMappingExtensions
{
    public static CLIENT_TMPDto ToDto(this CLIENT_TMP entity)
    {
        if (entity == null) return null!;
        return new CLIENT_TMPDto
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
            NROLE = entity.NROLE,
            TABLE12SDESCRIPT = entity.TABLE12?.SDESCRIPT,
            NID = entity.NID,
            STYPEAGE = entity.STYPEAGE,
            DBIRTHDATE = entity.DBIRTHDATE,
            NINITAGE = entity.NINITAGE,
            NENDAGE = entity.NENDAGE,
            NINSURED = entity.NINSURED,
            NRENTAMOUNT = entity.NRENTAMOUNT,
            NCURRENCY = entity.NCURRENCY,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SVIP = entity.SVIP,
            SSEXCLIEN = entity.SSEXCLIEN,
        };
    }

    public static CLIENT_TMP ToEntity(this CreateCLIENT_TMPDto dto)
    {
        if (dto == null) return null!;
        return new CLIENT_TMP
        {
            STYPEAGE = dto.STYPEAGE,
            DBIRTHDATE = dto.DBIRTHDATE,
            NINITAGE = dto.NINITAGE,
            NENDAGE = dto.NENDAGE,
            NINSURED = dto.NINSURED,
            NRENTAMOUNT = dto.NRENTAMOUNT,
            NCURRENCY = dto.NCURRENCY,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SVIP = dto.SVIP,
            SSEXCLIEN = dto.SSEXCLIEN,
        };
    }

    public static void UpdateEntity(this CLIENT_TMP entity, UpdateCLIENT_TMPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.STYPEAGE = dto.STYPEAGE;
        entity.DBIRTHDATE = dto.DBIRTHDATE;
        entity.NINITAGE = dto.NINITAGE;
        entity.NENDAGE = dto.NENDAGE;
        entity.NINSURED = dto.NINSURED;
        entity.NRENTAMOUNT = dto.NRENTAMOUNT;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SVIP = dto.SVIP;
        entity.SSEXCLIEN = dto.SSEXCLIEN;
    }
}
