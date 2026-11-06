using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE61;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE61Service : CrudService<TABLE61, TABLE61Dto, CreateTABLE61Dto, UpdateTABLE61Dto, int>, ITABLE61Service
{
    public TABLE61Service(IRepository<TABLE61> repository)
        : base(repository, TABLE61MappingExtensions.ToDto, TABLE61MappingExtensions.ToEntity, TABLE61MappingExtensions.UpdateEntity) { }
}
