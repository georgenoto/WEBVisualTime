using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5527;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5527Service : CrudService<TABLE5527, TABLE5527Dto, CreateTABLE5527Dto, UpdateTABLE5527Dto, int>, ITABLE5527Service
{
    public TABLE5527Service(IRepository<TABLE5527> repository)
        : base(repository, TABLE5527MappingExtensions.ToDto, TABLE5527MappingExtensions.ToEntity, TABLE5527MappingExtensions.UpdateEntity) { }
}
