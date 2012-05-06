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

public class AtomArray : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AtomArray(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AtomArray obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static AtomArray Alloc() {
    IntPtr cPtr = C4dApiPINVOKE.AtomArray_Alloc();
    AtomArray ret = (cPtr == IntPtr.Zero) ? null : new AtomArray(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_AtomArray obj) {
    C4dApiPINVOKE.AtomArray_Free(SWIGTYPE_p_p_AtomArray.getCPtr(obj));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetCount() {
    int ret = C4dApiPINVOKE.AtomArray_GetCount__SWIG_0(swigCPtr);
    return ret;
  }

  public int GetCount(int type, int instance) {
    int ret = C4dApiPINVOKE.AtomArray_GetCount__SWIG_1(swigCPtr, type, instance);
    return ret;
  }

  public C4DAtom GetIndex(int idx) {
    IntPtr cPtr = C4dApiPINVOKE.AtomArray_GetIndex(swigCPtr, idx);
    C4DAtom ret = (cPtr == IntPtr.Zero) ? null : new C4DAtom(cPtr, false);
    return ret;
  }

  public bool Append(C4DAtom obj) {
    bool ret = C4dApiPINVOKE.AtomArray_Append__SWIG_0(swigCPtr, C4DAtom.getCPtr(obj));
    return ret;
  }

  public void Flush() {
    C4dApiPINVOKE.AtomArray_Flush(swigCPtr);
  }

  public bool Remove(C4DAtom obj) {
    bool ret = C4dApiPINVOKE.AtomArray_Remove(swigCPtr, C4DAtom.getCPtr(obj));
    return ret;
  }

  public bool CopyTo(AtomArray dest) {
    bool ret = C4dApiPINVOKE.AtomArray_CopyTo(swigCPtr, AtomArray.getCPtr(dest));
    return ret;
  }

  public bool CopyToFilter(AtomArray dest, int type, int instance, bool generators) {
    bool ret = C4dApiPINVOKE.AtomArray_CopyToFilter__SWIG_0(swigCPtr, AtomArray.getCPtr(dest), type, instance, generators);
    return ret;
  }

  public bool CopyToFilter(AtomArray dest, int type, int instance) {
    bool ret = C4dApiPINVOKE.AtomArray_CopyToFilter__SWIG_1(swigCPtr, AtomArray.getCPtr(dest), type, instance);
    return ret;
  }

  public int GetUserID() {
    int ret = C4dApiPINVOKE.AtomArray_GetUserID(swigCPtr);
    return ret;
  }

  public void SetUserID(int t_userid) {
    C4dApiPINVOKE.AtomArray_SetUserID(swigCPtr, t_userid);
  }

  public SWIGTYPE_p_void GetUserData() {
    IntPtr cPtr = C4dApiPINVOKE.AtomArray_GetUserData(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public void SetUserData(SWIGTYPE_p_void t_userdata) {
    C4dApiPINVOKE.AtomArray_SetUserData(swigCPtr, SWIGTYPE_p_void.getCPtr(t_userdata));
  }

  public C4DAtom GetPreferred() {
    IntPtr cPtr = C4dApiPINVOKE.AtomArray_GetPreferred(swigCPtr);
    C4DAtom ret = (cPtr == IntPtr.Zero) ? null : new C4DAtom(cPtr, false);
    return ret;
  }

  public void SetPreferred(C4DAtom t_preferred) {
    C4dApiPINVOKE.AtomArray_SetPreferred(swigCPtr, C4DAtom.getCPtr(t_preferred));
  }

  public void FilterObject(int type, int instance, bool generators) {
    C4dApiPINVOKE.AtomArray_FilterObject__SWIG_0(swigCPtr, type, instance, generators);
  }

  public void FilterObject(int type, int instance) {
    C4dApiPINVOKE.AtomArray_FilterObject__SWIG_1(swigCPtr, type, instance);
  }

  public void FilterObjectChildren() {
    C4dApiPINVOKE.AtomArray_FilterObjectChildren(swigCPtr);
  }

  public bool Append(AtomArray src) {
    bool ret = C4dApiPINVOKE.AtomArray_Append__SWIG_1(swigCPtr, AtomArray.getCPtr(src));
    return ret;
  }

  public int Find(C4DAtom obj) {
    int ret = C4dApiPINVOKE.AtomArray_Find(swigCPtr, C4DAtom.getCPtr(obj));
    return ret;
  }

  public bool Compare(AtomArray cmp) {
    bool ret = C4dApiPINVOKE.AtomArray_Compare(swigCPtr, AtomArray.getCPtr(cmp));
    return ret;
  }

}

}
