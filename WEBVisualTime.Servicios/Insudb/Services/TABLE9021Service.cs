using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9021;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9021Service : CrudService<TABLE9021, TABLE9021Dto, CreateTABLE9021Dto, UpdateTABLE9021Dto, int>, ITABLE9021Service
{
    public TABLE9021Service(IRepository<TABLE9021> repository)
        : base(repository, TABLE9021MappingExtensions.ToDto, TABLE9021MappingExtensions.ToEntity, TABLE9021MappingExtensions.UpdateEntity) { }
}
