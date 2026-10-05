using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.HEALTHCLAIMFORM;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class HEALTHCLAIMFORMMappingExtensions
{
    public static HEALTHCLAIMFORMDto ToDto(this HEALTHCLAIMFORM entity)
    {
        if (entity == null) return null!;
        return new HEALTHCLAIMFORMDto
        {
            CLIENTE = entity.CLIENTE,
            IDRECLAMACION = entity.IDRECLAMACION,
            NCASENUM = entity.NCASENUM,
            FORMULARIO = entity.FORMULARIO,
            FECHACOMPUTADOR = entity.FECHACOMPUTADOR,
            FORMID = entity.FORMID,
            MODELID = entity.MODELID,
            USERID = entity.USERID,
            CONTENT = entity.CONTENT,
        };
    }

    public static HEALTHCLAIMFORM ToEntity(this CreateHEALTHCLAIMFORMDto dto)
    {
        if (dto == null) return null!;
        return new HEALTHCLAIMFORM
        {
            CLIENTE = dto.CLIENTE,
            IDRECLAMACION = dto.IDRECLAMACION,
            NCASENUM = dto.NCASENUM,
            FORMULARIO = dto.FORMULARIO,
            FECHACOMPUTADOR = dto.FECHACOMPUTADOR,
            USERID = dto.USERID,
            CONTENT = dto.CONTENT,
        };
    }

    public static void UpdateEntity(this HEALTHCLAIMFORM entity, UpdateHEALTHCLAIMFORMDto dto)
    {
        if (entity == null || dto == null) return;
        entity.CLIENTE = dto.CLIENTE;
        entity.IDRECLAMACION = dto.IDRECLAMACION;
        entity.NCASENUM = dto.NCASENUM;
        entity.FORMULARIO = dto.FORMULARIO;
        entity.FECHACOMPUTADOR = dto.FECHACOMPUTADOR;
        entity.USERID = dto.USERID;
        entity.CONTENT = dto.CONTENT;
    }
}
