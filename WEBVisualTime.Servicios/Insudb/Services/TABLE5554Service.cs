using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5554;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5554Service : CrudService<TABLE5554, TABLE5554Dto, CreateTABLE5554Dto, UpdateTABLE5554Dto, int>, ITABLE5554Service
{
    public TABLE5554Service(IRepository<TABLE5554> repository)
        : base(repository, TABLE5554MappingExtensions.ToDto, TABLE5554MappingExtensions.ToEntity, TABLE5554MappingExtensions.UpdateEntity) { }
}
