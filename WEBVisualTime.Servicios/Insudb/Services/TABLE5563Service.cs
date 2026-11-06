using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5563;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5563Service : CrudService<TABLE5563, TABLE5563Dto, CreateTABLE5563Dto, UpdateTABLE5563Dto, int>, ITABLE5563Service
{
    public TABLE5563Service(IRepository<TABLE5563> repository)
        : base(repository, TABLE5563MappingExtensions.ToDto, TABLE5563MappingExtensions.ToEntity, TABLE5563MappingExtensions.UpdateEntity) { }
}
