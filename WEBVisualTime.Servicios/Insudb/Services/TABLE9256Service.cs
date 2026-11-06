using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9256;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9256Service : CrudService<TABLE9256, TABLE9256Dto, CreateTABLE9256Dto, UpdateTABLE9256Dto, int>, ITABLE9256Service
{
    public TABLE9256Service(IRepository<TABLE9256> repository)
        : base(repository, TABLE9256MappingExtensions.ToDto, TABLE9256MappingExtensions.ToEntity, TABLE9256MappingExtensions.UpdateEntity) { }
}
