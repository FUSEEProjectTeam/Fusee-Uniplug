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

public class CLine : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CLine(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CLine obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CLine() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_CLine(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public double t {
    set {
      C4dApiPINVOKE.CLine_t_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.CLine_t_get(swigCPtr);
      return ret;
    } 
  }

  public double pos {
    set {
      C4dApiPINVOKE.CLine_pos_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.CLine_pos_get(swigCPtr);
      return ret;
    } 
  }

  public CLine() : this(C4dApiPINVOKE.new_CLine(), true) {
  }

}

}
