﻿using System.ComponentModel.DataAnnotations;

namespace Philcosa.Application.Responses.Identity
{
    public class RoleResponse
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}