using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample1
{
    public interface IArticleRepository
    {
        // Query 系
        IArticle FindOneById(int articleId);
        IEnumerable<IArticle> FindByKeyword(string keyword);

        // Command 系
        void Create(IArticle article);
        void Update(IArticle article);
        void Delete(int articleId);
    }
}
