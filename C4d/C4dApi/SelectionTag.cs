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

public class SelectionTag : BaseTag {
  private HandleRef swigCPtr;

  internal SelectionTag(IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.SelectionTag_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SelectionTag obj) {
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

  public BaseSelect GetBaseSelect() {
    IntPtr cPtr = C4dApiPINVOKE.SelectionTag_GetBaseSelect(swigCPtr);
    BaseSelect ret = (cPtr == IntPtr.Zero) ? null : new BaseSelect(cPtr, false);
    return ret;
  }

  public new static SelectionTag Alloc(int type) {
    IntPtr cPtr = C4dApiPINVOKE.SelectionTag_Alloc(type);
    SelectionTag ret = (cPtr == IntPtr.Zero) ? null : new SelectionTag(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_SelectionTag bl) {
    C4dApiPINVOKE.SelectionTag_Free(SWIGTYPE_p_p_SelectionTag.getCPtr(bl));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
