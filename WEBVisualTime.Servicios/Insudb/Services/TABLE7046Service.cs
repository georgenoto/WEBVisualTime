using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7046;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7046Service : CrudService<TABLE7046, TABLE7046Dto, CreateTABLE7046Dto, UpdateTABLE7046Dto, int>, ITABLE7046Service
{
    public TABLE7046Service(IRepository<TABLE7046> repository)
        : base(repository, TABLE7046MappingExtensions.ToDto, TABLE7046MappingExtensions.ToEntity, TABLE7046MappingExtensions.UpdateEntity) { }
}
