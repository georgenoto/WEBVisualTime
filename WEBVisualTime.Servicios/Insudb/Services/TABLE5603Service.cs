using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5603;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5603Service : CrudService<TABLE5603, TABLE5603Dto, CreateTABLE5603Dto, UpdateTABLE5603Dto, int>, ITABLE5603Service
{
    public TABLE5603Service(IRepository<TABLE5603> repository)
        : base(repository, TABLE5603MappingExtensions.ToDto, TABLE5603MappingExtensions.ToEntity, TABLE5603MappingExtensions.UpdateEntity) { }
}
