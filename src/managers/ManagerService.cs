using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using managers_back.src.managers.dtos;
using managers_back.src.managers.interfaces;

namespace managers_back.src.managers
{
    public class ManagerService(IManagerRepository rep) : IManagerService
    {
        private readonly IManagerRepository _rep = rep;


        public async Task<List<ManagerModel>> GetManagers() {
            return await _rep.GetManagers();
        }

        public async Task<ManagerModel> GetManager(uint managerId) {
            return await _rep.GetManager(managerId);
        }

        public async Task<ManagerModel> NewManager(NewManagerRequest request)
        {
            return await _rep.NewManager(request);
        }

        public async Task<ManagerModel> RemoveManager(uint managerId)
        {
            return await _rep.RemoveManager(managerId);
        }

        public async Task<ManagerModel> EditManager(uint managerId, EditManagerRequest request)
        {
            return await _rep.EditManager(managerId, request);
        }

        public async Task<ManagerModel> AddStack(uint managerId, string stack)
        {
            return await _rep.AddStack(managerId, stack);
        }

        public async Task<ManagerModel> RemoveStack(uint managerId, string stack)
        {
            return await _rep.RemoveStack(managerId, stack);
        }

        public async Task<List<string>> GetStacks(uint managerId)
        {
            return await _rep.GetStacks(managerId);
        }

        public async Task ChangePosition(List<ManagerRankUpdate> updates) {
            await _rep.ChangePosition(updates);
        }
        
    }
}