using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SampleConsole.Sample2.Case3
{
    public class Container
    {
        private IRepository Repository { get; }

        public Container(IRepository repository)
        {
            Repository = repository;
        }

        public List<Model> SelectModels(string key)
        {
            return Repository.SelectTargetSources(key)
                .Select(x => Model.Factory.Create(x))
                .Where(x => x.IsEnabled)
                .Select(x => OnSelectModel(x))
                .ToList();
        }

        private Model OnSelectModel(Model model)
        {
            // Any Processing for each Model

            return model;
        }
    }
}
