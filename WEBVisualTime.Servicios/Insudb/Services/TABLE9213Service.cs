using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9213;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9213Service : CrudService<TABLE9213, TABLE9213Dto, CreateTABLE9213Dto, UpdateTABLE9213Dto, int>, ITABLE9213Service
{
    public TABLE9213Service(IRepository<TABLE9213> repository)
        : base(repository, TABLE9213MappingExtensions.ToDto, TABLE9213MappingExtensions.ToEntity, TABLE9213MappingExtensions.UpdateEntity) { }
}
