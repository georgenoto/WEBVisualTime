using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_PREFERENCES;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class ODWA_PREFERENCESService : CrudService<ODWA_PREFERENCES, ODWA_PREFERENCESDto, CreateODWA_PREFERENCESDto, UpdateODWA_PREFERENCESDto, string>, IODWA_PREFERENCESService
{
    public ODWA_PREFERENCESService(IRepository<ODWA_PREFERENCES> repository)
        : base(repository, ODWA_PREFERENCESMappingExtensions.ToDto, ODWA_PREFERENCESMappingExtensions.ToEntity, ODWA_PREFERENCESMappingExtensions.UpdateEntity) { }
}
