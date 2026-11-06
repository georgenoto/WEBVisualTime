using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5545;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5545Service : CrudService<TABLE5545, TABLE5545Dto, CreateTABLE5545Dto, UpdateTABLE5545Dto, int>, ITABLE5545Service
{
    public TABLE5545Service(IRepository<TABLE5545> repository)
        : base(repository, TABLE5545MappingExtensions.ToDto, TABLE5545MappingExtensions.ToEntity, TABLE5545MappingExtensions.UpdateEntity) { }
}
