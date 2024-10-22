using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using managers_back.src.context;
using managers_back.src.managers.dtos;
using managers_back.src.managers.interfaces;
using Microsoft.EntityFrameworkCore;

namespace managers_back.src.managers
{
    public class ManagerRepository(ApiContext db) : IManagerRepository
    {
        private readonly ApiContext _db = db;

        public async Task<List<ManagerModel>> GetManagers()
        {
            return await _db.Managers.ToListAsync();
        }

        public async Task<ManagerModel> GetManager(uint managerId)
        {
            return await _db.Managers.SingleOrDefaultAsync(manager => manager.Id == managerId) ?? throw new Exception("Manager not found");
        }

        public async Task<ManagerModel> AddStack(uint managerId, string stack)
        {
            var manager = await _db.Managers.FirstOrDefaultAsync(man => man.Id == managerId) ?? throw new Exception("Manager not found");
            if (manager.Stacks.Contains(stack))
                throw new Exception("Manager already have this stack.");
            manager.Stacks.Add(stack);
            await _db.SaveChangesAsync();
            return manager;
        }

        public async Task<ManagerModel> RemoveStack(uint managerId, string stack)
        {
            var manager = await _db.Managers.FirstOrDefaultAsync(man => man.Id == managerId) ?? throw new Exception("Manager not found");
            if (!manager.Stacks.Contains(stack))
                throw new Exception("Manager doesnt have this stack.");

            manager.Stacks.Remove(stack);
            await _db.SaveChangesAsync();
            return manager;
        }

        public async Task<ManagerModel> EditManager(uint managerId, EditManagerRequest request)
        {
            var manager = await _db.Managers.FirstOrDefaultAsync(man => man.Id == managerId) ?? throw new Exception("Manager not found");
            if (request.ManagerName != null)
            {
                manager.ManagerName = request.ManagerName;
            }
            if (request.TeamName != null)
            {
                manager.RoleName = request.TeamName;
            }
            if (request.Description != null)
            {
                manager.Description = request.Description;
            }

            await _db.SaveChangesAsync();
            return manager;
        }

        public async Task<List<string>> GetStacks(uint managerId)
        {
            var manager = await _db.Managers.FirstOrDefaultAsync(man => man.Id == managerId) ?? throw new Exception("Manager not found");
            return manager.Stacks;
        }

        public async Task<ManagerModel> NewManager(NewManagerRequest request)
        {
            ManagerModel newManager = request.Parse();
            _db.Add(newManager);
            await _db.SaveChangesAsync();
            newManager.Rank = newManager.Id;
            await _db.SaveChangesAsync();
            return newManager;
        }

        public async Task<ManagerModel> RemoveManager(uint managerId)
        {
            var manager = await _db.Managers.FirstOrDefaultAsync(man => man.Id == managerId) ?? throw new Exception("Manager not found");
            _db.Remove(manager);
            await _db.SaveChangesAsync();
            return manager;
        }

        public async Task ChangePosition(List<ManagerRankUpdate> updates)
        {
            if (updates == null || !updates.Any())
            {
                throw new ArgumentException("Invalid update list.");
            }

            foreach (var update in updates)
            {
                var manager = await _db.Managers.FirstOrDefaultAsync(man => man.Id == update.Id);
                if (manager != null)
                {
                    manager.Rank = update.Position;
                    _db.Managers.Update(manager);
                }
                else
                {
                    throw new Exception($"Manager with ID {update.Id} not found.");
                }
            }

            await _db.SaveChangesAsync();
        }
    }
}