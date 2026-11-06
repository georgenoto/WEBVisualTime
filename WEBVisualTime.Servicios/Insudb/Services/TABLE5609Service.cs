using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5609;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5609Service : CrudService<TABLE5609, TABLE5609Dto, CreateTABLE5609Dto, UpdateTABLE5609Dto, int>, ITABLE5609Service
{
    public TABLE5609Service(IRepository<TABLE5609> repository)
        : base(repository, TABLE5609MappingExtensions.ToDto, TABLE5609MappingExtensions.ToEntity, TABLE5609MappingExtensions.UpdateEntity) { }
}
