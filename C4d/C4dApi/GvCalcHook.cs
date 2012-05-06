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

public class GvCalcHook : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GvCalcHook(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GvCalcHook obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GvCalcHook() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_GvCalcHook(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public GvCalcHook() : this(C4dApiPINVOKE.new_GvCalcHook(), true) {
  }

  public GvNodeMaster master {
    set {
      C4dApiPINVOKE.GvCalcHook_master_set(swigCPtr, GvNodeMaster.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.GvCalcHook_master_get(swigCPtr);
      GvNodeMaster ret = (cPtr == IntPtr.Zero) ? null : new GvNodeMaster(cPtr, false);
      return ret;
    } 
  }

  public BaseDocument document {
    set {
      C4dApiPINVOKE.GvCalcHook_document_set(swigCPtr, BaseDocument.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.GvCalcHook_document_get(swigCPtr);
      BaseDocument ret = (cPtr == IntPtr.Zero) ? null : new BaseDocument(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void user {
    set {
      C4dApiPINVOKE.GvCalcHook_user_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.GvCalcHook_user_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public GvCalc calc {
    set {
      C4dApiPINVOKE.GvCalcHook_calc_set(swigCPtr, GvCalc.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.GvCalcHook_calc_get(swigCPtr);
      GvCalc ret = (cPtr == IntPtr.Zero) ? null : new GvCalc(cPtr, false);
      return ret;
    } 
  }

  public bool status {
    set {
      C4dApiPINVOKE.GvCalcHook_status_set(swigCPtr, value);
    } 
    get {
      bool ret = C4dApiPINVOKE.GvCalcHook_status_get(swigCPtr);
      return ret;
    } 
  }

}

}
