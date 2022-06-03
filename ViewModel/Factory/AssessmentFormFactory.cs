using System.Collections.Generic;
using System.Linq;
using System.Windows.Media.TextFormatting;
using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database;
using ViewModel.FormAssessment;
using ViewModel.GroupAdmin;
using ViewModel.StartingScreen;

namespace ViewModel.Factory
{
    /// <summary>
    /// Factory class to create view models with the help of models and the correct database data-object
    /// </summary>
    public class AssessmentFormFactory
    {
        private AssessmentContext? _context;

        /// <summary>
        /// constructor that initializes database context object and other service objects
        /// </summary>
        public AssessmentFormFactory()
        {
            _context = new AssessmentContext();
        }

        /// <summary>
        /// Creates form view model for a form to allow the view to see form information
        /// </summary>
        /// <param name="form">Form given by the AssessmentFormViewModel derived out of the Project property</param>
        /// <returns>Form view model with a property set to the form with the correct form id</returns>
        public FormViewModel CreateForm(Form form)
        {
            FormViewModel temp;
            temp = new FormViewModel(_context?.Forms.Where(fm => fm.FormId == form.FormId)
                .Include(frm => frm.Competences).Include(frm => frm.Indicators)
                .FirstOrDefault()!)!;
            return temp;
        }
        /// <summary>
        /// Create a view model for a competence to allow the view to see competence information
        /// </summary>
        /// <param name="competence">Competence given by the CreateCompetences function, derived from the FormViewModel.FormModel.Competences list</param>
        /// <returns>Newly created competence view model with a property set to the competence with the correct competence id</returns>
        public CompetenceViewModel CreateCompetence(Competence competence)
        {
            CompetenceViewModel temp;
            temp = new CompetenceViewModel(_context?.Competences.Where(comp => comp.CompetenceId == competence.CompetenceId)
                .Include(comp => comp.Criteria)
                .FirstOrDefault()!)!;
            return temp;
        }
        /// <summary>
        /// Create multiple view models for every competence of a form to allow the view to see each competence information
        /// </summary>
        /// <param name="competences">List of competences given by the FormViewModel out of the FormModel.Competences property</param>
        /// <returns>List of newly created competence view models with properties set to competences with the correct ids</returns>
        public IEnumerable<CompetenceViewModel> CreateCompetences(IEnumerable<Competence> competences)
        {
            List<CompetenceViewModel> temp = new List<CompetenceViewModel>();
            foreach (Competence comp in competences)
            {
                temp.Add(CreateCompetence(comp));
            }
            return temp;
        }
        /// <summary>
        /// Create a view model for a criterion to allow the view to see criterion information
        /// </summary>
        /// <param name="criterion">Criterion given by the CreateCriteria function, derived from the CompetenceViewModel.CompetenceModel.Criteria list</param>
        /// <returns>Newly created criterion view model with a property set to the criterion with the correct id</returns>
        public CriterionViewModel CreateCriterion(Criterion criterion)
        {
            CriterionViewModel temp;
            temp =
                new CriterionViewModel(_context?.Criteria.Where(crit => crit.CriterionId == criterion.CriterionId)
                    .Include(crit => crit.Requirements).FirstOrDefault()!)!;
            return temp;
        }
        /// <summary>
        /// Create multiple view models for every criteria of a competence to allow the view to see each criterion information
        /// </summary>
        /// <param name="criteria">List of criteria given by the CompetenceViewModel out of the CompetenceModel.Criteria property</param>
        /// <returns>List of newly created criterion view models with properties set to criteria with the correct ids</returns>
        public IEnumerable<CriterionViewModel> CreateCriteria(IEnumerable<Criterion> criteria)
        {
            List<CriterionViewModel> temp = new List<CriterionViewModel>();
            foreach (Criterion crit in criteria)
            {
                temp.Add(CreateCriterion(crit));
            }
            return temp;
        }
        /// <summary>
        /// Create a view model for a requirement to allow the view to see requirement information
        /// </summary>
        /// <param name="criterion">Requirement given by the CreateRequirements function, derived from the CriterionViewModel.CriterionModel.Requirements list</param>
        /// <returns>Newly created requirement view model with a property set to the requirement with the correct id</returns>
        public RequirementViewModel CreateRequirement(Requirement requirement)
        {
            RequirementViewModel temp;
            temp = new RequirementViewModel(_context?.Requirements.
                Where(req => req.RequirementId == requirement.RequirementId).
                Include(req => req.Indicator).Include(req => req.Criterion).
                FirstOrDefault()!)!;
            return temp;
        }
        /// <summary>
        /// Create multiple view models for every requirement of a criterion to allow the view to see each requirement information
        /// </summary>
        /// <param name="criteria">List of requirements given by the CriterionViewModel out of the CriterionModel.Requirements property</param>
        /// <returns>List of newly created requirement view models with properties set to requirements with the correct ids</returns>
        public IEnumerable<RequirementViewModel> CreateRequirements(IEnumerable<Requirement> requirements)
        {
            List<RequirementViewModel> temp = new List<RequirementViewModel>();
            foreach (Requirement req in requirements)
            {
                temp.Add(CreateRequirement(req));
            }
            return temp;
        }
        /// <summary>
        /// Create a view model for a group to allow the view to see group information
        /// </summary>
        /// <param name="group">Group given by the CreateGroups function, derived from the AssessmentFormViewModel.Groups property</param>
        /// <returns>Newly created group view model with a property set to the group with the correct id</returns>
        public GroupViewModel CreateGroup(Group group)
        {
            GroupViewModel temp;
            temp = new GroupViewModel(_context?.Groups.Where(grp => grp.GroupId == @group.GroupId)
                .Include(grp => grp.Students).Include(grp => grp.Assessments).ThenInclude(a => a.Ratings)
                .FirstOrDefault()!);
            return temp;
        }
        /// <summary>
        /// Create multiple view models for every group of a project to allow the view to see each group information
        /// </summary>
        /// <param name="groups">List of groups given by the AssessmentFormViewModel out of the Project property</param>
        /// <returns>List of newly created group view models with properties set to groups with the correct ids</returns>
        public IEnumerable<GroupViewModel> CreateGroups(List<Group> groups)
        {
            List<GroupViewModel> temp = new List<GroupViewModel>();
            foreach (Group grp in groups)
            {
                temp.Add(CreateGroup(grp));
            }
            return temp;
        }
        /// <summary>
        /// Create a view model for a student to allow the view to see student information
        /// </summary>
        /// <param name="student">Student given by the CreateStudent function, derived from the GroupViewModel.Students property</param>
        /// <returns>Newly created student view model with a property set to the student with the correct student number</returns>
        public StudentViewModel CreateStudent(Student student)
        {
            StudentViewModel temp = new StudentViewModel();
            temp.StudentModel = (_context?.Students!).FirstOrDefault(std => std.StudentNumber == student.StudentNumber)!;
            return temp;
        }
        /// <summary>
        /// Create multiple view models for every student of a group to allow the view to see each student information
        /// </summary>
        /// <param name="students">List of students given by the GroupViewModel out of the Students property</param>
        /// <returns>List of newly created student view models with properties set to students with the correct student numbers</returns>
        public IEnumerable<StudentViewModel> CreateStudents(IEnumerable<Student> students)
        {
            List<StudentViewModel> temp = new List<StudentViewModel>();
            foreach (Student student in students)
            {
                temp.Add(CreateStudent(student));
            }
            return temp;
        }
        /// <summary>
        /// Create a view model for an indicator to allow the view to see the indicator information
        /// </summary>
        /// <param name="indicator">Indicator given by the CreateIndicators function, derived from AssessmentFormViewModel.Form.Indicators</param>
        /// <returns>Newly created indicator view model with a property set to the indicator with the correct indicator id</returns>
        public IndicatorViewModel CreateIndicator(Indicator indicator)
        {
            IndicatorViewModel temp;
            temp = new IndicatorViewModel((_context?.Indicators!)
                .FirstOrDefault(indi => indi.IndicatorId == indicator.IndicatorId)!);
            return temp;
        }
        /// <summary>
        /// Create multiple view models for every indicator of a form to allow the view to see each indicator information
        /// </summary>
        /// <param name="indicators">List of indicators given by the AssessmentFormViewModel out of the Form.Indicators property</param>
        /// <returns>List of newly created indicator view models with properties set to indicators with the correct indicator id</returns>
        public IEnumerable<IndicatorViewModel> CreateIndicators(IEnumerable<Indicator> indicators)
        {
            List<IndicatorViewModel> temp = new List<IndicatorViewModel>();
            foreach (Indicator indicator in indicators)
            {
                temp.Add(CreateIndicator(indicator));
            }
            return temp;
        }

        public AssessmentViewModel CreateAssessment(Assessment assessment)
        {
            AssessmentViewModel temp = new AssessmentViewModel();
            temp.AssessmentModel = _context?.Assessments.
                Where(assess => assess.AssessmentId == assessment.AssessmentId)
                .Include(assess => assess.Group).Include(a => a.Ratings).ThenInclude(r => r.Criterion).ThenInclude(cr => cr.Competence).Include(a => a.Ratings).ThenInclude(r => r.Requirement).ThenInclude(r => r.Indicator)
                .FirstOrDefault()!;
            return temp;
        }
        public IEnumerable<AssessmentViewModel> CreateAssessments(IEnumerable<Assessment> assessments)
        {
            List<AssessmentViewModel> temp = new List<AssessmentViewModel>();
            foreach (Assessment assessment in assessments)
            {
                temp.Add(CreateAssessment(assessment));
            }
            return temp;
        }

        public RatingViewModel CreateRating(Rating rating)
        {
            RatingViewModel temp = new RatingViewModel();
            temp.RatingModel = _context?.Ratings.Where(rat =>
                    rat.AssessmentId == rating.AssessmentId && rat.CriterionId == rating.CriterionId)
                .Include(rat => rat.Indicator)
                .Include(rat => rat.Requirement).Include(r => r.Criterion).ThenInclude(c => c.Competence).FirstOrDefault()!;
            return temp;
        }

        public IEnumerable<RatingViewModel> CreateRatings(IEnumerable<Rating> ratings)
        {
            List<RatingViewModel> temp = new List<RatingViewModel>();
            foreach (Rating rating in ratings)
            {
                temp.Add(CreateRating(rating));
            }

            return temp;
        }
        public ProjectViewModel CreateProject(Project project)
        {
            ProjectViewModel temp = new ProjectViewModel();
            temp.ProjectModel = _context.Projects.Where(p => p.ProjectId == project.ProjectId).Include(p => p.Form).FirstOrDefault();
            return temp;
        }
        public IEnumerable<ProjectViewModel> CreateProjects()
        {
            AssessmentContext context = new AssessmentContext();
            List<ProjectViewModel> temp = new List<ProjectViewModel>();
            foreach (Project project in context.Projects!)
            {
                temp.Add(CreateProject(project));
            }

            return temp;
        }
    }
}
