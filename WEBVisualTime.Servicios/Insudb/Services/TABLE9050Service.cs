using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9050;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9050Service : CrudService<TABLE9050, TABLE9050Dto, CreateTABLE9050Dto, UpdateTABLE9050Dto, int>, ITABLE9050Service
{
    public TABLE9050Service(IRepository<TABLE9050> repository)
        : base(repository, TABLE9050MappingExtensions.ToDto, TABLE9050MappingExtensions.ToEntity, TABLE9050MappingExtensions.UpdateEntity) { }
}
