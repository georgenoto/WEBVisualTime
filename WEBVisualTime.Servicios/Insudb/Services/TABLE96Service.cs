using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE96;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE96Service : CrudService<TABLE96, TABLE96Dto, CreateTABLE96Dto, UpdateTABLE96Dto, long>, ITABLE96Service
{
    public TABLE96Service(IRepository<TABLE96> repository)
        : base(repository, TABLE96MappingExtensions.ToDto, TABLE96MappingExtensions.ToEntity, TABLE96MappingExtensions.UpdateEntity) { }
}
