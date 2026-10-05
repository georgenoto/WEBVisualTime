using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANCE_CO;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class FINANCE_COMappingExtensions
{
    public static FINANCE_CODto ToDto(this FINANCE_CO entity)
    {
        if (entity == null) return null!;
        return new FINANCE_CODto
        {
            NAMOUNT = entity.NAMOUNT,
            NFRECUENCY = entity.NFRECUENCY,
            TABLE250SDESCRIPT = entity.TABLE250?.SDESCRIPT,
            NAMOUNT_D = entity.NAMOUNT_D,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DCOMPDATE = entity.DCOMPDATE,
            NCONTRAT = entity.NCONTRAT,
            NCURRENCY = entity.NCURRENCY,
            DEFFECDATE = entity.DEFFECDATE,
            DDATE_PRINT = entity.DDATE_PRINT,
            NDSCTO_AMO = entity.NDSCTO_AMO,
            NSTAT_CONTR = entity.NSTAT_CONTR,
            TABLE278SDESCRIPT = entity.TABLE278?.SDESCRIPT,
            DFIRST_DRAF = entity.DFIRST_DRAF,
            NINITIAL = entity.NINITIAL,
            NINITIAL_OR = entity.NINITIAL_OR,
            NINTEREST = entity.NINTEREST,
            DLEDGER_DAT = entity.DLEDGER_DAT,
            NNOTENUM = entity.NNOTENUM,
            DNULLDATE = entity.DNULLDATE,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            SOPT_COMMI = entity.SOPT_COMMI,
            SPAYMENT_IN = entity.SPAYMENT_IN,
            NQ_DRAFT = entity.NQ_DRAFT,
            SWAIT_CONTR = entity.SWAIT_CONTR,
            NUSERCODE = entity.NUSERCODE,
            USERSSACCESSWO = entity.USERS?.SACCESSWO,
            NBILL_DAY = entity.NBILL_DAY,
            NWAY_PAY = entity.NWAY_PAY,
            TABLE5002SDESCRIPT = entity.TABLE5002?.SDESCRIPT,
            NCOD_AGREE = entity.NCOD_AGREE,
            STYPE_CONTR = entity.STYPE_CONTR,
            NPOLICY = entity.NPOLICY,
            SORIGIN = entity.SORIGIN,
        };
    }

    public static FINANCE_CO ToEntity(this CreateFINANCE_CODto dto)
    {
        if (dto == null) return null!;
        return new FINANCE_CO
        {
            NAMOUNT = dto.NAMOUNT,
            NFRECUENCY = dto.NFRECUENCY,
            NAMOUNT_D = dto.NAMOUNT_D,
            SCLIENT = dto.SCLIENT,
            DCOMPDATE = dto.DCOMPDATE,
            NCURRENCY = dto.NCURRENCY,
            DDATE_PRINT = dto.DDATE_PRINT,
            NDSCTO_AMO = dto.NDSCTO_AMO,
            NSTAT_CONTR = dto.NSTAT_CONTR,
            DFIRST_DRAF = dto.DFIRST_DRAF,
            NINITIAL = dto.NINITIAL,
            NINITIAL_OR = dto.NINITIAL_OR,
            NINTEREST = dto.NINTEREST,
            DLEDGER_DAT = dto.DLEDGER_DAT,
            NNOTENUM = dto.NNOTENUM,
            DNULLDATE = dto.DNULLDATE,
            NOFFICE = dto.NOFFICE,
            SOPT_COMMI = dto.SOPT_COMMI,
            SPAYMENT_IN = dto.SPAYMENT_IN,
            NQ_DRAFT = dto.NQ_DRAFT,
            SWAIT_CONTR = dto.SWAIT_CONTR,
            NUSERCODE = dto.NUSERCODE,
            NBILL_DAY = dto.NBILL_DAY,
            NWAY_PAY = dto.NWAY_PAY,
            NCOD_AGREE = dto.NCOD_AGREE,
            STYPE_CONTR = dto.STYPE_CONTR,
            NPOLICY = dto.NPOLICY,
            SORIGIN = dto.SORIGIN,
        };
    }

    public static void UpdateEntity(this FINANCE_CO entity, UpdateFINANCE_CODto dto)
    {
        if (entity == null || dto == null) return;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NFRECUENCY = dto.NFRECUENCY;
        entity.NAMOUNT_D = dto.NAMOUNT_D;
        entity.SCLIENT = dto.SCLIENT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.DDATE_PRINT = dto.DDATE_PRINT;
        entity.NDSCTO_AMO = dto.NDSCTO_AMO;
        entity.NSTAT_CONTR = dto.NSTAT_CONTR;
        entity.DFIRST_DRAF = dto.DFIRST_DRAF;
        entity.NINITIAL = dto.NINITIAL;
        entity.NINITIAL_OR = dto.NINITIAL_OR;
        entity.NINTEREST = dto.NINTEREST;
        entity.DLEDGER_DAT = dto.DLEDGER_DAT;
        entity.NNOTENUM = dto.NNOTENUM;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NOFFICE = dto.NOFFICE;
        entity.SOPT_COMMI = dto.SOPT_COMMI;
        entity.SPAYMENT_IN = dto.SPAYMENT_IN;
        entity.NQ_DRAFT = dto.NQ_DRAFT;
        entity.SWAIT_CONTR = dto.SWAIT_CONTR;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NBILL_DAY = dto.NBILL_DAY;
        entity.NWAY_PAY = dto.NWAY_PAY;
        entity.NCOD_AGREE = dto.NCOD_AGREE;
        entity.STYPE_CONTR = dto.STYPE_CONTR;
        entity.NPOLICY = dto.NPOLICY;
        entity.SORIGIN = dto.SORIGIN;
    }
}
