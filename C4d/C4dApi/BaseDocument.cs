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

public class BaseDocument : BaseList2D {
  private HandleRef swigCPtr;

  internal BaseDocument(IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.BaseDocument_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BaseDocument obj) {
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

  public new BaseDocument GetNext() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetNext(swigCPtr);
    BaseDocument ret = (cPtr == IntPtr.Zero) ? null : new BaseDocument(cPtr, false);
    return ret;
  }

  public new BaseDocument GetPred() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetPred(swigCPtr);
    BaseDocument ret = (cPtr == IntPtr.Zero) ? null : new BaseDocument(cPtr, false);
    return ret;
  }

  public BaseContainer GetData(DOCUMENTSETTINGS type) {
    BaseContainer ret = new BaseContainer(C4dApiPINVOKE.BaseDocument_GetData(swigCPtr, (int)type), true);
    return ret;
  }

  public void SetData(DOCUMENTSETTINGS type, BaseContainer bc) {
    C4dApiPINVOKE.BaseDocument_SetData(swigCPtr, (int)type, BaseContainer.getCPtr(bc));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public BaseContainer GetSettingsInstance(int type) {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetSettingsInstance(swigCPtr, type);
    BaseContainer ret = (cPtr == IntPtr.Zero) ? null : new BaseContainer(cPtr, false);
    return ret;
  }

  public BaseObject GetFirstObject() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetFirstObject(swigCPtr);
    BaseObject ret = (cPtr == IntPtr.Zero) ? null : new BaseObject(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_BaseMaterial GetFirstMaterial() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetFirstMaterial(swigCPtr);
    SWIGTYPE_p_BaseMaterial ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_BaseMaterial(cPtr, false);
    return ret;
  }

  public RenderData GetFirstRenderData() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetFirstRenderData(swigCPtr);
    RenderData ret = (cPtr == IntPtr.Zero) ? null : new RenderData(cPtr, false);
    return ret;
  }

  public void InsertRenderData(RenderData rd, RenderData parent, RenderData pred) {
    C4dApiPINVOKE.BaseDocument_InsertRenderData(swigCPtr, RenderData.getCPtr(rd), RenderData.getCPtr(parent), RenderData.getCPtr(pred));
  }

  public void InsertRenderDataLast(RenderData rd) {
    C4dApiPINVOKE.BaseDocument_InsertRenderDataLast(swigCPtr, RenderData.getCPtr(rd));
  }

  public void InsertMaterial(SWIGTYPE_p_BaseMaterial mat, SWIGTYPE_p_BaseMaterial pred, bool checknames) {
    C4dApiPINVOKE.BaseDocument_InsertMaterial__SWIG_0(swigCPtr, SWIGTYPE_p_BaseMaterial.getCPtr(mat), SWIGTYPE_p_BaseMaterial.getCPtr(pred), checknames);
  }

  public void InsertMaterial(SWIGTYPE_p_BaseMaterial mat, SWIGTYPE_p_BaseMaterial pred) {
    C4dApiPINVOKE.BaseDocument_InsertMaterial__SWIG_1(swigCPtr, SWIGTYPE_p_BaseMaterial.getCPtr(mat), SWIGTYPE_p_BaseMaterial.getCPtr(pred));
  }

  public void InsertMaterial(SWIGTYPE_p_BaseMaterial mat) {
    C4dApiPINVOKE.BaseDocument_InsertMaterial__SWIG_2(swigCPtr, SWIGTYPE_p_BaseMaterial.getCPtr(mat));
  }

  public void InsertObject(BaseObject op, BaseObject parent, BaseObject pred, bool checknames) {
    C4dApiPINVOKE.BaseDocument_InsertObject__SWIG_0(swigCPtr, BaseObject.getCPtr(op), BaseObject.getCPtr(parent), BaseObject.getCPtr(pred), checknames);
  }

  public void InsertObject(BaseObject op, BaseObject parent, BaseObject pred) {
    C4dApiPINVOKE.BaseDocument_InsertObject__SWIG_1(swigCPtr, BaseObject.getCPtr(op), BaseObject.getCPtr(parent), BaseObject.getCPtr(pred));
  }

  public RenderData GetActiveRenderData() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetActiveRenderData(swigCPtr);
    RenderData ret = (cPtr == IntPtr.Zero) ? null : new RenderData(cPtr, false);
    return ret;
  }

  public BaseObject GetActiveObject() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetActiveObject(swigCPtr);
    BaseObject ret = (cPtr == IntPtr.Zero) ? null : new BaseObject(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_BaseMaterial GetActiveMaterial() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetActiveMaterial(swigCPtr);
    SWIGTYPE_p_BaseMaterial ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_BaseMaterial(cPtr, false);
    return ret;
  }

  public BaseTag GetActiveTag() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetActiveTag(swigCPtr);
    BaseTag ret = (BaseTag) C4dApiPINVOKE.InstantiateConcreteObject(cPtr, false);
    return ret;
}

  public BaseObject GetRealActiveObject(AtomArray help, SWIGTYPE_p_Bool multi) {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetRealActiveObject(swigCPtr, AtomArray.getCPtr(help), SWIGTYPE_p_Bool.getCPtr(multi));
    BaseObject ret = (cPtr == IntPtr.Zero) ? null : new BaseObject(cPtr, false);
    return ret;
  }

  public void GetActiveObjects(AtomArray selection, SWIGTYPE_p_GETACTIVEOBJECTFLAGS flags) {
    C4dApiPINVOKE.BaseDocument_GetActiveObjects(swigCPtr, AtomArray.getCPtr(selection), SWIGTYPE_p_GETACTIVEOBJECTFLAGS.getCPtr(flags));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetActivePolygonObjects(AtomArray selection, bool children) {
    C4dApiPINVOKE.BaseDocument_GetActivePolygonObjects(swigCPtr, AtomArray.getCPtr(selection), children);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetActiveObjectsFilter(AtomArray selection, bool children, int type, int instanceof) {
    C4dApiPINVOKE.BaseDocument_GetActiveObjectsFilter(swigCPtr, AtomArray.getCPtr(selection), children, type, instanceof);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetActiveTags(AtomArray selection) {
    C4dApiPINVOKE.BaseDocument_GetActiveTags(swigCPtr, AtomArray.getCPtr(selection));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetActiveMaterials(AtomArray selection) {
    C4dApiPINVOKE.BaseDocument_GetActiveMaterials(swigCPtr, AtomArray.getCPtr(selection));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetSelection(AtomArray selection) {
    C4dApiPINVOKE.BaseDocument_GetSelection(swigCPtr, AtomArray.getCPtr(selection));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetActiveObject(BaseObject op, int mode) {
    C4dApiPINVOKE.BaseDocument_SetActiveObject__SWIG_0(swigCPtr, BaseObject.getCPtr(op), mode);
  }

  public void SetActiveObject(BaseObject op) {
    C4dApiPINVOKE.BaseDocument_SetActiveObject__SWIG_1(swigCPtr, BaseObject.getCPtr(op));
  }

  public void SetActiveTag(BaseTag tag, int mode) {
    C4dApiPINVOKE.BaseDocument_SetActiveTag__SWIG_0(swigCPtr, BaseTag.getCPtr(tag), mode);
  }

  public void SetActiveTag(BaseTag tag) {
    C4dApiPINVOKE.BaseDocument_SetActiveTag__SWIG_1(swigCPtr, BaseTag.getCPtr(tag));
  }

  public void SetActiveMaterial(SWIGTYPE_p_BaseMaterial mp, int mode) {
    C4dApiPINVOKE.BaseDocument_SetActiveMaterial__SWIG_0(swigCPtr, SWIGTYPE_p_BaseMaterial.getCPtr(mp), mode);
  }

  public void SetActiveMaterial(SWIGTYPE_p_BaseMaterial mp) {
    C4dApiPINVOKE.BaseDocument_SetActiveMaterial__SWIG_1(swigCPtr, SWIGTYPE_p_BaseMaterial.getCPtr(mp));
  }

  public void SetActiveRenderData(RenderData rd) {
    C4dApiPINVOKE.BaseDocument_SetActiveRenderData(swigCPtr, RenderData.getCPtr(rd));
  }

  public void SetSelection(BaseList2D bl, int mode) {
    C4dApiPINVOKE.BaseDocument_SetSelection__SWIG_0(swigCPtr, BaseList2D.getCPtr(bl), mode);
  }

  public void SetSelection(BaseList2D bl) {
    C4dApiPINVOKE.BaseDocument_SetSelection__SWIG_1(swigCPtr, BaseList2D.getCPtr(bl));
  }

  public void Flush() {
    C4dApiPINVOKE.BaseDocument_Flush(swigCPtr);
  }

  public BaseObject GetHighest(int type, bool editor) {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetHighest(swigCPtr, type, editor);
    BaseObject ret = (cPtr == IntPtr.Zero) ? null : new BaseObject(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_BaseMaterial SearchMaterial(string /* constString&_cstype */ str) {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_SearchMaterial(swigCPtr, str);
    SWIGTYPE_p_BaseMaterial ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_BaseMaterial(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_BaseMaterial SearchMaterialInc(string /* constString&_cstype */ str) {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_SearchMaterialInc(swigCPtr, str);
    SWIGTYPE_p_BaseMaterial ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_BaseMaterial(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BaseObject SearchObject(string /* constString&_cstype */ str) {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_SearchObject(swigCPtr, str);
    BaseObject ret = (cPtr == IntPtr.Zero) ? null : new BaseObject(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BaseObject SearchObjectInc(string /* constString&_cstype */ str) {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_SearchObjectInc(swigCPtr, str);
    BaseObject ret = (cPtr == IntPtr.Zero) ? null : new BaseObject(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BaseObject GetHelperAxis() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetHelperAxis(swigCPtr);
    BaseObject ret = (cPtr == IntPtr.Zero) ? null : new BaseObject(cPtr, false);
    return ret;
  }

  public BaseContainer GetAllTextures(AtomArray ar) {
    BaseContainer ret = new BaseContainer(C4dApiPINVOKE.BaseDocument_GetAllTextures(swigCPtr, AtomArray.getCPtr(ar)), true);
    return ret;
  }

  public bool GetChanged() {
    bool ret = C4dApiPINVOKE.BaseDocument_GetChanged(swigCPtr);
    return ret;
  }

  public void SetChanged() {
    C4dApiPINVOKE.BaseDocument_SetChanged(swigCPtr);
  }

  public SWIGTYPE_p_Filename GetDocumentName() {
    SWIGTYPE_p_Filename ret = new SWIGTYPE_p_Filename(C4dApiPINVOKE.BaseDocument_GetDocumentName(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Filename GetDocumentPath() {
    SWIGTYPE_p_Filename ret = new SWIGTYPE_p_Filename(C4dApiPINVOKE.BaseDocument_GetDocumentPath(swigCPtr), true);
    return ret;
  }

  public void SetDocumentName(SWIGTYPE_p_Filename fn) {
    C4dApiPINVOKE.BaseDocument_SetDocumentName(swigCPtr, SWIGTYPE_p_Filename.getCPtr(fn));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDocumentPath(SWIGTYPE_p_Filename path) {
    C4dApiPINVOKE.BaseDocument_SetDocumentPath(swigCPtr, SWIGTYPE_p_Filename.getCPtr(path));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetLOD() {
    double ret = C4dApiPINVOKE.BaseDocument_GetLOD(swigCPtr);
    return ret;
  }

  public void SetLOD(double lod) {
    C4dApiPINVOKE.BaseDocument_SetLOD(swigCPtr, lod);
  }

  public int GetFps() {
    int ret = C4dApiPINVOKE.BaseDocument_GetFps(swigCPtr);
    return ret;
  }

  public void SetFps(int fps) {
    C4dApiPINVOKE.BaseDocument_SetFps(swigCPtr, fps);
  }

  public SWIGTYPE_p_BaseTime GetMinTime() {
    SWIGTYPE_p_BaseTime ret = new SWIGTYPE_p_BaseTime(C4dApiPINVOKE.BaseDocument_GetMinTime(swigCPtr), true);
    return ret;
  }

  public void SetMinTime(SWIGTYPE_p_BaseTime t) {
    C4dApiPINVOKE.BaseDocument_SetMinTime(swigCPtr, SWIGTYPE_p_BaseTime.getCPtr(t));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_BaseTime GetMaxTime() {
    SWIGTYPE_p_BaseTime ret = new SWIGTYPE_p_BaseTime(C4dApiPINVOKE.BaseDocument_GetMaxTime(swigCPtr), true);
    return ret;
  }

  public void SetMaxTime(SWIGTYPE_p_BaseTime t) {
    C4dApiPINVOKE.BaseDocument_SetMaxTime(swigCPtr, SWIGTYPE_p_BaseTime.getCPtr(t));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_BaseTime GetUsedMinTime(BaseList2D check) {
    SWIGTYPE_p_BaseTime ret = new SWIGTYPE_p_BaseTime(C4dApiPINVOKE.BaseDocument_GetUsedMinTime(swigCPtr, BaseList2D.getCPtr(check)), true);
    return ret;
  }

  public SWIGTYPE_p_BaseTime GetUsedMaxTime(BaseList2D check) {
    SWIGTYPE_p_BaseTime ret = new SWIGTYPE_p_BaseTime(C4dApiPINVOKE.BaseDocument_GetUsedMaxTime(swigCPtr, BaseList2D.getCPtr(check)), true);
    return ret;
  }

  public SWIGTYPE_p_BaseTime GetLoopMinTime() {
    SWIGTYPE_p_BaseTime ret = new SWIGTYPE_p_BaseTime(C4dApiPINVOKE.BaseDocument_GetLoopMinTime(swigCPtr), true);
    return ret;
  }

  public void SetLoopMinTime(SWIGTYPE_p_BaseTime t) {
    C4dApiPINVOKE.BaseDocument_SetLoopMinTime(swigCPtr, SWIGTYPE_p_BaseTime.getCPtr(t));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_BaseTime GetLoopMaxTime() {
    SWIGTYPE_p_BaseTime ret = new SWIGTYPE_p_BaseTime(C4dApiPINVOKE.BaseDocument_GetLoopMaxTime(swigCPtr), true);
    return ret;
  }

  public void SetLoopMaxTime(SWIGTYPE_p_BaseTime t) {
    C4dApiPINVOKE.BaseDocument_SetLoopMaxTime(swigCPtr, SWIGTYPE_p_BaseTime.getCPtr(t));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetRenderLod() {
    bool ret = C4dApiPINVOKE.BaseDocument_GetRenderLod(swigCPtr);
    return ret;
  }

  public void SetRenderLod(bool lod) {
    C4dApiPINVOKE.BaseDocument_SetRenderLod(swigCPtr, lod);
  }

  public SWIGTYPE_p_BaseTime GetTime() {
    SWIGTYPE_p_BaseTime ret = new SWIGTYPE_p_BaseTime(C4dApiPINVOKE.BaseDocument_GetTime(swigCPtr), true);
    return ret;
  }

  public void SetTime(SWIGTYPE_p_BaseTime t) {
    C4dApiPINVOKE.BaseDocument_SetTime(swigCPtr, SWIGTYPE_p_BaseTime.getCPtr(t));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetMode() {
    int ret = C4dApiPINVOKE.BaseDocument_GetMode(swigCPtr);
    return ret;
  }

  public void SetMode(int m) {
    C4dApiPINVOKE.BaseDocument_SetMode(swigCPtr, m);
  }

  public int GetAction() {
    int ret = C4dApiPINVOKE.BaseDocument_GetAction(swigCPtr);
    return ret;
  }

  public void SetAction(int a) {
    C4dApiPINVOKE.BaseDocument_SetAction(swigCPtr, a);
  }

  public bool IsEditMode() {
    bool ret = C4dApiPINVOKE.BaseDocument_IsEditMode(swigCPtr);
    return ret;
  }

  public bool StartUndo() {
    bool ret = C4dApiPINVOKE.BaseDocument_StartUndo(swigCPtr);
    return ret;
  }

  public bool EndUndo() {
    bool ret = C4dApiPINVOKE.BaseDocument_EndUndo(swigCPtr);
    return ret;
  }

  public bool AddUndo(UNDOTYPE type, SWIGTYPE_p_void data) {
    bool ret = C4dApiPINVOKE.BaseDocument_AddUndo__SWIG_0(swigCPtr, (int)type, SWIGTYPE_p_void.getCPtr(data));
    return ret;
  }

  public bool AddUndo(BaseDraw bd) {
    bool ret = C4dApiPINVOKE.BaseDocument_AddUndo__SWIG_1(swigCPtr, BaseDraw.getCPtr(bd));
    return ret;
  }

  public bool DoUndo(bool multiple) {
    bool ret = C4dApiPINVOKE.BaseDocument_DoUndo__SWIG_0(swigCPtr, multiple);
    return ret;
  }

  public bool DoUndo() {
    bool ret = C4dApiPINVOKE.BaseDocument_DoUndo__SWIG_1(swigCPtr);
    return ret;
  }

  public bool DoRedo() {
    bool ret = C4dApiPINVOKE.BaseDocument_DoRedo(swigCPtr);
    return ret;
  }

  public BaseList2D GetUndoPtr() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetUndoPtr(swigCPtr);
    BaseList2D ret = (cPtr == IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
    return ret;
  }

  public BaseList2D FindUndoPtr(BaseList2D bl, UNDOTYPE type) {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_FindUndoPtr(swigCPtr, BaseList2D.getCPtr(bl), (int)type);
    BaseList2D ret = (cPtr == IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
    return ret;
  }

  public void AutoKey(BaseList2D undo, BaseList2D op, bool recursive, bool pos, bool scale, bool rot, bool param, bool pla) {
    C4dApiPINVOKE.BaseDocument_AutoKey(swigCPtr, BaseList2D.getCPtr(undo), BaseList2D.getCPtr(op), recursive, pos, scale, rot, param, pla);
  }

  public bool RecordKey(BaseList2D op, SWIGTYPE_p_BaseTime time, DescID id, BaseList2D undo, bool eval_attribmanager, bool autokeying, bool allow_linking) {
    bool ret = C4dApiPINVOKE.BaseDocument_RecordKey(swigCPtr, BaseList2D.getCPtr(op), SWIGTYPE_p_BaseTime.getCPtr(time), DescID.getCPtr(id), BaseList2D.getCPtr(undo), eval_attribmanager, autokeying, allow_linking);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Record() {
    C4dApiPINVOKE.BaseDocument_Record(swigCPtr);
  }

  public void AnimateObject(BaseList2D op, SWIGTYPE_p_BaseTime time, ANIMATEFLAGS flags) {
    C4dApiPINVOKE.BaseDocument_AnimateObject(swigCPtr, BaseList2D.getCPtr(op), SWIGTYPE_p_BaseTime.getCPtr(time), (int)flags);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public BaseDocument Polygonize(bool keepanimation) {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_Polygonize__SWIG_0(swigCPtr, keepanimation);
    BaseDocument ret = (cPtr == IntPtr.Zero) ? null : new BaseDocument(cPtr, false);
    return ret;
  }

  public BaseDocument Polygonize() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_Polygonize__SWIG_1(swigCPtr);
    BaseDocument ret = (cPtr == IntPtr.Zero) ? null : new BaseDocument(cPtr, false);
    return ret;
  }

  public BaseDraw GetActiveBaseDraw() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetActiveBaseDraw(swigCPtr);
    BaseDraw ret = (cPtr == IntPtr.Zero) ? null : new BaseDraw(cPtr, false);
    return ret;
  }

  public BaseDraw GetRenderBaseDraw() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetRenderBaseDraw(swigCPtr);
    BaseDraw ret = (cPtr == IntPtr.Zero) ? null : new BaseDraw(cPtr, false);
    return ret;
  }

  public BaseDraw GetBaseDraw(int num) {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetBaseDraw(swigCPtr, num);
    BaseDraw ret = (cPtr == IntPtr.Zero) ? null : new BaseDraw(cPtr, false);
    return ret;
  }

  public int GetBaseDrawCount() {
    int ret = C4dApiPINVOKE.BaseDocument_GetBaseDrawCount(swigCPtr);
    return ret;
  }

  public int GetSplinePlane() {
    int ret = C4dApiPINVOKE.BaseDocument_GetSplinePlane(swigCPtr);
    return ret;
  }

  public void SetRewind(int flags) {
    C4dApiPINVOKE.BaseDocument_SetRewind__SWIG_0(swigCPtr, flags);
  }

  public void SetRewind() {
    C4dApiPINVOKE.BaseDocument_SetRewind__SWIG_1(swigCPtr);
  }

  public BaseSceneHook FindSceneHook(int id) {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_FindSceneHook(swigCPtr, id);
    BaseSceneHook ret = (cPtr == IntPtr.Zero) ? null : new BaseSceneHook(cPtr, false);
    return ret;
  }

  public static BaseDocument Alloc() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_Alloc();
    BaseDocument ret = (cPtr == IntPtr.Zero) ? null : new BaseDocument(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_BaseDocument v) {
    C4dApiPINVOKE.BaseDocument_Free(SWIGTYPE_p_p_BaseDocument.getCPtr(v));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsCacheBuilt(bool force) {
    bool ret = C4dApiPINVOKE.BaseDocument_IsCacheBuilt__SWIG_0(swigCPtr, force);
    return ret;
  }

  public bool IsCacheBuilt() {
    bool ret = C4dApiPINVOKE.BaseDocument_IsCacheBuilt__SWIG_1(swigCPtr);
    return ret;
  }

  public void ForceCreateBaseDraw() {
    C4dApiPINVOKE.BaseDocument_ForceCreateBaseDraw(swigCPtr);
  }

  public GeListHead GetLayerObjectRoot() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetLayerObjectRoot(swigCPtr);
    GeListHead ret = (cPtr == IntPtr.Zero) ? null : new GeListHead(cPtr, false);
    return ret;
  }

  public bool HandleSelectedTextureFilename(SWIGTYPE_p_BaseChannel bc, SWIGTYPE_p_Filename fn, SWIGTYPE_p_Filename resfilename, bool undo, SWIGTYPE_p_GEMB_R already_answered) {
    bool ret = C4dApiPINVOKE.BaseDocument_HandleSelectedTextureFilename(swigCPtr, SWIGTYPE_p_BaseChannel.getCPtr(bc), SWIGTYPE_p_Filename.getCPtr(fn), SWIGTYPE_p_Filename.getCPtr(resfilename), undo, SWIGTYPE_p_GEMB_R.getCPtr(already_answered));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ReceiveMaterials(BaseObject op, AtomArray mat, bool clearfirst) {
    bool ret = C4dApiPINVOKE.BaseDocument_ReceiveMaterials(swigCPtr, BaseObject.getCPtr(op), AtomArray.getCPtr(mat), clearfirst);
    return ret;
  }

  public bool ReceiveNewTexture(BaseObject op, SWIGTYPE_p_Filename filename, bool sdown, SWIGTYPE_p_GEMB_R already_answered) {
    bool ret = C4dApiPINVOKE.BaseDocument_ReceiveNewTexture(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Filename.getCPtr(filename), sdown, SWIGTYPE_p_GEMB_R.getCPtr(already_answered));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CollectSounds(SWIGTYPE_p_BaseSound snd, SWIGTYPE_p_BaseTime from, SWIGTYPE_p_BaseTime to) {
    bool ret = C4dApiPINVOKE.BaseDocument_CollectSounds(swigCPtr, SWIGTYPE_p_BaseSound.getCPtr(snd), SWIGTYPE_p_BaseTime.getCPtr(from), SWIGTYPE_p_BaseTime.getCPtr(to));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RecordZero() {
    C4dApiPINVOKE.BaseDocument_RecordZero(swigCPtr);
  }

  public void RecordNoEvent() {
    C4dApiPINVOKE.BaseDocument_RecordNoEvent(swigCPtr);
  }

  public int GetDrawTime() {
    int ret = C4dApiPINVOKE.BaseDocument_GetDrawTime(swigCPtr);
    return ret;
  }

  public bool ExecutePasses(BaseThread bt, bool animation, bool expressions, bool caches, BUILDFLAGS flags) {
    bool ret = C4dApiPINVOKE.BaseDocument_ExecutePasses(swigCPtr, BaseThread.getCPtr(bt), animation, expressions, caches, (int)flags);
    return ret;
  }

  public PickSessionDataStruct GetPickSession() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDocument_GetPickSession(swigCPtr);
    PickSessionDataStruct ret = (cPtr == IntPtr.Zero) ? null : new PickSessionDataStruct(cPtr, false);
    return ret;
  }

  public void StartPickSession(PickSessionDataStruct psd) {
    C4dApiPINVOKE.BaseDocument_StartPickSession(swigCPtr, PickSessionDataStruct.getCPtr(psd));
  }

  public void StopPickSession(bool cancel) {
    C4dApiPINVOKE.BaseDocument_StopPickSession(swigCPtr, cancel);
  }

  public bool GetDefaultKey(SWIGTYPE_p_CKey pKey, SWIGTYPE_p_Bool bOverdub) {
    bool ret = C4dApiPINVOKE.BaseDocument_GetDefaultKey(swigCPtr, SWIGTYPE_p_CKey.getCPtr(pKey), SWIGTYPE_p_Bool.getCPtr(bOverdub));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDefaultKey(SWIGTYPE_p_CKey pKey, bool bOverdub) {
    C4dApiPINVOKE.BaseDocument_SetDefaultKey(swigCPtr, SWIGTYPE_p_CKey.getCPtr(pKey), bOverdub);
  }

  public void SendInfo(int type, int format, SWIGTYPE_p_Filename fn, BaseList2D bl, bool hooks_only) {
    C4dApiPINVOKE.BaseDocument_SendInfo(swigCPtr, type, format, SWIGTYPE_p_Filename.getCPtr(fn), BaseList2D.getCPtr(bl), hooks_only);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetHighlightedObject(BaseObject op, int mode) {
    C4dApiPINVOKE.BaseDocument_SetHighlightedObject__SWIG_0(swigCPtr, BaseObject.getCPtr(op), mode);
  }

  public void SetHighlightedObject(BaseObject op) {
    C4dApiPINVOKE.BaseDocument_SetHighlightedObject__SWIG_1(swigCPtr, BaseObject.getCPtr(op));
  }

  public void SetHighlightedObjects(AtomArray selection, int mode) {
    C4dApiPINVOKE.BaseDocument_SetHighlightedObjects__SWIG_0(swigCPtr, AtomArray.getCPtr(selection), mode);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetHighlightedObjects(AtomArray selection) {
    C4dApiPINVOKE.BaseDocument_SetHighlightedObjects__SWIG_1(swigCPtr, AtomArray.getCPtr(selection));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetHighlightedObjects(AtomArray selection) {
    C4dApiPINVOKE.BaseDocument_GetHighlightedObjects(swigCPtr, AtomArray.getCPtr(selection));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsAxisEnabled() {
    bool ret = C4dApiPINVOKE.BaseDocument_IsAxisEnabled(swigCPtr);
    return ret;
  }

}

}
