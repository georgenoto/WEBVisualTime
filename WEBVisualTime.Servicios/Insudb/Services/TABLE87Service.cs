using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE87;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE87Service : CrudService<TABLE87, TABLE87Dto, CreateTABLE87Dto, UpdateTABLE87Dto, int>, ITABLE87Service
{
    public TABLE87Service(IRepository<TABLE87> repository)
        : base(repository, TABLE87MappingExtensions.ToDto, TABLE87MappingExtensions.ToEntity, TABLE87MappingExtensions.UpdateEntity) { }
}
