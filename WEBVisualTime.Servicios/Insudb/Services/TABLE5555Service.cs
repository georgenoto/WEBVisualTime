using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5555;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5555Service : CrudService<TABLE5555, TABLE5555Dto, CreateTABLE5555Dto, UpdateTABLE5555Dto, int>, ITABLE5555Service
{
    public TABLE5555Service(IRepository<TABLE5555> repository)
        : base(repository, TABLE5555MappingExtensions.ToDto, TABLE5555MappingExtensions.ToEntity, TABLE5555MappingExtensions.UpdateEntity) { }
}
