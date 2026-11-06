using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE695;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE695Service : CrudService<TABLE695, TABLE695Dto, CreateTABLE695Dto, UpdateTABLE695Dto, int>, ITABLE695Service
{
    public TABLE695Service(IRepository<TABLE695> repository)
        : base(repository, TABLE695MappingExtensions.ToDto, TABLE695MappingExtensions.ToEntity, TABLE695MappingExtensions.UpdateEntity) { }
}
