using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5003;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5003Service : CrudService<TABLE5003, TABLE5003Dto, CreateTABLE5003Dto, UpdateTABLE5003Dto, int>, ITABLE5003Service
{
    public TABLE5003Service(IRepository<TABLE5003> repository)
        : base(repository, TABLE5003MappingExtensions.ToDto, TABLE5003MappingExtensions.ToEntity, TABLE5003MappingExtensions.UpdateEntity) { }
}
