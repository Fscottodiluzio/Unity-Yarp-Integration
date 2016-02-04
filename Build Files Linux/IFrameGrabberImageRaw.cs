/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class IFrameGrabberImageRaw : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IFrameGrabberImageRaw(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IFrameGrabberImageRaw obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IFrameGrabberImageRaw() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_IFrameGrabberImageRaw(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual bool getImage(ImageMono image) {
    bool ret = yarpPINVOKE.IFrameGrabberImageRaw_getImage(swigCPtr, ImageMono.getCPtr(image));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int height() {
    int ret = yarpPINVOKE.IFrameGrabberImageRaw_height(swigCPtr);
    return ret;
  }

  public virtual int width() {
    int ret = yarpPINVOKE.IFrameGrabberImageRaw_width(swigCPtr);
    return ret;
  }

}
