using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9257;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9257Service : CrudService<TABLE9257, TABLE9257Dto, CreateTABLE9257Dto, UpdateTABLE9257Dto, int>, ITABLE9257Service
{
    public TABLE9257Service(IRepository<TABLE9257> repository)
        : base(repository, TABLE9257MappingExtensions.ToDto, TABLE9257MappingExtensions.ToEntity, TABLE9257MappingExtensions.UpdateEntity) { }
}
