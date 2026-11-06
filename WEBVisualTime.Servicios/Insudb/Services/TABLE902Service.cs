using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE902;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE902Service : CrudService<TABLE902, TABLE902Dto, CreateTABLE902Dto, UpdateTABLE902Dto, long>, ITABLE902Service
{
    public TABLE902Service(IRepository<TABLE902> repository)
        : base(repository, TABLE902MappingExtensions.ToDto, TABLE902MappingExtensions.ToEntity, TABLE902MappingExtensions.UpdateEntity) { }
}
