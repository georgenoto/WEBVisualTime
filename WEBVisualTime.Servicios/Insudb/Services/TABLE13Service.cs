using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE13;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE13Service : CrudService<TABLE13, TABLE13Dto, CreateTABLE13Dto, UpdateTABLE13Dto, int>, ITABLE13Service
{
    public TABLE13Service(IRepository<TABLE13> repository)
        : base(repository, TABLE13MappingExtensions.ToDto, TABLE13MappingExtensions.ToEntity, TABLE13MappingExtensions.UpdateEntity) { }
}
