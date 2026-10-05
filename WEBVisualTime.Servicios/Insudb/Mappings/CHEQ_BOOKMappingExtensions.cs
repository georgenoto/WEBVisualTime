using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CHEQ_BOOK;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CHEQ_BOOKMappingExtensions
{
    public static CHEQ_BOOKDto ToDto(this CHEQ_BOOK entity)
    {
        if (entity == null) return null!;
        return new CHEQ_BOOKDto
        {
            NACC_BANK = entity.NACC_BANK,
            BANK_ACCSACC_LEDGER = entity.BANK_ACC?.SACC_LEDGER,
            DEFFECDATE = entity.DEFFECDATE,
            SCHEQUE_END = entity.SCHEQUE_END,
            SCHEQUE_LAS = entity.SCHEQUE_LAS,
            SCHEQUE_STA = entity.SCHEQUE_STA,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NQ_CHE_DAMA = entity.NQ_CHE_DAMA,
            NQ_CHE_NULL = entity.NQ_CHE_NULL,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static CHEQ_BOOK ToEntity(this CreateCHEQ_BOOKDto dto)
    {
        if (dto == null) return null!;
        return new CHEQ_BOOK
        {
            SCHEQUE_END = dto.SCHEQUE_END,
            SCHEQUE_LAS = dto.SCHEQUE_LAS,
            SCHEQUE_STA = dto.SCHEQUE_STA,
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NQ_CHE_DAMA = dto.NQ_CHE_DAMA,
            NQ_CHE_NULL = dto.NQ_CHE_NULL,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this CHEQ_BOOK entity, UpdateCHEQ_BOOKDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCHEQUE_END = dto.SCHEQUE_END;
        entity.SCHEQUE_LAS = dto.SCHEQUE_LAS;
        entity.SCHEQUE_STA = dto.SCHEQUE_STA;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NQ_CHE_DAMA = dto.NQ_CHE_DAMA;
        entity.NQ_CHE_NULL = dto.NQ_CHE_NULL;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
