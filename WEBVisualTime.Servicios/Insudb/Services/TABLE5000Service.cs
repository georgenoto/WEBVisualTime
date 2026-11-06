using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5000Service : CrudService<TABLE5000, TABLE5000Dto, CreateTABLE5000Dto, UpdateTABLE5000Dto, int>, ITABLE5000Service
{
    public TABLE5000Service(IRepository<TABLE5000> repository)
        : base(repository, TABLE5000MappingExtensions.ToDto, TABLE5000MappingExtensions.ToEntity, TABLE5000MappingExtensions.UpdateEntity) { }
}
