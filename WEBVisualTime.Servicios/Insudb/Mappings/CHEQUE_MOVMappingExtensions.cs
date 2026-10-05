using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CHEQUE_MOV;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CHEQUE_MOVMappingExtensions
{
    public static CHEQUE_MOVDto ToDto(this CHEQUE_MOV entity)
    {
        if (entity == null) return null!;
        return new CHEQUE_MOVDto
        {
            NCOMPANY = entity.NCOMPANY,
            COMPANYSACCOUNT = entity.COMPANY?.SACCOUNT,
            NBANK_CODE = entity.NBANK_CODE,
            TABLE7NBANK_CODESDESCRIPT = entity.TABLE7NBANK_CODE?.SDESCRIPT,
            SCHEQUENU = entity.SCHEQUENU,
            DEFFECDATE = entity.DEFFECDATE,
            NCHEOPERTYP = entity.NCHEOPERTYP,
            NCHEOPER_REASON = entity.NCHEOPER_REASON,
            TABLE5577SDESCRIPT = entity.TABLE5577?.SDESCRIPT,
            NID = entity.NID,
            NBANK_INTER = entity.NBANK_INTER,
            TABLE7NBANK_INTERSDESCRIPT = entity.TABLE7NBANK_INTER?.SDESCRIPT,
            SCHEQUEINTER = entity.SCHEQUEINTER,
            DNEW_DATE = entity.DNEW_DATE,
            SDEPNUMBER = entity.SDEPNUMBER,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NFIN_INT = entity.NFIN_INT,
            NNOTENUM = entity.NNOTENUM,
        };
    }

    public static CHEQUE_MOV ToEntity(this CreateCHEQUE_MOVDto dto)
    {
        if (dto == null) return null!;
        return new CHEQUE_MOV
        {
            NCHEOPER_REASON = dto.NCHEOPER_REASON,
            NBANK_INTER = dto.NBANK_INTER,
            SCHEQUEINTER = dto.SCHEQUEINTER,
            DNEW_DATE = dto.DNEW_DATE,
            SDEPNUMBER = dto.SDEPNUMBER,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NFIN_INT = dto.NFIN_INT,
            NNOTENUM = dto.NNOTENUM,
        };
    }

    public static void UpdateEntity(this CHEQUE_MOV entity, UpdateCHEQUE_MOVDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCHEOPER_REASON = dto.NCHEOPER_REASON;
        entity.NBANK_INTER = dto.NBANK_INTER;
        entity.SCHEQUEINTER = dto.SCHEQUEINTER;
        entity.DNEW_DATE = dto.DNEW_DATE;
        entity.SDEPNUMBER = dto.SDEPNUMBER;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NFIN_INT = dto.NFIN_INT;
        entity.NNOTENUM = dto.NNOTENUM;
    }
}
