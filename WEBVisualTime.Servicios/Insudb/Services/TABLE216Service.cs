using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE216;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE216Service : CrudService<TABLE216, TABLE216Dto, CreateTABLE216Dto, UpdateTABLE216Dto, long>, ITABLE216Service
{
    public TABLE216Service(IRepository<TABLE216> repository)
        : base(repository, TABLE216MappingExtensions.ToDto, TABLE216MappingExtensions.ToEntity, TABLE216MappingExtensions.UpdateEntity) { }
}
