using Phonebook.AdonetLayer.Repositories;
using Phonebook.Models.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook.BusinessLogic.Services
{
    public interface IGroupService
    {
        List<Group> GetList();

        void Add(Group group);
    }

    public class GroupService:IGroupService
    {
        private readonly GroupRepository _groupRepository;

        public GroupService()
        {
            _groupRepository = new GroupRepository();
        }

        public List<Group> GetList()
        {
            return _groupRepository.GetAll()
                                        .OrderBy(g => g.Name)
                                        .ToList();
        }

        public void Add(Group group)
        {
            _groupRepository.Add(group);
        }
    }
}
