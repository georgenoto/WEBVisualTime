using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5639;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5639Service : CrudService<TABLE5639, TABLE5639Dto, CreateTABLE5639Dto, UpdateTABLE5639Dto, int>, ITABLE5639Service
{
    public TABLE5639Service(IRepository<TABLE5639> repository)
        : base(repository, TABLE5639MappingExtensions.ToDto, TABLE5639MappingExtensions.ToEntity, TABLE5639MappingExtensions.UpdateEntity) { }
}
