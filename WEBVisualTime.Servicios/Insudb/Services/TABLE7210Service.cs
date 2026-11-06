using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7210;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7210Service : CrudService<TABLE7210, TABLE7210Dto, CreateTABLE7210Dto, UpdateTABLE7210Dto, int>, ITABLE7210Service
{
    public TABLE7210Service(IRepository<TABLE7210> repository)
        : base(repository, TABLE7210MappingExtensions.ToDto, TABLE7210MappingExtensions.ToEntity, TABLE7210MappingExtensions.UpdateEntity) { }
}
