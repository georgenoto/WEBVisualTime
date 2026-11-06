using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE178;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE178Service : CrudService<TABLE178, TABLE178Dto, CreateTABLE178Dto, UpdateTABLE178Dto, int>, ITABLE178Service
{
    public TABLE178Service(IRepository<TABLE178> repository)
        : base(repository, TABLE178MappingExtensions.ToDto, TABLE178MappingExtensions.ToEntity, TABLE178MappingExtensions.UpdateEntity) { }
}
