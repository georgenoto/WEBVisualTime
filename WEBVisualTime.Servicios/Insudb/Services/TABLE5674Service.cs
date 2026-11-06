using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5674;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5674Service : CrudService<TABLE5674, TABLE5674Dto, CreateTABLE5674Dto, UpdateTABLE5674Dto, int>, ITABLE5674Service
{
    public TABLE5674Service(IRepository<TABLE5674> repository)
        : base(repository, TABLE5674MappingExtensions.ToDto, TABLE5674MappingExtensions.ToEntity, TABLE5674MappingExtensions.UpdateEntity) { }
}
