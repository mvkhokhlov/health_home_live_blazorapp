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
    [PgsDataTable(EntityAcceesNameHdr.Continents)]
    public class e_Continent : HHLBaseRepository<e_Continent>
    {


        [PgsPK]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

    }
}
