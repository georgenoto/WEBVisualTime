using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5588;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5588Service : CrudService<TABLE5588, TABLE5588Dto, CreateTABLE5588Dto, UpdateTABLE5588Dto, int>, ITABLE5588Service
{
    public TABLE5588Service(IRepository<TABLE5588> repository)
        : base(repository, TABLE5588MappingExtensions.ToDto, TABLE5588MappingExtensions.ToEntity, TABLE5588MappingExtensions.UpdateEntity) { }
}
