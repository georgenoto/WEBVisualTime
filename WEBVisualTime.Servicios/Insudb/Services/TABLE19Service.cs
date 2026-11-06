using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE19;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE19Service : CrudService<TABLE19, TABLE19Dto, CreateTABLE19Dto, UpdateTABLE19Dto, int>, ITABLE19Service
{
    public TABLE19Service(IRepository<TABLE19> repository)
        : base(repository, TABLE19MappingExtensions.ToDto, TABLE19MappingExtensions.ToEntity, TABLE19MappingExtensions.UpdateEntity) { }
}
