using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5601;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5601Service : CrudService<TABLE5601, TABLE5601Dto, CreateTABLE5601Dto, UpdateTABLE5601Dto, int>, ITABLE5601Service
{
    public TABLE5601Service(IRepository<TABLE5601> repository)
        : base(repository, TABLE5601MappingExtensions.ToDto, TABLE5601MappingExtensions.ToEntity, TABLE5601MappingExtensions.UpdateEntity) { }
}
