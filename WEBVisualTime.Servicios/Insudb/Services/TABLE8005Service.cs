using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8005;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE8005Service : CrudService<TABLE8005, TABLE8005Dto, CreateTABLE8005Dto, UpdateTABLE8005Dto, int>, ITABLE8005Service
{
    public TABLE8005Service(IRepository<TABLE8005> repository)
        : base(repository, TABLE8005MappingExtensions.ToDto, TABLE8005MappingExtensions.ToEntity, TABLE8005MappingExtensions.UpdateEntity) { }
}
