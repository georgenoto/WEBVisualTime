using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE161;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE161Service : CrudService<TABLE161, TABLE161Dto, CreateTABLE161Dto, UpdateTABLE161Dto, string>, ITABLE161Service
{
    public TABLE161Service(IRepository<TABLE161> repository)
        : base(repository, TABLE161MappingExtensions.ToDto, TABLE161MappingExtensions.ToEntity, TABLE161MappingExtensions.UpdateEntity) { }
}
