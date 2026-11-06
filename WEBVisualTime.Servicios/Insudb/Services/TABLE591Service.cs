using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE591;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE591Service : CrudService<TABLE591, TABLE591Dto, CreateTABLE591Dto, UpdateTABLE591Dto, int>, ITABLE591Service
{
    public TABLE591Service(IRepository<TABLE591> repository)
        : base(repository, TABLE591MappingExtensions.ToDto, TABLE591MappingExtensions.ToEntity, TABLE591MappingExtensions.UpdateEntity) { }
}
