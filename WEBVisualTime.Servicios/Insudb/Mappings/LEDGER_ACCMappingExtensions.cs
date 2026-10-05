using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LEDGER_ACC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class LEDGER_ACCMappingExtensions
{
    public static LEDGER_ACCDto ToDto(this LEDGER_ACC entity)
    {
        if (entity == null) return null!;
        return new LEDGER_ACCDto
        {
            NLED_COMPAN = entity.NLED_COMPAN,
            LED_COMPANSACCOUNT_BG = entity.LED_COMPAN?.SACCOUNT_BG,
            SACCOUNT = entity.SACCOUNT,
            SAUX_ACCOUN = entity.SAUX_ACCOUN,
            SADJU_EXCI = entity.SADJU_EXCI,
            NAUX_CREATE = entity.NAUX_CREATE,
            NBALANCE = entity.NBALANCE,
            SBLOCK_CRE = entity.SBLOCK_CRE,
            SBLOCK_DEB = entity.SBLOCK_DEB,
            SBUDGET_IND = entity.SBUDGET_IND,
            DCOMPDATE = entity.DCOMPDATE,
            SDESCRIPT = entity.SDESCRIPT,
            SORGAN_UNIT = entity.SORGAN_UNIT,
            SSTATREGT = entity.SSTATREGT,
            NTOTAL_CRE = entity.NTOTAL_CRE,
            NTOTAL_DEB = entity.NTOTAL_DEB,
            STYPE_ACC = entity.STYPE_ACC,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static LEDGER_ACC ToEntity(this CreateLEDGER_ACCDto dto)
    {
        if (dto == null) return null!;
        return new LEDGER_ACC
        {
            SADJU_EXCI = dto.SADJU_EXCI,
            NAUX_CREATE = dto.NAUX_CREATE,
            NBALANCE = dto.NBALANCE,
            SBLOCK_CRE = dto.SBLOCK_CRE,
            SBLOCK_DEB = dto.SBLOCK_DEB,
            SBUDGET_IND = dto.SBUDGET_IND,
            DCOMPDATE = dto.DCOMPDATE,
            SDESCRIPT = dto.SDESCRIPT,
            SORGAN_UNIT = dto.SORGAN_UNIT,
            SSTATREGT = dto.SSTATREGT,
            NTOTAL_CRE = dto.NTOTAL_CRE,
            NTOTAL_DEB = dto.NTOTAL_DEB,
            STYPE_ACC = dto.STYPE_ACC,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this LEDGER_ACC entity, UpdateLEDGER_ACCDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SADJU_EXCI = dto.SADJU_EXCI;
        entity.NAUX_CREATE = dto.NAUX_CREATE;
        entity.NBALANCE = dto.NBALANCE;
        entity.SBLOCK_CRE = dto.SBLOCK_CRE;
        entity.SBLOCK_DEB = dto.SBLOCK_DEB;
        entity.SBUDGET_IND = dto.SBUDGET_IND;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.SORGAN_UNIT = dto.SORGAN_UNIT;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NTOTAL_CRE = dto.NTOTAL_CRE;
        entity.NTOTAL_DEB = dto.NTOTAL_DEB;
        entity.STYPE_ACC = dto.STYPE_ACC;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
