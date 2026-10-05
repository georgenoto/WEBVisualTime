using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.NOCONVERS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class NOCONVERSMappingExtensions
{
    public static NOCONVERSDto ToDto(this NOCONVERS entity)
    {
        if (entity == null) return null!;
        return new NOCONVERSDto
        {
            NNO_CONVERS = entity.NNO_CONVERS,
            SDESCRIPT = entity.SDESCRIPT,
            NAREAWAIT = entity.NAREAWAIT,
            TABLE5603SDESCRIPT = entity.TABLE5603?.SDESCRIPT,
            SDEVO = entity.SDEVO,
            SDISC = entity.SDISC,
            SSTATREGT = entity.SSTATREGT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NEXPENSES = entity.NEXPENSES,
            SROUTINE = entity.SROUTINE,
            NHEALTHEXP = entity.NHEALTHEXP,
        };
    }

    public static NOCONVERS ToEntity(this CreateNOCONVERSDto dto)
    {
        if (dto == null) return null!;
        return new NOCONVERS
        {
            SDESCRIPT = dto.SDESCRIPT,
            NAREAWAIT = dto.NAREAWAIT,
            SDEVO = dto.SDEVO,
            SDISC = dto.SDISC,
            SSTATREGT = dto.SSTATREGT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NEXPENSES = dto.NEXPENSES,
            SROUTINE = dto.SROUTINE,
            NHEALTHEXP = dto.NHEALTHEXP,
        };
    }

    public static void UpdateEntity(this NOCONVERS entity, UpdateNOCONVERSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NAREAWAIT = dto.NAREAWAIT;
        entity.SDEVO = dto.SDEVO;
        entity.SDISC = dto.SDISC;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NEXPENSES = dto.NEXPENSES;
        entity.SROUTINE = dto.SROUTINE;
        entity.NHEALTHEXP = dto.NHEALTHEXP;
    }
}
