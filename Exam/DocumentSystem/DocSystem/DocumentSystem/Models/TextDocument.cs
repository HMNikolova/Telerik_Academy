namespace DocumentSystem
{
    public class TextDocument : Document, IDocument
    {
        public TextDocument(string name, string charset = null) : base(name) 
        {
            this.Charset = charset;
        }
        public string Charset { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "charset")
            {
                this.Charset = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
    }
}
//40:18