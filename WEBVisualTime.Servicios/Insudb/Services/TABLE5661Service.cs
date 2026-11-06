using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5661;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5661Service : CrudService<TABLE5661, TABLE5661Dto, CreateTABLE5661Dto, UpdateTABLE5661Dto, int>, ITABLE5661Service
{
    public TABLE5661Service(IRepository<TABLE5661> repository)
        : base(repository, TABLE5661MappingExtensions.ToDto, TABLE5661MappingExtensions.ToEntity, TABLE5661MappingExtensions.UpdateEntity) { }
}
