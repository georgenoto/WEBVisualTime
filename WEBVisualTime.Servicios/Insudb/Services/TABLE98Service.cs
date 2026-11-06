using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE98;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE98Service : CrudService<TABLE98, TABLE98Dto, CreateTABLE98Dto, UpdateTABLE98Dto, int>, ITABLE98Service
{
    public TABLE98Service(IRepository<TABLE98> repository)
        : base(repository, TABLE98MappingExtensions.ToDto, TABLE98MappingExtensions.ToEntity, TABLE98MappingExtensions.UpdateEntity) { }
}
