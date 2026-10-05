using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMED_HIS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class INTERMED_HISMappingExtensions
{
    public static INTERMED_HISDto ToDto(this INTERMED_HIS entity)
    {
        if (entity == null) return null!;
        return new INTERMED_HISDto
        {
            NINTERMED = entity.NINTERMED,
            INTERMEDIASCOL_AGREE = entity.INTERMEDIA?.SCOL_AGREE,
            DEFFECDATE = entity.DEFFECDATE,
            NNULLCODE = entity.NNULLCODE,
            TABLE163SDESCRIPT = entity.TABLE163?.SDESCRIPT,
            NINTERTYP = entity.NINTERTYP,
            INTERM_TYPSDESCRIPT = entity.INTERM_TYP?.SDESCRIPT,
            NOFFICE = entity.NOFFICE,
            TABLE9SDESCRIPT = entity.TABLE9?.SDESCRIPT,
            NSUPERVIS = entity.NSUPERVIS,
            NINT_STATUS = entity.NINT_STATUS,
            TABLE200SDESCRIPT = entity.TABLE200?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            NRECEPTYP = entity.NRECEPTYP,
            SDESCRIPT = entity.SDESCRIPT,
        };
    }

    public static INTERMED_HIS ToEntity(this CreateINTERMED_HISDto dto)
    {
        if (dto == null) return null!;
        return new INTERMED_HIS
        {
            NNULLCODE = dto.NNULLCODE,
            NINTERTYP = dto.NINTERTYP,
            NOFFICE = dto.NOFFICE,
            NSUPERVIS = dto.NSUPERVIS,
            NINT_STATUS = dto.NINT_STATUS,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            NRECEPTYP = dto.NRECEPTYP,
            SDESCRIPT = dto.SDESCRIPT,
        };
    }

    public static void UpdateEntity(this INTERMED_HIS entity, UpdateINTERMED_HISDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NNULLCODE = dto.NNULLCODE;
        entity.NINTERTYP = dto.NINTERTYP;
        entity.NOFFICE = dto.NOFFICE;
        entity.NSUPERVIS = dto.NSUPERVIS;
        entity.NINT_STATUS = dto.NINT_STATUS;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NRECEPTYP = dto.NRECEPTYP;
        entity.SDESCRIPT = dto.SDESCRIPT;
    }
}
