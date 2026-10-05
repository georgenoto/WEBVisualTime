using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.COLLECTOR;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class COLLECTORMappingExtensions
{
    public static COLLECTORDto ToDto(this COLLECTOR entity)
    {
        if (entity == null) return null!;
        return new COLLECTORDto
        {
            NCOLLECTOR = entity.NCOLLECTOR,
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            NCOLLECTORTYPE = entity.NCOLLECTORTYPE,
            TABLE5551SDESCRIPT = entity.TABLE5551?.SDESCRIPT,
            DINPUTDATE = entity.DINPUTDATE,
            NCONTYPE = entity.NCONTYPE,
            TABLE5557SDESCRIPT = entity.TABLE5557?.SDESCRIPT,
            NINSUR_AREA = entity.NINSUR_AREA,
            TABLE5001SDESCRIPT = entity.TABLE5001?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NCODE = entity.NCODE,
            TAB_COLLECTCOMMSDESCRIPT = entity.TAB_COLLECTCOMM?.SDESCRIPT,
            NLEGAL_SCH = entity.NLEGAL_SCH,
            TABLE5501SDESCRIPT = entity.TABLE5501?.SDESCRIPT,
            NINT_STATUS = entity.NINT_STATUS,
            DSTATUSDATE = entity.DSTATUSDATE,
            NOFFICE = entity.NOFFICE,
            NSUPERVIS = entity.NSUPERVIS,
        };
    }

    public static COLLECTOR ToEntity(this CreateCOLLECTORDto dto)
    {
        if (dto == null) return null!;
        return new COLLECTOR
        {
            SCLIENT = dto.SCLIENT,
            NCOLLECTORTYPE = dto.NCOLLECTORTYPE,
            DINPUTDATE = dto.DINPUTDATE,
            NCONTYPE = dto.NCONTYPE,
            NINSUR_AREA = dto.NINSUR_AREA,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NCODE = dto.NCODE,
            NLEGAL_SCH = dto.NLEGAL_SCH,
            NINT_STATUS = dto.NINT_STATUS,
            DSTATUSDATE = dto.DSTATUSDATE,
            NOFFICE = dto.NOFFICE,
            NSUPERVIS = dto.NSUPERVIS,
        };
    }

    public static void UpdateEntity(this COLLECTOR entity, UpdateCOLLECTORDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SCLIENT = dto.SCLIENT;
        entity.NCOLLECTORTYPE = dto.NCOLLECTORTYPE;
        entity.DINPUTDATE = dto.DINPUTDATE;
        entity.NCONTYPE = dto.NCONTYPE;
        entity.NINSUR_AREA = dto.NINSUR_AREA;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NCODE = dto.NCODE;
        entity.NLEGAL_SCH = dto.NLEGAL_SCH;
        entity.NINT_STATUS = dto.NINT_STATUS;
        entity.DSTATUSDATE = dto.DSTATUSDATE;
        entity.NOFFICE = dto.NOFFICE;
        entity.NSUPERVIS = dto.NSUPERVIS;
    }
}
