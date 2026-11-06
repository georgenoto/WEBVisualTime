using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE10Service : CrudService<TABLE10, TABLE10Dto, CreateTABLE10Dto, UpdateTABLE10Dto, int>, ITABLE10Service
{
    public TABLE10Service(IRepository<TABLE10> repository)
        : base(repository, TABLE10MappingExtensions.ToDto, TABLE10MappingExtensions.ToEntity, TABLE10MappingExtensions.UpdateEntity) { }
}
