﻿using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTO.Response
{
    public class GetByOrderIdQueryResponse:IDto
    {
        public Guid Id { get; set; }
    }
}