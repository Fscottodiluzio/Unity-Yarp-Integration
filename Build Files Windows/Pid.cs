//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Pid : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Pid(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Pid obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Pid() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_Pid(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public double kp {
    set {
      yarpPINVOKE.Pid_kp_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.Pid_kp_get(swigCPtr);
      return ret;
    } 
  }

  public double kd {
    set {
      yarpPINVOKE.Pid_kd_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.Pid_kd_get(swigCPtr);
      return ret;
    } 
  }

  public double ki {
    set {
      yarpPINVOKE.Pid_ki_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.Pid_ki_get(swigCPtr);
      return ret;
    } 
  }

  public double max_int {
    set {
      yarpPINVOKE.Pid_max_int_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.Pid_max_int_get(swigCPtr);
      return ret;
    } 
  }

  public double scale {
    set {
      yarpPINVOKE.Pid_scale_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.Pid_scale_get(swigCPtr);
      return ret;
    } 
  }

  public double max_output {
    set {
      yarpPINVOKE.Pid_max_output_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.Pid_max_output_get(swigCPtr);
      return ret;
    } 
  }

  public double offset {
    set {
      yarpPINVOKE.Pid_offset_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.Pid_offset_get(swigCPtr);
      return ret;
    } 
  }

  public double stiction_up_val {
    set {
      yarpPINVOKE.Pid_stiction_up_val_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.Pid_stiction_up_val_get(swigCPtr);
      return ret;
    } 
  }

  public double stiction_down_val {
    set {
      yarpPINVOKE.Pid_stiction_down_val_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.Pid_stiction_down_val_get(swigCPtr);
      return ret;
    } 
  }

  public double kff {
    set {
      yarpPINVOKE.Pid_kff_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.Pid_kff_get(swigCPtr);
      return ret;
    } 
  }

  public Pid() : this(yarpPINVOKE.new_Pid__SWIG_0(), true) {
  }

  public Pid(double kp, double kd, double ki, double int_max, double scale, double out_max) : this(yarpPINVOKE.new_Pid__SWIG_1(kp, kd, ki, int_max, scale, out_max), true) {
  }

  public Pid(double kp, double kd, double ki, double int_max, double scale, double out_max, double st_up, double st_down, double kff) : this(yarpPINVOKE.new_Pid__SWIG_2(kp, kd, ki, int_max, scale, out_max, st_up, st_down, kff), true) {
  }

  public void setMaxInt(double m) {
    yarpPINVOKE.Pid_setMaxInt(swigCPtr, m);
  }

  public void setMaxOut(double m) {
    yarpPINVOKE.Pid_setMaxOut(swigCPtr, m);
  }

  public void setStictionValues(double up_value, double down_value) {
    yarpPINVOKE.Pid_setStictionValues(swigCPtr, up_value, down_value);
  }

}
