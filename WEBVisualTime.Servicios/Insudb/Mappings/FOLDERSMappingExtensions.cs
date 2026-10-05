using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FOLDERS;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class FOLDERSMappingExtensions
{
    public static FOLDERSDto ToDto(this FOLDERS entity)
    {
        if (entity == null) return null!;
        return new FOLDERSDto
        {
            NFOLDER = entity.NFOLDER,
            SFOLDERNAME = entity.SFOLDERNAME,
            SROOTNAME = entity.SROOTNAME,
            NIMAGE = entity.NIMAGE,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            SCLASS = entity.SCLASS,
            SFOLDERKEY = entity.SFOLDERKEY,
            NFOLDERKEY = entity.NFOLDERKEY,
            PROPERTYLIBRARYSPROPERTY = entity.PROPERTYLIBRARY?.SPROPERTY,
            SORIGI = entity.SORIGI,
        };
    }

    public static FOLDERS ToEntity(this CreateFOLDERSDto dto)
    {
        if (dto == null) return null!;
        return new FOLDERS
        {
            SFOLDERNAME = dto.SFOLDERNAME,
            SROOTNAME = dto.SROOTNAME,
            NIMAGE = dto.NIMAGE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            SCLASS = dto.SCLASS,
            SFOLDERKEY = dto.SFOLDERKEY,
            NFOLDERKEY = dto.NFOLDERKEY,
            SORIGI = dto.SORIGI,
        };
    }

    public static void UpdateEntity(this FOLDERS entity, UpdateFOLDERSDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SFOLDERNAME = dto.SFOLDERNAME;
        entity.SROOTNAME = dto.SROOTNAME;
        entity.NIMAGE = dto.NIMAGE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.SCLASS = dto.SCLASS;
        entity.SFOLDERKEY = dto.SFOLDERKEY;
        entity.NFOLDERKEY = dto.NFOLDERKEY;
        entity.SORIGI = dto.SORIGI;
    }
}
