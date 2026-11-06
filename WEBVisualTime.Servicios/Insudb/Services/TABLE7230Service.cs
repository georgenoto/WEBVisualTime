using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7230;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7230Service : CrudService<TABLE7230, TABLE7230Dto, CreateTABLE7230Dto, UpdateTABLE7230Dto, int>, ITABLE7230Service
{
    public TABLE7230Service(IRepository<TABLE7230> repository)
        : base(repository, TABLE7230MappingExtensions.ToDto, TABLE7230MappingExtensions.ToEntity, TABLE7230MappingExtensions.UpdateEntity) { }
}
