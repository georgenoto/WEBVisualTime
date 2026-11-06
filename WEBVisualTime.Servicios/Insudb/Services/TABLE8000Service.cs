using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8000;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8000Service : CrudService<TABLE8000, TABLE8000Dto, CreateTABLE8000Dto, UpdateTABLE8000Dto, int>, ITABLE8000Service
{
    public TABLE8000Service(IRepository<TABLE8000> repository)
        : base(repository, TABLE8000MappingExtensions.ToDto, TABLE8000MappingExtensions.ToEntity, TABLE8000MappingExtensions.UpdateEntity) { }
}
