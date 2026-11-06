using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE140;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE140Service : CrudService<TABLE140, TABLE140Dto, CreateTABLE140Dto, UpdateTABLE140Dto, int>, ITABLE140Service
{
    public TABLE140Service(IRepository<TABLE140> repository)
        : base(repository, TABLE140MappingExtensions.ToDto, TABLE140MappingExtensions.ToEntity, TABLE140MappingExtensions.UpdateEntity) { }
}
