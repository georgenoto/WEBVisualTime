using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5702;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5702Service : CrudService<TABLE5702, TABLE5702Dto, CreateTABLE5702Dto, UpdateTABLE5702Dto, int>, ITABLE5702Service
{
    public TABLE5702Service(IRepository<TABLE5702> repository)
        : base(repository, TABLE5702MappingExtensions.ToDto, TABLE5702MappingExtensions.ToEntity, TABLE5702MappingExtensions.UpdateEntity) { }
}
