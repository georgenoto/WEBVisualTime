using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7504;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7504Service : CrudService<TABLE7504, TABLE7504Dto, CreateTABLE7504Dto, UpdateTABLE7504Dto, string>, ITABLE7504Service
{
    public TABLE7504Service(IRepository<TABLE7504> repository)
        : base(repository, TABLE7504MappingExtensions.ToDto, TABLE7504MappingExtensions.ToEntity, TABLE7504MappingExtensions.UpdateEntity) { }
}
