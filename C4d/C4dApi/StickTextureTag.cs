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

public class StickTextureTag : VariableTag {
  private HandleRef swigCPtr;

  internal StickTextureTag(IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.StickTextureTag_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StickTextureTag obj) {
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

  public SWIGTYPE_p_Vector GetDataAddressR() {
    IntPtr cPtr = C4dApiPINVOKE.StickTextureTag_GetDataAddressR(swigCPtr);
    SWIGTYPE_p_Vector ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Vector(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Vector GetDataAddressW() {
    IntPtr cPtr = C4dApiPINVOKE.StickTextureTag_GetDataAddressW(swigCPtr);
    SWIGTYPE_p_Vector ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Vector(cPtr, false);
    return ret;
  }

  public bool Record(BaseObject op, bool always) {
    bool ret = C4dApiPINVOKE.StickTextureTag_Record(swigCPtr, BaseObject.getCPtr(op), always);
    return ret;
  }

  public new static StickTextureTag Alloc(int type) {
    IntPtr cPtr = C4dApiPINVOKE.StickTextureTag_Alloc(type);
    StickTextureTag ret = (cPtr == IntPtr.Zero) ? null : new StickTextureTag(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_StickTextureTag bl) {
    C4dApiPINVOKE.StickTextureTag_Free(SWIGTYPE_p_p_StickTextureTag.getCPtr(bl));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
