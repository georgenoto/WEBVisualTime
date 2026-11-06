using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE147;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE147Service : CrudService<TABLE147, TABLE147Dto, CreateTABLE147Dto, UpdateTABLE147Dto, int>, ITABLE147Service
{
    public TABLE147Service(IRepository<TABLE147> repository)
        : base(repository, TABLE147MappingExtensions.ToDto, TABLE147MappingExtensions.ToEntity, TABLE147MappingExtensions.UpdateEntity) { }
}
