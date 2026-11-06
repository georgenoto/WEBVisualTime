using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5565;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5565Service : CrudService<TABLE5565, TABLE5565Dto, CreateTABLE5565Dto, UpdateTABLE5565Dto, int>, ITABLE5565Service
{
    public TABLE5565Service(IRepository<TABLE5565> repository)
        : base(repository, TABLE5565MappingExtensions.ToDto, TABLE5565MappingExtensions.ToEntity, TABLE5565MappingExtensions.UpdateEntity) { }
}
