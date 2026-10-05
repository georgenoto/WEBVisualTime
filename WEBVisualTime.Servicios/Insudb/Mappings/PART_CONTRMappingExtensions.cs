using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PART_CONTR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PART_CONTRMappingExtensions
{
    public static PART_CONTRDto ToDto(this PART_CONTR entity)
    {
        if (entity == null) return null!;
        return new PART_CONTRDto
        {
            NTYPE_REL = entity.NTYPE_REL,
            CONTRMASTERNTYPE_RELSSTATREGT = entity.CONTRMASTERNTYPE_REL?.SSTATREGT,
            NNUMBER = entity.NNUMBER,
            CONTRMASTERNNUMBERSSTATREGT = entity.CONTRMASTERNNUMBER?.SSTATREGT,
            NBRANCH = entity.NBRANCH,
            CONTRMASTERNBRANCHSSTATREGT = entity.CONTRMASTERNBRANCH?.SSTATREGT,
            DEFFECDATE = entity.DEFFECDATE,
            NTYPE = entity.NTYPE,
            CONTRMASTERNTYPESSTATREGT = entity.CONTRMASTERNTYPE?.SSTATREGT,
            DSTARTDATE = entity.DSTARTDATE,
            NCOMPANY = entity.NCOMPANY,
            COMPANYSACCOUNT = entity.COMPANY?.SACCOUNT,
            NARR_PERD = entity.NARR_PERD,
            NCOMISION = entity.NCOMISION,
            DCOMPDATE = entity.DCOMPDATE,
            NCORREDOR = entity.NCORREDOR,
            DNULLDATE = entity.DNULLDATE,
            NPR_INOUT = entity.NPR_INOUT,
            NCL_INOUT = entity.NCL_INOUT,
            NRATE = entity.NRATE,
            NRATE_BENE = entity.NRATE_BENE,
            NSHARE = entity.NSHARE,
            NUSERCODE = entity.NUSERCODE,
            NCESSPRFIX = entity.NCESSPRFIX,
            NCESSRATE = entity.NCESSRATE,
            SROUCESS = entity.SROUCESS,
            SROUPROFIT = entity.SROUPROFIT,
            NAMOUNTPROFIT = entity.NAMOUNTPROFIT,
            SFREQPROFIT = entity.SFREQPROFIT,
            NEXCESS = entity.NEXCESS,
            NTAX = entity.NTAX,
            NEXPENSES = entity.NEXPENSES,
            NRATE_DEV = entity.NRATE_DEV,
        };
    }

    public static PART_CONTR ToEntity(this CreatePART_CONTRDto dto)
    {
        if (dto == null) return null!;
        return new PART_CONTR
        {
            NARR_PERD = dto.NARR_PERD,
            NCOMISION = dto.NCOMISION,
            DCOMPDATE = dto.DCOMPDATE,
            NCORREDOR = dto.NCORREDOR,
            DNULLDATE = dto.DNULLDATE,
            NPR_INOUT = dto.NPR_INOUT,
            NCL_INOUT = dto.NCL_INOUT,
            NRATE = dto.NRATE,
            NRATE_BENE = dto.NRATE_BENE,
            NSHARE = dto.NSHARE,
            NUSERCODE = dto.NUSERCODE,
            NCESSPRFIX = dto.NCESSPRFIX,
            NCESSRATE = dto.NCESSRATE,
            SROUCESS = dto.SROUCESS,
            SROUPROFIT = dto.SROUPROFIT,
            NAMOUNTPROFIT = dto.NAMOUNTPROFIT,
            SFREQPROFIT = dto.SFREQPROFIT,
            NEXCESS = dto.NEXCESS,
            NTAX = dto.NTAX,
            NEXPENSES = dto.NEXPENSES,
            NRATE_DEV = dto.NRATE_DEV,
        };
    }

    public static void UpdateEntity(this PART_CONTR entity, UpdatePART_CONTRDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NARR_PERD = dto.NARR_PERD;
        entity.NCOMISION = dto.NCOMISION;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NCORREDOR = dto.NCORREDOR;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NPR_INOUT = dto.NPR_INOUT;
        entity.NCL_INOUT = dto.NCL_INOUT;
        entity.NRATE = dto.NRATE;
        entity.NRATE_BENE = dto.NRATE_BENE;
        entity.NSHARE = dto.NSHARE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NCESSPRFIX = dto.NCESSPRFIX;
        entity.NCESSRATE = dto.NCESSRATE;
        entity.SROUCESS = dto.SROUCESS;
        entity.SROUPROFIT = dto.SROUPROFIT;
        entity.NAMOUNTPROFIT = dto.NAMOUNTPROFIT;
        entity.SFREQPROFIT = dto.SFREQPROFIT;
        entity.NEXCESS = dto.NEXCESS;
        entity.NTAX = dto.NTAX;
        entity.NEXPENSES = dto.NEXPENSES;
        entity.NRATE_DEV = dto.NRATE_DEV;
    }
}
