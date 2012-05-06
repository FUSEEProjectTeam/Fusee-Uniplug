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

public class MessageFilter : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MessageFilter(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MessageFilter obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MessageFilter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_MessageFilter(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public MessageFilter() : this(C4dApiPINVOKE.new_MessageFilter(), true) {
  }

  public int type {
    set {
      C4dApiPINVOKE.MessageFilter_type_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.MessageFilter_type_get(swigCPtr);
      return ret;
    } 
  }

  public MULTIMSG_ROUTE route {
    set {
      C4dApiPINVOKE.MessageFilter_route_set(swigCPtr, (int)value);
    } 
    get {
      MULTIMSG_ROUTE ret = (MULTIMSG_ROUTE)C4dApiPINVOKE.MessageFilter_route_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void data {
    set {
      C4dApiPINVOKE.MessageFilter_data_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.MessageFilter_data_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

}

}
