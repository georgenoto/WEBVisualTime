using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_HIS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class CLAIM_SETT_HISMappingExtensions
{
    public static CLAIM_SETT_HISDto ToDto(this CLAIM_SETT_HIS entity)
    {
        if (entity == null) return null!;
        return new CLAIM_SETT_HISDto
        {
            NSETTLEMENT_NUM = entity.NSETTLEMENT_NUM,
            NTRANSAC = entity.NTRANSAC,
            DOPERDATE = entity.DOPERDATE,
            NPAYMENT_METHOD = entity.NPAYMENT_METHOD,
            TABLE9252SDESCRIPT = entity.TABLE9252?.SDESCRIPT,
            NPAYEE = entity.NPAYEE,
            TABLE9251SDESCRIPT = entity.TABLE9251?.SDESCRIPT,
            NSETTLEMENT_STAT = entity.NSETTLEMENT_STAT,
            TABLE9250SDESCRIPT = entity.TABLE9250?.SDESCRIPT,
            NSETTLEMENT_CONC = entity.NSETTLEMENT_CONC,
            TABLE9249SDESCRIPT = entity.TABLE9249?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SREMARKS = entity.SREMARKS,
            NMOVEMENT_TYPE = entity.NMOVEMENT_TYPE,
            TABLE9266SDESCRIPT = entity.TABLE9266?.SDESCRIPT,
            NNULLCODE = entity.NNULLCODE,
            TABLE9274SDESCRIPT = entity.TABLE9274?.SDESCRIPT,
            DLEDGERDAT = entity.DLEDGERDAT,
            NREQUEST_NU = entity.NREQUEST_NU,
        };
    }

    public static CLAIM_SETT_HIS ToEntity(this CreateCLAIM_SETT_HISDto dto)
    {
        if (dto == null) return null!;
        return new CLAIM_SETT_HIS
        {
            DOPERDATE = dto.DOPERDATE,
            NPAYMENT_METHOD = dto.NPAYMENT_METHOD,
            NPAYEE = dto.NPAYEE,
            NSETTLEMENT_STAT = dto.NSETTLEMENT_STAT,
            NSETTLEMENT_CONC = dto.NSETTLEMENT_CONC,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SREMARKS = dto.SREMARKS,
            NMOVEMENT_TYPE = dto.NMOVEMENT_TYPE,
            NNULLCODE = dto.NNULLCODE,
            DLEDGERDAT = dto.DLEDGERDAT,
            NREQUEST_NU = dto.NREQUEST_NU,
        };
    }

    public static void UpdateEntity(this CLAIM_SETT_HIS entity, UpdateCLAIM_SETT_HISDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DOPERDATE = dto.DOPERDATE;
        entity.NPAYMENT_METHOD = dto.NPAYMENT_METHOD;
        entity.NPAYEE = dto.NPAYEE;
        entity.NSETTLEMENT_STAT = dto.NSETTLEMENT_STAT;
        entity.NSETTLEMENT_CONC = dto.NSETTLEMENT_CONC;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SREMARKS = dto.SREMARKS;
        entity.NMOVEMENT_TYPE = dto.NMOVEMENT_TYPE;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.DLEDGERDAT = dto.DLEDGERDAT;
        entity.NREQUEST_NU = dto.NREQUEST_NU;
    }
}
