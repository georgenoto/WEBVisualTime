using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE563;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE563Service : CrudService<TABLE563, TABLE563Dto, CreateTABLE563Dto, UpdateTABLE563Dto, long>, ITABLE563Service
{
    public TABLE563Service(IRepository<TABLE563> repository)
        : base(repository, TABLE563MappingExtensions.ToDto, TABLE563MappingExtensions.ToEntity, TABLE563MappingExtensions.UpdateEntity) { }
}
