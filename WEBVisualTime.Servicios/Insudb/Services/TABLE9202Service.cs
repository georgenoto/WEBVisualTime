using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9202;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9202Service : CrudService<TABLE9202, TABLE9202Dto, CreateTABLE9202Dto, UpdateTABLE9202Dto, int>, ITABLE9202Service
{
    public TABLE9202Service(IRepository<TABLE9202> repository)
        : base(repository, TABLE9202MappingExtensions.ToDto, TABLE9202MappingExtensions.ToEntity, TABLE9202MappingExtensions.UpdateEntity) { }
}
