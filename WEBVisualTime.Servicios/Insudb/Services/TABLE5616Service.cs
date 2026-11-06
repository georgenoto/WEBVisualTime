using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5616;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5616Service : CrudService<TABLE5616, TABLE5616Dto, CreateTABLE5616Dto, UpdateTABLE5616Dto, int>, ITABLE5616Service
{
    public TABLE5616Service(IRepository<TABLE5616> repository)
        : base(repository, TABLE5616MappingExtensions.ToDto, TABLE5616MappingExtensions.ToEntity, TABLE5616MappingExtensions.UpdateEntity) { }
}
