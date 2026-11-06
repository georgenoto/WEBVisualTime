using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9007;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9007Service : CrudService<TABLE9007, TABLE9007Dto, CreateTABLE9007Dto, UpdateTABLE9007Dto, int>, ITABLE9007Service
{
    public TABLE9007Service(IRepository<TABLE9007> repository)
        : base(repository, TABLE9007MappingExtensions.ToDto, TABLE9007MappingExtensions.ToEntity, TABLE9007MappingExtensions.UpdateEntity) { }
}
