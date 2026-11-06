using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5748;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5748Service : CrudService<TABLE5748, TABLE5748Dto, CreateTABLE5748Dto, UpdateTABLE5748Dto, int>, ITABLE5748Service
{
    public TABLE5748Service(IRepository<TABLE5748> repository)
        : base(repository, TABLE5748MappingExtensions.ToDto, TABLE5748MappingExtensions.ToEntity, TABLE5748MappingExtensions.UpdateEntity) { }
}
