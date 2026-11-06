using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5558;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5558Service : CrudService<TABLE5558, TABLE5558Dto, CreateTABLE5558Dto, UpdateTABLE5558Dto, int>, ITABLE5558Service
{
    public TABLE5558Service(IRepository<TABLE5558> repository)
        : base(repository, TABLE5558MappingExtensions.ToDto, TABLE5558MappingExtensions.ToEntity, TABLE5558MappingExtensions.UpdateEntity) { }
}
