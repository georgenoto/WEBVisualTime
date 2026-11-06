using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5640;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5640Service : CrudService<TABLE5640, TABLE5640Dto, CreateTABLE5640Dto, UpdateTABLE5640Dto, int>, ITABLE5640Service
{
    public TABLE5640Service(IRepository<TABLE5640> repository)
        : base(repository, TABLE5640MappingExtensions.ToDto, TABLE5640MappingExtensions.ToEntity, TABLE5640MappingExtensions.UpdateEntity) { }
}
