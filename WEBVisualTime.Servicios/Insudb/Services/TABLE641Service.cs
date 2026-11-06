using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE641;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE641Service : CrudService<TABLE641, TABLE641Dto, CreateTABLE641Dto, UpdateTABLE641Dto, long>, ITABLE641Service
{
    public TABLE641Service(IRepository<TABLE641> repository)
        : base(repository, TABLE641MappingExtensions.ToDto, TABLE641MappingExtensions.ToEntity, TABLE641MappingExtensions.UpdateEntity) { }
}
