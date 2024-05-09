using Opc.Ua;
using Opc.UaFx;
using System;
using System.Collections.Generic;
using Opc.UaFx.Server;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCS
{
    internal class OpcHandler
    {
        private static OpcServer server;
        public List<OpcDataVariableNode> Nodes { get; private set; }
        public OpcHandler()
        {
            Nodes = new List<OpcDataVariableNode>();
        }
        public void AddNode(string name, double initialValue = 0.0)
        {
            // Add nodes to the Opc Handler

            OpcDataVariableNode node = new OpcDataVariableNode(name, initialValue);
            Nodes.Add(node);
        }

        public void UpdateNodeValue(string name, double newValue)
        {
            // Update values for nodes

            OpcDataVariableNode node = Nodes.Find(n => n.Name == name);

            if (node != null)
            {
                node.Value = newValue;
                node.ApplyChanges(server.SystemContext);
            }
            else
            {
                MessageBox.Show($"Node '{name}' not found.");
            }
        }
        public void StartOpcUaServer()
        {
            // Start OPC UA Server THREAD

            try
            {
                server = new OpcServer("opc.tcp://localhost:4840/", Nodes.ToArray());
                server.Start();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
