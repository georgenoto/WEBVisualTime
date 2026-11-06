using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE34;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE34Service : CrudService<TABLE34, TABLE34Dto, CreateTABLE34Dto, UpdateTABLE34Dto, long>, ITABLE34Service
{
    public TABLE34Service(IRepository<TABLE34> repository)
        : base(repository, TABLE34MappingExtensions.ToDto, TABLE34MappingExtensions.ToEntity, TABLE34MappingExtensions.UpdateEntity) { }
}
