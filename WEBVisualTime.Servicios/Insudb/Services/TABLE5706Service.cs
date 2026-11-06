using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5706;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5706Service : CrudService<TABLE5706, TABLE5706Dto, CreateTABLE5706Dto, UpdateTABLE5706Dto, int>, ITABLE5706Service
{
    public TABLE5706Service(IRepository<TABLE5706> repository)
        : base(repository, TABLE5706MappingExtensions.ToDto, TABLE5706MappingExtensions.ToEntity, TABLE5706MappingExtensions.UpdateEntity) { }
}
