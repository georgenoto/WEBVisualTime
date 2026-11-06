using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE624;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE624Service : CrudService<TABLE624, TABLE624Dto, CreateTABLE624Dto, UpdateTABLE624Dto, int>, ITABLE624Service
{
    public TABLE624Service(IRepository<TABLE624> repository)
        : base(repository, TABLE624MappingExtensions.ToDto, TABLE624MappingExtensions.ToEntity, TABLE624MappingExtensions.UpdateEntity) { }
}
