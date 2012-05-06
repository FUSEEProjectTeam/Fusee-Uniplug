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

public class MovieLoader : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MovieLoader(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MovieLoader obj) {
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

  public static MovieLoader Alloc() {
    IntPtr cPtr = C4dApiPINVOKE.MovieLoader_Alloc();
    MovieLoader ret = (cPtr == IntPtr.Zero) ? null : new MovieLoader(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_MovieLoader ml) {
    C4dApiPINVOKE.MovieLoader_Free(SWIGTYPE_p_p_MovieLoader.getCPtr(ml));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public IMAGERESULT Open(SWIGTYPE_p_Filename fn) {
    IMAGERESULT ret = (IMAGERESULT)C4dApiPINVOKE.MovieLoader_Open(swigCPtr, SWIGTYPE_p_Filename.getCPtr(fn));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Close() {
    C4dApiPINVOKE.MovieLoader_Close(swigCPtr);
  }

  public BaseBitmap Read(int new_frame_idx, SWIGTYPE_p_LONG _result) {
    IntPtr cPtr = C4dApiPINVOKE.MovieLoader_Read__SWIG_0(swigCPtr, new_frame_idx, SWIGTYPE_p_LONG.getCPtr(_result));
    BaseBitmap ret = (cPtr == IntPtr.Zero) ? null : new BaseBitmap(cPtr, false);
    return ret;
  }

  public BaseBitmap Read(int new_frame_idx) {
    IntPtr cPtr = C4dApiPINVOKE.MovieLoader_Read__SWIG_1(swigCPtr, new_frame_idx);
    BaseBitmap ret = (cPtr == IntPtr.Zero) ? null : new BaseBitmap(cPtr, false);
    return ret;
  }

  public BaseBitmap Read() {
    IntPtr cPtr = C4dApiPINVOKE.MovieLoader_Read__SWIG_2(swigCPtr);
    BaseBitmap ret = (cPtr == IntPtr.Zero) ? null : new BaseBitmap(cPtr, false);
    return ret;
  }

  public int GetInfo(SWIGTYPE_p_Real _fps) {
    int ret = C4dApiPINVOKE.MovieLoader_GetInfo(swigCPtr, SWIGTYPE_p_Real.getCPtr(_fps));
    return ret;
  }

}

}
