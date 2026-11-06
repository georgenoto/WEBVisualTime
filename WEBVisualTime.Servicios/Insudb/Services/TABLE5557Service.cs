using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5557;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5557Service : CrudService<TABLE5557, TABLE5557Dto, CreateTABLE5557Dto, UpdateTABLE5557Dto, int>, ITABLE5557Service
{
    public TABLE5557Service(IRepository<TABLE5557> repository)
        : base(repository, TABLE5557MappingExtensions.ToDto, TABLE5557MappingExtensions.ToEntity, TABLE5557MappingExtensions.UpdateEntity) { }
}
