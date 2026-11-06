using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE323;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE323Service : CrudService<TABLE323, TABLE323Dto, CreateTABLE323Dto, UpdateTABLE323Dto, int>, ITABLE323Service
{
    public TABLE323Service(IRepository<TABLE323> repository)
        : base(repository, TABLE323MappingExtensions.ToDto, TABLE323MappingExtensions.ToEntity, TABLE323MappingExtensions.UpdateEntity) { }
}
