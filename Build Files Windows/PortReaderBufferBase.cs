//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PortReaderBufferBase : PortReader {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PortReaderBufferBase(global::System.IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.PortReaderBufferBase_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PortReaderBufferBase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PortReaderBufferBase() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_PortReaderBufferBase(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PortReaderBufferBase(uint maxBuffer) : this(yarpPINVOKE.new_PortReaderBufferBase(maxBuffer), true) {
  }

  public void setCreator(PortReaderBufferBaseCreator creator) {
    yarpPINVOKE.PortReaderBufferBase_setCreator(swigCPtr, PortReaderBufferBaseCreator.getCPtr(creator));
  }

  public new void setReplier(PortReader reader) {
    yarpPINVOKE.PortReaderBufferBase_setReplier(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setPrune(bool flag) {
    yarpPINVOKE.PortReaderBufferBase_setPrune__SWIG_0(swigCPtr, flag);
  }

  public void setPrune() {
    yarpPINVOKE.PortReaderBufferBase_setPrune__SWIG_1(swigCPtr);
  }

  public void setAllowReuse(bool flag) {
    yarpPINVOKE.PortReaderBufferBase_setAllowReuse__SWIG_0(swigCPtr, flag);
  }

  public void setAllowReuse() {
    yarpPINVOKE.PortReaderBufferBase_setAllowReuse__SWIG_1(swigCPtr);
  }

  public new void setTargetPeriod(double period) {
    yarpPINVOKE.PortReaderBufferBase_setTargetPeriod(swigCPtr, period);
  }

  public string getName() {
    string ret = yarpPINVOKE.PortReaderBufferBase_getName(swigCPtr);
    return ret;
  }

  public uint getMaxBuffer() {
    uint ret = yarpPINVOKE.PortReaderBufferBase_getMaxBuffer(swigCPtr);
    return ret;
  }

  public new bool isClosed() {
    bool ret = yarpPINVOKE.PortReaderBufferBase_isClosed(swigCPtr);
    return ret;
  }

  public void clear() {
    yarpPINVOKE.PortReaderBufferBase_clear(swigCPtr);
  }

  public virtual PortReader create() {
    global::System.IntPtr cPtr = yarpPINVOKE.PortReaderBufferBase_create(swigCPtr);
    PortReader ret = (cPtr == global::System.IntPtr.Zero) ? null : new PortReader(cPtr, false);
    return ret;
  }

  public virtual void release(PortReader completed) {
    yarpPINVOKE.PortReaderBufferBase_release__SWIG_0(swigCPtr, PortReader.getCPtr(completed));
  }

  public new int check() {
    int ret = yarpPINVOKE.PortReaderBufferBase_check(swigCPtr);
    return ret;
  }

  public new bool read(ConnectionReader connection) {
    bool ret = yarpPINVOKE.PortReaderBufferBase_read(swigCPtr, ConnectionReader.getCPtr(connection));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PortReader readBase(SWIGTYPE_p_bool missed, bool cleanup) {
    global::System.IntPtr cPtr = yarpPINVOKE.PortReaderBufferBase_readBase(swigCPtr, SWIGTYPE_p_bool.getCPtr(missed), cleanup);
    PortReader ret = (cPtr == global::System.IntPtr.Zero) ? null : new PortReader(cPtr, false);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void interrupt() {
    yarpPINVOKE.PortReaderBufferBase_interrupt(swigCPtr);
  }

  public void attachBase(Port port) {
    yarpPINVOKE.PortReaderBufferBase_attachBase(swigCPtr, Port.getCPtr(port));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool acceptObjectBase(PortReader obj, PortWriter wrapper) {
    bool ret = yarpPINVOKE.PortReaderBufferBase_acceptObjectBase(swigCPtr, PortReader.getCPtr(obj), PortWriter.getCPtr(wrapper));
    return ret;
  }

  public virtual bool forgetObjectBase(PortReader obj, PortWriter wrapper) {
    bool ret = yarpPINVOKE.PortReaderBufferBase_forgetObjectBase(swigCPtr, PortReader.getCPtr(obj), PortWriter.getCPtr(wrapper));
    return ret;
  }

  public virtual bool getEnvelope(PortReader envelope) {
    bool ret = yarpPINVOKE.PortReaderBufferBase_getEnvelope(swigCPtr, PortReader.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_void acquire() {
    global::System.IntPtr cPtr = yarpPINVOKE.PortReaderBufferBase_acquire(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public virtual void release(SWIGTYPE_p_void key) {
    yarpPINVOKE.PortReaderBufferBase_release__SWIG_1(swigCPtr, SWIGTYPE_p_void.getCPtr(key));
  }

  public void setAutoRelease(bool flag) {
    yarpPINVOKE.PortReaderBufferBase_setAutoRelease__SWIG_0(swigCPtr, flag);
  }

  public void setAutoRelease() {
    yarpPINVOKE.PortReaderBufferBase_setAutoRelease__SWIG_1(swigCPtr);
  }

}
