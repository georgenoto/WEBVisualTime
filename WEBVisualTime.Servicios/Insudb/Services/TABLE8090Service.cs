using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8090;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8090Service : CrudService<TABLE8090, TABLE8090Dto, CreateTABLE8090Dto, UpdateTABLE8090Dto, int>, ITABLE8090Service
{
    public TABLE8090Service(IRepository<TABLE8090> repository)
        : base(repository, TABLE8090MappingExtensions.ToDto, TABLE8090MappingExtensions.ToEntity, TABLE8090MappingExtensions.UpdateEntity) { }
}
