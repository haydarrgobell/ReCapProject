using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class ColorDetailDto:IDto
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
