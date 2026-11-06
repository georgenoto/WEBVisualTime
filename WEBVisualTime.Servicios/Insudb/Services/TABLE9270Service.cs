using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9270;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9270Service : CrudService<TABLE9270, TABLE9270Dto, CreateTABLE9270Dto, UpdateTABLE9270Dto, long>, ITABLE9270Service
{
    public TABLE9270Service(IRepository<TABLE9270> repository)
        : base(repository, TABLE9270MappingExtensions.ToDto, TABLE9270MappingExtensions.ToEntity, TABLE9270MappingExtensions.UpdateEntity) { }
}
