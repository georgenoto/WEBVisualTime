using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5570;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5570Service : CrudService<TABLE5570, TABLE5570Dto, CreateTABLE5570Dto, UpdateTABLE5570Dto, int>, ITABLE5570Service
{
    public TABLE5570Service(IRepository<TABLE5570> repository)
        : base(repository, TABLE5570MappingExtensions.ToDto, TABLE5570MappingExtensions.ToEntity, TABLE5570MappingExtensions.UpdateEntity) { }
}
