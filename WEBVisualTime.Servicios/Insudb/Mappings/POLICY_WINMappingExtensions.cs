using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY_WIN;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class POLICY_WINMappingExtensions
{
    public static POLICY_WINDto ToDto(this POLICY_WIN entity)
    {
        if (entity == null) return null!;
        return new POLICY_WINDto
        {
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            SV_CONPOLIC = entity.SV_CONPOLIC,
            SV_WINPOLIC = entity.SV_WINPOLIC,
        };
    }

    public static POLICY_WIN ToEntity(this CreatePOLICY_WINDto dto)
    {
        if (dto == null) return null!;
        return new POLICY_WIN
        {
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            SV_CONPOLIC = dto.SV_CONPOLIC,
            SV_WINPOLIC = dto.SV_WINPOLIC,
        };
    }

    public static void UpdateEntity(this POLICY_WIN entity, UpdatePOLICY_WINDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SV_CONPOLIC = dto.SV_CONPOLIC;
        entity.SV_WINPOLIC = dto.SV_WINPOLIC;
    }
}
