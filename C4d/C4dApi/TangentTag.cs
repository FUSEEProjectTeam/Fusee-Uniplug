//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace C4d {

public class TangentTag : VariableTag {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal TangentTag(global::System.IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.TangentTag_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TangentTag obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Tangent GetDataAddressR() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.TangentTag_GetDataAddressR(swigCPtr);
    Tangent ret = (cPtr == global::System.IntPtr.Zero) ? null : new Tangent(cPtr, false);
    return ret;
  }

  public Tangent GetDataAddressW() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.TangentTag_GetDataAddressW(swigCPtr);
    Tangent ret = (cPtr == global::System.IntPtr.Zero) ? null : new Tangent(cPtr, false);
    return ret;
  }

}

}
