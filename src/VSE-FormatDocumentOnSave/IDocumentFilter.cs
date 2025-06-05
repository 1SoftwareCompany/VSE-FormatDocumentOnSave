using EnvDTE;

namespace VSE_FormatDocumentOnSave
{
    public interface IDocumentFilter
    {
        bool IsAllowed(Document document);
    }
}