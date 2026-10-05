using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_AGREE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class BANK_AGREEMappingExtensions
{
    public static BANK_AGREEDto ToDto(this BANK_AGREE entity)
    {
        if (entity == null) return null!;
        return new BANK_AGREEDto
        {
            STYPE_BANKAGREE = entity.STYPE_BANKAGREE,
            NBANK = entity.NBANK,
            TABLE7SDESCRIPT = entity.TABLE7?.SDESCRIPT,
            NACCOUNT = entity.NACCOUNT,
            BANK_ACCSACC_LEDGER = entity.BANK_ACC?.SACC_LEDGER,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NNUMDIGIT = entity.NNUMDIGIT,
            SFORMAT = entity.SFORMAT,
        };
    }

    public static BANK_AGREE ToEntity(this CreateBANK_AGREEDto dto)
    {
        if (dto == null) return null!;
        return new BANK_AGREE
        {
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SCLIENT = dto.SCLIENT,
            NNUMDIGIT = dto.NNUMDIGIT,
            SFORMAT = dto.SFORMAT,
        };
    }

    public static void UpdateEntity(this BANK_AGREE entity, UpdateBANK_AGREEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCLIENT = dto.SCLIENT;
        entity.NNUMDIGIT = dto.NNUMDIGIT;
        entity.SFORMAT = dto.SFORMAT;
    }
}
