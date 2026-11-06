using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE515;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE515Service : CrudService<TABLE515, TABLE515Dto, CreateTABLE515Dto, UpdateTABLE515Dto, long>, ITABLE515Service
{
    public TABLE515Service(IRepository<TABLE515> repository)
        : base(repository, TABLE515MappingExtensions.ToDto, TABLE515MappingExtensions.ToEntity, TABLE515MappingExtensions.UpdateEntity) { }
}
