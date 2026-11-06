using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5614;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5614Service : CrudService<TABLE5614, TABLE5614Dto, CreateTABLE5614Dto, UpdateTABLE5614Dto, int>, ITABLE5614Service
{
    public TABLE5614Service(IRepository<TABLE5614> repository)
        : base(repository, TABLE5614MappingExtensions.ToDto, TABLE5614MappingExtensions.ToEntity, TABLE5614MappingExtensions.UpdateEntity) { }
}
