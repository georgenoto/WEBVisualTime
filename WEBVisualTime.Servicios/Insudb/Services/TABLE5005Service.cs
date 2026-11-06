using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5005;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5005Service : CrudService<TABLE5005, TABLE5005Dto, CreateTABLE5005Dto, UpdateTABLE5005Dto, int>, ITABLE5005Service
{
    public TABLE5005Service(IRepository<TABLE5005> repository)
        : base(repository, TABLE5005MappingExtensions.ToDto, TABLE5005MappingExtensions.ToEntity, TABLE5005MappingExtensions.UpdateEntity) { }
}
