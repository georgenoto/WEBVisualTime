using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE15;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE15Service : CrudService<TABLE15, TABLE15Dto, CreateTABLE15Dto, UpdateTABLE15Dto, int>, ITABLE15Service
{
    public TABLE15Service(IRepository<TABLE15> repository)
        : base(repository, TABLE15MappingExtensions.ToDto, TABLE15MappingExtensions.ToEntity, TABLE15MappingExtensions.UpdateEntity) { }
}
