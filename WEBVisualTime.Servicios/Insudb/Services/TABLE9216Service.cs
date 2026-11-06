using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9216;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9216Service : CrudService<TABLE9216, TABLE9216Dto, CreateTABLE9216Dto, UpdateTABLE9216Dto, int>, ITABLE9216Service
{
    public TABLE9216Service(IRepository<TABLE9216> repository)
        : base(repository, TABLE9216MappingExtensions.ToDto, TABLE9216MappingExtensions.ToEntity, TABLE9216MappingExtensions.UpdateEntity) { }
}
