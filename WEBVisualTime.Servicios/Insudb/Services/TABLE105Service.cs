using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE105;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE105Service : CrudService<TABLE105, TABLE105Dto, CreateTABLE105Dto, UpdateTABLE105Dto, string>, ITABLE105Service
{
    public TABLE105Service(IRepository<TABLE105> repository)
        : base(repository, TABLE105MappingExtensions.ToDto, TABLE105MappingExtensions.ToEntity, TABLE105MappingExtensions.UpdateEntity) { }
}
