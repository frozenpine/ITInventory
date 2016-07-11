using System.Xml;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace CommonClass
{
    public class Templetes
    {
        private XmlDocument xmlDoc = new XmlDocument();
        private TreeNodeEx[] templeteRoot;
        private TreeNodeEx[] templetRootDetail;
        private string xmlTempletePath;
        public string TempletePath
        {
            set { xmlTempletePath = value; }
        }
        public TreeNodeEx[] TempleteRoot
        {
            get { return templeteRoot; }
        }

        public TreeNodeEx[] TempleteRootDetail
        {
            get { return templetRootDetail; }
        }

        public Templetes()
        { }

        public Templetes(string xmlPath)
        {
            ParseTempletes(xmlPath);
        }

        public void ParseTempletes(string path,bool detail=true)
        {
            Debug.WriteLine(path);
            if (System.IO.File.Exists(path))
            {
                xmlTempletePath = path;
                xmlDoc.Load(path);
                XmlElement xmlRoot = xmlDoc.DocumentElement;
                XmlNodeList xmlTempletes = xmlRoot.GetElementsByTagName("Templete");
                templeteRoot = new TreeNodeEx[xmlTempletes.Count];
                if (detail)
                {
                    templetRootDetail = new TreeNodeEx[xmlTempletes.Count];
                }
                for (int i = 0; i < xmlTempletes.Count; i++)
                {
                    templeteRoot[i] = new TreeNodeEx(xmlTempletes[i].Attributes["Name"].InnerText);
                    templeteRoot[i].Name = "device";
                    CreateLeaf(templeteRoot[i], xmlTempletes[i]);
                    if (detail)
                    {
                        templetRootDetail[i] = new TreeNodeEx(xmlTempletes[i].Attributes["Name"].InnerText);
                        templetRootDetail[i].Name = "device";
                        CreateLeaf(templetRootDetail[i], xmlTempletes[i], true);
                    }
                }
            }
        }

        private void CreateLeaf(TreeNode pNode, XmlNode pxmlNode, bool detail = false)
        {
            if (pxmlNode.HasChildNodes)
            {
                foreach (XmlNode xmlChildNode in pxmlNode.ChildNodes)
                {
                    try
                    {
                        int count = int.Parse(xmlChildNode.Attributes["Quantity"].InnerText);
                        if (detail)
                        {
                            TreeNodeEx[] childNode = new TreeNodeEx[count];
                            for (int i = 0; i < count; i++)
                            {
                                childNode[i] = new TreeNodeEx(xmlChildNode.Attributes["Name"].InnerText.Replace("{n}", (int.Parse(xmlChildNode.Attributes["StartPos"].InnerText) + i).ToString()));
                                Hashtable ht = new Hashtable();
                                switch (xmlChildNode.Name)
                                {
                                    case "Item":
                                        childNode[i].Name = "device";
                                        ht.Add("device_name", childNode[i].Text);
                                        ht.Add("device_type_id_ref", int.Parse(xmlChildNode.Attributes["ID"].InnerText));
                                        break;
                                    case "Socket":
                                        childNode[i].Name = "socket";
                                        ht.Add("socket_name", childNode[i].Text);
                                        ht.Add("socket_phy_type_id_ref", int.Parse(xmlChildNode.Attributes["ID"].InnerText));
                                        break;
                                    default:
                                        MessageBox.Show("XML模版文件格式错误！");
                                        break;
                                }
                                childNode[i].Tag = ht;
                                CreateLeaf(childNode[i], xmlChildNode, true);
                            }
                            pNode.Nodes.AddRange(childNode);
                        }
                        else
                        {
                            TreeNodeEx childNode = new TreeNodeEx(xmlChildNode.Attributes["Name"].InnerText.Replace("{n}", "{n × " + count.ToString() + "}"));
                            switch (xmlChildNode.Name)
                            {
                                case "Item":
                                    childNode.Name = "device";
                                    break;
                                case "Socket":
                                    childNode.Name = "socket";
                                    break;
                                default:
                                    MessageBox.Show("XML模版文件格式错误！");
                                    break;
                            }
                            CreateLeaf(childNode, xmlChildNode);
                            pNode.Nodes.AddRange(new TreeNodeEx[] { childNode });
                        }
                    }
                    catch (System.Exception err)
                    {
                        MessageBox.Show("XML模版文件格式错误！");
                        Debug.WriteLine(err);
                    }
                }
            }
        }
    }
}
