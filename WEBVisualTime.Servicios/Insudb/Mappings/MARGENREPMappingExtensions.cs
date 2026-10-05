using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.MARGENREP;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class MARGENREPMappingExtensions
{
    public static MARGENREPDto ToDto(this MARGENREP entity)
    {
        if (entity == null) return null!;
        return new MARGENREPDto
        {
            NBRANCH = entity.NBRANCH,
            NPRODUCT = entity.NPRODUCT,
            NREPTYPE = entity.NREPTYPE,
            SLOGO = entity.SLOGO,
            SLOG = entity.SLOG,
            X1 = entity.X1,
            Y1 = entity.Y1,
            NIMAGENX = entity.NIMAGENX,
            NIMAGENY = entity.NIMAGENY,
            NPOSIMGX = entity.NPOSIMGX,
            NPOSIMGY = entity.NPOSIMGY,
            NRADIOCURVA = entity.NRADIOCURVA,
            NSPACE = entity.NSPACE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static MARGENREP ToEntity(this CreateMARGENREPDto dto)
    {
        if (dto == null) return null!;
        return new MARGENREP
        {
            SLOGO = dto.SLOGO,
            SLOG = dto.SLOG,
            X1 = dto.X1,
            Y1 = dto.Y1,
            NIMAGENX = dto.NIMAGENX,
            NIMAGENY = dto.NIMAGENY,
            NPOSIMGX = dto.NPOSIMGX,
            NPOSIMGY = dto.NPOSIMGY,
            NRADIOCURVA = dto.NRADIOCURVA,
            NSPACE = dto.NSPACE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this MARGENREP entity, UpdateMARGENREPDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SLOGO = dto.SLOGO;
        entity.SLOG = dto.SLOG;
        entity.X1 = dto.X1;
        entity.Y1 = dto.Y1;
        entity.NIMAGENX = dto.NIMAGENX;
        entity.NIMAGENY = dto.NIMAGENY;
        entity.NPOSIMGX = dto.NPOSIMGX;
        entity.NPOSIMGY = dto.NPOSIMGY;
        entity.NRADIOCURVA = dto.NRADIOCURVA;
        entity.NSPACE = dto.NSPACE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
