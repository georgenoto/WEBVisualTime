using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_LOG_ERROR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MASSIVE_LOG_ERRORMappingExtensions
{
    public static MASSIVE_LOG_ERRORDto ToDto(this MASSIVE_LOG_ERROR entity)
    {
        if (entity == null) return null!;
        return new MASSIVE_LOG_ERRORDto
        {
            SKEY = entity.SKEY,
            NKEY = entity.NKEY,
            NROW = entity.NROW,
            NSEQ = entity.NSEQ,
            NCONSEC = entity.NCONSEC,
            SACTION = entity.SACTION,
            NCODERROR = entity.NCODERROR,
            SERRORTYP = entity.SERRORTYP,
            STYP_CONDI = entity.STYP_CONDI,
            NSECTION = entity.NSECTION,
            SCODISPL = entity.SCODISPL,
            SERRORMESSEROW = entity.SERRORMESSEROW,
            SBREAK = entity.SBREAK,
            NCOD_AGREE = entity.NCOD_AGREE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NACTION = entity.NACTION,
        };
    }

    public static MASSIVE_LOG_ERROR ToEntity(this CreateMASSIVE_LOG_ERRORDto dto)
    {
        if (dto == null) return null!;
        return new MASSIVE_LOG_ERROR
        {
            SKEY = dto.SKEY,
            NKEY = dto.NKEY,
            NROW = dto.NROW,
            NSEQ = dto.NSEQ,
            NCONSEC = dto.NCONSEC,
            SACTION = dto.SACTION,
            NCODERROR = dto.NCODERROR,
            SERRORTYP = dto.SERRORTYP,
            STYP_CONDI = dto.STYP_CONDI,
            NSECTION = dto.NSECTION,
            SCODISPL = dto.SCODISPL,
            SERRORMESSEROW = dto.SERRORMESSEROW,
            SBREAK = dto.SBREAK,
            NCOD_AGREE = dto.NCOD_AGREE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NACTION = dto.NACTION,
        };
    }

    public static void UpdateEntity(this MASSIVE_LOG_ERROR entity, UpdateMASSIVE_LOG_ERRORDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SKEY = dto.SKEY;
        entity.NKEY = dto.NKEY;
        entity.NROW = dto.NROW;
        entity.NSEQ = dto.NSEQ;
        entity.NCONSEC = dto.NCONSEC;
        entity.SACTION = dto.SACTION;
        entity.NCODERROR = dto.NCODERROR;
        entity.SERRORTYP = dto.SERRORTYP;
        entity.STYP_CONDI = dto.STYP_CONDI;
        entity.NSECTION = dto.NSECTION;
        entity.SCODISPL = dto.SCODISPL;
        entity.SERRORMESSEROW = dto.SERRORMESSEROW;
        entity.SBREAK = dto.SBREAK;
        entity.NCOD_AGREE = dto.NCOD_AGREE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NACTION = dto.NACTION;
    }
}
