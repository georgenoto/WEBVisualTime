using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9017;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9017Service : CrudService<TABLE9017, TABLE9017Dto, CreateTABLE9017Dto, UpdateTABLE9017Dto, int>, ITABLE9017Service
{
    public TABLE9017Service(IRepository<TABLE9017> repository)
        : base(repository, TABLE9017MappingExtensions.ToDto, TABLE9017MappingExtensions.ToEntity, TABLE9017MappingExtensions.UpdateEntity) { }
}
