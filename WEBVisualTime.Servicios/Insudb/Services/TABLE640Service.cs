using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE640;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE640Service : CrudService<TABLE640, TABLE640Dto, CreateTABLE640Dto, UpdateTABLE640Dto, int>, ITABLE640Service
{
    public TABLE640Service(IRepository<TABLE640> repository)
        : base(repository, TABLE640MappingExtensions.ToDto, TABLE640MappingExtensions.ToEntity, TABLE640MappingExtensions.UpdateEntity) { }
}
