using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE320;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE320Service : CrudService<TABLE320, TABLE320Dto, CreateTABLE320Dto, UpdateTABLE320Dto, int>, ITABLE320Service
{
    public TABLE320Service(IRepository<TABLE320> repository)
        : base(repository, TABLE320MappingExtensions.ToDto, TABLE320MappingExtensions.ToEntity, TABLE320MappingExtensions.UpdateEntity) { }
}
