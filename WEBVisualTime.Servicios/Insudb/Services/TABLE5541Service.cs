using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5541;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5541Service : CrudService<TABLE5541, TABLE5541Dto, CreateTABLE5541Dto, UpdateTABLE5541Dto, int>, ITABLE5541Service
{
    public TABLE5541Service(IRepository<TABLE5541> repository)
        : base(repository, TABLE5541MappingExtensions.ToDto, TABLE5541MappingExtensions.ToEntity, TABLE5541MappingExtensions.UpdateEntity) { }
}
