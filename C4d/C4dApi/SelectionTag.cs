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

public class SelectionTag : BaseTag {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SelectionTag(global::System.IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.SelectionTag_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SelectionTag obj) {
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

  public new static SelectionTag Alloc(int type) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.SelectionTag_Alloc(type);
    SelectionTag ret = (cPtr == global::System.IntPtr.Zero) ? null : new SelectionTag(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_SelectionTag bl) {
    C4dApiPINVOKE.SelectionTag_Free(SWIGTYPE_p_p_SelectionTag.getCPtr(bl));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public BaseSelect GetBaseSelect() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.SelectionTag_GetBaseSelect(swigCPtr);
    BaseSelect ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseSelect(cPtr, false);
    return ret;
  }

}

}
