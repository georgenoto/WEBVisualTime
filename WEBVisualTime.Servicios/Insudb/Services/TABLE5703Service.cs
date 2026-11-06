using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5703;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5703Service : CrudService<TABLE5703, TABLE5703Dto, CreateTABLE5703Dto, UpdateTABLE5703Dto, int>, ITABLE5703Service
{
    public TABLE5703Service(IRepository<TABLE5703> repository)
        : base(repository, TABLE5703MappingExtensions.ToDto, TABLE5703MappingExtensions.ToEntity, TABLE5703MappingExtensions.UpdateEntity) { }
}
