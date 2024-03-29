using System.Runtime.InteropServices;

namespace HKSDK.Models;

/// <summary>
/// 设备信息
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct DeviceInfo
{
    /// <summary>
    /// 设备主版本
    /// </summary>
    public ushort MajorVer;
    
    /// <summary>
    /// 设备次版本
    /// </summary>
    public ushort MinorVer;
    
    /// <summary>
    /// 高MAC地址
    /// </summary>
    public uint MacAddrHigh;
    
    /// <summary>
    /// 低MAC地址
    /// </summary>
    public uint MacAddrLow;
    
    /// <summary>
    /// 设备传输的协议层类型
    /// </summary>
    public uint LayerType;
    
    /// <summary>
    /// 设备类型信息
    /// 设备类型规则：
    /// 7 - 0 bit: 预留
    /// 15 - 8 bit：产品子类别
    /// 23 - 16 bit：产品类型
    /// 31 - 24bit：产品线（如: 0x01 标准产品；0x02 3D产品；0x03 智能ID产品） 更多...
    /// </summary>
    public uint DevTypeInfo;
    
    /// <summary>
    /// 预留字段
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public uint[] Reserved;
    
    
    public SPECIAL_INFO SpecialInfo;
    
    [StructLayout(LayoutKind.Explicit, Size = 540)]
    public struct SPECIAL_INFO
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 216)]
        public byte[] stGigEInfo;

        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 536)]
        public byte[] stCamLInfo;

        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 540)]
        public byte[] stUsb3VInfo;
    }
}