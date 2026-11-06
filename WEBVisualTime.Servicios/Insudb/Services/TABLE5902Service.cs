using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5902;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5902Service : CrudService<TABLE5902, TABLE5902Dto, CreateTABLE5902Dto, UpdateTABLE5902Dto, int>, ITABLE5902Service
{
    public TABLE5902Service(IRepository<TABLE5902> repository)
        : base(repository, TABLE5902MappingExtensions.ToDto, TABLE5902MappingExtensions.ToEntity, TABLE5902MappingExtensions.UpdateEntity) { }
}
