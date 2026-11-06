using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5571;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5571Service : CrudService<TABLE5571, TABLE5571Dto, CreateTABLE5571Dto, UpdateTABLE5571Dto, int>, ITABLE5571Service
{
    public TABLE5571Service(IRepository<TABLE5571> repository)
        : base(repository, TABLE5571MappingExtensions.ToDto, TABLE5571MappingExtensions.ToEntity, TABLE5571MappingExtensions.UpdateEntity) { }
}
