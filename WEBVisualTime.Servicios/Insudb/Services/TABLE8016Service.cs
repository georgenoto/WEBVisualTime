using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8016;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8016Service : CrudService<TABLE8016, TABLE8016Dto, CreateTABLE8016Dto, UpdateTABLE8016Dto, int>, ITABLE8016Service
{
    public TABLE8016Service(IRepository<TABLE8016> repository)
        : base(repository, TABLE8016MappingExtensions.ToDto, TABLE8016MappingExtensions.ToEntity, TABLE8016MappingExtensions.UpdateEntity) { }
}
