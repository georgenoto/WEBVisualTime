using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_NODES;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class ODWA_HELP_NODESService : CrudService<ODWA_HELP_NODES, ODWA_HELP_NODESDto, CreateODWA_HELP_NODESDto, UpdateODWA_HELP_NODESDto, int>, IODWA_HELP_NODESService
{
    public ODWA_HELP_NODESService(IRepository<ODWA_HELP_NODES> repository)
        : base(repository, ODWA_HELP_NODESMappingExtensions.ToDto, ODWA_HELP_NODESMappingExtensions.ToEntity, ODWA_HELP_NODESMappingExtensions.UpdateEntity) { }
}
