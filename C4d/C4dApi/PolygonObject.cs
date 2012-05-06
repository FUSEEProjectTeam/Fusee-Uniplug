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

public class PolygonObject : PointObject {
  private HandleRef swigCPtr;

  internal PolygonObject(IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.PolygonObject_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PolygonObject obj) {
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

  public BaseSelect GetPolygonS() {
    IntPtr cPtr = C4dApiPINVOKE.PolygonObject_GetPolygonS(swigCPtr);
    BaseSelect ret = (cPtr == IntPtr.Zero) ? null : new BaseSelect(cPtr, false);
    return ret;
  }

  public BaseSelect GetPolygonH() {
    IntPtr cPtr = C4dApiPINVOKE.PolygonObject_GetPolygonH(swigCPtr);
    BaseSelect ret = (cPtr == IntPtr.Zero) ? null : new BaseSelect(cPtr, false);
    return ret;
  }

  public BaseSelect GetEdgeS() {
    IntPtr cPtr = C4dApiPINVOKE.PolygonObject_GetEdgeS(swigCPtr);
    BaseSelect ret = (cPtr == IntPtr.Zero) ? null : new BaseSelect(cPtr, false);
    return ret;
  }

  public BaseSelect GetEdgeH() {
    IntPtr cPtr = C4dApiPINVOKE.PolygonObject_GetEdgeH(swigCPtr);
    BaseSelect ret = (cPtr == IntPtr.Zero) ? null : new BaseSelect(cPtr, false);
    return ret;
  }

  public BaseSelect GetPhongBreak() {
    IntPtr cPtr = C4dApiPINVOKE.PolygonObject_GetPhongBreak(swigCPtr);
    BaseSelect ret = (cPtr == IntPtr.Zero) ? null : new BaseSelect(cPtr, false);
    return ret;
  }

  public CPolygon GetPolygonR() {
    IntPtr cPtr = C4dApiPINVOKE.PolygonObject_GetPolygonR(swigCPtr);
    CPolygon ret = (cPtr == IntPtr.Zero) ? null : new CPolygon(cPtr, false);
    return ret;
  }

  public CPolygon GetPolygonW() {
    IntPtr cPtr = C4dApiPINVOKE.PolygonObject_GetPolygonW(swigCPtr);
    CPolygon ret = (cPtr == IntPtr.Zero) ? null : new CPolygon(cPtr, false);
    return ret;
  }

  public int GetPolygonCount() {
    int ret = C4dApiPINVOKE.PolygonObject_GetPolygonCount(swigCPtr);
    return ret;
  }

  public bool ResizeObject(int pcnt, int vcnt) {
    bool ret = C4dApiPINVOKE.PolygonObject_ResizeObject__SWIG_0(swigCPtr, pcnt, vcnt);
    return ret;
  }

  public bool ResizeObject(int pcnt, int vcnt, int ncnt) {
    bool ret = C4dApiPINVOKE.PolygonObject_ResizeObject__SWIG_1(swigCPtr, pcnt, vcnt, ncnt);
    return ret;
  }

  public bool ResizeObject(int pcnt, int vcnt, int ncnt, int vc_flags) {
    bool ret = C4dApiPINVOKE.PolygonObject_ResizeObject__SWIG_2(swigCPtr, pcnt, vcnt, ncnt, vc_flags);
    return ret;
  }

  public BaseSelect GetSelectedEdges(Neighbor e, EDGESELECTIONTYPE ltype) {
    IntPtr cPtr = C4dApiPINVOKE.PolygonObject_GetSelectedEdges__SWIG_0(swigCPtr, Neighbor.getCPtr(e), (int)ltype);
    BaseSelect ret = (cPtr == IntPtr.Zero) ? null : new BaseSelect(cPtr, false);
    return ret;
  }

  public BaseSelect GetSelectedEdges(Neighbor e, BaseSelect sel) {
    IntPtr cPtr = C4dApiPINVOKE.PolygonObject_GetSelectedEdges__SWIG_1(swigCPtr, Neighbor.getCPtr(e), BaseSelect.getCPtr(sel));
    BaseSelect ret = (cPtr == IntPtr.Zero) ? null : new BaseSelect(cPtr, false);
    return ret;
  }

  public bool SetSelectedEdges(Neighbor e, BaseSelect pSel, EDGESELECTIONTYPE ltype) {
    bool ret = C4dApiPINVOKE.PolygonObject_SetSelectedEdges(swigCPtr, Neighbor.getCPtr(e), BaseSelect.getCPtr(pSel), (int)ltype);
    return ret;
  }

  public SWIGTYPE_p_SVector CreatePhongNormals() {
    IntPtr cPtr = C4dApiPINVOKE.PolygonObject_CreatePhongNormals(swigCPtr);
    SWIGTYPE_p_SVector ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_SVector(cPtr, false);
    return ret;
  }

  public bool GetPolygonTranslationMap(SWIGTYPE_p_LONG ngoncnt, SWIGTYPE_p_p_LONG polymap) {
    bool ret = C4dApiPINVOKE.PolygonObject_GetPolygonTranslationMap(swigCPtr, SWIGTYPE_p_LONG.getCPtr(ngoncnt), SWIGTYPE_p_p_LONG.getCPtr(polymap));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetNGonTranslationMap(int ngoncnt, SWIGTYPE_p_LONG polymap, SWIGTYPE_p_p_p_LONG ngons) {
    bool ret = C4dApiPINVOKE.PolygonObject_GetNGonTranslationMap(swigCPtr, ngoncnt, SWIGTYPE_p_LONG.getCPtr(polymap), SWIGTYPE_p_p_p_LONG.getCPtr(ngons));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Pgon GetAndBuildNgon() {
    IntPtr cPtr = C4dApiPINVOKE.PolygonObject_GetAndBuildNgon(swigCPtr);
    SWIGTYPE_p_Pgon ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Pgon(cPtr, false);
    return ret;
  }

  public int GetNgonCount() {
    int ret = C4dApiPINVOKE.PolygonObject_GetNgonCount(swigCPtr);
    return ret;
  }

  public void GetSelectedNgons(BaseSelect sel) {
    C4dApiPINVOKE.PolygonObject_GetSelectedNgons(swigCPtr, BaseSelect.getCPtr(sel));
  }

  public void GetHiddenNgons(BaseSelect sel) {
    C4dApiPINVOKE.PolygonObject_GetHiddenNgons(swigCPtr, BaseSelect.getCPtr(sel));
  }

  public SWIGTYPE_p_NgonBase GetNgonBase() {
    IntPtr cPtr = C4dApiPINVOKE.PolygonObject_GetNgonBase(swigCPtr);
    SWIGTYPE_p_NgonBase ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_NgonBase(cPtr, false);
    return ret;
  }

  public bool ValidateEdgeSelection(BaseSelect sel) {
    bool ret = C4dApiPINVOKE.PolygonObject_ValidateEdgeSelection__SWIG_0(swigCPtr, BaseSelect.getCPtr(sel));
    return ret;
  }

  public bool ValidateEdgeSelection() {
    bool ret = C4dApiPINVOKE.PolygonObject_ValidateEdgeSelection__SWIG_1(swigCPtr);
    return ret;
  }

  public bool GetEdgeSelection(BaseSelect sel, EDGESELECTIONTYPE type) {
    bool ret = C4dApiPINVOKE.PolygonObject_GetEdgeSelection(swigCPtr, BaseSelect.getCPtr(sel), (int)type);
    return ret;
  }

  public void GetNgonEdgesCompact(SWIGTYPE_p_p_UCHAR edges) {
    C4dApiPINVOKE.PolygonObject_GetNgonEdgesCompact(swigCPtr, SWIGTYPE_p_p_UCHAR.getCPtr(edges));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_ULONG VBOInitUpdate(BaseDraw bd) {
    SWIGTYPE_p_ULONG ret = new SWIGTYPE_p_ULONG(C4dApiPINVOKE.PolygonObject_VBOInitUpdate(swigCPtr, BaseDraw.getCPtr(bd)), true);
    return ret;
  }

  public bool VBOStartUpdate(BaseDraw bd, GlVertexBufferAccessFlags access, bool latemap) {
    bool ret = C4dApiPINVOKE.PolygonObject_VBOStartUpdate(swigCPtr, BaseDraw.getCPtr(bd), (int)access, latemap);
    return ret;
  }

  public SWIGTYPE_p_GlVertexBufferAttributeInfo VBOUpdateVectorGetAttribute(SWIGTYPE_p_ULONG flags) {
    IntPtr cPtr = C4dApiPINVOKE.PolygonObject_VBOUpdateVectorGetAttribute(swigCPtr, SWIGTYPE_p_ULONG.getCPtr(flags));
    SWIGTYPE_p_GlVertexBufferAttributeInfo ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_GlVertexBufferAttributeInfo(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void VBOUpdateVector(int i, SWIGTYPE_p_SVector v, SWIGTYPE_p_GlVertexBufferAttributeInfo pInfo) {
    C4dApiPINVOKE.PolygonObject_VBOUpdateVector(swigCPtr, i, SWIGTYPE_p_SVector.getCPtr(v), SWIGTYPE_p_GlVertexBufferAttributeInfo.getCPtr(pInfo));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void VBOEndUpdate(BaseDraw bd) {
    C4dApiPINVOKE.PolygonObject_VBOEndUpdate(swigCPtr, BaseDraw.getCPtr(bd));
  }

  public void VBOFreeUpdate() {
    C4dApiPINVOKE.PolygonObject_VBOFreeUpdate(swigCPtr);
  }

  public static PolygonObject Alloc(int pcnt, int vcnt) {
    IntPtr cPtr = C4dApiPINVOKE.PolygonObject_Alloc(pcnt, vcnt);
    PolygonObject ret = (cPtr == IntPtr.Zero) ? null : new PolygonObject(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_PolygonObject bl) {
    C4dApiPINVOKE.PolygonObject_Free(SWIGTYPE_p_p_PolygonObject.getCPtr(bl));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
