namespace Textamina.Markdig.Syntax.Inlines
{
    public class LinkInline : ContainerInline
    {
        public string Url { get; set; }

        public string Title { get; set; }

        public bool IsImage { get; set; }

        public override string ToString()
        {
            return (IsImage ? "<img src=\"" : "<a href=\"") + Url + "\" title=\"" + Title + "\">";
        }
    }
}