using System.Collections.ObjectModel;
using Model;

namespace UnitTests
{
    public class Tests
    {
        private GroupSelectionViewModel _viewModel;

        [SetUp]
        public void Setup()
        {
            _viewModel = new GroupSelectionViewModel();
        }

        [Test]
        public void AddGroupToGroups()
        {
            ObservableCollection<Group> groups = new ObservableCollection<Group>(_viewModel.Groups);
            _viewModel.AddGroup.Execute(new Object());
            Assert.Greater(_viewModel.Groups.Count, groups.Count);
        }

        [Test]
        public void RemoveGroupFromGroups()
        {
            _viewModel.AddGroup.Execute(new Object());
            ObservableCollection<Group> groups = new ObservableCollection<Group>(_viewModel.Groups);
            _viewModel.RemoveGroup.Execute(new Object());
            Assert.Less(_viewModel.Groups.Count, groups.Count);
        }
    }
}
