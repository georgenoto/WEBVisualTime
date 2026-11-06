using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE360;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE360Service : CrudService<TABLE360, TABLE360Dto, CreateTABLE360Dto, UpdateTABLE360Dto, int>, ITABLE360Service
{
    public TABLE360Service(IRepository<TABLE360> repository)
        : base(repository, TABLE360MappingExtensions.ToDto, TABLE360MappingExtensions.ToEntity, TABLE360MappingExtensions.UpdateEntity) { }
}
