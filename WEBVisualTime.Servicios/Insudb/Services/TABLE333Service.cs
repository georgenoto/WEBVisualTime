using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE333;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE333Service : CrudService<TABLE333, TABLE333Dto, CreateTABLE333Dto, UpdateTABLE333Dto, int>, ITABLE333Service
{
    public TABLE333Service(IRepository<TABLE333> repository)
        : base(repository, TABLE333MappingExtensions.ToDto, TABLE333MappingExtensions.ToEntity, TABLE333MappingExtensions.UpdateEntity) { }
}
