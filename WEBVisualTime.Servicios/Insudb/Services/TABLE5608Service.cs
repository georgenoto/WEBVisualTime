using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5608;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5608Service : CrudService<TABLE5608, TABLE5608Dto, CreateTABLE5608Dto, UpdateTABLE5608Dto, int>, ITABLE5608Service
{
    public TABLE5608Service(IRepository<TABLE5608> repository)
        : base(repository, TABLE5608MappingExtensions.ToDto, TABLE5608MappingExtensions.ToEntity, TABLE5608MappingExtensions.UpdateEntity) { }
}
