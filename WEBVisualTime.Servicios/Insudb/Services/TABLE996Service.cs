using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE996;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE996Service : CrudService<TABLE996, TABLE996Dto, CreateTABLE996Dto, UpdateTABLE996Dto, int>, ITABLE996Service
{
    public TABLE996Service(IRepository<TABLE996> repository)
        : base(repository, TABLE996MappingExtensions.ToDto, TABLE996MappingExtensions.ToEntity, TABLE996MappingExtensions.UpdateEntity) { }
}
