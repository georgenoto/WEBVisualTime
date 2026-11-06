using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE276;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE276Service : CrudService<TABLE276, TABLE276Dto, CreateTABLE276Dto, UpdateTABLE276Dto, string>, ITABLE276Service
{
    public TABLE276Service(IRepository<TABLE276> repository)
        : base(repository, TABLE276MappingExtensions.ToDto, TABLE276MappingExtensions.ToEntity, TABLE276MappingExtensions.UpdateEntity) { }
}
