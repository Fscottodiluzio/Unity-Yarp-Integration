/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class TypedReaderImageRgbFloat : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TypedReaderImageRgbFloat(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TypedReaderImageRgbFloat obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TypedReaderImageRgbFloat() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_TypedReaderImageRgbFloat(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public new void setStrict(bool strict) {
    yarpPINVOKE.TypedReaderImageRgbFloat_setStrict__SWIG_0(swigCPtr, strict);
  }

  public new void setStrict() {
    yarpPINVOKE.TypedReaderImageRgbFloat_setStrict__SWIG_1(swigCPtr);
  }

  public new ImageRgbFloat read(bool shouldWait) {
    IntPtr cPtr = yarpPINVOKE.TypedReaderImageRgbFloat_read__SWIG_0(swigCPtr, shouldWait);
    ImageRgbFloat ret = (cPtr == IntPtr.Zero) ? null : new ImageRgbFloat(cPtr, false);
    return ret;
  }

  public new ImageRgbFloat read() {
    IntPtr cPtr = yarpPINVOKE.TypedReaderImageRgbFloat_read__SWIG_1(swigCPtr);
    ImageRgbFloat ret = (cPtr == IntPtr.Zero) ? null : new ImageRgbFloat(cPtr, false);
    return ret;
  }

  public virtual void interrupt() {
    yarpPINVOKE.TypedReaderImageRgbFloat_interrupt(swigCPtr);
  }

  public new ImageRgbFloat lastRead() {
    IntPtr cPtr = yarpPINVOKE.TypedReaderImageRgbFloat_lastRead(swigCPtr);
    ImageRgbFloat ret = (cPtr == IntPtr.Zero) ? null : new ImageRgbFloat(cPtr, false);
    return ret;
  }

  public new bool isClosed() {
    bool ret = yarpPINVOKE.TypedReaderImageRgbFloat_isClosed(swigCPtr);
    return ret;
  }

  public new void useCallback(TypedReaderCallbackImageRgbFloat callback) {
    yarpPINVOKE.TypedReaderImageRgbFloat_useCallback(swigCPtr, TypedReaderCallbackImageRgbFloat.getCPtr(callback));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void disableCallback() {
    yarpPINVOKE.TypedReaderImageRgbFloat_disableCallback(swigCPtr);
  }

  public new int getPendingReads() {
    int ret = yarpPINVOKE.TypedReaderImageRgbFloat_getPendingReads(swigCPtr);
    return ret;
  }

  public virtual string getName() {
    string ret = yarpPINVOKE.TypedReaderImageRgbFloat_getName(swigCPtr);
    return ret;
  }

  public new void setReplier(PortReader reader) {
    yarpPINVOKE.TypedReaderImageRgbFloat_setReplier(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual System.IntPtr acquire() { return yarpPINVOKE.TypedReaderImageRgbFloat_acquire(swigCPtr); }

  public virtual void release(System.IntPtr handle) {
    yarpPINVOKE.TypedReaderImageRgbFloat_release(swigCPtr, handle);
  }

  public new void setTargetPeriod(double period) {
    yarpPINVOKE.TypedReaderImageRgbFloat_setTargetPeriod(swigCPtr, period);
  }

}
