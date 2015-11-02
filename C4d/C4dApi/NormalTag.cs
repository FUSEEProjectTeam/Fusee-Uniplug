/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class NormalTag : VariableTag {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal NormalTag(global::System.IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.NormalTag_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NormalTag obj) {
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

  public new static NormalTag Alloc(int count) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.NormalTag_Alloc(count);
    NormalTag ret = (cPtr == global::System.IntPtr.Zero) ? null : new NormalTag(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_NormalTag bl) {
    C4dApiPINVOKE.NormalTag_Free(SWIGTYPE_p_p_NormalTag.getCPtr(bl));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_ConstNormalHandle GetDataAddressR() {
    SWIGTYPE_p_ConstNormalHandle ret = new SWIGTYPE_p_ConstNormalHandle(C4dApiPINVOKE.NormalTag_GetDataAddressR(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_NormalHandle GetDataAddressW() {
    SWIGTYPE_p_NormalHandle ret = new SWIGTYPE_p_NormalHandle(C4dApiPINVOKE.NormalTag_GetDataAddressW(swigCPtr), true);
    return ret;
  }

  public static void Get(SWIGTYPE_p_ConstNormalHandle dataptr, int i, SWIGTYPE_p_NormalStruct res) {
    C4dApiPINVOKE.NormalTag_Get(SWIGTYPE_p_ConstNormalHandle.getCPtr(dataptr), i, SWIGTYPE_p_NormalStruct.getCPtr(res));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void Set(SWIGTYPE_p_NormalHandle dataptr, int i, SWIGTYPE_p_NormalStruct s) {
    C4dApiPINVOKE.NormalTag_Set(SWIGTYPE_p_NormalHandle.getCPtr(dataptr), i, SWIGTYPE_p_NormalStruct.getCPtr(s));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void Copy(SWIGTYPE_p_NormalHandle destptr, int dst, SWIGTYPE_p_ConstNormalHandle srcptr, int src) {
    C4dApiPINVOKE.NormalTag_Copy(SWIGTYPE_p_NormalHandle.getCPtr(destptr), dst, SWIGTYPE_p_ConstNormalHandle.getCPtr(srcptr), src);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
