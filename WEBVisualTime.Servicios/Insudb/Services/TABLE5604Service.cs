using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5604;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5604Service : CrudService<TABLE5604, TABLE5604Dto, CreateTABLE5604Dto, UpdateTABLE5604Dto, int>, ITABLE5604Service
{
    public TABLE5604Service(IRepository<TABLE5604> repository)
        : base(repository, TABLE5604MappingExtensions.ToDto, TABLE5604MappingExtensions.ToEntity, TABLE5604MappingExtensions.UpdateEntity) { }
}
