using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE30;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE30Service : CrudService<TABLE30, TABLE30Dto, CreateTABLE30Dto, UpdateTABLE30Dto, string>, ITABLE30Service
{
    public TABLE30Service(IRepository<TABLE30> repository)
        : base(repository, TABLE30MappingExtensions.ToDto, TABLE30MappingExtensions.ToEntity, TABLE30MappingExtensions.UpdateEntity) { }
}
