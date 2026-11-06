using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE153;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE153Service : CrudService<TABLE153, TABLE153Dto, CreateTABLE153Dto, UpdateTABLE153Dto, string>, ITABLE153Service
{
    public TABLE153Service(IRepository<TABLE153> repository)
        : base(repository, TABLE153MappingExtensions.ToDto, TABLE153MappingExtensions.ToEntity, TABLE153MappingExtensions.UpdateEntity) { }
}
