using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5544;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5544Service : CrudService<TABLE5544, TABLE5544Dto, CreateTABLE5544Dto, UpdateTABLE5544Dto, int>, ITABLE5544Service
{
    public TABLE5544Service(IRepository<TABLE5544> repository)
        : base(repository, TABLE5544MappingExtensions.ToDto, TABLE5544MappingExtensions.ToEntity, TABLE5544MappingExtensions.UpdateEntity) { }
}
