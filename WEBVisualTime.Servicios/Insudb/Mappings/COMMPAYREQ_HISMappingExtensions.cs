using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_HIS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COMMPAYREQ_HISMappingExtensions
{
    public static COMMPAYREQ_HISDto ToDto(this COMMPAYREQ_HIS entity)
    {
        if (entity == null) return null!;
        return new COMMPAYREQ_HISDto
        {
            NID_COMMPAYREQ = entity.NID_COMMPAYREQ,
            COMMPAYMENTREQUESTSSCLIENAME_HOLDER = entity.COMMPAYMENTREQUESTS?.SCLIENAME_HOLDER,
            NMOVEMENT = entity.NMOVEMENT,
            DMOVEMENT_DATE = entity.DMOVEMENT_DATE,
            NMOVEMENT_TYPE = entity.NMOVEMENT_TYPE,
            TABLE9276SDESCRIPT = entity.TABLE9276?.SDESCRIPT,
            NSTATUS = entity.NSTATUS,
            TABLE9275SDESCRIPT = entity.TABLE9275?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            SCLARIFICATIONREQUESTED = entity.SCLARIFICATIONREQUESTED,
            SJUSTIFICATIONREQUESTED = entity.SJUSTIFICATIONREQUESTED,
            NUSERCODE_RESPONSIBLE = entity.NUSERCODE_RESPONSIBLE,
            DRESULTDATE = entity.DRESULTDATE,
            SIND_RESULT = entity.SIND_RESULT,
            SIND_ASSUMEIVA = entity.SIND_ASSUMEIVA,
            NCURRENCY_PAY = entity.NCURRENCY_PAY,
            NAMOUNT_PAY = entity.NAMOUNT_PAY,
            NNULLCODE = entity.NNULLCODE,
        };
    }

    public static COMMPAYREQ_HIS ToEntity(this CreateCOMMPAYREQ_HISDto dto)
    {
        if (dto == null) return null!;
        return new COMMPAYREQ_HIS
        {
            DMOVEMENT_DATE = dto.DMOVEMENT_DATE,
            NMOVEMENT_TYPE = dto.NMOVEMENT_TYPE,
            NSTATUS = dto.NSTATUS,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            SCLARIFICATIONREQUESTED = dto.SCLARIFICATIONREQUESTED,
            SJUSTIFICATIONREQUESTED = dto.SJUSTIFICATIONREQUESTED,
            NUSERCODE_RESPONSIBLE = dto.NUSERCODE_RESPONSIBLE,
            DRESULTDATE = dto.DRESULTDATE,
            SIND_RESULT = dto.SIND_RESULT,
            SIND_ASSUMEIVA = dto.SIND_ASSUMEIVA,
            NCURRENCY_PAY = dto.NCURRENCY_PAY,
            NAMOUNT_PAY = dto.NAMOUNT_PAY,
            NNULLCODE = dto.NNULLCODE,
        };
    }

    public static void UpdateEntity(this COMMPAYREQ_HIS entity, UpdateCOMMPAYREQ_HISDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DMOVEMENT_DATE = dto.DMOVEMENT_DATE;
        entity.NMOVEMENT_TYPE = dto.NMOVEMENT_TYPE;
        entity.NSTATUS = dto.NSTATUS;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.SCLARIFICATIONREQUESTED = dto.SCLARIFICATIONREQUESTED;
        entity.SJUSTIFICATIONREQUESTED = dto.SJUSTIFICATIONREQUESTED;
        entity.NUSERCODE_RESPONSIBLE = dto.NUSERCODE_RESPONSIBLE;
        entity.DRESULTDATE = dto.DRESULTDATE;
        entity.SIND_RESULT = dto.SIND_RESULT;
        entity.SIND_ASSUMEIVA = dto.SIND_ASSUMEIVA;
        entity.NCURRENCY_PAY = dto.NCURRENCY_PAY;
        entity.NAMOUNT_PAY = dto.NAMOUNT_PAY;
        entity.NNULLCODE = dto.NNULLCODE;
    }
}
