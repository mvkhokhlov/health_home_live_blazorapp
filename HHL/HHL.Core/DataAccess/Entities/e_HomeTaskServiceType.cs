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
    [PgsDataTable(EntityAcceesNameHdr.HomeTaskServiceTypes)]
    public class e_HomeTaskServiceType : HHLBaseRepository<e_HomeTaskServiceType>
    {

        [PgsPK]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
