using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9014;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9014Service : CrudService<TABLE9014, TABLE9014Dto, CreateTABLE9014Dto, UpdateTABLE9014Dto, int>, ITABLE9014Service
{
    public TABLE9014Service(IRepository<TABLE9014> repository)
        : base(repository, TABLE9014MappingExtensions.ToDto, TABLE9014MappingExtensions.ToEntity, TABLE9014MappingExtensions.UpdateEntity) { }
}
