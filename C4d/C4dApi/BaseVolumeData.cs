//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace C4d {

public class BaseVolumeData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BaseVolumeData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BaseVolumeData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BaseVolumeData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_BaseVolumeData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int version {
    set {
      C4dApiPINVOKE.BaseVolumeData_version_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.BaseVolumeData_version_get(swigCPtr);
      return ret;
    } 
  }

  public int fps {
    set {
      C4dApiPINVOKE.BaseVolumeData_fps_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.BaseVolumeData_fps_get(swigCPtr);
      return ret;
    } 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ ambient {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.BaseVolumeData_ambient_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.BaseVolumeData_ambient_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public double time {
    set {
      C4dApiPINVOKE.BaseVolumeData_time_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.BaseVolumeData_time_get(swigCPtr);
      return ret;
    } 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ col {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.BaseVolumeData_col_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.BaseVolumeData_col_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ trans {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.BaseVolumeData_trans_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.BaseVolumeData_trans_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ refl {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.BaseVolumeData_refl_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.BaseVolumeData_refl_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public double alpha {
    set {
      C4dApiPINVOKE.BaseVolumeData_alpha_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.BaseVolumeData_alpha_get(swigCPtr);
      return ret;
    } 
  }

  public Ray tray {
    set {
      C4dApiPINVOKE.BaseVolumeData_tray_set(swigCPtr, Ray.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BaseVolumeData_tray_get(swigCPtr);
      Ray ret = (cPtr == global::System.IntPtr.Zero) ? null : new Ray(cPtr, false);
      return ret;
    } 
  }

  public Ray rray {
    set {
      C4dApiPINVOKE.BaseVolumeData_rray_set(swigCPtr, Ray.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BaseVolumeData_rray_get(swigCPtr);
      Ray ret = (cPtr == global::System.IntPtr.Zero) ? null : new Ray(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Vector64 p {
    set {
      C4dApiPINVOKE.BaseVolumeData_p_set(swigCPtr, SWIGTYPE_p_Vector64.getCPtr(value));
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_Vector64 ret = new SWIGTYPE_p_Vector64(C4dApiPINVOKE.BaseVolumeData_p_get(swigCPtr), true);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_Vector64 bumpn {
    set {
      C4dApiPINVOKE.BaseVolumeData_bumpn_set(swigCPtr, SWIGTYPE_p_Vector64.getCPtr(value));
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_Vector64 ret = new SWIGTYPE_p_Vector64(C4dApiPINVOKE.BaseVolumeData_bumpn_get(swigCPtr), true);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Ray ray {
    set {
      C4dApiPINVOKE.BaseVolumeData_ray_set(swigCPtr, Ray.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BaseVolumeData_ray_get(swigCPtr);
      Ray ret = (cPtr == global::System.IntPtr.Zero) ? null : new Ray(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Vector64 orign {
    set {
      C4dApiPINVOKE.BaseVolumeData_orign_set(swigCPtr, SWIGTYPE_p_Vector64.getCPtr(value));
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_Vector64 ret = new SWIGTYPE_p_Vector64(C4dApiPINVOKE.BaseVolumeData_orign_get(swigCPtr), true);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_Vector64 n {
    set {
      C4dApiPINVOKE.BaseVolumeData_n_set(swigCPtr, SWIGTYPE_p_Vector64.getCPtr(value));
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_Vector64 ret = new SWIGTYPE_p_Vector64(C4dApiPINVOKE.BaseVolumeData_n_get(swigCPtr), true);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_Vector64 dispn {
    set {
      C4dApiPINVOKE.BaseVolumeData_dispn_set(swigCPtr, SWIGTYPE_p_Vector64.getCPtr(value));
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_Vector64 ret = new SWIGTYPE_p_Vector64(C4dApiPINVOKE.BaseVolumeData_dispn_get(swigCPtr), true);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double dist {
    set {
      C4dApiPINVOKE.BaseVolumeData_dist_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.BaseVolumeData_dist_get(swigCPtr);
      return ret;
    } 
  }

  public double cosc {
    set {
      C4dApiPINVOKE.BaseVolumeData_cosc_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.BaseVolumeData_cosc_get(swigCPtr);
      return ret;
    } 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ uvw {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.BaseVolumeData_uvw_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.BaseVolumeData_uvw_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ delta {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.BaseVolumeData_delta_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.BaseVolumeData_delta_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public RayHitID lhit {
    set {
      C4dApiPINVOKE.BaseVolumeData_lhit_set(swigCPtr, RayHitID.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BaseVolumeData_lhit_get(swigCPtr);
      RayHitID ret = (cPtr == global::System.IntPtr.Zero) ? null : new RayHitID(cPtr, false);
      return ret;
    } 
  }

  public TexData tex {
    set {
      C4dApiPINVOKE.BaseVolumeData_tex_set(swigCPtr, TexData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BaseVolumeData_tex_get(swigCPtr);
      TexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new TexData(cPtr, false);
      return ret;
    } 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ ddu {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.BaseVolumeData_ddu_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.BaseVolumeData_ddu_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ ddv {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.BaseVolumeData_ddv_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.BaseVolumeData_ddv_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public int raydepth {
    set {
      C4dApiPINVOKE.BaseVolumeData_raydepth_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.BaseVolumeData_raydepth_get(swigCPtr);
      return ret;
    } 
  }

  public int calc_trans {
    set {
      C4dApiPINVOKE.BaseVolumeData_calc_trans_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.BaseVolumeData_calc_trans_get(swigCPtr);
      return ret;
    } 
  }

  public int calc_refl {
    set {
      C4dApiPINVOKE.BaseVolumeData_calc_refl_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.BaseVolumeData_calc_refl_get(swigCPtr);
      return ret;
    } 
  }

  public bool calc_shadow {
    set {
      C4dApiPINVOKE.BaseVolumeData_calc_shadow_set(swigCPtr, value);
    } 
    get {
      bool ret = C4dApiPINVOKE.BaseVolumeData_calc_shadow_get(swigCPtr);
      return ret;
    } 
  }

  public int calc_illum {
    set {
      C4dApiPINVOKE.BaseVolumeData_calc_illum_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.BaseVolumeData_calc_illum_get(swigCPtr);
      return ret;
    } 
  }

  public int calc_mip {
    set {
      C4dApiPINVOKE.BaseVolumeData_calc_mip_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.BaseVolumeData_calc_mip_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_Vector pp {
    set {
      C4dApiPINVOKE.BaseVolumeData_pp_set(swigCPtr, SWIGTYPE_p_Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BaseVolumeData_pp_get(swigCPtr);
      SWIGTYPE_p_Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Vector(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Vector nn {
    set {
      C4dApiPINVOKE.BaseVolumeData_nn_set(swigCPtr, SWIGTYPE_p_Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BaseVolumeData_nn_get(swigCPtr);
      SWIGTYPE_p_Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Vector(cPtr, false);
      return ret;
    } 
  }

  public RAYBIT raybits {
    set {
      C4dApiPINVOKE.BaseVolumeData_raybits_set(swigCPtr, (int)value);
    } 
    get {
      RAYBIT ret = (RAYBIT)C4dApiPINVOKE.BaseVolumeData_raybits_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_RayLight xlight {
    set {
      C4dApiPINVOKE.BaseVolumeData_xlight_set(swigCPtr, SWIGTYPE_p_RayLight.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BaseVolumeData_xlight_get(swigCPtr);
      SWIGTYPE_p_RayLight ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_RayLight(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_RayObject op {
    set {
      C4dApiPINVOKE.BaseVolumeData_op_set(swigCPtr, SWIGTYPE_p_RayObject.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BaseVolumeData_op_get(swigCPtr);
      SWIGTYPE_p_RayObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_RayObject(cPtr, false);
      return ret;
    } 
  }

  public int recursion_id {
    set {
      C4dApiPINVOKE.BaseVolumeData_recursion_id_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.BaseVolumeData_recursion_id_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void recursion_data {
    set {
      C4dApiPINVOKE.BaseVolumeData_recursion_data_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BaseVolumeData_recursion_data_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_Multipass multipass {
    set {
      C4dApiPINVOKE.BaseVolumeData_multipass_set(swigCPtr, SWIGTYPE_p_Multipass.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BaseVolumeData_multipass_get(swigCPtr);
      SWIGTYPE_p_Multipass ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Multipass(cPtr, false);
      return ret;
    } 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ back_p {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.BaseVolumeData_back_p_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.BaseVolumeData_back_p_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ back_delta {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.BaseVolumeData_back_delta_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.BaseVolumeData_back_delta_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public double global_mip {
    set {
      C4dApiPINVOKE.BaseVolumeData_global_mip_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.BaseVolumeData_global_mip_get(swigCPtr);
      return ret;
    } 
  }

  public int sid {
    set {
      C4dApiPINVOKE.BaseVolumeData_sid_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.BaseVolumeData_sid_get(swigCPtr);
      return ret;
    } 
  }

  public double par_u {
    set {
      C4dApiPINVOKE.BaseVolumeData_par_u_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.BaseVolumeData_par_u_get(swigCPtr);
      return ret;
    } 
  }

  public double par_v {
    set {
      C4dApiPINVOKE.BaseVolumeData_par_v_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.BaseVolumeData_par_v_get(swigCPtr);
      return ret;
    } 
  }

  public SurfaceIntersection intersection {
    set {
      C4dApiPINVOKE.BaseVolumeData_intersection_set(swigCPtr, SurfaceIntersection.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BaseVolumeData_intersection_get(swigCPtr);
      SurfaceIntersection ret = (cPtr == global::System.IntPtr.Zero) ? null : new SurfaceIntersection(cPtr, false);
      return ret;
    } 
  }

  public double mb_offset {
    set {
      C4dApiPINVOKE.BaseVolumeData_mb_offset_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.BaseVolumeData_mb_offset_get(swigCPtr);
      return ret;
    } 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ comp_color {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.BaseVolumeData_comp_color_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.BaseVolumeData_comp_color_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ comp_specular {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.BaseVolumeData_comp_specular_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.BaseVolumeData_comp_specular_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ comp_luminance {
    /* <Vector_csvarin> */
    set 
	{
      C4dApiPINVOKE.BaseVolumeData_comp_luminance_set(swigCPtr, value /* Vector_csin */);
    }  /* </Vector_csvarin> */   
   /* <Vector_csvarout> */
   get
   {  
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.BaseVolumeData_comp_luminance_get(swigCPtr);
      return ret;
   } /* <Vector_csvarout> */ 
  }

  public SWIGTYPE_p_Int32 unused {
    set {
      C4dApiPINVOKE.BaseVolumeData_unused_set(swigCPtr, SWIGTYPE_p_Int32.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BaseVolumeData_unused_get(swigCPtr);
      SWIGTYPE_p_Int32 ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Int32(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_TexEntry rtex {
    set {
      C4dApiPINVOKE.BaseVolumeData_rtex_set(swigCPtr, SWIGTYPE_p_p_TexEntry.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.BaseVolumeData_rtex_get(swigCPtr);
      SWIGTYPE_p_p_TexEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_TexEntry(cPtr, false);
      return ret;
    } 
  }

  public int rtex_count {
    set {
      C4dApiPINVOKE.BaseVolumeData_rtex_count_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.BaseVolumeData_rtex_count_get(swigCPtr);
      return ret;
    } 
  }

}

}
