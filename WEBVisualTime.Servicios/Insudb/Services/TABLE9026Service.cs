using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9026;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9026Service : CrudService<TABLE9026, TABLE9026Dto, CreateTABLE9026Dto, UpdateTABLE9026Dto, int>, ITABLE9026Service
{
    public TABLE9026Service(IRepository<TABLE9026> repository)
        : base(repository, TABLE9026MappingExtensions.ToDto, TABLE9026MappingExtensions.ToEntity, TABLE9026MappingExtensions.UpdateEntity) { }
}
