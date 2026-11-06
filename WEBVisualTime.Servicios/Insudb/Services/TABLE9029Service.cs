using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9029;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9029Service : CrudService<TABLE9029, TABLE9029Dto, CreateTABLE9029Dto, UpdateTABLE9029Dto, int>, ITABLE9029Service
{
    public TABLE9029Service(IRepository<TABLE9029> repository)
        : base(repository, TABLE9029MappingExtensions.ToDto, TABLE9029MappingExtensions.ToEntity, TABLE9029MappingExtensions.UpdateEntity) { }
}
