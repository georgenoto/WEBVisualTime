using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_ACC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CASH_ACCMappingExtensions
{
    public static CASH_ACCDto ToDto(this CASH_ACC entity)
    {
        if (entity == null) return null!;
        return new CASH_ACCDto
        {
            NACC_CASH = entity.NACC_CASH,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NLED_COMPAN = entity.NLED_COMPAN,
            LEDGER_ACCNLED_COMPANSADJU_EXCI = entity.LEDGER_ACCNLED_COMPAN?.SADJU_EXCI,
            SACCOUNT = entity.SACCOUNT,
            LEDGER_ACCSACCOUNTSADJU_EXCI = entity.LEDGER_ACCSACCOUNT?.SADJU_EXCI,
            NCURRENCY = entity.NCURRENCY,
            DEFFECDATE = entity.DEFFECDATE,
            SAUX_ACCOUN = entity.SAUX_ACCOUN,
            LEDGER_ACCSAUX_ACCOUNSADJU_EXCI = entity.LEDGER_ACCSAUX_ACCOUN?.SADJU_EXCI,
            DCOMPDATE = entity.DCOMPDATE,
            NAVAILABLE = entity.NAVAILABLE,
            NUSERCODE = entity.NUSERCODE,
            SSTATREGT = entity.SSTATREGT,
            NCASHNUM = entity.NCASHNUM,
            NMIN_AMOUNT = entity.NMIN_AMOUNT,
            NCOMPANY = entity.NCOMPANY,
            COMPANYSACCOUNT = entity.COMPANY?.SACCOUNT,
            NTYPECASH = entity.NTYPECASH,
        };
    }

    public static CASH_ACC ToEntity(this CreateCASH_ACCDto dto)
    {
        if (dto == null) return null!;
        return new CASH_ACC
        {
            NLED_COMPAN = dto.NLED_COMPAN,
            SACCOUNT = dto.SACCOUNT,
            DEFFECDATE = dto.DEFFECDATE,
            SAUX_ACCOUN = dto.SAUX_ACCOUN,
            DCOMPDATE = dto.DCOMPDATE,
            NAVAILABLE = dto.NAVAILABLE,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
            NMIN_AMOUNT = dto.NMIN_AMOUNT,
            NCOMPANY = dto.NCOMPANY,
            NTYPECASH = dto.NTYPECASH,
        };
    }

    public static void UpdateEntity(this CASH_ACC entity, UpdateCASH_ACCDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NLED_COMPAN = dto.NLED_COMPAN;
        entity.SACCOUNT = dto.SACCOUNT;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.SAUX_ACCOUN = dto.SAUX_ACCOUN;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NAVAILABLE = dto.NAVAILABLE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NMIN_AMOUNT = dto.NMIN_AMOUNT;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.NTYPECASH = dto.NTYPECASH;
    }
}
