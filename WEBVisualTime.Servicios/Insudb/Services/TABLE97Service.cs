using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE97;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE97Service : CrudService<TABLE97, TABLE97Dto, CreateTABLE97Dto, UpdateTABLE97Dto, int>, ITABLE97Service
{
    public TABLE97Service(IRepository<TABLE97> repository)
        : base(repository, TABLE97MappingExtensions.ToDto, TABLE97MappingExtensions.ToEntity, TABLE97MappingExtensions.UpdateEntity) { }
}
