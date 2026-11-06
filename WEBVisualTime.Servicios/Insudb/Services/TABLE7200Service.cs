using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7200;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7200Service : CrudService<TABLE7200, TABLE7200Dto, CreateTABLE7200Dto, UpdateTABLE7200Dto, int>, ITABLE7200Service
{
    public TABLE7200Service(IRepository<TABLE7200> repository)
        : base(repository, TABLE7200MappingExtensions.ToDto, TABLE7200MappingExtensions.ToEntity, TABLE7200MappingExtensions.UpdateEntity) { }
}
