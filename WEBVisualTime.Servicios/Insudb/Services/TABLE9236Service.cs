using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9236;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9236Service : CrudService<TABLE9236, TABLE9236Dto, CreateTABLE9236Dto, UpdateTABLE9236Dto, int>, ITABLE9236Service
{
    public TABLE9236Service(IRepository<TABLE9236> repository)
        : base(repository, TABLE9236MappingExtensions.ToDto, TABLE9236MappingExtensions.ToEntity, TABLE9236MappingExtensions.UpdateEntity) { }
}
