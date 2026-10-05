using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIALLOCLA;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLIALLOCLAMappingExtensions
{
    public static CLIALLOCLADto ToDto(this CLIALLOCLA entity)
    {
        if (entity == null) return null!;
        return new CLIALLOCLADto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NROLE = entity.NROLE,
            TABLE12SDESCRIPT = entity.TABLE12?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            SREQUIRE = entity.SREQUIRE,
            NUSERCODE = entity.NUSERCODE,
            NMAXNUM_ROL = entity.NMAXNUM_ROL,
            SIND_CRECLI = entity.SIND_CRECLI,
            SDEFAULT_CLA_IND = entity.SDEFAULT_CLA_IND,
        };
    }

    public static CLIALLOCLA ToEntity(this CreateCLIALLOCLADto dto)
    {
        if (dto == null) return null!;
        return new CLIALLOCLA
        {
            DCOMPDATE = dto.DCOMPDATE,
            SREQUIRE = dto.SREQUIRE,
            NUSERCODE = dto.NUSERCODE,
            NMAXNUM_ROL = dto.NMAXNUM_ROL,
            SIND_CRECLI = dto.SIND_CRECLI,
            SDEFAULT_CLA_IND = dto.SDEFAULT_CLA_IND,
        };
    }

    public static void UpdateEntity(this CLIALLOCLA entity, UpdateCLIALLOCLADto dto)
    {
        if (entity == null || dto == null) return;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SREQUIRE = dto.SREQUIRE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NMAXNUM_ROL = dto.NMAXNUM_ROL;
        entity.SIND_CRECLI = dto.SIND_CRECLI;
        entity.SDEFAULT_CLA_IND = dto.SDEFAULT_CLA_IND;
    }
}
