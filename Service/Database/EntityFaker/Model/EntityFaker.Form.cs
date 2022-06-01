using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static Form CreateForm(FakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new FakerArgs();
            var form = _formFaker.Generate();

            if (fakerArgs.Save)
                Save(form);

            return form;
        }

        public static void Save(Form form)
        {
            using var context = GetContext();
            context.Forms.Add(form);
            context.SaveChanges();
        }

        public static void Update(Form form)
        {
            using var context = GetContext();
            context.Forms.Add(form);
            context.SaveChanges();
        }

        public static void Remove(Form form)
        {
            using var context = GetContext();
            context.Remove(form);
            context.SaveChanges();
        }

        public static IEnumerable<Form> CreateForms(EnumerableFakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new EnumerableFakerArgs();
            using var context = new AssessmentContext();

            var forms = new List<Form>(fakerArgs.Count);

            int id = fakerArgs.StartId;
            int count = fakerArgs.Count;
            while (count > 0)
            {
                forms.Add(CreateForm(new FakerArgs
                {
                    id = id,
                    Save = false,
                }));

                id = forms.Last().FormId + 1;
                count--;
            }

            if (fakerArgs.Save)
                SaveRange(forms);

            return forms;
        }

        public static void SaveRange(IEnumerable<Form> forms)
        {
            using var context = GetContext();
            context.Forms.AddRange(forms);
            context.SaveChanges();
        }

        public static void UpdateRange(IEnumerable<Form> forms)
        {
            using var context = GetContext();
            context.Forms.AddRange(forms);
            context.SaveChanges();
        }

        public static void RemoveRange(IEnumerable<Form> forms)
        {
            using var context = GetContext();
            context.Forms.RemoveRange(forms);
            context.SaveChanges();
        }
    }

    public partial class EntityFakerContained
    {
        public Container<Form> CreateForm(FakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new FakerArgs();
            fakerArgs.Save = false;

            var form = EntityFaker.CreateForm(fakerArgs);
            return new Container<Form>(form,
                () => EntityFaker.Save(form),
                () => EntityFaker.Update(form),
                () => EntityFaker.Remove(form)
            );
        }

        public Container<IEnumerable<Form>> CreateForms(EnumerableFakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new EnumerableFakerArgs();
            fakerArgs.Save = false;

            var forms = EntityFaker.CreateForms(fakerArgs);
            return new Container<IEnumerable<Form>>(forms,
                () => EntityFaker.SaveRange(forms),
                () => EntityFaker.UpdateRange(forms),
                () => EntityFaker.RemoveRange(forms)
            );
        }
    }
}
