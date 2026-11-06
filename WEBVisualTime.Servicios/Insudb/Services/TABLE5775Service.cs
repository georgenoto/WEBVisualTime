using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5775;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5775Service : CrudService<TABLE5775, TABLE5775Dto, CreateTABLE5775Dto, UpdateTABLE5775Dto, int>, ITABLE5775Service
{
    public TABLE5775Service(IRepository<TABLE5775> repository)
        : base(repository, TABLE5775MappingExtensions.ToDto, TABLE5775MappingExtensions.ToEntity, TABLE5775MappingExtensions.UpdateEntity) { }
}
