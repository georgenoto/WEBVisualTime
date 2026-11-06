using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE199;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE199Service : CrudService<TABLE199, TABLE199Dto, CreateTABLE199Dto, UpdateTABLE199Dto, int>, ITABLE199Service
{
    public TABLE199Service(IRepository<TABLE199> repository)
        : base(repository, TABLE199MappingExtensions.ToDto, TABLE199MappingExtensions.ToEntity, TABLE199MappingExtensions.UpdateEntity) { }
}
