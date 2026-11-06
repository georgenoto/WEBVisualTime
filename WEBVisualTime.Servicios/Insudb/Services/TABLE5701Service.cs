using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5701;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5701Service : CrudService<TABLE5701, TABLE5701Dto, CreateTABLE5701Dto, UpdateTABLE5701Dto, int>, ITABLE5701Service
{
    public TABLE5701Service(IRepository<TABLE5701> repository)
        : base(repository, TABLE5701MappingExtensions.ToDto, TABLE5701MappingExtensions.ToEntity, TABLE5701MappingExtensions.UpdateEntity) { }
}
