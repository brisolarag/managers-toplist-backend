using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using managers_back.src.managers.dtos;

namespace managers_back.src.managers.interfaces
{
    public interface IManagerService
    {
        Task<List<ManagerModel>> GetManagers();
        Task<ManagerModel> GetManager(uint managerId);
        Task<ManagerModel> NewManager(NewManagerRequest request);
        Task<ManagerModel> RemoveManager(uint managerId);
        Task<ManagerModel> EditManager(uint managerId, EditManagerRequest request);
        Task<ManagerModel> AddStack(uint managerId, string stack);
        Task<ManagerModel> RemoveStack(uint managerId, string stack);
        Task<List<string>> GetStacks(uint managerId);
        Task ChangePosition(List<ManagerRankUpdate> updates);
    }
}