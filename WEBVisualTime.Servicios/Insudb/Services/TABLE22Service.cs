using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE22;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE22Service : CrudService<TABLE22, TABLE22Dto, CreateTABLE22Dto, UpdateTABLE22Dto, int>, ITABLE22Service
{
    public TABLE22Service(IRepository<TABLE22> repository)
        : base(repository, TABLE22MappingExtensions.ToDto, TABLE22MappingExtensions.ToEntity, TABLE22MappingExtensions.UpdateEntity) { }
}
