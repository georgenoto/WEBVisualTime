using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE291;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE291Service : CrudService<TABLE291, TABLE291Dto, CreateTABLE291Dto, UpdateTABLE291Dto, string>, ITABLE291Service
{
    public TABLE291Service(IRepository<TABLE291> repository)
        : base(repository, TABLE291MappingExtensions.ToDto, TABLE291MappingExtensions.ToEntity, TABLE291MappingExtensions.UpdateEntity) { }
}
