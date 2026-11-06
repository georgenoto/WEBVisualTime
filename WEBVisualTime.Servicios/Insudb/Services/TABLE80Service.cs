using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE80;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE80Service : CrudService<TABLE80, TABLE80Dto, CreateTABLE80Dto, UpdateTABLE80Dto, string>, ITABLE80Service
{
    public TABLE80Service(IRepository<TABLE80> repository)
        : base(repository, TABLE80MappingExtensions.ToDto, TABLE80MappingExtensions.ToEntity, TABLE80MappingExtensions.UpdateEntity) { }
}
