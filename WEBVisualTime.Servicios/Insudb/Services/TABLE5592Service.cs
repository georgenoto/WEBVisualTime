using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5592;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5592Service : CrudService<TABLE5592, TABLE5592Dto, CreateTABLE5592Dto, UpdateTABLE5592Dto, int>, ITABLE5592Service
{
    public TABLE5592Service(IRepository<TABLE5592> repository)
        : base(repository, TABLE5592MappingExtensions.ToDto, TABLE5592MappingExtensions.ToEntity, TABLE5592MappingExtensions.UpdateEntity) { }
}
