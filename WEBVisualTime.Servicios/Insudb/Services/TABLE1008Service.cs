using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1008;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE1008Service : CrudService<TABLE1008, TABLE1008Dto, CreateTABLE1008Dto, UpdateTABLE1008Dto, int>, ITABLE1008Service
{
    public TABLE1008Service(IRepository<TABLE1008> repository)
        : base(repository, TABLE1008MappingExtensions.ToDto, TABLE1008MappingExtensions.ToEntity, TABLE1008MappingExtensions.UpdateEntity) { }
}
