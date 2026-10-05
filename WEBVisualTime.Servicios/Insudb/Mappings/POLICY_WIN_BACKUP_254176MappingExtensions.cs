using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY_WIN_BACKUP_254176;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class POLICY_WIN_BACKUP_254176MappingExtensions
{
    public static POLICY_WIN_BACKUP_254176Dto ToDto(this POLICY_WIN_BACKUP_254176 entity)
    {
        if (entity == null) return null!;
        return new POLICY_WIN_BACKUP_254176Dto
        {
            SCERTYPE = entity.SCERTYPE,
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY = entity.NPOLICY,
            NCERTIF = entity.NCERTIF,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            SV_CONPOLIC = entity.SV_CONPOLIC,
            SV_WINPOLIC = entity.SV_WINPOLIC,
        };
    }

    public static POLICY_WIN_BACKUP_254176 ToEntity(this CreatePOLICY_WIN_BACKUP_254176Dto dto)
    {
        if (dto == null) return null!;
        return new POLICY_WIN_BACKUP_254176
        {
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            DEFFECDATE = dto.DEFFECDATE,
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            SV_CONPOLIC = dto.SV_CONPOLIC,
            SV_WINPOLIC = dto.SV_WINPOLIC,
        };
    }

    public static void UpdateEntity(this POLICY_WIN_BACKUP_254176 entity, UpdatePOLICY_WIN_BACKUP_254176Dto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SV_CONPOLIC = dto.SV_CONPOLIC;
        entity.SV_WINPOLIC = dto.SV_WINPOLIC;
    }
}
