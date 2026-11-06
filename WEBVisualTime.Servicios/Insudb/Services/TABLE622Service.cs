using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE622;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE622Service : CrudService<TABLE622, TABLE622Dto, CreateTABLE622Dto, UpdateTABLE622Dto, int>, ITABLE622Service
{
    public TABLE622Service(IRepository<TABLE622> repository)
        : base(repository, TABLE622MappingExtensions.ToDto, TABLE622MappingExtensions.ToEntity, TABLE622MappingExtensions.UpdateEntity) { }
}
