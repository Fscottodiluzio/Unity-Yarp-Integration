/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class IAmplifierControl : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IAmplifierControl(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IAmplifierControl obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IAmplifierControl() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IAmplifierControl(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual bool enableAmp(int j) {
    bool ret = yarpPINVOKE.IAmplifierControl_enableAmp(swigCPtr, j);
    return ret;
  }

  public virtual bool disableAmp(int j) {
    bool ret = yarpPINVOKE.IAmplifierControl_disableAmp(swigCPtr, j);
    return ret;
  }

  public virtual bool getCurrents(SWIGTYPE_p_double vals) {
    bool ret = yarpPINVOKE.IAmplifierControl_getCurrents__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(vals));
    return ret;
  }

  public virtual bool getCurrent(int j, SWIGTYPE_p_double val) {
    bool ret = yarpPINVOKE.IAmplifierControl_getCurrent__SWIG_0(swigCPtr, j, SWIGTYPE_p_double.getCPtr(val));
    return ret;
  }

  public virtual bool getMaxCurrent(int j, SWIGTYPE_p_double v) {
    bool ret = yarpPINVOKE.IAmplifierControl_getMaxCurrent(swigCPtr, j, SWIGTYPE_p_double.getCPtr(v));
    return ret;
  }

  public virtual bool setMaxCurrent(int j, double v) {
    bool ret = yarpPINVOKE.IAmplifierControl_setMaxCurrent(swigCPtr, j, v);
    return ret;
  }

  public virtual bool getAmpStatus(SWIGTYPE_p_int st) {
    bool ret = yarpPINVOKE.IAmplifierControl_getAmpStatus__SWIG_0(swigCPtr, SWIGTYPE_p_int.getCPtr(st));
    return ret;
  }

  public virtual bool getAmpStatus(int j, SWIGTYPE_p_int v) {
    bool ret = yarpPINVOKE.IAmplifierControl_getAmpStatus__SWIG_1(swigCPtr, j, SWIGTYPE_p_int.getCPtr(v));
    return ret;
  }

  public bool getCurrents(DVector data) {
    bool ret = yarpPINVOKE.IAmplifierControl_getCurrents__SWIG_1(swigCPtr, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getCurrent(int j, DVector data) {
    bool ret = yarpPINVOKE.IAmplifierControl_getCurrent__SWIG_1(swigCPtr, j, DVector.getCPtr(data));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
