using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5547;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5547Service : CrudService<TABLE5547, TABLE5547Dto, CreateTABLE5547Dto, UpdateTABLE5547Dto, int>, ITABLE5547Service
{
    public TABLE5547Service(IRepository<TABLE5547> repository)
        : base(repository, TABLE5547MappingExtensions.ToDto, TABLE5547MappingExtensions.ToEntity, TABLE5547MappingExtensions.UpdateEntity) { }
}
