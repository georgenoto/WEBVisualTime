using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5599;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5599Service : CrudService<TABLE5599, TABLE5599Dto, CreateTABLE5599Dto, UpdateTABLE5599Dto, int>, ITABLE5599Service
{
    public TABLE5599Service(IRepository<TABLE5599> repository)
        : base(repository, TABLE5599MappingExtensions.ToDto, TABLE5599MappingExtensions.ToEntity, TABLE5599MappingExtensions.UpdateEntity) { }
}
