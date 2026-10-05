using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MODULES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MODULESMappingExtensions
{
    public static MODULESDto ToDto(this MODULES entity)
    {
        if (entity == null) return null!;
        return new MODULESDto
        {
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
            NGROUP_INSU = entity.NGROUP_INSU,
            NMODULEC = entity.NMODULEC,
            DEFFECDATE = entity.DEFFECDATE,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NUSERCODE = entity.NUSERCODE,
            SCHANGEI = entity.SCHANGEI,
            NCURRENCY = entity.NCURRENCY,
            NPREMIRAT = entity.NPREMIRAT,
            STYP_RAT = entity.STYP_RAT,
            SINHERIT = entity.SINHERIT,
            NGEOGRAPHAREA = entity.NGEOGRAPHAREA,
            TABLE9214SDESCRIPT = entity.TABLE9214?.SDESCRIPT,
            NATTENSYSTEM = entity.NATTENSYSTEM,
            TABLE9215SDESCRIPT = entity.TABLE9215?.SDESCRIPT,
            NMOVEMENT = entity.NMOVEMENT,
            NMOVEMENT_NULL = entity.NMOVEMENT_NULL,
        };
    }

    public static MODULES ToEntity(this CreateMODULESDto dto)
    {
        if (dto == null) return null!;
        return new MODULES
        {
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NUSERCODE = dto.NUSERCODE,
            SCHANGEI = dto.SCHANGEI,
            NCURRENCY = dto.NCURRENCY,
            NPREMIRAT = dto.NPREMIRAT,
            STYP_RAT = dto.STYP_RAT,
            SINHERIT = dto.SINHERIT,
            NGEOGRAPHAREA = dto.NGEOGRAPHAREA,
            NATTENSYSTEM = dto.NATTENSYSTEM,
            NMOVEMENT = dto.NMOVEMENT,
            NMOVEMENT_NULL = dto.NMOVEMENT_NULL,
        };
    }

    public static void UpdateEntity(this MODULES entity, UpdateMODULESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCHANGEI = dto.SCHANGEI;
        entity.NCURRENCY = dto.NCURRENCY;
        entity.NPREMIRAT = dto.NPREMIRAT;
        entity.STYP_RAT = dto.STYP_RAT;
        entity.SINHERIT = dto.SINHERIT;
        entity.NGEOGRAPHAREA = dto.NGEOGRAPHAREA;
        entity.NATTENSYSTEM = dto.NATTENSYSTEM;
        entity.NMOVEMENT = dto.NMOVEMENT;
        entity.NMOVEMENT_NULL = dto.NMOVEMENT_NULL;
    }
}
