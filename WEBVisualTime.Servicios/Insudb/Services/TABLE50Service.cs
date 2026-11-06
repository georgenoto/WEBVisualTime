using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE50;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE50Service : CrudService<TABLE50, TABLE50Dto, CreateTABLE50Dto, UpdateTABLE50Dto, string>, ITABLE50Service
{
    public TABLE50Service(IRepository<TABLE50> repository)
        : base(repository, TABLE50MappingExtensions.ToDto, TABLE50MappingExtensions.ToEntity, TABLE50MappingExtensions.UpdateEntity) { }
}
