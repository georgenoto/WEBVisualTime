using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5575;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5575Service : CrudService<TABLE5575, TABLE5575Dto, CreateTABLE5575Dto, UpdateTABLE5575Dto, int>, ITABLE5575Service
{
    public TABLE5575Service(IRepository<TABLE5575> repository)
        : base(repository, TABLE5575MappingExtensions.ToDto, TABLE5575MappingExtensions.ToEntity, TABLE5575MappingExtensions.UpdateEntity) { }
}
