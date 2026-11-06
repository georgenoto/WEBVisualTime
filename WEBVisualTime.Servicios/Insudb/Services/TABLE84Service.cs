using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE84;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE84Service : CrudService<TABLE84, TABLE84Dto, CreateTABLE84Dto, UpdateTABLE84Dto, int>, ITABLE84Service
{
    public TABLE84Service(IRepository<TABLE84> repository)
        : base(repository, TABLE84MappingExtensions.ToDto, TABLE84MappingExtensions.ToEntity, TABLE84MappingExtensions.UpdateEntity) { }
}
