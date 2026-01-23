using System.ComponentModel.DataAnnotations;

namespace AuthServiceIN6BV.Application.DTOs;

public class UpdateUserRoleDto
{
    public string roleName {get; set;} = string.Empty;

}