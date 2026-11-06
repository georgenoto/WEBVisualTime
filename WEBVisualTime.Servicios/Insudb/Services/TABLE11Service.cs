using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE11;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE11Service : CrudService<TABLE11, TABLE11Dto, CreateTABLE11Dto, UpdateTABLE11Dto, long>, ITABLE11Service
{
    public TABLE11Service(IRepository<TABLE11> repository)
        : base(repository, TABLE11MappingExtensions.ToDto, TABLE11MappingExtensions.ToEntity, TABLE11MappingExtensions.UpdateEntity) { }
}
