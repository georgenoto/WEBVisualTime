using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5634;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5634Service : CrudService<TABLE5634, TABLE5634Dto, CreateTABLE5634Dto, UpdateTABLE5634Dto, int>, ITABLE5634Service
{
    public TABLE5634Service(IRepository<TABLE5634> repository)
        : base(repository, TABLE5634MappingExtensions.ToDto, TABLE5634MappingExtensions.ToEntity, TABLE5634MappingExtensions.UpdateEntity) { }
}
