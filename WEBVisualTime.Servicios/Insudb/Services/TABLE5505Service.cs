using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5505;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5505Service : CrudService<TABLE5505, TABLE5505Dto, CreateTABLE5505Dto, UpdateTABLE5505Dto, int>, ITABLE5505Service
{
    public TABLE5505Service(IRepository<TABLE5505> repository)
        : base(repository, TABLE5505MappingExtensions.ToDto, TABLE5505MappingExtensions.ToEntity, TABLE5505MappingExtensions.UpdateEntity) { }
}
