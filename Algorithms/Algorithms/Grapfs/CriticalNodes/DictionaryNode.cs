using System.Collections.Generic;

namespace Grapfs.CriticalNodes
{
    public class DictionaryNode
    {
        string _word;
        Dictionary<char, DictionaryNode> _dict; // Slow.

        public DictionaryNode Add(char value)
        {
            // Add individual node as child.
            // ... Handle null field.
            if (this._dict == null)
            {
                this._dict = new Dictionary<char, DictionaryNode>();
            }
            // Look up and return if possible.
            DictionaryNode result;
            if (this._dict.TryGetValue(value, out result))
            {
                return result;
            }
            // Store.
            result = new DictionaryNode();
            this._dict[value] = result;
            return result;
        }

        public DictionaryNode Get(char value)
        {
            // Get individual child node.
            if (this._dict == null)
            {
                return null;
            }
            DictionaryNode result;
            if (this._dict.TryGetValue(value, out result))
            {
                return result;
            }
            return null;
        }

        public void SetWord(string word)
        {
            this._word = word;
        }

        public string GetWord()
        {
            return this._word;
        }
    }
}