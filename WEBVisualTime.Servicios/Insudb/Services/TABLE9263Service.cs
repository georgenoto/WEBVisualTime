using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9263;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9263Service : CrudService<TABLE9263, TABLE9263Dto, CreateTABLE9263Dto, UpdateTABLE9263Dto, int>, ITABLE9263Service
{
    public TABLE9263Service(IRepository<TABLE9263> repository)
        : base(repository, TABLE9263MappingExtensions.ToDto, TABLE9263MappingExtensions.ToEntity, TABLE9263MappingExtensions.UpdateEntity) { }
}
