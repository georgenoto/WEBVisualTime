using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5677;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5677Service : CrudService<TABLE5677, TABLE5677Dto, CreateTABLE5677Dto, UpdateTABLE5677Dto, int>, ITABLE5677Service
{
    public TABLE5677Service(IRepository<TABLE5677> repository)
        : base(repository, TABLE5677MappingExtensions.ToDto, TABLE5677MappingExtensions.ToEntity, TABLE5677MappingExtensions.UpdateEntity) { }
}
