using System.Collections.ObjectModel;
using Model;
using System.Diagnostics;



namespace UnitTests
{
    public class Tests
    {
        private GroupSelectionViewModel _viewModel;

        [SetUp]
        public void Setup()
        {
            _viewModel = new GroupSelectionViewModel();

            //Adding a dummy group as the selected group as to able to run tests
            Group _testGroup = new Group("TestName");
            _viewModel.Groups.Add(_testGroup);
            _viewModel.SelectedGroup = _testGroup;

            //Adding a dummy student to the selected, previously generated group
            Student _testStudent = new Student(1234567, "John Doe");
            _viewModel.SelectedGroup.Students.Add(_testStudent);
            _viewModel.SelectedStudent = _testStudent;
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

        [Test]
        public void ChangeSelectedGroupName()
        {
            _viewModel.ChangeGroupName.Execute(new Object());
            Assert.AreEqual(_viewModel.SelectedGroup.Name, _viewModel.GroupName);
        }

        [Test]
        public void AddStudent()
        {
            _viewModel.StudentNumber = "1234567";
            ObservableCollection<Student> students = new ObservableCollection<Student>(_viewModel.SelectedGroup.Students);
            _viewModel.AddStudent.Execute(new Object());
            Assert.Greater(_viewModel.SelectedGroup.Students.Count, students.Count);
        }

        [Test]
        public void RemoveStudent()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>(_viewModel.SelectedGroup.Students);
            _viewModel.RemoveStudent.Execute(new Object());
            Assert.Less(_viewModel.SelectedGroup.Students.Count, students.Count);
        }
    }
}
