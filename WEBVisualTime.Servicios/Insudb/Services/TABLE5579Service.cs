using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5579;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5579Service : CrudService<TABLE5579, TABLE5579Dto, CreateTABLE5579Dto, UpdateTABLE5579Dto, int>, ITABLE5579Service
{
    public TABLE5579Service(IRepository<TABLE5579> repository)
        : base(repository, TABLE5579MappingExtensions.ToDto, TABLE5579MappingExtensions.ToEntity, TABLE5579MappingExtensions.UpdateEntity) { }
}
