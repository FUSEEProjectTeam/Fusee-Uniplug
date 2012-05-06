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

public class CAWeightTag : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CAWeightTag(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CAWeightTag obj) {
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

  public static CAWeightTag Alloc() {
    IntPtr cPtr = C4dApiPINVOKE.CAWeightTag_Alloc();
    CAWeightTag ret = (cPtr == IntPtr.Zero) ? null : new CAWeightTag(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_CAWeightTag pTag) {
    C4dApiPINVOKE.CAWeightTag_Free(SWIGTYPE_p_p_CAWeightTag.getCPtr(pTag));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public BaseObject GetJoint(int index, BaseDocument doc) {
    IntPtr cPtr = C4dApiPINVOKE.CAWeightTag_GetJoint(swigCPtr, index, BaseDocument.getCPtr(doc));
    BaseObject ret = (cPtr == IntPtr.Zero) ? null : new BaseObject(cPtr, false);
    return ret;
  }

  public int GetJointCount() {
    int ret = C4dApiPINVOKE.CAWeightTag_GetJointCount(swigCPtr);
    return ret;
  }

  public int FindJoint(BaseObject op, BaseDocument doc) {
    int ret = C4dApiPINVOKE.CAWeightTag_FindJoint(swigCPtr, BaseObject.getCPtr(op), BaseDocument.getCPtr(doc));
    return ret;
  }

  public JointRestState GetJointRestState(int index) {
    JointRestState ret = new JointRestState(C4dApiPINVOKE.CAWeightTag_GetJointRestState(swigCPtr, index), true);
    return ret;
  }

  public void SetJointRestState(int index, JointRestState state) {
    C4dApiPINVOKE.CAWeightTag_SetJointRestState(swigCPtr, index, JointRestState.getCPtr(state));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetWeightMap(int index, SWIGTYPE_p_SReal map, int cnt) {
    C4dApiPINVOKE.CAWeightTag_GetWeightMap(swigCPtr, index, SWIGTYPE_p_SReal.getCPtr(map), cnt);
  }

  public bool SetWeightMap(int index, SWIGTYPE_p_SReal map, int cnt) {
    bool ret = C4dApiPINVOKE.CAWeightTag_SetWeightMap(swigCPtr, index, SWIGTYPE_p_SReal.getCPtr(map), cnt);
    return ret;
  }

  public int GetWeightCount(int index) {
    int ret = C4dApiPINVOKE.CAWeightTag_GetWeightCount(swigCPtr, index);
    return ret;
  }

  public void GetIndexWeight(int index, int windex, SWIGTYPE_p_LONG pntindex, SWIGTYPE_p_Real weight) {
    C4dApiPINVOKE.CAWeightTag_GetIndexWeight(swigCPtr, index, windex, SWIGTYPE_p_LONG.getCPtr(pntindex), SWIGTYPE_p_Real.getCPtr(weight));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetWeight(int index, int pntindex) {
    double ret = C4dApiPINVOKE.CAWeightTag_GetWeight(swigCPtr, index, pntindex);
    return ret;
  }

  public bool SetWeight(int index, int pntindex, double weight) {
    bool ret = C4dApiPINVOKE.CAWeightTag_SetWeight(swigCPtr, index, pntindex, weight);
    return ret;
  }

  public SWIGTYPE_p_ULONG GetWeightDirty() {
    SWIGTYPE_p_ULONG ret = new SWIGTYPE_p_ULONG(C4dApiPINVOKE.CAWeightTag_GetWeightDirty(swigCPtr), true);
    return ret;
  }

  public void WeightDirty() {
    C4dApiPINVOKE.CAWeightTag_WeightDirty(swigCPtr);
  }

  public Fusee.Math.Core.Matrix4D /* Matrix_cstype */ GetGeomMg()  {  /* <Matrix_csout> */
      C34M ret_c34m = C4dApiPINVOKE.CAWeightTag_GetGeomMg(swigCPtr);
	  Fusee.Math.Core.Matrix4D ret;
	  unsafe {ret = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(ret_c34m.m);}
      return ret;
   } /* </Matrix_csout> */ 

  public void SetGeomMg(ref Fusee.Math.Core.Matrix4D /* constMatrix&_cstype */ mg) {
    double[] adbl_mg;
    unsafe {adbl_mg = Fusee.Math.ArrayConversion.Convert.Matrix4DToArrayDoubleC4DLayout(mg);    fixed (double *pdbl_mg = adbl_mg) {
    /* constMatrix&_csin_pre */
    try {
      C4dApiPINVOKE.CAWeightTag_SetGeomMg(swigCPtr, (IntPtr) pdbl_mg /* constMatrix&_csin */);
    } finally {
        // NOP mg = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(pdbl_mg);
        /* constMatrix&_csin_post */
    }
} } /* constMatrix&_csin_terminator */
  }

  public int AddJoint(BaseObject op) {
    int ret = C4dApiPINVOKE.CAWeightTag_AddJoint(swigCPtr, BaseObject.getCPtr(op));
    return ret;
  }

  public void RemoveJoint(BaseObject op) {
    C4dApiPINVOKE.CAWeightTag_RemoveJoint(swigCPtr, BaseObject.getCPtr(op));
  }

  public void CalculateBoneStates(int index) {
    C4dApiPINVOKE.CAWeightTag_CalculateBoneStates(swigCPtr, index);
  }

  public bool TransferWeightMap(BaseDocument doc, CAWeightTag dst, int sindex, int dindex, int offset, int cnt, AliasTrans trans) {
    bool ret = C4dApiPINVOKE.CAWeightTag_TransferWeightMap(swigCPtr, BaseDocument.getCPtr(doc), CAWeightTag.getCPtr(dst), sindex, dindex, offset, cnt, AliasTrans.getCPtr(trans));
    return ret;
  }

}

}
