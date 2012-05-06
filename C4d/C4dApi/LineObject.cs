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

public class LineObject : PointObject {
  private HandleRef swigCPtr;

  internal LineObject(IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.LineObject_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(LineObject obj) {
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

  public Segment GetSegmentR() {
    IntPtr cPtr = C4dApiPINVOKE.LineObject_GetSegmentR(swigCPtr);
    Segment ret = (cPtr == IntPtr.Zero) ? null : new Segment(cPtr, false);
    return ret;
  }

  public Segment GetSegmentW() {
    IntPtr cPtr = C4dApiPINVOKE.LineObject_GetSegmentW(swigCPtr);
    Segment ret = (cPtr == IntPtr.Zero) ? null : new Segment(cPtr, false);
    return ret;
  }

  public int GetSegmentCount() {
    int ret = C4dApiPINVOKE.LineObject_GetSegmentCount(swigCPtr);
    return ret;
  }

  public CLine GetLineR() {
    IntPtr cPtr = C4dApiPINVOKE.LineObject_GetLineR(swigCPtr);
    CLine ret = (cPtr == IntPtr.Zero) ? null : new CLine(cPtr, false);
    return ret;
  }

  public CLine GetLineW() {
    IntPtr cPtr = C4dApiPINVOKE.LineObject_GetLineW(swigCPtr);
    CLine ret = (cPtr == IntPtr.Zero) ? null : new CLine(cPtr, false);
    return ret;
  }

  public bool ResizeObject(int pcnt, int scnt) {
    bool ret = C4dApiPINVOKE.LineObject_ResizeObject(swigCPtr, pcnt, scnt);
    return ret;
  }

  public PolygonObject Triangulate(double regular, BaseThread bt) {
    IntPtr cPtr = C4dApiPINVOKE.LineObject_Triangulate(swigCPtr, regular, BaseThread.getCPtr(bt));
    PolygonObject ret = (cPtr == IntPtr.Zero) ? null : new PolygonObject(cPtr, false);
    return ret;
  }

  public static LineObject Alloc(int pcnt, int scnt) {
    IntPtr cPtr = C4dApiPINVOKE.LineObject_Alloc(pcnt, scnt);
    LineObject ret = (cPtr == IntPtr.Zero) ? null : new LineObject(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_LineObject bl) {
    C4dApiPINVOKE.LineObject_Free(SWIGTYPE_p_p_LineObject.getCPtr(bl));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
