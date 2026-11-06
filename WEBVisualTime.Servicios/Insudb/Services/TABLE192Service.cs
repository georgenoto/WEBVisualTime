using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE192;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE192Service : CrudService<TABLE192, TABLE192Dto, CreateTABLE192Dto, UpdateTABLE192Dto, int>, ITABLE192Service
{
    public TABLE192Service(IRepository<TABLE192> repository)
        : base(repository, TABLE192MappingExtensions.ToDto, TABLE192MappingExtensions.ToEntity, TABLE192MappingExtensions.UpdateEntity) { }
}
