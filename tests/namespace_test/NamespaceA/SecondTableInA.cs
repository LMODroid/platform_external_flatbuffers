// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace NamespaceA
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct SecondTableInA : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static SecondTableInA GetRootAsSecondTableInA(ByteBuffer _bb) { return GetRootAsSecondTableInA(_bb, new SecondTableInA()); }
  public static SecondTableInA GetRootAsSecondTableInA(ByteBuffer _bb, SecondTableInA obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SecondTableInA __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public NamespaceC.TableInC? ReferToC { get { int o = __p.__offset(4); return o != 0 ? (NamespaceC.TableInC?)(new NamespaceC.TableInC()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<NamespaceA.SecondTableInA> CreateSecondTableInA(FlatBufferBuilder builder,
      Offset<NamespaceC.TableInC> refer_to_cOffset = default(Offset<NamespaceC.TableInC>)) {
    builder.StartTable(1);
    SecondTableInA.AddReferToC(builder, refer_to_cOffset);
    return SecondTableInA.EndSecondTableInA(builder);
  }

  public static void StartSecondTableInA(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddReferToC(FlatBufferBuilder builder, Offset<NamespaceC.TableInC> referToCOffset) { builder.AddOffset(0, referToCOffset.Value, 0); }
  public static Offset<NamespaceA.SecondTableInA> EndSecondTableInA(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<NamespaceA.SecondTableInA>(o);
  }
  public SecondTableInAT UnPack() {
    var _o = new SecondTableInAT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SecondTableInAT _o) {
    _o.ReferToC = this.ReferToC.HasValue ? this.ReferToC.Value.UnPack() : null;
  }
  public static Offset<NamespaceA.SecondTableInA> Pack(FlatBufferBuilder builder, SecondTableInAT _o) {
    if (_o == null) return default(Offset<NamespaceA.SecondTableInA>);
    var _refer_to_c = _o.ReferToC == null ? default(Offset<NamespaceC.TableInC>) : NamespaceC.TableInC.Pack(builder, _o.ReferToC);
    return CreateSecondTableInA(
      builder,
      _refer_to_c);
  }
}

public class SecondTableInAT
{
  [Newtonsoft.Json.JsonProperty("refer_to_c")]
  public NamespaceC.TableInCT ReferToC { get; set; }

  public SecondTableInAT() {
    this.ReferToC = null;
  }
}


}
