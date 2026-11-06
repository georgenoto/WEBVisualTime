using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5523;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5523Service : CrudService<TABLE5523, TABLE5523Dto, CreateTABLE5523Dto, UpdateTABLE5523Dto, int>, ITABLE5523Service
{
    public TABLE5523Service(IRepository<TABLE5523> repository)
        : base(repository, TABLE5523MappingExtensions.ToDto, TABLE5523MappingExtensions.ToEntity, TABLE5523MappingExtensions.UpdateEntity) { }
}
