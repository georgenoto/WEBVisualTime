using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE271;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE271Service : CrudService<TABLE271, TABLE271Dto, CreateTABLE271Dto, UpdateTABLE271Dto, int>, ITABLE271Service
{
    public TABLE271Service(IRepository<TABLE271> repository)
        : base(repository, TABLE271MappingExtensions.ToDto, TABLE271MappingExtensions.ToEntity, TABLE271MappingExtensions.UpdateEntity) { }
}
