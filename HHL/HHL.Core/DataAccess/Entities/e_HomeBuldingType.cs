using HHL.Auth.Core.Handlers;
using HHL.Core.Handlers;
using HHL.Core.Services;
using HHL.PostreSQL.Core;
using HHL.PostreSQL.Core.Attributes;
using HHL.PostreSQL.Core.Services;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Text;

namespace HHL.Core.DataAccess.Entities
{
    [PgsDataTable(EntityAcceesNameHdr.HomeBuldingTypes)]
    public class e_HomeBuldingType : HHLBaseRepository<e_HomeBuldingType>
    {

        [PgsPK]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
  
    }
}
