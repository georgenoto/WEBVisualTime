using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9000;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9000Service : CrudService<TABLE9000, TABLE9000Dto, CreateTABLE9000Dto, UpdateTABLE9000Dto, int>, ITABLE9000Service
{
    public TABLE9000Service(IRepository<TABLE9000> repository)
        : base(repository, TABLE9000MappingExtensions.ToDto, TABLE9000MappingExtensions.ToEntity, TABLE9000MappingExtensions.UpdateEntity) { }
}
