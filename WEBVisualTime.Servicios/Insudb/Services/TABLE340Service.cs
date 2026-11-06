using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE340;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE340Service : CrudService<TABLE340, TABLE340Dto, CreateTABLE340Dto, UpdateTABLE340Dto, int>, ITABLE340Service
{
    public TABLE340Service(IRepository<TABLE340> repository)
        : base(repository, TABLE340MappingExtensions.ToDto, TABLE340MappingExtensions.ToEntity, TABLE340MappingExtensions.UpdateEntity) { }
}
