using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CommonClass
{
    [System.Serializable]
    public class TreeNodeEx:TreeNode
    {
        public TreeNodeEx(string text) : base(text)
        { }

        public TreeNodeEx() : base()
        { }

        protected TreeNodeEx(SerializationInfo info,StreamingContext context):base(info,context)
        { }

        /*private int id = -1;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }*/

        public override string ToString()
        {
            return base.Text;
        }

        /*public override object Clone()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, this);
            ms.Seek(0, SeekOrigin.Begin);
            return bf.Deserialize(ms);
        }*/
    }
}
