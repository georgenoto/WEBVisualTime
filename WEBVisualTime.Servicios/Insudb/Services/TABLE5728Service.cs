using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5728;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5728Service : CrudService<TABLE5728, TABLE5728Dto, CreateTABLE5728Dto, UpdateTABLE5728Dto, int>, ITABLE5728Service
{
    public TABLE5728Service(IRepository<TABLE5728> repository)
        : base(repository, TABLE5728MappingExtensions.ToDto, TABLE5728MappingExtensions.ToEntity, TABLE5728MappingExtensions.UpdateEntity) { }
}
