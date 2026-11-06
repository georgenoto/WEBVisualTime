using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE71;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE71Service : CrudService<TABLE71, TABLE71Dto, CreateTABLE71Dto, UpdateTABLE71Dto, int>, ITABLE71Service
{
    public TABLE71Service(IRepository<TABLE71> repository)
        : base(repository, TABLE71MappingExtensions.ToDto, TABLE71MappingExtensions.ToEntity, TABLE71MappingExtensions.UpdateEntity) { }
}
