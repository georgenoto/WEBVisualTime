using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE3022;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TABLE3022Service : CrudService<TABLE3022, TABLE3022Dto, CreateTABLE3022Dto, UpdateTABLE3022Dto, int>, ITABLE3022Service
{
    public TABLE3022Service(IRepository<TABLE3022> repository)
        : base(repository, TABLE3022MappingExtensions.ToDto, TABLE3022MappingExtensions.ToEntity, TABLE3022MappingExtensions.UpdateEntity) { }
}
