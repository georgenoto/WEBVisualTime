using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5638;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5638Service : CrudService<TABLE5638, TABLE5638Dto, CreateTABLE5638Dto, UpdateTABLE5638Dto, int>, ITABLE5638Service
{
    public TABLE5638Service(IRepository<TABLE5638> repository)
        : base(repository, TABLE5638MappingExtensions.ToDto, TABLE5638MappingExtensions.ToEntity, TABLE5638MappingExtensions.UpdateEntity) { }
}
