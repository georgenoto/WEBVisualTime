using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5636;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5636Service : CrudService<TABLE5636, TABLE5636Dto, CreateTABLE5636Dto, UpdateTABLE5636Dto, int>, ITABLE5636Service
{
    public TABLE5636Service(IRepository<TABLE5636> repository)
        : base(repository, TABLE5636MappingExtensions.ToDto, TABLE5636MappingExtensions.ToEntity, TABLE5636MappingExtensions.UpdateEntity) { }
}
