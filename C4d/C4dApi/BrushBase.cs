//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace C4d {

public class BrushBase : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BrushBase(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BrushBase obj) {
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

  public static BrushBase Alloc() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BrushBase_Alloc();
    BrushBase ret = (cPtr == global::System.IntPtr.Zero) ? null : new BrushBase(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_BrushBase p) {
    C4dApiPINVOKE.BrushBase_Free(SWIGTYPE_p_p_BrushBase.getCPtr(p));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool InitTool(BaseDocument doc, BaseContainer data, BaseThread bt, BrushToolData tool) {
    bool ret = C4dApiPINVOKE.BrushBase_InitTool(swigCPtr, BaseDocument.getCPtr(doc), BaseContainer.getCPtr(data), BaseThread.getCPtr(bt), BrushToolData.getCPtr(tool));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void FreeTool(BaseDocument doc, BaseContainer data) {
    C4dApiPINVOKE.BrushBase_FreeTool(swigCPtr, BaseDocument.getCPtr(doc), BaseContainer.getCPtr(data));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InitDefaultSettings(BaseDocument doc, BaseContainer data) {
    C4dApiPINVOKE.BrushBase_InitDefaultSettings(swigCPtr, BaseDocument.getCPtr(doc), BaseContainer.getCPtr(data));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetDEnabling(BaseDocument doc, BaseContainer data, DescID id, GeData t_data, DESCFLAGS_ENABLE flags, BaseContainer itemdesc) {
    bool ret = C4dApiPINVOKE.BrushBase_GetDEnabling(swigCPtr, BaseDocument.getCPtr(doc), BaseContainer.getCPtr(data), DescID.getCPtr(id), GeData.getCPtr(t_data), (int)flags, BaseContainer.getCPtr(itemdesc));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetDParameter(BaseDocument doc, BaseContainer data, DescID id, GeData t_data, SWIGTYPE_p_DESCFLAGS_SET flags) {
    bool ret = C4dApiPINVOKE.BrushBase_SetDParameter(swigCPtr, BaseDocument.getCPtr(doc), BaseContainer.getCPtr(data), DescID.getCPtr(id), GeData.getCPtr(t_data), SWIGTYPE_p_DESCFLAGS_SET.getCPtr(flags));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetDDescription(BaseDocument doc, BaseContainer data, Description description, SWIGTYPE_p_DESCFLAGS_DESC flags) {
    bool ret = C4dApiPINVOKE.BrushBase_GetDDescription(swigCPtr, BaseDocument.getCPtr(doc), BaseContainer.getCPtr(data), Description.getCPtr(description), SWIGTYPE_p_DESCFLAGS_DESC.getCPtr(flags));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Message(BaseDocument doc, BaseContainer data, int type, SWIGTYPE_p_void t_data) {
    bool ret = C4dApiPINVOKE.BrushBase_Message(swigCPtr, BaseDocument.getCPtr(doc), BaseContainer.getCPtr(data), type, SWIGTYPE_p_void.getCPtr(t_data));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetCursorInfo(BaseDocument doc, BaseContainer data, BaseDraw bd, double x, double y, BaseContainer bc) {
    bool ret = C4dApiPINVOKE.BrushBase_GetCursorInfo(swigCPtr, BaseDocument.getCPtr(doc), BaseContainer.getCPtr(data), BaseDraw.getCPtr(bd), x, y, BaseContainer.getCPtr(bc));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool MouseInput(BaseDocument doc, BaseContainer data, BaseDraw bd, SWIGTYPE_p_EditorWindow win, BaseContainer msg) {
    bool ret = C4dApiPINVOKE.BrushBase_MouseInput(swigCPtr, BaseDocument.getCPtr(doc), BaseContainer.getCPtr(data), BaseDraw.getCPtr(bd), SWIGTYPE_p_EditorWindow.getCPtr(win), BaseContainer.getCPtr(msg));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BrushVertexData GetSelected(BaseDocument doc, BaseContainer data, BaseDraw bd, SWIGTYPE_p_Int32 vcnt, int x, int y, double rad, BaseObject op) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BrushBase_GetSelected(swigCPtr, BaseDocument.getCPtr(doc), BaseContainer.getCPtr(data), BaseDraw.getCPtr(bd), SWIGTYPE_p_Int32.getCPtr(vcnt), x, y, rad, BaseObject.getCPtr(op));
    BrushVertexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new BrushVertexData(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetCursor(SWIGTYPE_p_Int32 x, SWIGTYPE_p_Int32 y) {
    double ret = C4dApiPINVOKE.BrushBase_GetCursor(swigCPtr, SWIGTYPE_p_Int32.getCPtr(x), SWIGTYPE_p_Int32.getCPtr(y));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetObjectInfo(SWIGTYPE_p_BrushObjectData data, BrushObjectInfo info) {
    C4dApiPINVOKE.BrushBase_GetObjectInfo__SWIG_0(swigCPtr, SWIGTYPE_p_BrushObjectData.getCPtr(data), BrushObjectInfo.getCPtr(info));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetObjectInfo(BaseObject op, BrushObjectInfo info) {
    bool ret = C4dApiPINVOKE.BrushBase_GetObjectInfo__SWIG_1(swigCPtr, BaseObject.getCPtr(op), BrushObjectInfo.getCPtr(info));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ValidateObjects(BaseDocument doc, BaseContainer data) {
    bool ret = C4dApiPINVOKE.BrushBase_ValidateObjects(swigCPtr, BaseDocument.getCPtr(doc), BaseContainer.getCPtr(data));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BrushPixelData GetObjectAt(int x, int y) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BrushBase_GetObjectAt(swigCPtr, x, y);
    BrushPixelData ret = (cPtr == global::System.IntPtr.Zero) ? null : new BrushPixelData(cPtr, false);
    return ret;
  }

  public double GetFalloff(double dst, int flags) {
    double ret = C4dApiPINVOKE.BrushBase_GetFalloff(swigCPtr, dst, flags);
    return ret;
  }

  public bool GetObjects(BaseDocument doc, AtomArray objects) {
    bool ret = C4dApiPINVOKE.BrushBase_GetObjects(swigCPtr, BaseDocument.getCPtr(doc), AtomArray.getCPtr(objects));
    return ret;
  }

  public bool UpdateCache(BaseDocument doc, BaseContainer data, BaseDraw bd, bool force) {
    bool ret = C4dApiPINVOKE.BrushBase_UpdateCache(swigCPtr, BaseDocument.getCPtr(doc), BaseContainer.getCPtr(data), BaseDraw.getCPtr(bd), force);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Float CalcSurfaceDistances(PolygonObject pObject, BaseSelect selected, Neighbor pNeighbor, ref Fusee.Math.Core.double3 /* Vector*&_cstype */ pNormals, ref Fusee.Math.Core.double3 /* Vector*&_cstype */ pGlobalPoints, SWIGTYPE_p_Float pDistance) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BrushBase_CalcSurfaceDistances__SWIG_0(swigCPtr, PolygonObject.getCPtr(pObject), BaseSelect.getCPtr(selected), Neighbor.getCPtr(pNeighbor), ref pNormals /* Vector*&_csin */, ref pGlobalPoints /* Vector*&_csin */, SWIGTYPE_p_Float.getCPtr(pDistance));
    SWIGTYPE_p_Float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Float(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Float CalcSurfaceDistances(PolygonObject pObject, BaseSelect selected, Neighbor pNeighbor, ref Fusee.Math.Core.double3 /* Vector*&_cstype */ pNormals, ref Fusee.Math.Core.double3 /* Vector*&_cstype */ pGlobalPoints) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BrushBase_CalcSurfaceDistances__SWIG_1(swigCPtr, PolygonObject.getCPtr(pObject), BaseSelect.getCPtr(selected), Neighbor.getCPtr(pNeighbor), ref pNormals /* Vector*&_csin */, ref pGlobalPoints /* Vector*&_csin */);
    SWIGTYPE_p_Float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Float(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Float CalcSurfaceDistances(PolygonObject pObject, BaseSelect selected, Neighbor pNeighbor, ref Fusee.Math.Core.double3 /* Vector*&_cstype */ pNormals) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BrushBase_CalcSurfaceDistances__SWIG_2(swigCPtr, PolygonObject.getCPtr(pObject), BaseSelect.getCPtr(selected), Neighbor.getCPtr(pNeighbor), ref pNormals /* Vector*&_csin */);
    SWIGTYPE_p_Float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Float(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Float CalcSurfaceDistances(PolygonObject pObject, BaseSelect selected, Neighbor pNeighbor) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BrushBase_CalcSurfaceDistances__SWIG_3(swigCPtr, PolygonObject.getCPtr(pObject), BaseSelect.getCPtr(selected), Neighbor.getCPtr(pNeighbor));
    SWIGTYPE_p_Float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Float(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Float CalcSurfaceDistances(PolygonObject pObject, BaseSelect selected) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BrushBase_CalcSurfaceDistances__SWIG_4(swigCPtr, PolygonObject.getCPtr(pObject), BaseSelect.getCPtr(selected));
    SWIGTYPE_p_Float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Float(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Float CalcSurfaceDistancesFromPoint(PolygonObject pObject, int pindex, Neighbor pNeighbor, ref Fusee.Math.Core.double3 /* Vector*&_cstype */ pNormals, ref Fusee.Math.Core.double3 /* Vector*&_cstype */ pGlobalPoints, SWIGTYPE_p_Float pDistance) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BrushBase_CalcSurfaceDistancesFromPoint__SWIG_0(swigCPtr, PolygonObject.getCPtr(pObject), pindex, Neighbor.getCPtr(pNeighbor), ref pNormals /* Vector*&_csin */, ref pGlobalPoints /* Vector*&_csin */, SWIGTYPE_p_Float.getCPtr(pDistance));
    SWIGTYPE_p_Float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Float(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Float CalcSurfaceDistancesFromPoint(PolygonObject pObject, int pindex, Neighbor pNeighbor, ref Fusee.Math.Core.double3 /* Vector*&_cstype */ pNormals, ref Fusee.Math.Core.double3 /* Vector*&_cstype */ pGlobalPoints) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BrushBase_CalcSurfaceDistancesFromPoint__SWIG_1(swigCPtr, PolygonObject.getCPtr(pObject), pindex, Neighbor.getCPtr(pNeighbor), ref pNormals /* Vector*&_csin */, ref pGlobalPoints /* Vector*&_csin */);
    SWIGTYPE_p_Float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Float(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Float CalcSurfaceDistancesFromPoint(PolygonObject pObject, int pindex, Neighbor pNeighbor, ref Fusee.Math.Core.double3 /* Vector*&_cstype */ pNormals) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BrushBase_CalcSurfaceDistancesFromPoint__SWIG_2(swigCPtr, PolygonObject.getCPtr(pObject), pindex, Neighbor.getCPtr(pNeighbor), ref pNormals /* Vector*&_csin */);
    SWIGTYPE_p_Float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Float(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Float CalcSurfaceDistancesFromPoint(PolygonObject pObject, int pindex, Neighbor pNeighbor) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BrushBase_CalcSurfaceDistancesFromPoint__SWIG_3(swigCPtr, PolygonObject.getCPtr(pObject), pindex, Neighbor.getCPtr(pNeighbor));
    SWIGTYPE_p_Float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Float(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Float CalcSurfaceDistancesFromPoint(PolygonObject pObject, int pindex) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BrushBase_CalcSurfaceDistancesFromPoint__SWIG_4(swigCPtr, PolygonObject.getCPtr(pObject), pindex);
    SWIGTYPE_p_Float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Float(cPtr, false);
    return ret;
  }

}

}
