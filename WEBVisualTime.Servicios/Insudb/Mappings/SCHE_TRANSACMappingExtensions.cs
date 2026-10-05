using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_TRANSAC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SCHE_TRANSACMappingExtensions
{
    public static SCHE_TRANSACDto ToDto(this SCHE_TRANSAC entity)
    {
        if (entity == null) return null!;
        return new SCHE_TRANSACDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            SECUR_SCHESLONGDESC = entity.SECUR_SCHE?.SLONGDESC,
            SCODISPL = entity.SCODISPL,
            WINDOWSSCODISP = entity.WINDOWS?.SCODISP,
            NTRANSAC = entity.NTRANSAC,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            SPAY_FORM = entity.SPAY_FORM,
            TABLE182SDESCRIPT = entity.TABLE182?.SDESCRIPT,
            NTYPE_AMEND = entity.NTYPE_AMEND,
            TABLE6059SDESCRIPT = entity.TABLE6059?.SDESCRIPT,
            NID = entity.NID,
        };
    }

    public static SCHE_TRANSAC ToEntity(this CreateSCHE_TRANSACDto dto)
    {
        if (dto == null) return null!;
        return new SCHE_TRANSAC
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SPAY_FORM = dto.SPAY_FORM,
            NTYPE_AMEND = dto.NTYPE_AMEND,
        };
    }

    public static void UpdateEntity(this SCHE_TRANSAC entity, UpdateSCHE_TRANSACDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SPAY_FORM = dto.SPAY_FORM;
        entity.NTYPE_AMEND = dto.NTYPE_AMEND;
    }
}
