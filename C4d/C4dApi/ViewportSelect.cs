/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class ViewportSelect : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ViewportSelect(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ViewportSelect obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static ViewportSelect Alloc() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_Alloc();
    ViewportSelect ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportSelect(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_ViewportSelect p) {
    C4dApiPINVOKE.ViewportSelect_Free(SWIGTYPE_p_p_ViewportSelect.getCPtr(p));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Init(int w, int h, BaseDraw bd, BaseObject op, int mode, bool onlyvisible, SWIGTYPE_p_VIEWPORTSELECTFLAGS flags) {
    bool ret = C4dApiPINVOKE.ViewportSelect_Init__SWIG_0(swigCPtr, w, h, BaseDraw.getCPtr(bd), BaseObject.getCPtr(op), mode, onlyvisible, SWIGTYPE_p_VIEWPORTSELECTFLAGS.getCPtr(flags));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Init(int w, int h, BaseDraw bd, BaseObject op, int mode, bool onlyvisible) {
    bool ret = C4dApiPINVOKE.ViewportSelect_Init__SWIG_1(swigCPtr, w, h, BaseDraw.getCPtr(bd), BaseObject.getCPtr(op), mode, onlyvisible);
    return ret;
  }

  public bool Init(int w, int h, BaseDraw bd, AtomArray ar, int mode, bool onlyvisible, SWIGTYPE_p_VIEWPORTSELECTFLAGS flags) {
    bool ret = C4dApiPINVOKE.ViewportSelect_Init__SWIG_2(swigCPtr, w, h, BaseDraw.getCPtr(bd), AtomArray.getCPtr(ar), mode, onlyvisible, SWIGTYPE_p_VIEWPORTSELECTFLAGS.getCPtr(flags));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Init(int w, int h, BaseDraw bd, AtomArray ar, int mode, bool onlyvisible) {
    bool ret = C4dApiPINVOKE.ViewportSelect_Init__SWIG_3(swigCPtr, w, h, BaseDraw.getCPtr(bd), AtomArray.getCPtr(ar), mode, onlyvisible);
    return ret;
  }

  public static bool PickObject(BaseDraw bd, BaseDocument doc, int x, int y, int rad, VIEWPORT_PICK_FLAGS flags, LassoSelection ls, SWIGTYPE_p_C4DObjectList list, SWIGTYPE_p_Matrix4d m) {
    bool ret = C4dApiPINVOKE.ViewportSelect_PickObject__SWIG_0(BaseDraw.getCPtr(bd), BaseDocument.getCPtr(doc), x, y, rad, (int)flags, LassoSelection.getCPtr(ls), SWIGTYPE_p_C4DObjectList.getCPtr(list), SWIGTYPE_p_Matrix4d.getCPtr(m));
    return ret;
  }

  public static bool PickObject(BaseDraw bd, BaseDocument doc, int x, int y, int rad, VIEWPORT_PICK_FLAGS flags, LassoSelection ls, SWIGTYPE_p_C4DObjectList list) {
    bool ret = C4dApiPINVOKE.ViewportSelect_PickObject__SWIG_1(BaseDraw.getCPtr(bd), BaseDocument.getCPtr(doc), x, y, rad, (int)flags, LassoSelection.getCPtr(ls), SWIGTYPE_p_C4DObjectList.getCPtr(list));
    return ret;
  }

  public static bool PickObject(BaseDraw bd, BaseDocument doc, int x, int y, int rad, SWIGTYPE_p_Int32 xr, SWIGTYPE_p_Int32 yr, SWIGTYPE_p_Int32 wr, SWIGTYPE_p_Int32 hr, SWIGTYPE_p_p_p_ViewportPixel pixels, VIEWPORT_PICK_FLAGS flags, LassoSelection ls, SWIGTYPE_p_C4DObjectList list, SWIGTYPE_p_Matrix4d m) {
    bool ret = C4dApiPINVOKE.ViewportSelect_PickObject__SWIG_2(BaseDraw.getCPtr(bd), BaseDocument.getCPtr(doc), x, y, rad, SWIGTYPE_p_Int32.getCPtr(xr), SWIGTYPE_p_Int32.getCPtr(yr), SWIGTYPE_p_Int32.getCPtr(wr), SWIGTYPE_p_Int32.getCPtr(hr), SWIGTYPE_p_p_p_ViewportPixel.getCPtr(pixels), (int)flags, LassoSelection.getCPtr(ls), SWIGTYPE_p_C4DObjectList.getCPtr(list), SWIGTYPE_p_Matrix4d.getCPtr(m));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool PickObject(BaseDraw bd, BaseDocument doc, int x, int y, int rad, SWIGTYPE_p_Int32 xr, SWIGTYPE_p_Int32 yr, SWIGTYPE_p_Int32 wr, SWIGTYPE_p_Int32 hr, SWIGTYPE_p_p_p_ViewportPixel pixels, VIEWPORT_PICK_FLAGS flags, LassoSelection ls, SWIGTYPE_p_C4DObjectList list) {
    bool ret = C4dApiPINVOKE.ViewportSelect_PickObject__SWIG_3(BaseDraw.getCPtr(bd), BaseDocument.getCPtr(doc), x, y, rad, SWIGTYPE_p_Int32.getCPtr(xr), SWIGTYPE_p_Int32.getCPtr(yr), SWIGTYPE_p_Int32.getCPtr(wr), SWIGTYPE_p_Int32.getCPtr(hr), SWIGTYPE_p_p_p_ViewportPixel.getCPtr(pixels), (int)flags, LassoSelection.getCPtr(ls), SWIGTYPE_p_C4DObjectList.getCPtr(list));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool PickObject(BaseDraw bd, BaseDocument doc, int x1, int y1, int x2, int y2, SWIGTYPE_p_Int32 xr, SWIGTYPE_p_Int32 yr, SWIGTYPE_p_Int32 wr, SWIGTYPE_p_Int32 hr, SWIGTYPE_p_p_p_ViewportPixel pixels, VIEWPORT_PICK_FLAGS flags, LassoSelection ls, SWIGTYPE_p_C4DObjectList list, SWIGTYPE_p_Matrix4d m) {
    bool ret = C4dApiPINVOKE.ViewportSelect_PickObject__SWIG_4(BaseDraw.getCPtr(bd), BaseDocument.getCPtr(doc), x1, y1, x2, y2, SWIGTYPE_p_Int32.getCPtr(xr), SWIGTYPE_p_Int32.getCPtr(yr), SWIGTYPE_p_Int32.getCPtr(wr), SWIGTYPE_p_Int32.getCPtr(hr), SWIGTYPE_p_p_p_ViewportPixel.getCPtr(pixels), (int)flags, LassoSelection.getCPtr(ls), SWIGTYPE_p_C4DObjectList.getCPtr(list), SWIGTYPE_p_Matrix4d.getCPtr(m));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool PickObject(BaseDraw bd, BaseDocument doc, int x1, int y1, int x2, int y2, SWIGTYPE_p_Int32 xr, SWIGTYPE_p_Int32 yr, SWIGTYPE_p_Int32 wr, SWIGTYPE_p_Int32 hr, SWIGTYPE_p_p_p_ViewportPixel pixels, VIEWPORT_PICK_FLAGS flags, LassoSelection ls, SWIGTYPE_p_C4DObjectList list) {
    bool ret = C4dApiPINVOKE.ViewportSelect_PickObject__SWIG_5(BaseDraw.getCPtr(bd), BaseDocument.getCPtr(doc), x1, y1, x2, y2, SWIGTYPE_p_Int32.getCPtr(xr), SWIGTYPE_p_Int32.getCPtr(yr), SWIGTYPE_p_Int32.getCPtr(wr), SWIGTYPE_p_Int32.getCPtr(hr), SWIGTYPE_p_p_p_ViewportPixel.getCPtr(pixels), (int)flags, LassoSelection.getCPtr(ls), SWIGTYPE_p_C4DObjectList.getCPtr(list));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetPixelInfoPoint(int x, int y) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetPixelInfoPoint(swigCPtr, x, y);
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    return ret;
  }

  public ViewportPixel GetPixelInfoPolygon(int x, int y) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetPixelInfoPolygon(swigCPtr, x, y);
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    return ret;
  }

  public ViewportPixel GetPixelInfoEdge(int x, int y) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetPixelInfoEdge(swigCPtr, x, y);
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    return ret;
  }

  public ViewportPixel GetNearestPoint(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y, int maxrad, bool onlyselected, SWIGTYPE_p_Int32 ignorelist, int ignorecnt) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestPoint__SWIG_0(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y), maxrad, onlyselected, SWIGTYPE_p_Int32.getCPtr(ignorelist), ignorecnt);
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetNearestPoint(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y, int maxrad, bool onlyselected, SWIGTYPE_p_Int32 ignorelist) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestPoint__SWIG_1(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y), maxrad, onlyselected, SWIGTYPE_p_Int32.getCPtr(ignorelist));
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetNearestPoint(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y, int maxrad, bool onlyselected) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestPoint__SWIG_2(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y), maxrad, onlyselected);
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetNearestPoint(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y, int maxrad) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestPoint__SWIG_3(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y), maxrad);
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetNearestPoint(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestPoint__SWIG_4(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y));
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetNearestPolygon(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y, int maxrad, bool onlyselected, SWIGTYPE_p_Int32 ignorelist, int ignorecnt) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestPolygon__SWIG_0(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y), maxrad, onlyselected, SWIGTYPE_p_Int32.getCPtr(ignorelist), ignorecnt);
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetNearestPolygon(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y, int maxrad, bool onlyselected, SWIGTYPE_p_Int32 ignorelist) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestPolygon__SWIG_1(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y), maxrad, onlyselected, SWIGTYPE_p_Int32.getCPtr(ignorelist));
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetNearestPolygon(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y, int maxrad, bool onlyselected) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestPolygon__SWIG_2(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y), maxrad, onlyselected);
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetNearestPolygon(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y, int maxrad) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestPolygon__SWIG_3(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y), maxrad);
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetNearestPolygon(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestPolygon__SWIG_4(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y));
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetNearestEdge(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y, int maxrad, bool onlyselected, SWIGTYPE_p_Int32 ignorelist, int ignorecnt) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestEdge__SWIG_0(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y), maxrad, onlyselected, SWIGTYPE_p_Int32.getCPtr(ignorelist), ignorecnt);
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetNearestEdge(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y, int maxrad, bool onlyselected, SWIGTYPE_p_Int32 ignorelist) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestEdge__SWIG_1(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y), maxrad, onlyselected, SWIGTYPE_p_Int32.getCPtr(ignorelist));
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetNearestEdge(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y, int maxrad, bool onlyselected) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestEdge__SWIG_2(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y), maxrad, onlyselected);
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetNearestEdge(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y, int maxrad) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestEdge__SWIG_3(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y), maxrad);
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewportPixel GetNearestEdge(BaseObject op, SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ViewportSelect_GetNearestEdge__SWIG_4(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y));
    ViewportPixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ViewportPixel(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool DrawPolygon(ref Fusee.Math.double3 /* Vector*&_cstype */ p, int ptcnt, int i, BaseObject op, bool onlyvisible) {
    bool ret = C4dApiPINVOKE.ViewportSelect_DrawPolygon__SWIG_0(swigCPtr, ref p /* Vector*&_csin */, ptcnt, i, BaseObject.getCPtr(op), onlyvisible);
    return ret;
  }

  public bool DrawPolygon(ref Fusee.Math.double3 /* Vector*&_cstype */ p, int ptcnt, int i, BaseObject op) {
    bool ret = C4dApiPINVOKE.ViewportSelect_DrawPolygon__SWIG_1(swigCPtr, ref p /* Vector*&_csin */, ptcnt, i, BaseObject.getCPtr(op));
    return ret;
  }

  public bool DrawHandle(Fusee.Math.double3 /* constVector&_cstype */ p, int i, BaseObject op, bool onlyvisible) {
    bool ret = C4dApiPINVOKE.ViewportSelect_DrawHandle__SWIG_0(swigCPtr, ref p /* constVector&_csin */, i, BaseObject.getCPtr(op), onlyvisible);
    return ret;
  }

  public bool DrawHandle(Fusee.Math.double3 /* constVector&_cstype */ p, int i, BaseObject op) {
    bool ret = C4dApiPINVOKE.ViewportSelect_DrawHandle__SWIG_1(swigCPtr, ref p /* constVector&_csin */, i, BaseObject.getCPtr(op));
    return ret;
  }

  public static void ShowHotspot(SWIGTYPE_p_EditorWindow bw, int x, int y, int rad, bool bRemove) {
    C4dApiPINVOKE.ViewportSelect_ShowHotspot__SWIG_0(SWIGTYPE_p_EditorWindow.getCPtr(bw), x, y, rad, bRemove);
  }

  public void ShowHotspot(SWIGTYPE_p_EditorWindow bw, int x, int y) {
    C4dApiPINVOKE.ViewportSelect_ShowHotspot__SWIG_1(swigCPtr, SWIGTYPE_p_EditorWindow.getCPtr(bw), x, y);
  }

  public void SetBrushRadius(int r) {
    C4dApiPINVOKE.ViewportSelect_SetBrushRadius(swigCPtr, r);
  }

  public void ClearPixelInfo(int x, int y, byte mask) {
    C4dApiPINVOKE.ViewportSelect_ClearPixelInfo(swigCPtr, x, y, mask);
  }

  public bool GetCameraCoordinates(double x, double y, double z, ref Fusee.Math.double3 /* Vector*&_cstype */ v) {
    bool ret = C4dApiPINVOKE.ViewportSelect_GetCameraCoordinates(swigCPtr, x, y, z, ref v /* Vector*&_csin */);
    return ret;
  }

}

}
