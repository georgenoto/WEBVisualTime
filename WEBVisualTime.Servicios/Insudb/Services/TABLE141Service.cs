using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE141;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE141Service : CrudService<TABLE141, TABLE141Dto, CreateTABLE141Dto, UpdateTABLE141Dto, int>, ITABLE141Service
{
    public TABLE141Service(IRepository<TABLE141> repository)
        : base(repository, TABLE141MappingExtensions.ToDto, TABLE141MappingExtensions.ToEntity, TABLE141MappingExtensions.UpdateEntity) { }
}
