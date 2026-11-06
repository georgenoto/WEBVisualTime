using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9200;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE9200Service : CrudService<TABLE9200, TABLE9200Dto, CreateTABLE9200Dto, UpdateTABLE9200Dto, int>, ITABLE9200Service
{
    public TABLE9200Service(IRepository<TABLE9200> repository)
        : base(repository, TABLE9200MappingExtensions.ToDto, TABLE9200MappingExtensions.ToEntity, TABLE9200MappingExtensions.UpdateEntity) { }
}
