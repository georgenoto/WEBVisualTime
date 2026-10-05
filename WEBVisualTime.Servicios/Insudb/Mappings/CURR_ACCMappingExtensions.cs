using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CURR_ACC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CURR_ACCMappingExtensions
{
    public static CURR_ACCDto ToDto(this CURR_ACC entity)
    {
        if (entity == null) return null!;
        return new CURR_ACCDto
        {
            NTYP_ACCO = entity.NTYP_ACCO,
            TABLE400SDESCRIPT = entity.TABLE400?.SDESCRIPT,
            STYPE_ACC = entity.STYPE_ACC,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NCURRENCY = entity.NCURRENCY,
            NBALANCE = entity.NBALANCE,
            NCREDIT = entity.NCREDIT,
            NDEBIT = entity.NDEBIT,
            DEFFECDATE = entity.DEFFECDATE,
            SSTATREGT = entity.SSTATREGT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NLED_COMPAN = entity.NLED_COMPAN,
            LEDGER_ACCNLED_COMPANSADJU_EXCI = entity.LEDGER_ACCNLED_COMPAN?.SADJU_EXCI,
            SACCOUNT = entity.SACCOUNT,
            LEDGER_ACCSACCOUNTSADJU_EXCI = entity.LEDGER_ACCSACCOUNT?.SADJU_EXCI,
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NCOMPANY = entity.NCOMPANY,
            COMPANYSACCOUNT = entity.COMPANY?.SACCOUNT,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            SAUX_ACCOUN = entity.SAUX_ACCOUN,
            LEDGER_ACCSAUX_ACCOUNSADJU_EXCI = entity.LEDGER_ACCSAUX_ACCOUN?.SADJU_EXCI,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NINSUR_AREA = entity.NINSUR_AREA,
            TABLE5001SDESCRIPT = entity.TABLE5001?.SDESCRIPT,
        };
    }

    public static CURR_ACC ToEntity(this CreateCURR_ACCDto dto)
    {
        if (dto == null) return null!;
        return new CURR_ACC
        {
            NBALANCE = dto.NBALANCE,
            NCREDIT = dto.NCREDIT,
            NDEBIT = dto.NDEBIT,
            DEFFECDATE = dto.DEFFECDATE,
            SSTATREGT = dto.SSTATREGT,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NLED_COMPAN = dto.NLED_COMPAN,
            SACCOUNT = dto.SACCOUNT,
            SCERTYPE = dto.SCERTYPE,
            NCOMPANY = dto.NCOMPANY,
            NPRODUCT = dto.NPRODUCT,
            SAUX_ACCOUN = dto.SAUX_ACCOUN,
            NBRANCH = dto.NBRANCH,
            NCERTIF = dto.NCERTIF,
            NPOLICY = dto.NPOLICY,
            NINSUR_AREA = dto.NINSUR_AREA,
        };
    }

    public static void UpdateEntity(this CURR_ACC entity, UpdateCURR_ACCDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NBALANCE = dto.NBALANCE;
        entity.NCREDIT = dto.NCREDIT;
        entity.NDEBIT = dto.NDEBIT;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NLED_COMPAN = dto.NLED_COMPAN;
        entity.SACCOUNT = dto.SACCOUNT;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.SAUX_ACCOUN = dto.SAUX_ACCOUN;
        entity.NBRANCH = dto.NBRANCH;
        entity.NCERTIF = dto.NCERTIF;
        entity.NPOLICY = dto.NPOLICY;
        entity.NINSUR_AREA = dto.NINSUR_AREA;
    }
}
