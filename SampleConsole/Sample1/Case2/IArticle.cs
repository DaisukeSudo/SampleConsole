using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample1.Case2
{
    public interface IArticle
    {
        int ArticleId { get; }
        string Title { get; }
        string Body { get; }
        int AuthorId { get; }
        DateTime CreateAt { get; }
        DateTime UpdateAt { get; }
    }
}
