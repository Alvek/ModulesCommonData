using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace NCE.ModulesCommonData
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

        public Channel(int gateCount, int pointsCount = 4)
        {
            _gates = new List<Gate>(gateCount);
            for (int i = 0; i < gateCount; i++)
            {
                _gates.Add(new Gate());
                _gates[i].Ascans = new List<PointPairList>();
                _gates[i].GatePoints = new List<PointPair>(pointsCount);
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

    public class ConvertedFFT
    {
        public byte[] RawData { get; }

        public List<Spectr> Spectr { get; }

        public ConvertedFFT(byte[] rawData, List<Spectr> spectr = null)
        {
            if (rawData == null)
                throw new ArgumentNullException("rawData", "Input raw data param is null!");

            RawData = rawData;
            Spectr = spectr;
            if (spectr == null)
                Spectr = new List<ModulesCommonData.Spectr>();
        }
    }

    public class Spectr
    {
        public Complex32[] SpectrFFTData { get; }
        public int ChannelId { get; }

        public Spectr(Complex32[] spectrData, int channelIdx)
        {
            if (spectrData == null)
                throw new ArgumentNullException("spectrData", "Input spectr data param is null!");

            SpectrFFTData = spectrData;
            ChannelId = channelIdx;
        }
    }
}
