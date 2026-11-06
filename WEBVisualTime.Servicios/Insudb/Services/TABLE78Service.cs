using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE78;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE78Service : CrudService<TABLE78, TABLE78Dto, CreateTABLE78Dto, UpdateTABLE78Dto, int>, ITABLE78Service
{
    public TABLE78Service(IRepository<TABLE78> repository)
        : base(repository, TABLE78MappingExtensions.ToDto, TABLE78MappingExtensions.ToEntity, TABLE78MappingExtensions.UpdateEntity) { }
}
