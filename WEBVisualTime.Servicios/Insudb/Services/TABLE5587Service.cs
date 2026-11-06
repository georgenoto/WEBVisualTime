using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5587;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5587Service : CrudService<TABLE5587, TABLE5587Dto, CreateTABLE5587Dto, UpdateTABLE5587Dto, int>, ITABLE5587Service
{
    public TABLE5587Service(IRepository<TABLE5587> repository)
        : base(repository, TABLE5587MappingExtensions.ToDto, TABLE5587MappingExtensions.ToEntity, TABLE5587MappingExtensions.UpdateEntity) { }
}
