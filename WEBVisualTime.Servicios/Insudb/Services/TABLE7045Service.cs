using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7045;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7045Service : CrudService<TABLE7045, TABLE7045Dto, CreateTABLE7045Dto, UpdateTABLE7045Dto, int>, ITABLE7045Service
{
    public TABLE7045Service(IRepository<TABLE7045> repository)
        : base(repository, TABLE7045MappingExtensions.ToDto, TABLE7045MappingExtensions.ToEntity, TABLE7045MappingExtensions.UpdateEntity) { }
}
