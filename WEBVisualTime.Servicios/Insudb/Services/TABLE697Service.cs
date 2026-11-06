using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE697;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE697Service : CrudService<TABLE697, TABLE697Dto, CreateTABLE697Dto, UpdateTABLE697Dto, int>, ITABLE697Service
{
    public TABLE697Service(IRepository<TABLE697> repository)
        : base(repository, TABLE697MappingExtensions.ToDto, TABLE697MappingExtensions.ToEntity, TABLE697MappingExtensions.UpdateEntity) { }
}
