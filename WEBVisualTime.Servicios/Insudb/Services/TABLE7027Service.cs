using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7027;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE7027Service : CrudService<TABLE7027, TABLE7027Dto, CreateTABLE7027Dto, UpdateTABLE7027Dto, int>, ITABLE7027Service
{
    public TABLE7027Service(IRepository<TABLE7027> repository)
        : base(repository, TABLE7027MappingExtensions.ToDto, TABLE7027MappingExtensions.ToEntity, TABLE7027MappingExtensions.UpdateEntity) { }
}
