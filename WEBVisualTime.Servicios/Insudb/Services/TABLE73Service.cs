using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE73;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE73Service : CrudService<TABLE73, TABLE73Dto, CreateTABLE73Dto, UpdateTABLE73Dto, int>, ITABLE73Service
{
    public TABLE73Service(IRepository<TABLE73> repository)
        : base(repository, TABLE73MappingExtensions.ToDto, TABLE73MappingExtensions.ToEntity, TABLE73MappingExtensions.UpdateEntity) { }
}
