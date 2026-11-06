using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE138;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE138Service : CrudService<TABLE138, TABLE138Dto, CreateTABLE138Dto, UpdateTABLE138Dto, int>, ITABLE138Service
{
    public TABLE138Service(IRepository<TABLE138> repository)
        : base(repository, TABLE138MappingExtensions.ToDto, TABLE138MappingExtensions.ToEntity, TABLE138MappingExtensions.UpdateEntity) { }
}
