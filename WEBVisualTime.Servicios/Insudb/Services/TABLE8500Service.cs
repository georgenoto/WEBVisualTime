using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8500;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8500Service : CrudService<TABLE8500, TABLE8500Dto, CreateTABLE8500Dto, UpdateTABLE8500Dto, int>, ITABLE8500Service
{
    public TABLE8500Service(IRepository<TABLE8500> repository)
        : base(repository, TABLE8500MappingExtensions.ToDto, TABLE8500MappingExtensions.ToEntity, TABLE8500MappingExtensions.UpdateEntity) { }
}
