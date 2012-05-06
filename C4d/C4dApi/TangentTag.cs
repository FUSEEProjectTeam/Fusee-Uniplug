/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 0.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

using System;
using System.Runtime.InteropServices;

public class TangentTag : VariableTag {
  private HandleRef swigCPtr;

  internal TangentTag(IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.TangentTag_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TangentTag obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Tangent GetDataAddressR() {
    IntPtr cPtr = C4dApiPINVOKE.TangentTag_GetDataAddressR(swigCPtr);
    Tangent ret = (cPtr == IntPtr.Zero) ? null : new Tangent(cPtr, false);
    return ret;
  }

  public Tangent GetDataAddressW() {
    IntPtr cPtr = C4dApiPINVOKE.TangentTag_GetDataAddressW(swigCPtr);
    Tangent ret = (cPtr == IntPtr.Zero) ? null : new Tangent(cPtr, false);
    return ret;
  }

}

}
