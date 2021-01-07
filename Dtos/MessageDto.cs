using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SimpleProjectSE2.Dtos
{
    public class MessageDto
    {
        public string Type { get; set; }
        public string JsonContent { get; set; }
    }
}
