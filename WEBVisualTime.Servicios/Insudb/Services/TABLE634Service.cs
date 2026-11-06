using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE634;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE634Service : CrudService<TABLE634, TABLE634Dto, CreateTABLE634Dto, UpdateTABLE634Dto, int>, ITABLE634Service
{
    public TABLE634Service(IRepository<TABLE634> repository)
        : base(repository, TABLE634MappingExtensions.ToDto, TABLE634MappingExtensions.ToEntity, TABLE634MappingExtensions.UpdateEntity) { }
}
