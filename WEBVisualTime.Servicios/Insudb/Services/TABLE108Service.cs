using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE108;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE108Service : CrudService<TABLE108, TABLE108Dto, CreateTABLE108Dto, UpdateTABLE108Dto, string>, ITABLE108Service
{
    public TABLE108Service(IRepository<TABLE108> repository)
        : base(repository, TABLE108MappingExtensions.ToDto, TABLE108MappingExtensions.ToEntity, TABLE108MappingExtensions.UpdateEntity) { }
}
