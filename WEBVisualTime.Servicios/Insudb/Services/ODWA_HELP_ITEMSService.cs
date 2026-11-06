using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_ITEMS;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class ODWA_HELP_ITEMSService : CrudService<ODWA_HELP_ITEMS, ODWA_HELP_ITEMSDto, CreateODWA_HELP_ITEMSDto, UpdateODWA_HELP_ITEMSDto, int>, IODWA_HELP_ITEMSService
{
    public ODWA_HELP_ITEMSService(IRepository<ODWA_HELP_ITEMS> repository)
        : base(repository, ODWA_HELP_ITEMSMappingExtensions.ToDto, ODWA_HELP_ITEMSMappingExtensions.ToEntity, ODWA_HELP_ITEMSMappingExtensions.UpdateEntity) { }
}
