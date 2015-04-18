using System.Collections.Generic;
namespace DocumentSystem
{
    public abstract class Document : IDocument
    {
        public Document(string name, string content = null)
        {
            this.Name = name;
            this.Content = content;
        }

        public string Name { get; private set; }

        public string Content { get; private set; }

        public virtual void LoadProperty(string key, string value)
        {
            key = key.ToLower();
            if (key == "Name")
            {
                this.Name = value;
            }
            else if (key == "content")
            {
                this.Content = value;
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            throw new System.NotImplementedException();
        }
    }
}
