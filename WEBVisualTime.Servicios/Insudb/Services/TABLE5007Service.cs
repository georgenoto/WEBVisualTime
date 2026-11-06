using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5007;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5007Service : CrudService<TABLE5007, TABLE5007Dto, CreateTABLE5007Dto, UpdateTABLE5007Dto, string>, ITABLE5007Service
{
    public TABLE5007Service(IRepository<TABLE5007> repository)
        : base(repository, TABLE5007MappingExtensions.ToDto, TABLE5007MappingExtensions.ToEntity, TABLE5007MappingExtensions.UpdateEntity) { }
}
