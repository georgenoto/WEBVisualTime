using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8001;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8001Service : CrudService<TABLE8001, TABLE8001Dto, CreateTABLE8001Dto, UpdateTABLE8001Dto, int>, ITABLE8001Service
{
    public TABLE8001Service(IRepository<TABLE8001> repository)
        : base(repository, TABLE8001MappingExtensions.ToDto, TABLE8001MappingExtensions.ToEntity, TABLE8001MappingExtensions.UpdateEntity) { }
}
