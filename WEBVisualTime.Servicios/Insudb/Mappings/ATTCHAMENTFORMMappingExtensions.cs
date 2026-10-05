using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ATTCHAMENTFORM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class ATTCHAMENTFORMMappingExtensions
{
    public static ATTCHAMENTFORMDto ToDto(this ATTCHAMENTFORM entity)
    {
        if (entity == null) return null!;
        return new ATTCHAMENTFORMDto
        {
            NSEQUENCEATT = entity.NSEQUENCEATT,
            SFORMID = entity.SFORMID,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static ATTCHAMENTFORM ToEntity(this CreateATTCHAMENTFORMDto dto)
    {
        if (dto == null) return null!;
        return new ATTCHAMENTFORM
        {
            NSEQUENCEATT = dto.NSEQUENCEATT,
            SFORMID = dto.SFORMID,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this ATTCHAMENTFORM entity, UpdateATTCHAMENTFORMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NSEQUENCEATT = dto.NSEQUENCEATT;
        entity.SFORMID = dto.SFORMID;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
