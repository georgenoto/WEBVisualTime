using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5519;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5519Service : CrudService<TABLE5519, TABLE5519Dto, CreateTABLE5519Dto, UpdateTABLE5519Dto, int>, ITABLE5519Service
{
    public TABLE5519Service(IRepository<TABLE5519> repository)
        : base(repository, TABLE5519MappingExtensions.ToDto, TABLE5519MappingExtensions.ToEntity, TABLE5519MappingExtensions.UpdateEntity) { }
}
