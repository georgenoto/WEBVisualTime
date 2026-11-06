using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5533;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5533Service : CrudService<TABLE5533, TABLE5533Dto, CreateTABLE5533Dto, UpdateTABLE5533Dto, int>, ITABLE5533Service
{
    public TABLE5533Service(IRepository<TABLE5533> repository)
        : base(repository, TABLE5533MappingExtensions.ToDto, TABLE5533MappingExtensions.ToEntity, TABLE5533MappingExtensions.UpdateEntity) { }
}
