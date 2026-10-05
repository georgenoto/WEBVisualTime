using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_ACC;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BANK_ACCMappingExtensions
{
    public static BANK_ACCDto ToDto(this BANK_ACC entity)
    {
        if (entity == null) return null!;
        return new BANK_ACCDto
        {
            NACC_BANK = entity.NACC_BANK,
            SACC_LEDGER = entity.SACC_LEDGER,
            NBANK_CODE = entity.NBANK_CODE,
            TAB_BK_AGENBANK_CODESDESCRIPT = entity.TAB_BK_AGENBANK_CODE?.SDESCRIPT,
            NBK_AGENCY = entity.NBK_AGENCY,
            TAB_BK_AGENBK_AGENCYSDESCRIPT = entity.TAB_BK_AGENBK_AGENCY?.SDESCRIPT,
            SACC_NUMBER = entity.SACC_NUMBER,
            SAUX_ACCOUN = entity.SAUX_ACCOUN,
            NACC_TYPE = entity.NACC_TYPE,
            TABLE190SDESCRIPT = entity.TABLE190?.SDESCRIPT,
            NAVAILABLE = entity.NAVAILABLE,
            DCOMPDATE = entity.DCOMPDATE,
            NAVAIL_TYPE = entity.NAVAIL_TYPE,
            TABLE197SDESCRIPT = entity.TABLE197?.SDESCRIPT,
            NCURRENCY = entity.NCURRENCY,
            DEFFECDATE = entity.DEFFECDATE,
            NLED_COMPAN = entity.NLED_COMPAN,
            NOFFICE = entity.NOFFICE,
            NTRANSIT_1 = entity.NTRANSIT_1,
            NTRANSIT_2 = entity.NTRANSIT_2,
            NTRANSIT_3 = entity.NTRANSIT_3,
            NTRANSIT_4 = entity.NTRANSIT_4,
            NTRANSIT_5 = entity.NTRANSIT_5,
            NUSERCODE = entity.NUSERCODE,
            SSTATREGT = entity.SSTATREGT,
            NCOMPANY = entity.NCOMPANY,
            COMPANYSACCOUNT = entity.COMPANY?.SACCOUNT,
            DREALDEP = entity.DREALDEP,
        };
    }

    public static BANK_ACC ToEntity(this CreateBANK_ACCDto dto)
    {
        if (dto == null) return null!;
        return new BANK_ACC
        {
            SACC_LEDGER = dto.SACC_LEDGER,
            NBANK_CODE = dto.NBANK_CODE,
            NBK_AGENCY = dto.NBK_AGENCY,
            SACC_NUMBER = dto.SACC_NUMBER,
            SAUX_ACCOUN = dto.SAUX_ACCOUN,
            NACC_TYPE = dto.NACC_TYPE,
            NAVAILABLE = dto.NAVAILABLE,
            DCOMPDATE = dto.DCOMPDATE,
            NAVAIL_TYPE = dto.NAVAIL_TYPE,
            NCURRENCY = dto.NCURRENCY,
            DEFFECDATE = dto.DEFFECDATE,
            NLED_COMPAN = dto.NLED_COMPAN,
            NOFFICE = dto.NOFFICE,
            NTRANSIT_1 = dto.NTRANSIT_1,
            NTRANSIT_2 = dto.NTRANSIT_2,
            NTRANSIT_3 = dto.NTRANSIT_3,
            NTRANSIT_4 = dto.NTRANSIT_4,
            NTRANSIT_5 = dto.NTRANSIT_5,
            NUSERCODE = dto.NUSERCODE,
            SSTATREGT = dto.SSTATREGT,
            NCOMPANY = dto.NCOMPANY,
            DREALDEP = dto.DREALDEP,
        };
    }

    public static void UpdateEntity(this BANK_ACC entity, UpdateBANK_ACCDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SACC_LEDGER = dto.SACC_LEDGER;
        entity.NBANK_CODE = dto.NBANK_CODE;
        entity.NBK_AGENCY = dto.NBK_AGENCY;
        entity.SACC_NUMBER = dto.SACC_NUMBER;
        entity.SAUX_ACCOUN = dto.SAUX_ACCOUN;
        entity.NACC_TYPE = dto.NACC_TYPE;
        entity.NAVAILABLE = dto.NAVAILABLE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NAVAIL_TYPE = dto.NAVAIL_TYPE;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.DEFFECDATE = dto.DEFFECDATE;
        entity.NLED_COMPAN = dto.NLED_COMPAN;
        entity.NOFFICE = dto.NOFFICE;
        entity.NTRANSIT_1 = dto.NTRANSIT_1;
        entity.NTRANSIT_2 = dto.NTRANSIT_2;
        entity.NTRANSIT_3 = dto.NTRANSIT_3;
        entity.NTRANSIT_4 = dto.NTRANSIT_4;
        entity.NTRANSIT_5 = dto.NTRANSIT_5;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.NCOMPANY = dto.NCOMPANY;
        entity.DREALDEP = dto.DREALDEP;
    }
}
