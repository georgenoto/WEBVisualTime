using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE78109;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE78109Service : CrudService<TABLE78109, TABLE78109Dto, CreateTABLE78109Dto, UpdateTABLE78109Dto, int>, ITABLE78109Service
{
    public TABLE78109Service(IRepository<TABLE78109> repository)
        : base(repository, TABLE78109MappingExtensions.ToDto, TABLE78109MappingExtensions.ToEntity, TABLE78109MappingExtensions.UpdateEntity) { }
}
