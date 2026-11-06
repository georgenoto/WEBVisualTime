using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE999;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE999Service : CrudService<TABLE999, TABLE999Dto, CreateTABLE999Dto, UpdateTABLE999Dto, string>, ITABLE999Service
{
    public TABLE999Service(IRepository<TABLE999> repository)
        : base(repository, TABLE999MappingExtensions.ToDto, TABLE999MappingExtensions.ToEntity, TABLE999MappingExtensions.UpdateEntity) { }
}
