using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5573;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5573Service : CrudService<TABLE5573, TABLE5573Dto, CreateTABLE5573Dto, UpdateTABLE5573Dto, int>, ITABLE5573Service
{
    public TABLE5573Service(IRepository<TABLE5573> repository)
        : base(repository, TABLE5573MappingExtensions.ToDto, TABLE5573MappingExtensions.ToEntity, TABLE5573MappingExtensions.UpdateEntity) { }
}
