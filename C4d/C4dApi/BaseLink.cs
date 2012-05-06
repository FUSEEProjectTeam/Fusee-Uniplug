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

public class BaseLink : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BaseLink(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BaseLink obj) {
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

  public BaseList2D GetLink(BaseDocument doc, int instanceof) {
    IntPtr cPtr = C4dApiPINVOKE.BaseLink_GetLink__SWIG_0(swigCPtr, BaseDocument.getCPtr(doc), instanceof);
    BaseList2D ret = (cPtr == IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
    return ret;
  }

  public BaseList2D GetLink(BaseDocument doc) {
    IntPtr cPtr = C4dApiPINVOKE.BaseLink_GetLink__SWIG_1(swigCPtr, BaseDocument.getCPtr(doc));
    BaseList2D ret = (cPtr == IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
    return ret;
  }

  public C4DAtomGoal GetLinkAtom(BaseDocument doc, int instanceof) {
    IntPtr cPtr = C4dApiPINVOKE.BaseLink_GetLinkAtom__SWIG_0(swigCPtr, BaseDocument.getCPtr(doc), instanceof);
    C4DAtomGoal ret = (cPtr == IntPtr.Zero) ? null : new C4DAtomGoal(cPtr, false);
    return ret;
  }

  public C4DAtomGoal GetLinkAtom(BaseDocument doc) {
    IntPtr cPtr = C4dApiPINVOKE.BaseLink_GetLinkAtom__SWIG_1(swigCPtr, BaseDocument.getCPtr(doc));
    C4DAtomGoal ret = (cPtr == IntPtr.Zero) ? null : new C4DAtomGoal(cPtr, false);
    return ret;
  }

  public BaseList2D ForceGetLink() {
    IntPtr cPtr = C4dApiPINVOKE.BaseLink_ForceGetLink(swigCPtr);
    BaseList2D ret = (cPtr == IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
    return ret;
  }

  public C4DAtomGoal ForceGetLinkAtom() {
    IntPtr cPtr = C4dApiPINVOKE.BaseLink_ForceGetLinkAtom(swigCPtr);
    C4DAtomGoal ret = (cPtr == IntPtr.Zero) ? null : new C4DAtomGoal(cPtr, false);
    return ret;
  }

  public void SetLink(C4DAtomGoal list) {
    C4dApiPINVOKE.BaseLink_SetLink(swigCPtr, C4DAtomGoal.getCPtr(list));
  }

  public bool Read(SWIGTYPE_p_HyperFile hf) {
    bool ret = C4dApiPINVOKE.BaseLink_Read(swigCPtr, SWIGTYPE_p_HyperFile.getCPtr(hf));
    return ret;
  }

  public bool Write(SWIGTYPE_p_HyperFile hf) {
    bool ret = C4dApiPINVOKE.BaseLink_Write(swigCPtr, SWIGTYPE_p_HyperFile.getCPtr(hf));
    return ret;
  }

  public BaseLink GetClone(COPYFLAGS flags, AliasTrans trn) {
    IntPtr cPtr = C4dApiPINVOKE.BaseLink_GetClone(swigCPtr, (int)flags, AliasTrans.getCPtr(trn));
    BaseLink ret = (cPtr == IntPtr.Zero) ? null : new BaseLink(cPtr, false);
    return ret;
  }

  public bool CopyTo(BaseLink dst, COPYFLAGS flags, AliasTrans trn) {
    bool ret = C4dApiPINVOKE.BaseLink_CopyTo(swigCPtr, BaseLink.getCPtr(dst), (int)flags, AliasTrans.getCPtr(trn));
    return ret;
  }

  public bool IsCacheLink() {
    bool ret = C4dApiPINVOKE.BaseLink_IsCacheLink(swigCPtr);
    return ret;
  }

  public static BaseLink Alloc() {
    IntPtr cPtr = C4dApiPINVOKE.BaseLink_Alloc();
    BaseLink ret = (cPtr == IntPtr.Zero) ? null : new BaseLink(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_BaseLink link) {
    C4dApiPINVOKE.BaseLink_Free(SWIGTYPE_p_p_BaseLink.getCPtr(link));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
