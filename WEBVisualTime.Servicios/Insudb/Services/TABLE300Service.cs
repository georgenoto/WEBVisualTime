using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE300;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE300Service : CrudService<TABLE300, TABLE300Dto, CreateTABLE300Dto, UpdateTABLE300Dto, long>, ITABLE300Service
{
    public TABLE300Service(IRepository<TABLE300> repository)
        : base(repository, TABLE300MappingExtensions.ToDto, TABLE300MappingExtensions.ToEntity, TABLE300MappingExtensions.UpdateEntity) { }
}
