using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7206;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7206Service : CrudService<TABLE7206, TABLE7206Dto, CreateTABLE7206Dto, UpdateTABLE7206Dto, int>, ITABLE7206Service
{
    public TABLE7206Service(IRepository<TABLE7206> repository)
        : base(repository, TABLE7206MappingExtensions.ToDto, TABLE7206MappingExtensions.ToEntity, TABLE7206MappingExtensions.UpdateEntity) { }
}
