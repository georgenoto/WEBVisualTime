using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5801;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5801Service : CrudService<TABLE5801, TABLE5801Dto, CreateTABLE5801Dto, UpdateTABLE5801Dto, int>, ITABLE5801Service
{
    public TABLE5801Service(IRepository<TABLE5801> repository)
        : base(repository, TABLE5801MappingExtensions.ToDto, TABLE5801MappingExtensions.ToEntity, TABLE5801MappingExtensions.UpdateEntity) { }
}
