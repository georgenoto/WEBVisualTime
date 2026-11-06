using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.PROPERTYLIBRARY;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class PROPERTYLIBRARYService : CrudService<PROPERTYLIBRARY, PROPERTYLIBRARYDto, CreatePROPERTYLIBRARYDto, UpdatePROPERTYLIBRARYDto, int>, IPROPERTYLIBRARYService
{
    public PROPERTYLIBRARYService(IRepository<PROPERTYLIBRARY> repository)
        : base(repository, PROPERTYLIBRARYMappingExtensions.ToDto, PROPERTYLIBRARYMappingExtensions.ToEntity, PROPERTYLIBRARYMappingExtensions.UpdateEntity) { }
}
