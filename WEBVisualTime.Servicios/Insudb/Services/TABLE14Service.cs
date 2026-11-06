using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE14;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE14Service : CrudService<TABLE14, TABLE14Dto, CreateTABLE14Dto, UpdateTABLE14Dto, int>, ITABLE14Service
{
    public TABLE14Service(IRepository<TABLE14> repository)
        : base(repository, TABLE14MappingExtensions.ToDto, TABLE14MappingExtensions.ToEntity, TABLE14MappingExtensions.UpdateEntity) { }
}
