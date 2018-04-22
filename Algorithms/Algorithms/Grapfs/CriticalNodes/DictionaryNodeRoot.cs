using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapfs.CriticalNodes
{
    public class DictionaryNodeRoot
    {
        //https://www.dotnetperls.com/tree
        DictionaryNode _root = new DictionaryNode();

        public void AddWord(string value)
        {
            // Add nodes from string chars.
            DictionaryNode current = this._root;
            for (int i = 0; i < value.Length; i++)
            {
                current = current.Add(value[i]);
            }
            // Set state.
            current.SetWord(value);
        }

        public bool ContainsWord(string value)
        {
            // Get existing nodes from string chars.
            DictionaryNode current = this._root;
            for (int i = 0; i < value.Length; i++)
            {
                current = current.Get(value[i]);
                if (current == null)
                {
                    return false;
                }
            }
            // Return state.
            return current != null && current.GetWord() != null;
        }
    }
}
