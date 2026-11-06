using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE137;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE137Service : CrudService<TABLE137, TABLE137Dto, CreateTABLE137Dto, UpdateTABLE137Dto, int>, ITABLE137Service
{
    public TABLE137Service(IRepository<TABLE137> repository)
        : base(repository, TABLE137MappingExtensions.ToDto, TABLE137MappingExtensions.ToEntity, TABLE137MappingExtensions.UpdateEntity) { }
}
