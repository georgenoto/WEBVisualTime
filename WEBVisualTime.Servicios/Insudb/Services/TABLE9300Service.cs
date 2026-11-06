using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9300;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9300Service : CrudService<TABLE9300, TABLE9300Dto, CreateTABLE9300Dto, UpdateTABLE9300Dto, int>, ITABLE9300Service
{
    public TABLE9300Service(IRepository<TABLE9300> repository)
        : base(repository, TABLE9300MappingExtensions.ToDto, TABLE9300MappingExtensions.ToEntity, TABLE9300MappingExtensions.UpdateEntity) { }
}
