using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE527;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE527Service : CrudService<TABLE527, TABLE527Dto, CreateTABLE527Dto, UpdateTABLE527Dto, int>, ITABLE527Service
{
    public TABLE527Service(IRepository<TABLE527> repository)
        : base(repository, TABLE527MappingExtensions.ToDto, TABLE527MappingExtensions.ToEntity, TABLE527MappingExtensions.UpdateEntity) { }
}
