using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9258;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9258Service : CrudService<TABLE9258, TABLE9258Dto, CreateTABLE9258Dto, UpdateTABLE9258Dto, int>, ITABLE9258Service
{
    public TABLE9258Service(IRepository<TABLE9258> repository)
        : base(repository, TABLE9258MappingExtensions.ToDto, TABLE9258MappingExtensions.ToEntity, TABLE9258MappingExtensions.UpdateEntity) { }
}
