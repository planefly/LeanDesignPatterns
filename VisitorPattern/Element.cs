namespace VisitorPattern
{
    public interface Element
    {
        void Accept(Visitor v);
    }
}
