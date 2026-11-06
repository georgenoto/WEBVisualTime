using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9232;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9232Service : CrudService<TABLE9232, TABLE9232Dto, CreateTABLE9232Dto, UpdateTABLE9232Dto, int>, ITABLE9232Service
{
    public TABLE9232Service(IRepository<TABLE9232> repository)
        : base(repository, TABLE9232MappingExtensions.ToDto, TABLE9232MappingExtensions.ToEntity, TABLE9232MappingExtensions.UpdateEntity) { }
}
