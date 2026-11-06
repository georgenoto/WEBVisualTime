using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.MESSAGE;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class MESSAGEService : CrudService<MESSAGE, MESSAGEDto, CreateMESSAGEDto, UpdateMESSAGEDto, long>, IMESSAGEService
{
    public MESSAGEService(IRepository<MESSAGE> repository)
        : base(repository, MESSAGEMappingExtensions.ToDto, MESSAGEMappingExtensions.ToEntity, MESSAGEMappingExtensions.UpdateEntity) { }
}
