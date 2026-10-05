using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.USER_CASHNUM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class USER_CASHNUMMappingExtensions
{
    public static USER_CASHNUMDto ToDto(this USER_CASHNUM entity)
    {
        if (entity == null) return null!;
        return new USER_CASHNUMDto
        {
            NCASHNUM = entity.NCASHNUM,
            SSTATUS = entity.SSTATUS,
            DCOMPDATE = entity.DCOMPDATE,
            NUSER = entity.NUSER,
            USERSNUSERSACCESSWO = entity.USERSNUSER?.SACCESSWO,
            NUSERCODE = entity.NUSERCODE,
            USERSNUSERCODESACCESSWO = entity.USERSNUSERCODE?.SACCESSWO,
            NCASHSUP = entity.NCASHSUP,
            USERSNCASHSUPSACCESSWO = entity.USERSNCASHSUP?.SACCESSWO,
            NHEADSUP = entity.NHEADSUP,
            USERSNHEADSUPSACCESSWO = entity.USERSNHEADSUP?.SACCESSWO,
            NOFFICEAGEN = entity.NOFFICEAGEN,
            NTYPECASH = entity.NTYPECASH,
        };
    }

    public static USER_CASHNUM ToEntity(this CreateUSER_CASHNUMDto dto)
    {
        if (dto == null) return null!;
        return new USER_CASHNUM
        {
            SSTATUS = dto.SSTATUS,
            DCOMPDATE = dto.DCOMPDATE,
            NUSER = dto.NUSER,
            NUSERCODE = dto.NUSERCODE,
            NCASHSUP = dto.NCASHSUP,
            NHEADSUP = dto.NHEADSUP,
            NOFFICEAGEN = dto.NOFFICEAGEN,
            NTYPECASH = dto.NTYPECASH,
        };
    }

    public static void UpdateEntity(this USER_CASHNUM entity, UpdateUSER_CASHNUMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SSTATUS = dto.SSTATUS;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSER = dto.NUSER;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NCASHSUP = dto.NCASHSUP;
        entity.NHEADSUP = dto.NHEADSUP;
        entity.NOFFICEAGEN = dto.NOFFICEAGEN;
        entity.NTYPECASH = dto.NTYPECASH;
    }
}
