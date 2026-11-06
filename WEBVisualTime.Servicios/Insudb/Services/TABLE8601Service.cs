using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8601;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8601Service : CrudService<TABLE8601, TABLE8601Dto, CreateTABLE8601Dto, UpdateTABLE8601Dto, string>, ITABLE8601Service
{
    public TABLE8601Service(IRepository<TABLE8601> repository)
        : base(repository, TABLE8601MappingExtensions.ToDto, TABLE8601MappingExtensions.ToEntity, TABLE8601MappingExtensions.UpdateEntity) { }
}
