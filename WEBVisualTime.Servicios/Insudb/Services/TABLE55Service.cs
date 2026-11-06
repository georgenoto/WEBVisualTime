using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE55;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE55Service : CrudService<TABLE55, TABLE55Dto, CreateTABLE55Dto, UpdateTABLE55Dto, int>, ITABLE55Service
{
    public TABLE55Service(IRepository<TABLE55> repository)
        : base(repository, TABLE55MappingExtensions.ToDto, TABLE55MappingExtensions.ToEntity, TABLE55MappingExtensions.UpdateEntity) { }
}
