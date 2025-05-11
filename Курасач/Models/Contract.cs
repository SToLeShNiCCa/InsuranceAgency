using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Курасач.Models;

public partial class Contract
{
    public int Id { get; set; }

    public int AgentId { get; set; }

    public int ClientId { get; set; }

    public DateTime ContractDate { get; set; } = DateTime.Now;

    public string Terms { get; set; } = null!;

    public virtual Agent Agent { get; set; } = null!;

    public virtual CommonUser Client { get; set; } = null!;

    [NotMapped]
    public List <CommonUser> UserContract
    {
        get
        {
            return DataWorker.GetAllContractByUsersId(ClientId);
        }
    }
    public CommonUser UserNameContract
    {
        get
        {
            return DataWorker.GetAllUsersNameForContract(ClientId);
        }
    }
    public Agent AgentsContract
    {
        get
        {
            return DataWorker.GetAllAgentsNameForContract(AgentId);
        }
    }
}
