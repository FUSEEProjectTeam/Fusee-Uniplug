/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class CAWeightTag : BaseTag {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CAWeightTag(global::System.IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.CAWeightTag_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CAWeightTag obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static CAWeightTag Alloc() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.CAWeightTag_Alloc();
    CAWeightTag ret = (cPtr == global::System.IntPtr.Zero) ? null : new CAWeightTag(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_CAWeightTag pTag) {
    C4dApiPINVOKE.CAWeightTag_Free(SWIGTYPE_p_p_CAWeightTag.getCPtr(pTag));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public BaseObject GetJoint(int index, BaseDocument doc) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.CAWeightTag_GetJoint(swigCPtr, index, BaseDocument.getCPtr(doc));
    BaseObject ret = (BaseObject) C4dApiPINVOKE.InstantiateConcreteObject(cPtr, false);
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

  public void GetWeightMap(int index, SWIGTYPE_p_Float32 map, int cnt) {
    C4dApiPINVOKE.CAWeightTag_GetWeightMap(swigCPtr, index, SWIGTYPE_p_Float32.getCPtr(map), cnt);
  }

  public bool SetWeightMap(int index, SWIGTYPE_p_Float32 map, int cnt) {
    bool ret = C4dApiPINVOKE.CAWeightTag_SetWeightMap(swigCPtr, index, SWIGTYPE_p_Float32.getCPtr(map), cnt);
    return ret;
  }

  public int GetWeightCount(int index) {
    int ret = C4dApiPINVOKE.CAWeightTag_GetWeightCount(swigCPtr, index);
    return ret;
  }

  public void GetIndexWeight(int index, int windex, SWIGTYPE_p_Int32 pntindex, SWIGTYPE_p_Float weight) {
    C4dApiPINVOKE.CAWeightTag_GetIndexWeight(swigCPtr, index, windex, SWIGTYPE_p_Int32.getCPtr(pntindex), SWIGTYPE_p_Float.getCPtr(weight));
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

  public uint GetWeightDirty() {
    uint ret = C4dApiPINVOKE.CAWeightTag_GetWeightDirty(swigCPtr);
    return ret;
  }

  public void WeightDirty() {
    C4dApiPINVOKE.CAWeightTag_WeightDirty(swigCPtr);
  }

  public Fusee.Math.double4x4 /* Matrix_cstype */ GetGeomMg()  {  /* <Matrix_csout> */
      C34M ret_c34m = C4dApiPINVOKE.CAWeightTag_GetGeomMg(swigCPtr);
	  Fusee.Math.double4x4 ret;
	  unsafe {ret = Fusee.Math.ArrayConvert.ArrayDoubleC4DLayoutTodouble4x4(ret_c34m.m);}
      return ret;
   } /* </Matrix_csout> */ 

  public void SetGeomMg(ref Fusee.Math.double4x4 /* constMatrix&_cstype */ mg) {
    double[] adbl_mg;
    unsafe {adbl_mg = Fusee.Math.ArrayConvert.double4x4ToArrayDoubleC4DLayout(mg);    fixed (double *pdbl_mg = adbl_mg) {
    /* constMatrix&_csin_pre */
    try {
      C4dApiPINVOKE.CAWeightTag_SetGeomMg(swigCPtr, (global::System.IntPtr) pdbl_mg /* constMatrix&_csin */);
    } finally {
        // NOP mg = Fusee.Math.ArrayConvert.ArrayDoubleC4DLayoutTodouble4x4(pdbl_mg);
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
