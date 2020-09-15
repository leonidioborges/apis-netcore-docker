using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClientsAPI.Models;

namespace ClientsAPI.Repository
{

    public class ClientRepository
    {
        public List<ClientModel> AllClients()
        {
            List<ClientModel> _list = new List<ClientModel>();

            _list.Add(new ClientModel(){ Id = "123" , Name = "Leonidio" , Lastname = "Borges" });
            _list.Add(new ClientModel(){ Id = "123" , Name = "Larissa" , Lastname = "Rodriguess" });

            return _list;
        }

    }
}