using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5593;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5593Service : CrudService<TABLE5593, TABLE5593Dto, CreateTABLE5593Dto, UpdateTABLE5593Dto, int>, ITABLE5593Service
{
    public TABLE5593Service(IRepository<TABLE5593> repository)
        : base(repository, TABLE5593MappingExtensions.ToDto, TABLE5593MappingExtensions.ToEntity, TABLE5593MappingExtensions.UpdateEntity) { }
}
