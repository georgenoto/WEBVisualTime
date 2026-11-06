using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7047;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7047Service : CrudService<TABLE7047, TABLE7047Dto, CreateTABLE7047Dto, UpdateTABLE7047Dto, int>, ITABLE7047Service
{
    public TABLE7047Service(IRepository<TABLE7047> repository)
        : base(repository, TABLE7047MappingExtensions.ToDto, TABLE7047MappingExtensions.ToEntity, TABLE7047MappingExtensions.UpdateEntity) { }
}
