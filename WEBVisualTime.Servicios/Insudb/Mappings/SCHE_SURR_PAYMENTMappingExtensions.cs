using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_SURR_PAYMENT;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SCHE_SURR_PAYMENTMappingExtensions
{
    public static SCHE_SURR_PAYMENTDto ToDto(this SCHE_SURR_PAYMENT entity)
    {
        if (entity == null) return null!;
        return new SCHE_SURR_PAYMENTDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            NTYPE_PAYMENT = entity.NTYPE_PAYMENT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SLIFE = entity.SLIFE,
        };
    }

    public static SCHE_SURR_PAYMENT ToEntity(this CreateSCHE_SURR_PAYMENTDto dto)
    {
        if (dto == null) return null!;
        return new SCHE_SURR_PAYMENT
        {
            SSCHE_CODE = dto.SSCHE_CODE,
            NTYPE_PAYMENT = dto.NTYPE_PAYMENT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SLIFE = dto.SLIFE,
        };
    }

    public static void UpdateEntity(this SCHE_SURR_PAYMENT entity, UpdateSCHE_SURR_PAYMENTDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SSCHE_CODE = dto.SSCHE_CODE;
        entity.NTYPE_PAYMENT = dto.NTYPE_PAYMENT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SLIFE = dto.SLIFE;
    }
}
