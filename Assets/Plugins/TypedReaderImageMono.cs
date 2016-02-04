/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class TypedReaderImageMono : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TypedReaderImageMono(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TypedReaderImageMono obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TypedReaderImageMono() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_TypedReaderImageMono(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public new void setStrict(bool strict) {
    yarpPINVOKE.TypedReaderImageMono_setStrict__SWIG_0(swigCPtr, strict);
  }

  public new void setStrict() {
    yarpPINVOKE.TypedReaderImageMono_setStrict__SWIG_1(swigCPtr);
  }

  public new ImageMono read(bool shouldWait) {
    IntPtr cPtr = yarpPINVOKE.TypedReaderImageMono_read__SWIG_0(swigCPtr, shouldWait);
    ImageMono ret = (cPtr == IntPtr.Zero) ? null : new ImageMono(cPtr, false);
    return ret;
  }

  public new ImageMono read() {
    IntPtr cPtr = yarpPINVOKE.TypedReaderImageMono_read__SWIG_1(swigCPtr);
    ImageMono ret = (cPtr == IntPtr.Zero) ? null : new ImageMono(cPtr, false);
    return ret;
  }

  public virtual void interrupt() {
    yarpPINVOKE.TypedReaderImageMono_interrupt(swigCPtr);
  }

  public new ImageMono lastRead() {
    IntPtr cPtr = yarpPINVOKE.TypedReaderImageMono_lastRead(swigCPtr);
    ImageMono ret = (cPtr == IntPtr.Zero) ? null : new ImageMono(cPtr, false);
    return ret;
  }

  public new bool isClosed() {
    bool ret = yarpPINVOKE.TypedReaderImageMono_isClosed(swigCPtr);
    return ret;
  }

  public new void useCallback(TypedReaderCallbackImageMono callback) {
    yarpPINVOKE.TypedReaderImageMono_useCallback(swigCPtr, TypedReaderCallbackImageMono.getCPtr(callback));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void disableCallback() {
    yarpPINVOKE.TypedReaderImageMono_disableCallback(swigCPtr);
  }

  public new int getPendingReads() {
    int ret = yarpPINVOKE.TypedReaderImageMono_getPendingReads(swigCPtr);
    return ret;
  }

  public virtual string getName() {
    string ret = yarpPINVOKE.TypedReaderImageMono_getName(swigCPtr);
    return ret;
  }

  public new void setReplier(PortReader reader) {
    yarpPINVOKE.TypedReaderImageMono_setReplier(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_void acquire() {
    IntPtr cPtr = yarpPINVOKE.TypedReaderImageMono_acquire(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public virtual void release(SWIGTYPE_p_void handle) {
    yarpPINVOKE.TypedReaderImageMono_release(swigCPtr, SWIGTYPE_p_void.getCPtr(handle));
  }

  public new void setTargetPeriod(double period) {
    yarpPINVOKE.TypedReaderImageMono_setTargetPeriod(swigCPtr, period);
  }

}
