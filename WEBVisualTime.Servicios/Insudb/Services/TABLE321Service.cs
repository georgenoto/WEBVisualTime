using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE321;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE321Service : CrudService<TABLE321, TABLE321Dto, CreateTABLE321Dto, UpdateTABLE321Dto, int>, ITABLE321Service
{
    public TABLE321Service(IRepository<TABLE321> repository)
        : base(repository, TABLE321MappingExtensions.ToDto, TABLE321MappingExtensions.ToEntity, TABLE321MappingExtensions.UpdateEntity) { }
}
