using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FREQ_WAY_PROD;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class FREQ_WAY_PRODMappingExtensions
{
    public static FREQ_WAY_PRODDto ToDto(this FREQ_WAY_PROD entity)
    {
        if (entity == null) return null!;
        return new FREQ_WAY_PRODDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NWAY_PAY = entity.NWAY_PAY,
            TABLE5002SDESCRIPT = entity.TABLE5002?.SDESCRIPT,
            NPAYFREQ = entity.NPAYFREQ,
            TABLE36SDESCRIPT = entity.TABLE36?.SDESCRIPT,
            DEFFECDATE = entity.DEFFECDATE,
            NCURRENCY = entity.NCURRENCY,
            NPRE_ISSUE = entity.NPRE_ISSUE,
            NPRE_AMEND = entity.NPRE_AMEND,
            DNULLDATE = entity.DNULLDATE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NLIMIT_EXCTAX = entity.NLIMIT_EXCTAX,
            NQPREM_BAS_ANN = entity.NQPREM_BAS_ANN,
            SIVA_COVER_IND = entity.SIVA_COVER_IND,
            SNO_SELL = entity.SNO_SELL,
            NPRE_COVEREXT = entity.NPRE_COVEREXT,
            NPRE_ISSUEMAX = entity.NPRE_ISSUEMAX,
            NDISC_PAYMETH = entity.NDISC_PAYMETH,
        };
    }

    public static FREQ_WAY_PROD ToEntity(this CreateFREQ_WAY_PRODDto dto)
    {
        if (dto == null) return null!;
        return new FREQ_WAY_PROD
        {
            NCURRENCY = dto.NCURRENCY,
            NPRE_ISSUE = dto.NPRE_ISSUE,
            NPRE_AMEND = dto.NPRE_AMEND,
            DNULLDATE = dto.DNULLDATE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NLIMIT_EXCTAX = dto.NLIMIT_EXCTAX,
            NQPREM_BAS_ANN = dto.NQPREM_BAS_ANN,
            SIVA_COVER_IND = dto.SIVA_COVER_IND,
            SNO_SELL = dto.SNO_SELL,
            NPRE_COVEREXT = dto.NPRE_COVEREXT,
            NPRE_ISSUEMAX = dto.NPRE_ISSUEMAX,
            NDISC_PAYMETH = dto.NDISC_PAYMETH,
        };
    }

    public static void UpdateEntity(this FREQ_WAY_PROD entity, UpdateFREQ_WAY_PRODDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NPRE_ISSUE = dto.NPRE_ISSUE;
        entity.NPRE_AMEND = dto.NPRE_AMEND;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NLIMIT_EXCTAX = dto.NLIMIT_EXCTAX;
        entity.NQPREM_BAS_ANN = dto.NQPREM_BAS_ANN;
        entity.SIVA_COVER_IND = dto.SIVA_COVER_IND;
        entity.SNO_SELL = dto.SNO_SELL;
        entity.NPRE_COVEREXT = dto.NPRE_COVEREXT;
        entity.NPRE_ISSUEMAX = dto.NPRE_ISSUEMAX;
        entity.NDISC_PAYMETH = dto.NDISC_PAYMETH;
    }
}
