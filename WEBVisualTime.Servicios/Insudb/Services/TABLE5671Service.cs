using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5671;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5671Service : CrudService<TABLE5671, TABLE5671Dto, CreateTABLE5671Dto, UpdateTABLE5671Dto, int>, ITABLE5671Service
{
    public TABLE5671Service(IRepository<TABLE5671> repository)
        : base(repository, TABLE5671MappingExtensions.ToDto, TABLE5671MappingExtensions.ToEntity, TABLE5671MappingExtensions.UpdateEntity) { }
}
