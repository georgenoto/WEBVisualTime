using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5672;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5672Service : CrudService<TABLE5672, TABLE5672Dto, CreateTABLE5672Dto, UpdateTABLE5672Dto, int>, ITABLE5672Service
{
    public TABLE5672Service(IRepository<TABLE5672> repository)
        : base(repository, TABLE5672MappingExtensions.ToDto, TABLE5672MappingExtensions.ToEntity, TABLE5672MappingExtensions.UpdateEntity) { }
}
