﻿using Model;

namespace Service.Database.EntityFaker.Args
{
    public class CompetenceArgs : FakerArgs
    {
        public Form Form
        {
            get => _form; set
            {
                if (value != _form)
                {
                    _form = value;
                    RemoveRelated = false;
                }
            }
        }
        private Form _form = EntityFaker.CreateForm();
    }
}
