using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5001Service : CrudService<TABLE5001, TABLE5001Dto, CreateTABLE5001Dto, UpdateTABLE5001Dto, int>, ITABLE5001Service
{
    public TABLE5001Service(IRepository<TABLE5001> repository)
        : base(repository, TABLE5001MappingExtensions.ToDto, TABLE5001MappingExtensions.ToEntity, TABLE5001MappingExtensions.UpdateEntity) { }
}
