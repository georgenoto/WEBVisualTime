using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMM_TOT;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COMM_TOTMappingExtensions
{
    public static COMM_TOTDto ToDto(this COMM_TOT entity)
    {
        if (entity == null) return null!;
        return new COMM_TOTDto
        {
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            NRECEIPT = entity.NRECEIPT,
            SCERTYPE = entity.SCERTYPE,
            CERTIFICATSCERTYPESCUMUL_CODE = entity.CERTIFICATSCERTYPE?.SCUMUL_CODE,
            NBRANCH = entity.NBRANCH,
            CERTIFICATNBRANCHSCUMUL_CODE = entity.CERTIFICATNBRANCH?.SCUMUL_CODE,
            NPRODUCT = entity.NPRODUCT,
            CERTIFICATNPRODUCTSCUMUL_CODE = entity.CERTIFICATNPRODUCT?.SCUMUL_CODE,
            NPOLICY = entity.NPOLICY,
            CERTIFICATNPOLICYSCUMUL_CODE = entity.CERTIFICATNPOLICY?.SCUMUL_CODE,
            NCERTIF = entity.NCERTIF,
            CERTIFICATNCERTIFSCUMUL_CODE = entity.CERTIFICATNCERTIF?.SCUMUL_CODE,
            NDIGIT = entity.NDIGIT,
            NPAYNUMBE = entity.NPAYNUMBE,
            NCOMM = entity.NCOMM,
            NMOVNUMBE = entity.NMOVNUMBE,
            NTOTALPREMIUM = entity.NTOTALPREMIUM,
            NTOTALCOMM = entity.NTOTALCOMM,
        };
    }

    public static COMM_TOT ToEntity(this CreateCOMM_TOTDto dto)
    {
        if (dto == null) return null!;
        return new COMM_TOT
        {
            NINTERMED = dto.NINTERMED,
            NRECEIPT = dto.NRECEIPT,
            SCERTYPE = dto.SCERTYPE,
            NBRANCH = dto.NBRANCH,
            NPRODUCT = dto.NPRODUCT,
            NPOLICY = dto.NPOLICY,
            NCERTIF = dto.NCERTIF,
            NDIGIT = dto.NDIGIT,
            NPAYNUMBE = dto.NPAYNUMBE,
            NMOVNUMBE = dto.NMOVNUMBE,
            NTOTALPREMIUM = dto.NTOTALPREMIUM,
            NTOTALCOMM = dto.NTOTALCOMM,
        };
    }

    public static void UpdateEntity(this COMM_TOT entity, UpdateCOMM_TOTDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NINTERMED = dto.NINTERMED;
        entity.NRECEIPT = dto.NRECEIPT;
        entity.SCERTYPE = dto.SCERTYPE;
        entity.NBRANCH = dto.NBRANCH;
        entity.NPRODUCT = dto.NPRODUCT;
        entity.NPOLICY = dto.NPOLICY;
        entity.NCERTIF = dto.NCERTIF;
        entity.NDIGIT = dto.NDIGIT;
        entity.NPAYNUMBE = dto.NPAYNUMBE;
        entity.NMOVNUMBE = dto.NMOVNUMBE;
        entity.NTOTALPREMIUM = dto.NTOTALPREMIUM;
        entity.NTOTALCOMM = dto.NTOTALCOMM;
    }
}
