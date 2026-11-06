using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5542;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5542Service : CrudService<TABLE5542, TABLE5542Dto, CreateTABLE5542Dto, UpdateTABLE5542Dto, int>, ITABLE5542Service
{
    public TABLE5542Service(IRepository<TABLE5542> repository)
        : base(repository, TABLE5542MappingExtensions.ToDto, TABLE5542MappingExtensions.ToEntity, TABLE5542MappingExtensions.UpdateEntity) { }
}
