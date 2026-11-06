using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE48;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE48Service : CrudService<TABLE48, TABLE48Dto, CreateTABLE48Dto, UpdateTABLE48Dto, int>, ITABLE48Service
{
    public TABLE48Service(IRepository<TABLE48> repository)
        : base(repository, TABLE48MappingExtensions.ToDto, TABLE48MappingExtensions.ToEntity, TABLE48MappingExtensions.UpdateEntity) { }
}
