using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.T_BANK_TRANS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class T_BANK_TRANSMappingExtensions
{
    public static T_BANK_TRANSDto ToDto(this T_BANK_TRANS entity)
    {
        if (entity == null) return null!;
        return new T_BANK_TRANSDto
        {
            NBORDEREAUX = entity.NBORDEREAUX,
            COLFORMREFSTYPE = entity.COLFORMREF?.STYPE,
            NSEQUENCE = entity.NSEQUENCE,
            NACC_BANK = entity.NACC_BANK,
            NACC_TYPE = entity.NACC_TYPE,
            SACCO_NUM = entity.SACCO_NUM,
            NBANK_CODE = entity.NBANK_CODE,
            NBK_AGENCY = entity.NBK_AGENCY,
            SCLIENT = entity.SCLIENT,
            NMOVEMENT = entity.NMOVEMENT,
            DEFFECDATE = entity.DEFFECDATE,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NEXCHANGE = entity.NEXCHANGE,
            SACTION = entity.SACTION,
        };
    }

    public static T_BANK_TRANS ToEntity(this CreateT_BANK_TRANSDto dto)
    {
        if (dto == null) return null!;
        return new T_BANK_TRANS
        {
            NACC_BANK = dto.NACC_BANK,
            NACC_TYPE = dto.NACC_TYPE,
            SACCO_NUM = dto.SACCO_NUM,
            NBANK_CODE = dto.NBANK_CODE,
            NBK_AGENCY = dto.NBK_AGENCY,
            SCLIENT = dto.SCLIENT,
            NMOVEMENT = dto.NMOVEMENT,
            DEFFECDATE = dto.DEFFECDATE,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NEXCHANGE = dto.NEXCHANGE,
            SACTION = dto.SACTION,
        };
    }

    public static void UpdateEntity(this T_BANK_TRANS entity, UpdateT_BANK_TRANSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NACC_BANK = dto.NACC_BANK;
        entity.NACC_TYPE = dto.NACC_TYPE;
        entity.SACCO_NUM = dto.SACCO_NUM;
        entity.NBANK_CODE = dto.NBANK_CODE;
        entity.NBK_AGENCY = dto.NBK_AGENCY;
        entity.SCLIENT = dto.SCLIENT;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NEXCHANGE = dto.NEXCHANGE;
        entity.SACTION = dto.SACTION;
    }
}
