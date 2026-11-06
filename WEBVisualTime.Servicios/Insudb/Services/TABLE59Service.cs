using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE59;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE59Service : CrudService<TABLE59, TABLE59Dto, CreateTABLE59Dto, UpdateTABLE59Dto, int>, ITABLE59Service
{
    public TABLE59Service(IRepository<TABLE59> repository)
        : base(repository, TABLE59MappingExtensions.ToDto, TABLE59MappingExtensions.ToEntity, TABLE59MappingExtensions.UpdateEntity) { }
}
