using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE85;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE85Service : CrudService<TABLE85, TABLE85Dto, CreateTABLE85Dto, UpdateTABLE85Dto, int>, ITABLE85Service
{
    public TABLE85Service(IRepository<TABLE85> repository)
        : base(repository, TABLE85MappingExtensions.ToDto, TABLE85MappingExtensions.ToEntity, TABLE85MappingExtensions.UpdateEntity) { }
}
