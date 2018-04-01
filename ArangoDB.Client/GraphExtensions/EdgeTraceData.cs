using Newtonsoft.Json.Linq;

namespace ArangoDB.Client
{
    /// <summary>
    /// the edge trace data for graph
    /// </summary>
    public class EdgeTraceData
    {
        /// <summary>
        /// the vertex at the traced level
        /// </summary>
        public JObject Vertex { get; set;}
        /// <summary>
        /// the edge at the traced level
        /// </summary>
        public EdgeBase Edge { get; set; }
    }
}
