using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.PCC004_FORM;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class PCC004_FORMService : CrudService<PCC004_FORM, PCC004_FORMDto, CreatePCC004_FORMDto, UpdatePCC004_FORMDto, long>, IPCC004_FORMService
{
    public PCC004_FORMService(IRepository<PCC004_FORM> repository)
        : base(repository, PCC004_FORMMappingExtensions.ToDto, PCC004_FORMMappingExtensions.ToEntity, PCC004_FORMMappingExtensions.UpdateEntity) { }
}
