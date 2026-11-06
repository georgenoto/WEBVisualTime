using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE163;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE163Service : CrudService<TABLE163, TABLE163Dto, CreateTABLE163Dto, UpdateTABLE163Dto, int>, ITABLE163Service
{
    public TABLE163Service(IRepository<TABLE163> repository)
        : base(repository, TABLE163MappingExtensions.ToDto, TABLE163MappingExtensions.ToEntity, TABLE163MappingExtensions.UpdateEntity) { }
}
