using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.PERSON_TYPE;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class PERSON_TYPEService : CrudService<PERSON_TYPE, PERSON_TYPEDto, CreatePERSON_TYPEDto, UpdatePERSON_TYPEDto, long>, IPERSON_TYPEService
{
    public PERSON_TYPEService(IRepository<PERSON_TYPE> repository)
        : base(repository, PERSON_TYPEMappingExtensions.ToDto, PERSON_TYPEMappingExtensions.ToEntity, PERSON_TYPEMappingExtensions.UpdateEntity) { }
}
