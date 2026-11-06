using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE400;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE400Service : CrudService<TABLE400, TABLE400Dto, CreateTABLE400Dto, UpdateTABLE400Dto, int>, ITABLE400Service
{
    public TABLE400Service(IRepository<TABLE400> repository)
        : base(repository, TABLE400MappingExtensions.ToDto, TABLE400MappingExtensions.ToEntity, TABLE400MappingExtensions.UpdateEntity) { }
}
