using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5561;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5561Service : CrudService<TABLE5561, TABLE5561Dto, CreateTABLE5561Dto, UpdateTABLE5561Dto, int>, ITABLE5561Service
{
    public TABLE5561Service(IRepository<TABLE5561> repository)
        : base(repository, TABLE5561MappingExtensions.ToDto, TABLE5561MappingExtensions.ToEntity, TABLE5561MappingExtensions.UpdateEntity) { }
}
