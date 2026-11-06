using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE531;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE531Service : CrudService<TABLE531, TABLE531Dto, CreateTABLE531Dto, UpdateTABLE531Dto, int>, ITABLE531Service
{
    public TABLE531Service(IRepository<TABLE531> repository)
        : base(repository, TABLE531MappingExtensions.ToDto, TABLE531MappingExtensions.ToEntity, TABLE531MappingExtensions.UpdateEntity) { }
}
