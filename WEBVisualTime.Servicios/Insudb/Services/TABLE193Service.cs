using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE193;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE193Service : CrudService<TABLE193, TABLE193Dto, CreateTABLE193Dto, UpdateTABLE193Dto, string>, ITABLE193Service
{
    public TABLE193Service(IRepository<TABLE193> repository)
        : base(repository, TABLE193MappingExtensions.ToDto, TABLE193MappingExtensions.ToEntity, TABLE193MappingExtensions.UpdateEntity) { }
}
