using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5526;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5526Service : CrudService<TABLE5526, TABLE5526Dto, CreateTABLE5526Dto, UpdateTABLE5526Dto, int>, ITABLE5526Service
{
    public TABLE5526Service(IRepository<TABLE5526> repository)
        : base(repository, TABLE5526MappingExtensions.ToDto, TABLE5526MappingExtensions.ToEntity, TABLE5526MappingExtensions.UpdateEntity) { }
}
