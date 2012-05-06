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

public class GvQuery : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GvQuery(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GvQuery obj) {
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

  public GvCalcFlags GetFlags() {
    GvCalcFlags ret = (GvCalcFlags)C4dApiPINVOKE.GvQuery_GetFlags(swigCPtr);
    return ret;
  }

  public void SetFlags(GvCalcFlags flags) {
    C4dApiPINVOKE.GvQuery_SetFlags(swigCPtr, (int)flags);
  }

  public void SetError(GvError error) {
    C4dApiPINVOKE.GvQuery_SetError(swigCPtr, (int)error);
  }

  public GvError GetError() {
    GvError ret = (GvError)C4dApiPINVOKE.GvQuery_GetError(swigCPtr);
    return ret;
  }

}

}
