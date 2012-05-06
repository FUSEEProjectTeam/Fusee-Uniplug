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

public class Semaphore : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Semaphore(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Semaphore obj) {
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

  public bool AttemptLock() {
    bool ret = C4dApiPINVOKE.Semaphore_AttemptLock(swigCPtr);
    return ret;
  }

  public bool Lock(BaseThread bt) {
    bool ret = C4dApiPINVOKE.Semaphore_Lock__SWIG_0(swigCPtr, BaseThread.getCPtr(bt));
    return ret;
  }

  public bool Lock(C4DThread bt) {
    bool ret = C4dApiPINVOKE.Semaphore_Lock__SWIG_1(swigCPtr, C4DThread.getCPtr(bt));
    return ret;
  }

  public void Unlock() {
    C4dApiPINVOKE.Semaphore_Unlock(swigCPtr);
  }

  public static Semaphore Alloc() {
    IntPtr cPtr = C4dApiPINVOKE.Semaphore_Alloc();
    Semaphore ret = (cPtr == IntPtr.Zero) ? null : new Semaphore(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_Semaphore sm) {
    C4dApiPINVOKE.Semaphore_Free(SWIGTYPE_p_p_Semaphore.getCPtr(sm));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
