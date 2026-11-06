using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE283;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE283Service : CrudService<TABLE283, TABLE283Dto, CreateTABLE283Dto, UpdateTABLE283Dto, int>, ITABLE283Service
{
    public TABLE283Service(IRepository<TABLE283> repository)
        : base(repository, TABLE283MappingExtensions.ToDto, TABLE283MappingExtensions.ToEntity, TABLE283MappingExtensions.UpdateEntity) { }
}
