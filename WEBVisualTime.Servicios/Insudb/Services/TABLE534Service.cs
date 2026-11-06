using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE534;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE534Service : CrudService<TABLE534, TABLE534Dto, CreateTABLE534Dto, UpdateTABLE534Dto, long>, ITABLE534Service
{
    public TABLE534Service(IRepository<TABLE534> repository)
        : base(repository, TABLE534MappingExtensions.ToDto, TABLE534MappingExtensions.ToEntity, TABLE534MappingExtensions.UpdateEntity) { }
}
