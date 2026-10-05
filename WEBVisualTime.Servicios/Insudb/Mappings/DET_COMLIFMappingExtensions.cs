using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DET_COMLIF;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DET_COMLIFMappingExtensions
{
    public static DET_COMLIFDto ToDto(this DET_COMLIF entity)
    {
        if (entity == null) return null!;
        return new DET_COMLIFDto
        {
            NCOMTABLI = entity.NCOMTABLI,
            TAB_COMLIFSDESCRIPT = entity.TAB_COMLIF?.SDESCRIPT,
            NBRANCH = entity.NBRANCH,
            TABLE10SDESCRIPT = entity.TABLE10?.SDESCRIPT,
            NPRODUCT = entity.NPRODUCT,
            NPOLICY_DUR = entity.NPOLICY_DUR,
            NMIN_DURAT = entity.NMIN_DURAT,
            DEFFECDATE = entity.DEFFECDATE,
            NPERCENT = entity.NPERCENT,
            DCOMPDATE = entity.DCOMPDATE,
            NWAY_PAY = entity.NWAY_PAY,
            NSELLCHANNEL = entity.NSELLCHANNEL,
            NUSERCODE = entity.NUSERCODE,
            DNULLDATE = entity.DNULLDATE,
            NCOVER = entity.NCOVER,
            NMAX_DURAT = entity.NMAX_DURAT,
            NMODULEC = entity.NMODULEC,
            NCURRENCY = entity.NCURRENCY,
            NAMOUNT = entity.NAMOUNT,
            NAGE_INIT = entity.NAGE_INIT,
            NAGE_END = entity.NAGE_END,
            NTYPE_CONTRAT = entity.NTYPE_CONTRAT,
            TABLE9108SDESCRIPT = entity.TABLE9108?.SDESCRIPT,
            SROUTINE = entity.SROUTINE,
            NLIFE_SCHE = entity.NLIFE_SCHE,
            NTYPCOMMIS = entity.NTYPCOMMIS,
            TABLE5662SDESCRIPT = entity.TABLE5662?.SDESCRIPT,
            NPERC_PAY = entity.NPERC_PAY,
            NTYPERISK = entity.NTYPERISK,
            TABLE5639SDESCRIPT = entity.TABLE5639?.SDESCRIPT,
            SSMOKING = entity.SSMOKING,
            NCAPITAL_INIT = entity.NCAPITAL_INIT,
            NCAPITAL_END = entity.NCAPITAL_END,
            NAMOUNTLIM = entity.NAMOUNTLIM,
            NDRCOMM = entity.NDRCOMM,
            NIDCOMM = entity.NIDCOMM,
            NCATEGORY = entity.NCATEGORY,
            TABLE9202SDESCRIPT = entity.TABLE9202?.SDESCRIPT,
        };
    }

    public static DET_COMLIF ToEntity(this CreateDET_COMLIFDto dto)
    {
        if (dto == null) return null!;
        return new DET_COMLIF
        {
            NPERCENT = dto.NPERCENT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            DNULLDATE = dto.DNULLDATE,
            NMAX_DURAT = dto.NMAX_DURAT,
            NCURRENCY = dto.NCURRENCY,
            NAMOUNT = dto.NAMOUNT,
            NAGE_INIT = dto.NAGE_INIT,
            NAGE_END = dto.NAGE_END,
            SROUTINE = dto.SROUTINE,
            NLIFE_SCHE = dto.NLIFE_SCHE,
            NTYPCOMMIS = dto.NTYPCOMMIS,
            NPERC_PAY = dto.NPERC_PAY,
            NTYPERISK = dto.NTYPERISK,
            SSMOKING = dto.SSMOKING,
            NCAPITAL_INIT = dto.NCAPITAL_INIT,
            NCAPITAL_END = dto.NCAPITAL_END,
            NAMOUNTLIM = dto.NAMOUNTLIM,
            NDRCOMM = dto.NDRCOMM,
            NIDCOMM = dto.NIDCOMM,
        };
    }

    public static void UpdateEntity(this DET_COMLIF entity, UpdateDET_COMLIFDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NPERCENT = dto.NPERCENT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NMAX_DURAT = dto.NMAX_DURAT;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NAMOUNT = dto.NAMOUNT;
        entity.NAGE_INIT = dto.NAGE_INIT;
        entity.NAGE_END = dto.NAGE_END;
        entity.SROUTINE = dto.SROUTINE;
        entity.NLIFE_SCHE = dto.NLIFE_SCHE;
        entity.NTYPCOMMIS = dto.NTYPCOMMIS;
        entity.NPERC_PAY = dto.NPERC_PAY;
        entity.NTYPERISK = dto.NTYPERISK;
        entity.SSMOKING = dto.SSMOKING;
        entity.NCAPITAL_INIT = dto.NCAPITAL_INIT;
        entity.NCAPITAL_END = dto.NCAPITAL_END;
        entity.NAMOUNTLIM = dto.NAMOUNTLIM;
        entity.NDRCOMM = dto.NDRCOMM;
        entity.NIDCOMM = dto.NIDCOMM;
    }
}
