using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5710;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE5710Service : CrudService<TABLE5710, TABLE5710Dto, CreateTABLE5710Dto, UpdateTABLE5710Dto, int>, ITABLE5710Service
{
    public TABLE5710Service(IRepository<TABLE5710> repository)
        : base(repository, TABLE5710MappingExtensions.ToDto, TABLE5710MappingExtensions.ToEntity, TABLE5710MappingExtensions.UpdateEntity) { }
}
