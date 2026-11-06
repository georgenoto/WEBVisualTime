using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5572;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5572Service : CrudService<TABLE5572, TABLE5572Dto, CreateTABLE5572Dto, UpdateTABLE5572Dto, int>, ITABLE5572Service
{
    public TABLE5572Service(IRepository<TABLE5572> repository)
        : base(repository, TABLE5572MappingExtensions.ToDto, TABLE5572MappingExtensions.ToEntity, TABLE5572MappingExtensions.UpdateEntity) { }
}
