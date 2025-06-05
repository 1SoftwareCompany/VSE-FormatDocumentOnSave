using EnvDTE;

namespace VSE_FormatDocumentOnSave
{
    public interface IDocumentFormatter
    {
        void Format(Document document, IDocumentFilter filter, string command);
    }
}