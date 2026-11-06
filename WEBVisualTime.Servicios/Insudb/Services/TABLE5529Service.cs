using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5529;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5529Service : CrudService<TABLE5529, TABLE5529Dto, CreateTABLE5529Dto, UpdateTABLE5529Dto, int>, ITABLE5529Service
{
    public TABLE5529Service(IRepository<TABLE5529> repository)
        : base(repository, TABLE5529MappingExtensions.ToDto, TABLE5529MappingExtensions.ToEntity, TABLE5529MappingExtensions.UpdateEntity) { }
}
