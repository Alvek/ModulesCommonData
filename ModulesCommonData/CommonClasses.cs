using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace NCE.UTscanner.ModulesCommonData
{
    public class Channel
    {
        private List<Gate> _gates;

        public int ChannelId { get; set; }
        public List<Gate> Gates
        {
            get
            {
                return _gates;
            }
        }

        public Channel(int gateCount)
        {
            _gates = new List<Gate>(gateCount);
            for (int i = 0; i < gateCount; i++)
            {
                _gates.Add(new Gate());
                _gates[i].Ascans = new List<PointPairList>();
                _gates[i].GatePoints = new List<PointPair>();
            }
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class Gate
    {
        public List<PointPair> GatePoints { get; set; }
        public List<PointPairList> Ascans { get; set; }
    }
}
