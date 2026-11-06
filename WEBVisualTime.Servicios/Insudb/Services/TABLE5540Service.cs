using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5540;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5540Service : CrudService<TABLE5540, TABLE5540Dto, CreateTABLE5540Dto, UpdateTABLE5540Dto, int>, ITABLE5540Service
{
    public TABLE5540Service(IRepository<TABLE5540> repository)
        : base(repository, TABLE5540MappingExtensions.ToDto, TABLE5540MappingExtensions.ToEntity, TABLE5540MappingExtensions.UpdateEntity) { }
}
