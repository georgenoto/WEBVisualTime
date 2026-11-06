using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9056;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9056Service : CrudService<TABLE9056, TABLE9056Dto, CreateTABLE9056Dto, UpdateTABLE9056Dto, int>, ITABLE9056Service
{
    public TABLE9056Service(IRepository<TABLE9056> repository)
        : base(repository, TABLE9056MappingExtensions.ToDto, TABLE9056MappingExtensions.ToEntity, TABLE9056MappingExtensions.UpdateEntity) { }
}
