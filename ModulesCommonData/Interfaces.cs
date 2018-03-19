using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace NCE.ModulesCommonData
{
    
    public interface IModule : IDataflowBlock
    {
        string ModuleName { get; }
    }

    public interface IRawDataInputModule : IRawSplitterTarget, IModule
    { }
    public interface IFFTConvertedInputModule : IFFTConvertedSplitterTarget, IModule
    { }
    /// <summary>
    /// Интерфейс сплитера конвертированных кооридинат
    /// </summary>
    public interface IConvertedSplitterTarget : IDataflowBlock
    {
        void PostData(List<Channel> channels);
    }
    /// <summary>
    /// Интерфейс сплитера сырых данных
    /// </summary>
    public interface IRawSplitterTarget : IDataflowBlock
    {
        void PostData(byte[] raw);
    }
    /// <summary>
    /// Интерфейс сплитера флага для записи координаты лайт барьера
    /// </summary>
    public interface ILightBarrierSplitterTarget : IDataflowBlock
    {
        void LightBarrierReached(double barrierCoord);
    }
    public interface IFFTConvertedSplitterTarget : IDataflowBlock
    {
        void PostData(ConvertedFFT data);
    }
}
