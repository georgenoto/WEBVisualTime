using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.DIR_DEBIT_CLI;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class DIR_DEBIT_CLIMappingExtensions
{
    public static DIR_DEBIT_CLIDto ToDto(this DIR_DEBIT_CLI entity)
    {
        if (entity == null) return null!;
        return new DIR_DEBIT_CLIDto
        {
            SCLIENT = entity.SCLIENT,
            CLIENTSACCOUNT_IN = entity.CLIENT?.SACCOUNT_IN,
            DEFFECDATE = entity.DEFFECDATE,
            SACCOUNT = entity.SACCOUNT,
            DNULLDATE = entity.DNULLDATE,
            STYP_DIRDEB = entity.STYP_DIRDEB,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NBANKEXT = entity.NBANKEXT,
            TABLE7SDESCRIPT = entity.TABLE7?.SDESCRIPT,
            SBANKAUTH = entity.SBANKAUTH,
            NBILL_DAY = entity.NBILL_DAY,
            NSTATUS_BANKAUTH = entity.NSTATUS_BANKAUTH,
        };
    }

    public static DIR_DEBIT_CLI ToEntity(this CreateDIR_DEBIT_CLIDto dto)
    {
        if (dto == null) return null!;
        return new DIR_DEBIT_CLI
        {
            SACCOUNT = dto.SACCOUNT,
            DNULLDATE = dto.DNULLDATE,
            STYP_DIRDEB = dto.STYP_DIRDEB,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NBANKEXT = dto.NBANKEXT,
            SBANKAUTH = dto.SBANKAUTH,
            NBILL_DAY = dto.NBILL_DAY,
            NSTATUS_BANKAUTH = dto.NSTATUS_BANKAUTH,
        };
    }

    public static void UpdateEntity(this DIR_DEBIT_CLI entity, UpdateDIR_DEBIT_CLIDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SACCOUNT = dto.SACCOUNT;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.STYP_DIRDEB = dto.STYP_DIRDEB;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NBANKEXT = dto.NBANKEXT;
        entity.SBANKAUTH = dto.SBANKAUTH;
        entity.NBILL_DAY = dto.NBILL_DAY;
        entity.NSTATUS_BANKAUTH = dto.NSTATUS_BANKAUTH;
    }
}
