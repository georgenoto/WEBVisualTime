using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5585;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5585Service : CrudService<TABLE5585, TABLE5585Dto, CreateTABLE5585Dto, UpdateTABLE5585Dto, int>, ITABLE5585Service
{
    public TABLE5585Service(IRepository<TABLE5585> repository)
        : base(repository, TABLE5585MappingExtensions.ToDto, TABLE5585MappingExtensions.ToEntity, TABLE5585MappingExtensions.UpdateEntity) { }
}
