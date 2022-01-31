﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFinalProject.Areas.Admin.ViewModels.ServiceViewModels
{
    public class ServiceCreateViewModel
    {
        [Required]
        public IFormFile Image { get; set; }

        [Required(ErrorMessage = "Name Field is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description Field is Required")]
        public string Description { get; set; }
    }
}
