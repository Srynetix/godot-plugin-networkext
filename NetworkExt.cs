using Godot;
using Newtonsoft.Json;

namespace SxGD
{
    public static class NetworkExt
    {
        /// Convert any object to JSON.
        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// Convert JSON data to any object.
        public static T FromJson<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }

        /// Check if the current tree is a network server, even
        /// without a NetworkPeer.
        public static bool IsNetworkServer(SceneTree tree)
        {
            return tree.IsNetworkServerChecked();
        }

        /// Check if the current tree is a network master, even
        /// without a NetworkPeer.
        public static bool IsNetworkMaster(Node node)
        {
            return node.IsNetworkMasterChecked();
        }

        /// Check if networking is enabled, even without a
        /// NetworkPeer.
        public static bool IsNetworkEnabled(SceneTree tree)
        {
            return tree.NetworkPeer != null;
        }

        /// Check if the current tree is a network server, even
        /// without a NetworkPeer, extension method version.
        public static bool IsNetworkServerChecked(this SceneTree tree)
        {
            if (tree.NetworkPeer == null)
            {
                return true;
            }
            else
            {
                return tree.IsNetworkServer();
            }
        }

        /// Check if the current tree is a network master, even
        /// without a NetworkPeer, extension method version.
        public static bool IsNetworkMasterChecked(this Node node)
        {
            if (node.GetTree().NetworkPeer == null)
            {
                return true;
            }
            else
            {
                return node.IsNetworkMaster();
            }
        }
    }
}