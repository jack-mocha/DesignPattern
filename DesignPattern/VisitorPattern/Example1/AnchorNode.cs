namespace DesignPattern.VisitorPattern.Example1
{
    public class AnchorNode : IHtmlNode
    {
        public string Result { get; set; } //Only for unit test
        public void Execute(IOperation operation)
        {
            Result = operation.Apply(this);
        }
    }
}