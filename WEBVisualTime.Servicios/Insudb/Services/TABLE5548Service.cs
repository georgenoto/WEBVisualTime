using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5548;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5548Service : CrudService<TABLE5548, TABLE5548Dto, CreateTABLE5548Dto, UpdateTABLE5548Dto, int>, ITABLE5548Service
{
    public TABLE5548Service(IRepository<TABLE5548> repository)
        : base(repository, TABLE5548MappingExtensions.ToDto, TABLE5548MappingExtensions.ToEntity, TABLE5548MappingExtensions.UpdateEntity) { }
}
